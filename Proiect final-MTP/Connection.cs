using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_final_MTP
{
    class Connection
    {
        static string connect = "Server=127.0.0.1;Database=stefana_matei_db;Uid=root;Pwd=;";
        static bool migrated = false;

        static public MySqlConnection getSqlConnection()
        {
            return new MySqlConnection(connect);
        }


        static public string getConnectBD()
        {
            return connect;
        }


        static public void runMigrations()
        {
            if (migrated) return;

            MySqlConnection sqlConnection = Connection.getSqlConnection();
            Connection connection = new Connection();

            connection.createDataBase();

            sqlConnection.Open();

            // Migrari
            connection.dropTables(sqlConnection);

            connection.createStudentiTable(sqlConnection);
            connection.createNoteTable(sqlConnection);
            connection.createMediiTable(sqlConnection);
            connection.generateTriggers(sqlConnection);

            connection.promovabilitateDisciplinaFunction(sqlConnection);
            connection.promovabilitateStudentFunction(sqlConnection);

            connection.createLoginAdminTable(sqlConnection);
            connection.createLoginStudentTable(sqlConnection);


            // Populare
            //  metoda in care executam query pentru popularea bazei de date cu studenti
            connection.insertStudentiTable(sqlConnection);
            //  metoda in care executam query pentru popularea bazei de date cu notele studentilor
            connection.insertNoteTable(sqlConnection);

            // TODO stergere metoda daca chiar nu e mai e necesara
            //connection.insertMediiTable(sqlConnection);
            //  metoda in care executam query pentru popularea bazei de date cu administratori
            connection.insertLoginAdminTable(sqlConnection);
            //  metoda in care executam query pentru popularea bazei de date cu datele de conectare a studentilor
            connection.insertLoginStudentTable(sqlConnection);


            sqlConnection.Close();

            migrated = true;
        }


        // metoda in care se creeaza baza de date, daca nu exista
        private void createDataBase()
        {
            string connection = "server=localhost;user=root;port=3306;password=;";
            MySqlConnection sqlConnection = new MySqlConnection(connection);

            sqlConnection.Open();
            new MySqlCommand("CREATE DATABASE IF NOT EXISTS stefana_matei_db", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
        }


        //----------------Tabela login_administrator----------------
        // crearea tabelei login_administrator in BD
        private void createLoginAdminTable(MySqlConnection sqlConnection)
        {
            string createTableQuery =
                    " CREATE TABLE `login_administrator` (" +
                    "   `id` int NOT NULL AUTO_INCREMENT," +
                    "   `nume` varchar(20) NOT NULL," +
                    "   `prenume` varchar(20) NOT NULL," +
                    "   `email` varchar(50) NOT NULL," +
                    "   `password` varchar(50) NOT NULL," +
                    "   PRIMARY KEY(`id`)" +
                    " ) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4;";
            MySqlCommand sqlCommandTable = new MySqlCommand(createTableQuery, sqlConnection);
            sqlCommandTable.ExecuteNonQuery();
        }


        // metoda in care executam query pentru popularea tabelei login_administrator cu admini
        private void insertLoginAdminTable(MySqlConnection sqlConnection)
        {
            queryInsertAdmin(sqlConnection, "Popescu", "Cristina", "cristina.popescu@upt.ro", "s1");
            queryInsertAdmin(sqlConnection, "Ioan", "Maria", "maria.ioan@upt.ro", "s2");
        }


        // query pentru a introduce un admin in tabela login_administrator
        private void queryInsertAdmin(MySqlConnection sqlConnection, string nume, string prenume, string email, string password)
        {
            string query =
                "INSERT INTO `login_administrator` (`nume`, `prenume`, `email`, `password`) " +
                "VALUES ('" + nume + "', '" + prenume + "', '" + email + "', '" + password + "');";

            new MySqlCommand(query, sqlConnection).ExecuteNonQuery();
        }
        //----------------------------------------------------------



        //----------------Tabela login_student----------------
        // crearea tabelei login_student in BD
        private void createLoginStudentTable(MySqlConnection sqlConnection)
        {
            string createTableQuery =
                " CREATE TABLE `login_student` (" +
                "   `id` int NOT NULL AUTO_INCREMENT," +
                "   `nr_legitimatie` int(6) NOT NULL," +
                "   `nume` varchar(20) NOT NULL," +
                "   `prenume` varchar(20) NOT NULL," +
                "   `email` varchar(50) NOT NULL," +
                "   `password` varchar(50) NOT NULL," +
                "   PRIMARY KEY(`id`)," +
                "   FOREIGN KEY(`nr_legitimatie`) REFERENCES studenti(`nr_legitimatie`) ON DELETE CASCADE" +
                " ) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4;";
            MySqlCommand sqlCommandTable = new MySqlCommand(createTableQuery, sqlConnection);
            sqlCommandTable.ExecuteNonQuery();
        }


        //  metoda in care executam query pentru popularea tabelei login_studenti cu datele de login a studentilor
        private void insertLoginStudentTable(MySqlConnection sqlConnection)
        {
            queryInsertStudentLogin(sqlConnection, "110", "Matei", "Stefana Otilia", "stefana.matei@student.upt.ro", "s1");
            queryInsertStudentLogin(sqlConnection, "111", "Popescu", "Cristian", "cristian.popescu@student.upt.ro", "c1");
            queryInsertStudentLogin(sqlConnection, "112", "Ionescu", "Andrada", "andrada.ionescu@student.upt.ro", "a1");
            queryInsertStudentLogin(sqlConnection, "114", "Petru", "Ioan", "ioan.petru@student.upt.ro", "p1");
        }


        //  query pentru a introduce un admin in tabela login_administrator
        private void queryInsertStudentLogin(MySqlConnection sqlConnection, string legitimatie, string nume, string prenume, string email, string password)
        {
            string query =
                "INSERT INTO `login_student` (`nr_legitimatie`, `nume`, `prenume`, `email`, `password`) " +
                "VALUES ('" + legitimatie + "','" + nume + "', '" + prenume + "', '" + email + "', '" + password + "');";

            new MySqlCommand(query, sqlConnection).ExecuteNonQuery();
        }
        //----------------------------------------------------


        // metoda prin care se sterg tabelele din BD
        private void dropTables(MySqlConnection sqlConnection)
        {
            new MySqlCommand("DROP TABLE IF EXISTS `medii`, `note`, `login_administrator`, `login_student`, `studenti`;", sqlConnection).ExecuteNonQuery();
        }


        //----------------Tabela studenti----------------
        //  crearea tabelei studenti in BD
        private void createStudentiTable(MySqlConnection sqlConnection)
        {
            string createStudentiQuery =
                " CREATE TABLE `studenti` (" +
                "   `nr_legitimatie` int(6) NOT NULL," +
                "   `nume` varchar(15) NOT NULL," +
                "   `prenume` varchar(20) NOT NULL," +
                "   PRIMARY KEY(`nr_legitimatie`)" +
                " ) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4;";
            MySqlCommand createStudentiCommand = new MySqlCommand(createStudentiQuery, sqlConnection);
            createStudentiCommand.ExecuteNonQuery();
        }


        //  metoda in care executam query pentru popularea bazei de date cu studenti
        private void insertStudentiTable(MySqlConnection sqlConnection)
        {
            queryInsertStudenti(sqlConnection, "110", "Matei", "Stefana Otilia");
            queryInsertStudenti(sqlConnection, "111", "Popescu", "Cristian");
            queryInsertStudenti(sqlConnection, "112", "Ionescu", "Andrada");
            queryInsertStudenti(sqlConnection, "113", "Costea", "Ioana");
            queryInsertStudenti(sqlConnection, "114", "Petru", "Ioan");
        }


        //  query pentru a introduce un student in tabela Studenti
        private void queryInsertStudenti(MySqlConnection sqlConnection, string legitimatie, string nume, string prenume)
        {
            string query =
                "INSERT INTO `studenti` (`nr_legitimatie`, `nume`, `prenume`) " +
                "VALUES ('" + legitimatie + "', '" + nume + "', '" + prenume + "');";

            new MySqlCommand(query, sqlConnection).ExecuteNonQuery();
        }
        //-----------------------------------------------


        //----------------Tabela medii----------------
        //  crearea tabelei medii in BD
        private void createMediiTable(MySqlConnection sqlConnection)
        {
            string createMediiQuery =
                " CREATE TABLE `medii` (" +
                "   `nr_legitimatie` int(6) NOT NULL," +
                "   `medie_generala` decimal(4, 2) NOT NULL DEFAULT 0.00," +
                "   `medie_an1` decimal(4, 2) NOT NULL DEFAULT 0.00," +
                "   `medie_an2` decimal(4, 2) NOT NULL DEFAULT 0.00," +
                "   `medie_an3` decimal(4, 2) NOT NULL DEFAULT 0.00," +
                "   PRIMARY KEY(`nr_legitimatie`)," +
                "   FOREIGN KEY(`nr_legitimatie`) REFERENCES studenti(`nr_legitimatie`) ON DELETE CASCADE" +
                " ) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4;";
            MySqlCommand createMediiCommand = new MySqlCommand(createMediiQuery, sqlConnection);
            createMediiCommand.ExecuteNonQuery();
        }


        //  metoda in care executam query pentru popularea bazei de date cu mediile studentilor
        private void insertMediiTable(MySqlConnection sqlConnection)
        {
            //  mediile au valoarea 0 ca default, acestea se schimba automat in urma adaugarii unei note

            queryInsertMedii(sqlConnection, "110", 0, 0, 0, 0); //  student cu legitimatie 110
            queryInsertMedii(sqlConnection, "111", 0, 0, 0, 0); //  student cu legitimatie 111
            queryInsertMedii(sqlConnection, "112", 0, 0, 0, 0); //  student cu legitimatie 112
            queryInsertMedii(sqlConnection, "113", 0, 0, 0, 0); //  student cu legitimatie 113
            queryInsertMedii(sqlConnection, "114", 0, 0, 0, 0); //  student cu legitimatie 114

        }


        //  query pentru a introduce o medie in tabela Medii
        private void queryInsertMedii(MySqlConnection sqlConnection, string legitimatie, double medieGenerala, double medieAnul1, double medieAnul2, double medieAnul3)
        {
            string query =
                "INSERT INTO `medii` (`nr_legitimatie`, `medie_generala`, `medie_an1`, `medie_an2`, `medie_an3`) " +
                "VALUES ('" + legitimatie + "', " + medieGenerala + ", " + medieAnul1 + ", " + medieAnul2 + ", " + medieAnul3 + ");";

            new MySqlCommand(query, sqlConnection).ExecuteNonQuery();
        }
        //--------------------------------------------


        //----------------Tabela note----------------
        //  crearea tabelei note in BD
        private void createNoteTable(MySqlConnection sqlConnection)
        {
            string createNoteQuery =
                " CREATE TABLE `note` (" +
                "   `id_nota` int NOT NULL AUTO_INCREMENT," +
                "   `nr_legitimatie` int(6) NOT NULL," +
                "   `disciplina` varchar(100) NOT NULL," +
                "   `an_studiu` int(1) NOT NULL," +
                "   `nr_prezentare` int(2) NOT NULL," +
                "   `data` DATE NOT NULL," +
                "   `nota` decimal(4, 2) NOT NULL," +
                "   CONSTRAINT `prezentari_unice` UNIQUE (`nr_legitimatie`, `disciplina`, `an_studiu`, `nr_prezentare`)," +
                "   PRIMARY KEY(`id_nota`)," +
                "   FOREIGN KEY(`nr_legitimatie`) REFERENCES studenti(`nr_legitimatie`) ON DELETE CASCADE" +
                " ) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4;";
            MySqlCommand createNoteCommand = new MySqlCommand(createNoteQuery, sqlConnection);
            createNoteCommand.ExecuteNonQuery();
        }


        //  metoda in care executam query pentru popularea bazei de date cu notele studentilor
        private void insertNoteTable(MySqlConnection sqlConnection)
        {
            //---------------------------------------------------------------------------
            // student cu legitimatie 110 - Matei Stefana Otilia - an de studiu 3 integralist
            // an 1
            queryInsertNote(sqlConnection, "110", "Algebra", 1, 1, "2020-01-10", 10);
            queryInsertNote(sqlConnection, "110", "Analiza Matematica", 1, 1, "2020-01-14", 4);
            queryInsertNote(sqlConnection, "110", "Introducere in programarea calculatoarelor", 1, 1, "2020-01-19", 9.8);
            queryInsertNote(sqlConnection, "110", "Structuri de date si algoritmi", 1, 1, "2020-01-15", 4.4);
            queryInsertNote(sqlConnection, "110", "Structuri de date si algoritmi", 1, 2, "2020-02-15", 6);
            queryInsertNote(sqlConnection, "110", "Fundamentele calculatoarelor", 1, 1, "2020-01-27", 3);
            queryInsertNote(sqlConnection, "110", "Analiza Matematica", 1, 2, "2020-02-13", 6.5);
            queryInsertNote(sqlConnection, "110", "Analiza Matematica", 1, 3, "2020-02-27", 7);
            queryInsertNote(sqlConnection, "110", "Fundamentele calculatoarelor", 1, 2, "2020-02-22", 4);
            queryInsertNote(sqlConnection, "110", "Fundamentele calculatoarelor", 1, 3, "2020-03-03", 6.8);
            queryInsertNote(sqlConnection, "110", "Fundamentele calculatoarelor", 1, 4, "2020-03-21", 8);

            // an 2
            queryInsertNote(sqlConnection, "110", "Sisteme de operare", 2, 1, "2020-12-12", 5.1);
            queryInsertNote(sqlConnection, "110", "Elemente de automatica", 2, 1, "2021-06-21", 7);
            queryInsertNote(sqlConnection, "110", "Analiza Algoritmilor", 2, 1, "2021-01-15", 5);
            queryInsertNote(sqlConnection, "110", "Proiectarea microsistemelor digitale", 2, 1, "2021-01-22", 8);
            queryInsertNote(sqlConnection, "110", "Management", 2, 1, "2021-05-09", 8);


            // an 3
            queryInsertNote(sqlConnection, "110", "Proiectarea interfetelor utilizator si grafica", 3, 1, "2022-01-19", 9);
            queryInsertNote(sqlConnection, "110", "Medii si tehnologii de programare", 3, 1, "2022-01-23", 8);
            queryInsertNote(sqlConnection, "110", "Limbaje formale si tehnici de compilare", 3, 1, "2022-01-27", 5);
            queryInsertNote(sqlConnection, "110", "Limbaje formale si tehnici de compilare", 3, 2, "2022-02-09", 6.8);
            queryInsertNote(sqlConnection, "110", "Limbaje formale si tehnici de compilare", 3, 3, "2019-02-23", 8);
            queryInsertNote(sqlConnection, "110", "Programare Web", 3, 1, "2022-01-20", 9.4);
            queryInsertNote(sqlConnection, "110", "Proiectarea bazelor de date", 3, 1, "2021-12-06", 9);


            //---------------------------------------------------------------------------


            // student cu legitimatie 111 - Popescu Cristian - an de studiu 1 integralist
            // an 1
            queryInsertNote(sqlConnection, "111", "Algebra", 1, 1, "2020-01-10", 9);
            queryInsertNote(sqlConnection, "111", "Analiza Matematica", 1, 1, "2020-01-16", 9.6);
            queryInsertNote(sqlConnection, "111", "Introducere in programarea calculatoarelor", 1, 1, "2020-01-18", 6.9);
            queryInsertNote(sqlConnection, "111", "Introducere in programarea calculatoarelor", 1, 2, "2020-02-20", 8.8);
            queryInsertNote(sqlConnection, "111", "Structuri de date si algoritmi", 1, 1, "2020-01-27", 7.5);
            queryInsertNote(sqlConnection, "111", "Fundamentele calculatoarelor", 1, 1, "2020-01-28", 3.8);
            queryInsertNote(sqlConnection, "111", "Fundamentele calculatoarelor", 1, 2, "2020-02-09", 4.7);
            queryInsertNote(sqlConnection, "111", "Fundamentele calculatoarelor", 1, 3, "2020-03-04", 7);


            //---------------------------------------------------------------------------


            // student cu legitimatie 112 - Ionescu Andrada - an de studiu 2
            // cu discipline nepromovate
            // an 1
            queryInsertNote(sqlConnection, "112", "Algebra", 1, 1, "2020-01-10", 6);
            queryInsertNote(sqlConnection, "112", "Algebra", 1, 2, "2020-02-12", 7.8);
            queryInsertNote(sqlConnection, "112", "Analiza Matematica", 1, 1, "2020-01-14", 3);
            queryInsertNote(sqlConnection, "112", "Introducere in programarea calculatoarelor", 1, 1, "2020-01-19", 9);
            queryInsertNote(sqlConnection, "112", "Structuri de date si algoritmi", 1, 1, "2020-01-15", 4.4);
            queryInsertNote(sqlConnection, "112", "Structuri de date si algoritmi", 1, 2, "2020-02-15", 5);
            queryInsertNote(sqlConnection, "112", "Structuri de date si algoritmi", 1, 3, "2020-02-15", 8.7);
            queryInsertNote(sqlConnection, "112", "Fundamentele calculatoarelor", 1, 1, "2020-01-27", 4);


            // an 2
            queryInsertNote(sqlConnection, "112", "Sisteme de operare", 2, 1, "2020-12-12", 6.5);
            queryInsertNote(sqlConnection, "112", "Elemente de automatica", 2, 1, "2021-04-21", 8.88);
            queryInsertNote(sqlConnection, "112", "Analiza Algoritmilor", 2, 1, "2021-01-15", 6.6);
            queryInsertNote(sqlConnection, "112", "Proiectarea microsistemelor digitale", 2, 1, "2021-01-22", 4);
            queryInsertNote(sqlConnection, "112", "Proiectarea microsistemelor digitale", 2, 2, "2021-02-10", 5.5);
            queryInsertNote(sqlConnection, "112", "Proiectarea microsistemelor digitale", 2, 3, "2021-02-24", 7.3);
            queryInsertNote(sqlConnection, "112", "Management", 2, 1, "2021-04-09", 9);


            //---------------------------------------------------------------------------


            // student cu legitimatie 113 - Costea Ioana - an 2 si are doar note sub 5 in doi ani consecutivi
            // an 1
            queryInsertNote(sqlConnection, "113", "Algebra", 1, 1, "2020-01-10", 3.3);
            queryInsertNote(sqlConnection, "113", "Algebra", 1, 2, "2020-02-12", 4);
            queryInsertNote(sqlConnection, "113", "Analiza Matematica", 1, 1, "2020-01-14", 3);
            queryInsertNote(sqlConnection, "113", "Introducere in programarea calculatoarelor", 1, 1, "2020-01-19", 3.5);
            queryInsertNote(sqlConnection, "113", "Structuri de date si algoritmi", 1, 1, "2020-01-15", 4.4);
            queryInsertNote(sqlConnection, "113", "Fundamentele calculatoarelor", 1, 1, "2020-01-27", 4);


            // an 2
            queryInsertNote(sqlConnection, "113", "Sisteme de operare", 2, 1, "2020-12-12", 3);
            queryInsertNote(sqlConnection, "113", "Elemente de automatica", 2, 1, "2021-04-21", 3.8);
            queryInsertNote(sqlConnection, "113", "Analiza Algoritmilor", 2, 1, "2021-01-15", 4.6);
            queryInsertNote(sqlConnection, "113", "Proiectarea microsistemelor digitale", 2, 1, "2021-01-22", 4);
            queryInsertNote(sqlConnection, "113", "Management", 2, 1, "2021-04-09", 2);


            //---------------------------------------------------------------------------


            // student cu legitimatie 114 - Petru Ioan - anul 3 si are doar note sub 5 in doi ani consecutivi
            // an 1
            queryInsertNote(sqlConnection, "114", "Algebra", 1, 1, "2020-01-10", 6);
            queryInsertNote(sqlConnection, "114", "Algebra", 1, 2, "2020-02-12", 9);
            queryInsertNote(sqlConnection, "114", "Analiza Matematica", 1, 1, "2020-01-14", 10);
            queryInsertNote(sqlConnection, "114", "Introducere in programarea calculatoarelor", 1, 1, "2020-01-19", 8.9);
            queryInsertNote(sqlConnection, "114", "Structuri de date si algoritmi", 1, 1, "2020-01-15", 4.4);
            queryInsertNote(sqlConnection, "114", "Structuri de date si algoritmi", 1, 2, "2020-02-15", 5);
            queryInsertNote(sqlConnection, "114", "Structuri de date si algoritmi", 1, 3, "2020-02-15", 7.7);
            queryInsertNote(sqlConnection, "114", "Structuri de date si algoritmi", 1, 4, "2020-03-15", 8.7);
            queryInsertNote(sqlConnection, "114", "Fundamentele calculatoarelor", 1, 1, "2020-01-27", 6);


            // an 2
            queryInsertNote(sqlConnection, "114", "Sisteme de operare", 2, 1, "2020-12-12", 3.3);
            queryInsertNote(sqlConnection, "114", "Elemente de automatica", 2, 1, "2021-04-21", 2);
            queryInsertNote(sqlConnection, "114", "Analiza Algoritmilor", 2, 1, "2021-01-15", 4);
            queryInsertNote(sqlConnection, "114", "Proiectarea microsistemelor digitale", 2, 1, "2021-01-22", 4);
            queryInsertNote(sqlConnection, "114", "Management", 2, 1, "2021-04-09", 4.8);


            // an 3
            queryInsertNote(sqlConnection, "114", "Proiectarea interfetelor utilizator si grafica", 3, 1, "2022-01-19", 4.5);
            queryInsertNote(sqlConnection, "114", "Medii si tehnologii de programare", 3, 1, "2022-01-23", 4.5);
            queryInsertNote(sqlConnection, "114", "Limbaje formale si tehnici de compilare", 3, 1, "2022-01-27", 4.5);
            queryInsertNote(sqlConnection, "114", "Programare Web", 3, 1, "2022-01-20", 4.5);
            queryInsertNote(sqlConnection, "114", "Proiectarea bazelor de date", 3, 1, "2021-12-06", 4.5);
        }


        //  query pentru a introduce o nota in tabela Note
        private void queryInsertNote(MySqlConnection sqlConnection, string legitimatie, string disciplina, int anStudiu, int nrPrezentare, string data, double nota)
        {
            string query =
                "INSERT INTO `note` (`nr_legitimatie`, `disciplina`, `an_studiu`, `nr_prezentare`, `data`, `nota`) " +
                "VALUES ('" + legitimatie + "', '" + disciplina + "', " + anStudiu + ", " + nrPrezentare + ", '" + data + "', " + nota + ");";

            new MySqlCommand(query, sqlConnection).ExecuteNonQuery();
        }
        //--------------------------------------------



        // trigger(SQL) ce se executa la aparitia unui eveniment - la adaugarea unei note
        // modifica starea anumitor obiecte din DB - se calculeaza automat atat media pe anul respectiv
        // cat si media generala
        private void generateTriggers(MySqlConnection sqlConnection)
        {
            string deleteQuery =
                " DROP TRIGGER IF EXISTS `deleteMedie`;" +
                " CREATE DEFINER=`root`@`localhost` TRIGGER `deleteMedie` AFTER INSERT ON" +
                "  `note` FOR EACH ROW" +
                "  DELETE" +
                "  FROM medii" +
                "  WHERE nr_legitimatie = new.nr_legitimatie";


            string updateQuery =
                " DROP TRIGGER IF EXISTS `updateMedie`;" +
                " CREATE DEFINER=`root`@`localhost` TRIGGER `updateMedie` AFTER INSERT ON `note`" +
                "  FOR EACH ROW" +
                "  INSERT INTO medii (medii.nr_legitimatie, medii.medie_generala, medii.medie_an1, medii.medie_an2, medii.medie_an3)" +
                "  WITH note_maxime_an AS" +
                "    (" +
                "        SELECT nr_legitimatie," +
                "               disciplina," +
                "               an_studiu," +
                "               MAX(nota) AS nota_maxima" +
                "        FROM note" +
                "        WHERE an_studiu IN(1, 2, 3)" + // selecteaza studentii care sunt in anul de studiu 1, 2 sau 3
                "          AND nr_legitimatie = new.nr_legitimatie" +
                "        GROUP BY nr_legitimatie, disciplina, an_studiu" +
                "    )" +
                "    ," +
                "       medie AS" +
                "    (" +
                "        SELECT nr_legitimatie," +
                "               an_studiu," +
                "               AVG(nota_maxima) AS medie" +
                "        FROM note_maxime_an" +
                "        GROUP BY nr_legitimatie," +
                "                 an_studiu" +
                "    )" +
                " SELECT nr_legitimatie," +
                "        AVG(medie) AS medie," +
                "        MAX(CASE WHEN an_studiu = 1 THEN medie END) AS medie_an_1," + // returneaza media in functie de anul de studiu
                "        MAX(CASE WHEN an_studiu = 2 THEN medie END) AS medie_an_2," +
                "        MAX(CASE WHEN an_studiu = 3 THEN medie END) AS medie_an_3" +
                " FROM medie" +
                " GROUP BY nr_legitimatie";


            new MySqlCommand(deleteQuery, sqlConnection).ExecuteNonQuery();
            new MySqlCommand(updateQuery, sqlConnection).ExecuteNonQuery();
        }


        // functie(SQL) ce primeste ca parametru disciplina si returneaza promovabilitatea acesteia
        private void promovabilitateDisciplinaFunction(MySqlConnection sqlConnection)
        {
            string queryFunction =
                " DROP FUNCTION IF EXISTS `promovabilitate_disciplina`;" +
                " CREATE DEFINER =`root`@`localhost`" +
                " FUNCTION `promovabilitate_disciplina`(`disciplina` VARCHAR(100)) RETURNS DOUBLE NOT DETERMINISTIC CONTAINS SQL SQL SECURITY DEFINER" +
                " BEGIN" +
                " DECLARE procent DOUBLE;" +
                " SET procent = 0;" +
                " WITH promovati AS" +
                "   (" +
                "       SELECT COUNT(studenti.nr_legitimatie) AS counter" +
                "       FROM studenti" +
                "       LEFT JOIN " +
                "         (" +
                "             SELECT note.nr_legitimatie," +
                "                    note.disciplina," +
                "                    note.an_studiu," +
                "                    MAX(note.nota) AS nota" +
                "             FROM note" +
                "             WHERE note.disciplina = disciplina" +
                "             GROUP BY note.nr_legitimatie," +
                "                      note.disciplina," +
                "                      note.an_studiu" +
                "         )" +
                "         AS joined USING(nr_legitimatie)" +
                "       WHERE joined.nota >= 5" +
                "         AND joined.disciplina = disciplina" +
                "   )" +
                "   ," +
                "      totali AS" +
                "   (" +
                "       SELECT COUNT(studenti.nr_legitimatie) AS counter" +
                "       FROM studenti" +
                "       LEFT JOIN" +
                "         (" +
                "             SELECT note.nr_legitimatie," +
                "                    note.disciplina," +
                "                    note.an_studiu," +
                "                    MAX(note.nota) AS nota" +
                "             FROM note" +
                "             WHERE note.disciplina = disciplina" +
                "             GROUP BY note.nr_legitimatie," +
                "                      note.disciplina," +
                "                      note.an_studiu " +
                "         )" +
                "         AS joined USING(nr_legitimatie)" +
                "       WHERE joined.disciplina = disciplina" +
                "   )" +
                " SELECT(promovati.counter / totali.counter) * 100" +
                " INTO procent" +
                " FROM promovati," +
                "      totali;" +
                " RETURN procent; " +
                " END";


            new MySqlCommand(queryFunction, sqlConnection).ExecuteNonQuery();
        }


        // functie(SQL) ce returneaza rata de promovabilitate a unui student 
        private void promovabilitateStudentFunction(MySqlConnection sqlConnection)
        {
            string query =
                " DROP FUNCTION IF EXISTS `promovabilitate_student`;" +
                " CREATE DEFINER =`root`@`localhost` FUNCTION `promovabilitate_student`(`nr_legitimatie` INT(6)) RETURNS DOUBLE NOT DETERMINISTIC CONTAINS SQL SQL SECURITY DEFINER BEGIN" +
                " DECLARE rata_promovabilitate DOUBLE;" +
                " SET rata_promovabilitate = 0;" +
                " WITH discipline_promovate AS" +
                "   (" +
                "       SELECT COUNT(note.disciplina) AS counter" +
                "       FROM" +
                "         ( " +
                "             SELECT nr_legitimatie," +
                "                    disciplina," +
                "                    an_studiu," +
                "                    MAX(nota) AS nota" +
                "             FROM" +
                "             note" +
                "             WHERE note.nr_legitimatie = nr_legitimatie" +
                "               AND nota >= 5" +
                "             GROUP BY note.nr_legitimatie," +
                "                      note.an_studiu" +
                "         ) note" +
                "   )" +
                "   ," +
                "      total_discipline AS" +
                "   (" +
                "       SELECT COUNT(note.disciplina) AS counter" +
                "       FROM" +
                "         (" +
                "             SELECT nr_legitimatie," +
                "                    disciplina," +
                "                    an_studiu," +
                "                    MAX(nota) AS nota" +
                "             FROM" +
                "             note" +
                "             WHERE note.nr_legitimatie = nr_legitimatie" +
                "             GROUP BY note.nr_legitimatie," +
                "                      note.an_studiu" +
                "         ) note" +
                "   )" +
                " SELECT(discipline_promovate.counter / total_discipline.counter) * 100" +
                " INTO rata_promovabilitate" +
                " FROM discipline_promovate," +
                "      total_discipline;" +
                " RETURN rata_promovabilitate;" +
                " END";


            new MySqlCommand(query, sqlConnection).ExecuteNonQuery();
        }
    }
}

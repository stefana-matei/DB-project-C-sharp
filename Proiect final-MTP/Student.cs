using MySql.Data.MySqlClient;

namespace Proiect_final_MTP
{
    class Student
    {
        static MySqlConnection sqlConnection = Connection.getSqlConnection();
        static string nume, prenume, nr_legitimatie;

        static public string Nume { get => nume; set => nume = value; }
        static public string Prenume { get => prenume; set => prenume = value; }
        static public string Legitimatie { get => nr_legitimatie; set => nr_legitimatie = value; }


        // metoda ce returneaza numele intreg al studentului
        static public string FullName()
        {
            return nume + " " + prenume;
        }


        // metoda ce returneaza anul de studiu al studentului
        static public int AnStudiu()
        {
            string queryAnStudiu =
               " SELECT MAX(note.an_studiu)" +
               " FROM note" +
               " WHERE nr_legitimatie = '" + Student.Legitimatie + "'";

            sqlConnection.Open();
            MySqlCommand sqlCommand = new MySqlCommand(queryAnStudiu, sqlConnection);
            int anStudiu = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();

            return anStudiu;
        }
    }
}

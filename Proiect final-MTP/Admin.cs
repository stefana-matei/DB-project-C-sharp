using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_final_MTP
{
    class Admin
    {
        static string nume, prenume;

        static public string Nume { get => nume; set => nume = value; }
        static public string Prenume { get => prenume; set => prenume = value; }


        static public string FullName()
        {
            return nume + " " + prenume;
        }
    }
}

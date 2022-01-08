using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_final_MTP
{
    class Instances
    {
        static Home home;


        static public void setHome(Home instance) { if (home == null) home = instance; }

        static public Home getHome() { return home; }
    }
}

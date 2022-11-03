using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    static class AllUsers
    {
        static List<Player> users = new List<Player>();

        internal static List<Player> Users { get => users; set => users = value; }
    }


}

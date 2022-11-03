using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    // מחזיקה  מחלקת שחקן 
    class Player
    {
        string userName;
        Queue<int> latest;


        internal Queue<int> Latast { get => latest; set => latest = value; }
        public string UserName { get => userName; set => userName = value; }

        public Player(string email)
        {
            UserName = userName;
            latest = new Queue<int>();

        }
    }
}

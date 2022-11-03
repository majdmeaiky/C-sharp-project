using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    static class CurrentUser
    {
        // מחלקה סטטית מחזיקה משתנה סטטי שם של שחקן כדי לדעת בכל רגע מי השחקן הנוחכי
        static string username;
        static Queue<int> usedwords;

        //פרופרטיס
        public static string Username { get => username; set => username = value; }
        public static Queue<int> Usedwords { get => usedwords; set => usedwords = value; }
    }
}

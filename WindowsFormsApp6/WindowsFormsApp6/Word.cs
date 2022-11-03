using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{  //מחלקת מילה - מחלקה שמייצגת מילה מחזיקה משתנה שהוא שם המילה 
    class Word
    { 
        string theWord;

        public string TheWord { get => theWord; set => theWord = value; }

        public Word(string theWord)
        {
            TheWord = theWord;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{

    //מחלקת אות- נחזיקה מספר שמייצג את מספר האות וליסט של אובייקטים מסוג תמונה ושמע
    class Letter
    {
        int num;
        List<ImageAndVoice> words;

        public int Num { get => num; set => num = value; }
        internal List<ImageAndVoice> Words { get => words; set => words = value; }

        public Letter(int num, List<ImageAndVoice> words)
        {
            Num = num;
            Words = words;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{


    class ImageAndVoiceData : ImageAndVoice
    {
        //מחלקת "מידע תמונה ושמע" - יורשת ממחלקת תמונה ושמע מחזיקה מידע על מספר המילה אורך המילה ואותיות נוספות
        public static int count = 0;
        int num;
        Queue<char> additional;
        int length;

        public int Num { get => num; set => num = value; }
        public Queue<char> Additional { get => additional; set => additional = value; }
        public static int Count { get => count; set => count = value; }

        public ImageAndVoiceData() : base(null, null, null)
        {
            Count = 0;
            num = 0;
            additional = null;
            length = 0;
        }

        public ImageAndVoiceData(ImageAndVoice iv) : base(iv.Image, iv.Voice, iv.TheWord)
        {
            Num = AllLitters.Counter;
            length = TheWord.Length;
            char[] otherLetters = iv.TheWord.ToCharArray();
            additional = new Queue<char>();
            for (int i = 1; i < otherLetters.Length; i++)
            {
                additional.Enqueue(otherLetters[i]);
            }
            Count++;
        }

        //מתודה שהופכת את נתוני ההאובייקט לסטרינג בפורמט כתיבה לקובץ
        public override String ToString()
        {
            string toTxt = "";
            string[] imageArr = Image.Split('\\');
            string[] voiceArr = Voice.Split('\\');
            string imageName = imageArr[imageArr.Length - 1];
            string voiceName = voiceArr[voiceArr.Length - 1];
            toTxt = toTxt + num + ";" + TheWord + ";" + imageName + ";" + voiceName + ";" + FirstLetter + ";" + length + ";";
            Queue<char> lastLetters = additional;
            while (lastLetters.Count != 0)
            {
                toTxt = toTxt + additional.Dequeue().ToString() + ";";
            }
            return toTxt;
        }
    }

}
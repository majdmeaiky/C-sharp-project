using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    //מחלקת תמונה ושמע -מחלקה שיורשת ממחלקה מילה  מחזיקה בנוסף את שם התמונה של השמע והאות הראשונה
    class ImageAndVoice : Word
    {
        string image;
        string voice;
        char firstLetter;

        public string Voice { get => voice; set => voice = value; }
        public string Image { get => image; set => image = value; }
        public char FirstLetter { get => firstLetter; set => firstLetter = value; }


        public ImageAndVoice(string image, string voice, string theWord) : base(theWord)
        {
            FirstLetter = TheWord.ToCharArray()[0];
            Image = image;
            Voice = voice;
        }
        //מתודה שמקבלת אובייקט תמונה ושמע ובודקת אם הוא שווה לאובייקט המפעיל לפי הפרמטרים שקבענו - יש לציין לא הצלחנו לממש ICOMPAREABLE לכן השתמשנו במתודה זו
        public int EqualTo(ImageAndVoice x)
        {
            string[] imageArr = Image.Split('\\');
            string[] voiceArr = Voice.Split('\\');
            string imageName = imageArr[imageArr.Length - 1];
            string voiceName = voiceArr[voiceArr.Length - 1];

            string[] imageArrX = x.Image.Split('\\');
            string[] voiceArrX = x.voice.Split('\\');
            string imageNameX = imageArrX[imageArrX.Length - 1];
            string voiceNameX = voiceArrX[voiceArrX.Length - 1];

            if (x.TheWord == TheWord || imageNameX == imageName || voiceNameX == voiceName)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}

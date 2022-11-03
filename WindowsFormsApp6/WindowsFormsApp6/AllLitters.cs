using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace WindowsFormsApp6
{
    //מחקלה סטטית שמחזיקה משתנה סטטי מערך של LETTERS
    static class AllLitters
    {
        //מערך של LETTERS
        static Letter[] letters = new Letter[26];
        static int counter = 0;

        //מונה סטטי לצורך מספר מזהה למילים
        public static int Counter { get => counter; set => counter = value; }

        //מתודה שיוצרת את מערך האותיות מהכתוב בקובץ firstletterdata
        static public Letter[] Createletters()
        {
            Letter[] letters = new Letter[26];
            List<ImageAndVoice> ivLIst = new List<ImageAndVoice>();
            StreamReader sr = new StreamReader(@".\DATA\firstletterData.txt");
            string[] lines = new string[26];
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = sr.ReadLine();
            }
            for (int i = 0; i < lines.Length; i++)
            {
                string[] letterInfo = lines[i].Split(';');
                for (int j = 1; j < letterInfo.Length; j = j + 2)
                {
                    string image = @".\DIMAGE\" + letterInfo[j] + ".jpg";
                    string voice = @".\VOICE\" + letterInfo[j] + ".wav";
                    ImageAndVoice tmp = new ImageAndVoice(image, voice, letterInfo[j]);
                    ivLIst.Add(tmp);
                }
                List<ImageAndVoice> tmp1 = new List<ImageAndVoice>(ivLIst);

                Letter l = new Letter(int.Parse(letterInfo[0]), tmp1);
                letters[i] = l;
                ivLIst.Clear();
                sr.Close();
            }
            return letters;
        }

        //מתודה שמקבלת אובייקט imageandvoice וכותבת אותה לפי הפורמט לwoedimagedata
        static public void WriteToWordImadeData(ImageAndVoiceData ivd)
        {
            StreamWriter sw = new StreamWriter(@".\DATA\wordImageData.txt", true);
            sw.WriteLine(ivd.ToString());
            Counter++;
            sw.Close();
        }

        //מתודה שמקבלת List<ImageAndVoice> וכותבת את כל האיברים לקובץ המילים  
        static public void WriteCurrentWords(List<ImageAndVoice> ivl)
        {
            for (int i = 0; i < ivl.Count; i++)
            {
                ImageAndVoiceData tmp = new ImageAndVoiceData(ivl[i]);
                WriteToWordImadeData(tmp);
            }
        }

        //מתודה שמקבלת מערך של אותיות וכותבת את כל איבריו לקובץ המילים
        static public void WriteCurrentWordsArr(Letter[] l)
        {
            for (int i = 0; i < l.Length; i++)
            {
                for (int j = 1; j < l[i].Words.Count; j++)
                {
                    ImageAndVoiceData tmp = new ImageAndVoiceData(l[i].Words[j]);
                    WriteToWordImadeData(tmp);
                }
            }
        }

        //מתודה שיוצרת ליסט של IMAGEANDVOICE מתוך הכתוב בקובץ
        static public List<ImageAndVoice> CreateCurrentWordList()
        {
            StreamReader sr = new StreamReader(@".\DATA\wordImageData.txt");
            string line = "";
            List<ImageAndVoice> ivl = new List<ImageAndVoice>();
            //List<string> lines = new List<string();
            int lineNum = File.ReadLines(@".\DATA\wordImageData.txt").Count();

            for (int i = 0; i < lineNum; i++)
            {
                line = sr.ReadLine();
                string[] lineInfo = line.Split(';');
                ImageAndVoice tmp = new ImageAndVoice(lineInfo[2], lineInfo[3], lineInfo[1]);
                ivl.Add(tmp);
            }
            sr.Close();

            return ivl;
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp6
{
    //מסך עדכון התוכן
    public partial class Form3 : Form
    {
           //מערך של כל האותיות
        static Letter[] letters = AllLitters.Createletters();

        //ליסט של כל המילים כאובייקט תמונה ושמע
        List<ImageAndVoice> ivl = AllLitters.CreateCurrentWordList();

        public Form3()
        {
            InitializeComponent();
        }

        //בלחציה נבחר קובץ תמונה להעלאה
        private void btnUpload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPG Files (*.jpg)| *.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = file.FileName;
            }
            file.Dispose();
        }

        //  בלחיצה נבחר קובץ שמע להעלאה 
        private void btnUploadVoice_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog file2 = new OpenFileDialog();
            file2.Filter = "WAV Files (*.wav)| *.wav";
            if (file2.ShowDialog() == DialogResult.OK)
            {
                txtVoice.Text = file2.FileName;
            }
            file2.Dispose();
        }

        // מתודה שמקבלת מילה כאובייקט תמונה ושמע ותחזיר 0 אם קיימת מילה בעלת אותו שם מילה או שם קובץ תמונה או שם קובץ שמע  
        private int CheckWord(ImageAndVoice x)
        {
            int flag = 1;
            for (int i = 0; i < ivl.Count; i++)
            {
                flag = x.EqualTo(ivl[i]);
                if (flag == 0)
                {
                    return flag;
                }
            }
            return flag;
        }

        //המתודה תוסיף את המילה שקראנו מהמשתמש תזרוק חריגה אם המילה קיימת לפי אחד מהפרמטרים
        private void AddWord()
        {
            string[] imageArr = txtImage.Text.Split('\\');
            string[] voiceArr = txtVoice.Text.Split('\\');
            //שם התמונה + סיומת
            string image = imageArr[imageArr.Length - 1];
            //שם קובץ שמע +סיומת
            string voice = voiceArr[voiceArr.Length - 1];
            //המילה
            string word = txtNewWord.Text;

            //יצירת אובייקטים מסוג "תמונה ושמע" ו"מידע תמונה ושמע"  
            ImageAndVoice y = new ImageAndVoice(image, voice, word);
            ImageAndVoiceData iwdY = new ImageAndVoiceData(y);

            //בדיקה האם המילה קיימת לפי אחד הפרמטרים וזריקת חריגה אם כן
            int flag1 = CheckWord(y);
            if (flag1 == 0)
            {
                throw new IOException();
                return;
            }

            else
            {
                MessageBox.Show("We have updated the data of the word.\nWe have finished, good bye.");
                ivl.Add(y); //הוספת המילה לליסט
                AllLitters.WriteToWordImadeData(iwdY);//כתיבת המילה לקובץ 
                ivl = AllLitters.CreateCurrentWordList();//עדכון הליסט מהקובץ
                File.WriteAllText(@".\DATA\wordImageData.txt", String.Empty);
                AllLitters.Counter = 0;
                AllLitters.WriteCurrentWords(ivl);//כתיבה מחודשת לקובץ 
                string imageSource = txtImage.Text;
                string voiceSource = txtImage.Text;
                string imageDest = @".\DIMAGE\" + image;
                string voiceDest = @".\VOICE\" + voice;
                File.Copy(imageSource, imageDest);//הכנסת קובץ התמונה לתקייה
                File.Copy(voiceSource, voiceDest);//הכנסת קובץ השמע לתקייה
                txtNewWord.Text = "";
                txtVoice.Text = "";
                txtImage.Text = "";
                this.Close();
            }
        }

        //בלחיצה בדיקת תקינות המידע והוספת הקובץ 
        private void btnNewSubmit_Click_1(object sender, EventArgs e)
        {
            if (!txtNewWord.Text.All(Char.IsLetter))
            {
                MessageBox.Show("You entered an illegal word, please try again");
                txtImage.Text = "";
                txtNewWord.Text = "";
                txtVoice.Text = "";
                return;
            }
            if (txtNewWord.Text == "" || txtImage.Text == "" || txtVoice.Text == "")
            {
                MessageBox.Show("Not all the information is entered, please try again");
                txtImage.Clear();
                txtNewWord.Clear();
                txtVoice.Clear();
                return;
            }
            else
            {
                try
                {
                    AddWord();
                }
                catch (IOException ex)
                {
                    MessageBox.Show("one of the files you entered is already in, sorry!");
                    txtNewWord.Text = "";
                    txtImage.Text = "";
                    txtVoice.Text = "";
                    return;
                }
            }
        }

      
    }
}

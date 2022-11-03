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
    // משחק 2 - במשחק מוצגת תמונה ועל השחקן לכתוב את המילה שהתמונה מייצגת
    //נבמהלך המשחק השחקן יקבל הודעות על תשובות נכונות ושגויות כל תשובה נכונה תזכה את השחקן בנקודה
    public partial class Form6 : Form
    {
        List<ImageAndVoice> tmp = AllLitters.CreateCurrentWordList(); //ליסט של כל המילים בפורנט "תמונה ושמע"
        static int counter = 0;  //סופר כמה סיבובים עברו במשחק
        string answer; // משתנה להחזקת התשובה של המשתמש
        int idx;
        int points = 0; //סופר נקודות
        Queue<int> usedWords = new Queue<int>();//תור של מילים שהמשתמש קיבל , משמש אותנו כדי שהמשתמש יקבל מילים מגוונות במשחק

        public Form6()
        {
            InitializeComponent();
            btnStart.Visible = true;
        }

        // מתודה המפעילה את המשחק מגרילה מילה ,אם השחקן וותיק (מעל שלוש טעויות) המתודה תגריל מילה אחת מבין הטעויות
        //מחזירה את המילה של התמונה המוצגת
        public string Game2()
        {
            int lines = File.ReadLines(@".\OUTPUT\" + CurrentUser.Username + "_Wrong.txt").Count();
            //שחקן ותיק הוא מי שיש לו לפחות שלוש טעויות
            if (counter == 1 && lines < 3)
            {
                StreamReader sr = new StreamReader(@".\OUTPUT\" + CurrentUser.Username + "_Wrong.txt");

                int[] mistakes = new int[lines];//מערך של הטעויות
                for (int i = 0; i < lines; i++)
                {
                    mistakes[i] = int.Parse(sr.ReadLine());
                }
                Random rnd1 = new Random();
                int tmpidx = rnd1.Next(lines);//הגרלת אינדקס מהמערך
                idx = mistakes[tmpidx];//המילה המוגרלת
                while (usedWords.Contains(idx))//בדיקה שהמילה לא הייתה לאחרונה
                {
                    tmpidx = rnd1.Next(lines);
                    idx = mistakes[tmpidx];
                }
                sr.Close();
            }
            else // הגרלת מילה אם המשתמש לא וותיק
            {
                Random rnd = new Random();
                idx = rnd.Next(0, tmp.Count);
                while (usedWords.Contains(idx))//בדיקה אם הייתה לאחרונה 
                {
                    idx = rnd.Next(0, tmp.Count);
                }
            }
            usedWords.Enqueue(idx);//הכנסת המילה לתור הייתה לאחרונה
            picGame.Image = Image.FromFile(@".\DIMAGE\" + tmp[idx].Image);
           return tmp[idx].TheWord;//החזרת המילה של התמונה המוצגת
        }
        //בלחיצה נפעיל את המשחק ,נתקדם ,נסיים ונציג הודעה על ניקוד בסוף נצא בצורה מסודרת
        private void btnStart_Click(object sender, EventArgs e)
        {
            answer = Game2();
            lblWriteHere.Visible = true;
            lblWelcome.Visible = false;
            btnStart.Text = "Next";
            btnStart.Visible = false;
            txtAnswer.Visible = true;
            picGame.Visible = true;
            btnSubmit.Visible = true;
            txtAnswer.Enabled = true; 

            txtAnswer.Text = "";
            counter++;
            if (counter == 3)
            {
                btnStart.Text = "Return To Games";
            }
            if (counter == 4)
            {
                lblWelcome.Visible = false;
                btnStart.Visible = false;
                lblWriteHere.Visible = false;
                txtAnswer.Visible = false;
                picGame.Visible = false;
                btnSubmit.Visible = false;
                btnStart.Visible = true;
                counter = 0;
                MessageBox.Show("you got " + points + " right answers." + "\nyou got " + (3 - points) + " wrong answers.");
                this.Close();
            }
        }
        // בלחיצה נקבע את התשובה ונציג נכון או לא נכון
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnStart.Visible = true;
            btnSubmit.Visible = false;
            lblWriteHere.Visible = false;

            if (txtAnswer.Text == answer)
            {
                points++;
                MessageBox.Show("your answer is correct");
                txtAnswer.Enabled = false;
            }
            else
            {
                btnSubmit.Visible = false;
                txtAnswer.Enabled = false;
                MessageBox.Show("you answer is not correct");
                StreamWriter sw = new StreamWriter(@".\OUTPUT\" + CurrentUser.Username + "_Wrong.txt", true);
                sw.WriteLine(idx.ToString());
                sw.Close();
            }
            txtAnswer.Text = "";
        }
    }
}

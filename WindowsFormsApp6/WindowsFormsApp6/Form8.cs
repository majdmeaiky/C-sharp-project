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
using System.Media;

namespace WindowsFormsApp6
{
    //משחק 4 - על המשתמש לבחור מה המילה הנכונה בהישמע צליל
    public partial class Form8 : Form
    {
        List<ImageAndVoice> tmp = AllLitters.CreateCurrentWordList();//ליסט כל המילים
        int x; // משתנה להחזקת אינדקס
        int y; // משתנה להחזקת ת.ז המילה הנכונה 
        int points = 0; // נקודות
        static int counter = 0;//סופר חזרות
        SoundPlayer sp;
        Queue<int> usedWords = new Queue<int>();

        public Form8()
        {
            InitializeComponent();
            sp = new SoundPlayer();
        }
        //מתודה להפעלת המשחק , מגרילה שלוש מילים בכל סיבוב ומתוכן מילה נכונה לשחקנים ותיקים תרגיל מילה מתוך הטעויות
        //מחזירה את האינדקס של התשובה הנכונה 
        public int Game4()
        {
            int correct, correctidx;//אינדקס של תשובה נכונה ,ת.ז של המילה הנכונה 
            int first, second, third;//המילים המוגרלות
            Random rand = new Random();

            first = rand.Next(0, tmp.Count);//גרלת המילה הראשונה
            while(usedWords.Contains(first))//בדיקה שלא הייתה לאחרונה
            {
                first = rand.Next(0, tmp.Count);
            }
            usedWords.Enqueue(first);//הכנסה לתור היה לאחרונה 

            second = rand.Next(0, tmp.Count);//הגרלת המילה השניה
            while (usedWords.Contains(second))//בדיקה שלא הייתה לאחרונה
            {
                second = rand.Next(0, tmp.Count);
            }
            usedWords.Enqueue(second);//הכנסה לתור היה לאחרונה 

            int lines = File.ReadLines(@".\OUTPUT\" + CurrentUser.Username + "_Wrong.txt").Count();
            //למשתמש ותיק בעל יותר משלוש טעויות
            if (counter==1 && lines>3)
            {
                StreamReader sr = new StreamReader(@".\OUTPUT\" + CurrentUser.Username + "_Wrong.txt");
                int[] mistakes = new int[lines];//מערך טעויות

                for (int i = 0; i < lines; i++)
                {
                    mistakes[i] = int.Parse(sr.ReadLine());
                }

                int tmpidx = rand.Next(lines);//הגרלת אינדקס לתשובה נכונה 
                correct = mistakes[tmpidx]; //השמה של התשובה הנכונה 
                third = correct;
                while (usedWords.Contains(correct))//בדיקה שלא היה לאחרונה 
                {
                    tmpidx = rand.Next(lines);
                    correct = mistakes[tmpidx];
                    third = correct;
                }
                correctidx = 1;
                usedWords.Enqueue(third);//השמה לתוך תור היה לאחרונה 
                sr.Close();
            }
            
            else//למשתמש לא וותיק 
            {
                third = rand.Next(0, tmp.Count);//הגרלת מילה 
                while (usedWords.Contains(third))//בדיקה שלא הייתה לאחרונה 
                {
                    third = rand.Next(0, tmp.Count);
                }
                usedWords.Enqueue(third);//השמה לתור היה לאחרונה 
                correctidx = rand.Next(0, 3);
            }

            third = rand.Next(0, tmp.Count);
            {
                third = rand.Next(0, tmp.Count);
            }
            usedWords.Enqueue(third);

            int[] arr = { first, second, third };
            correctidx = rand.Next(0, 3);
             correct = arr[correctidx];
            lblWord1.Text = tmp[first].TheWord;
            lblWord2.Text = tmp[second].TheWord;
            lblWord3.Text = tmp[third].TheWord;
            sp.SoundLocation = (@".\VOICE\" + tmp[correct].Voice);
            sp.Play();
            y = correct;
            return correctidx;//החזרת האינדקס של המילה הנכונה 
        }

        //בלחיצה נתחיל ונפעיל את המשחק נתקדם ונסיים במסודר בסיום נציג הודעה עם פיאוט תשובות נכונות ושגיאות
        private void btnStart_Click(object sender, EventArgs e)
        {
            x = Game4();
            cmbAnswer.Enabled = true;
            btnSubmit.Visible = true;
            btnStart.Visible = false;
            cmbAnswer.Visible = true;
            lblChoise1.Visible = true;
            lblChoise2.Visible = true;
            lblChoise3.Visible = true;
            lblWord1.Visible = true;
            lblWord2.Visible = true;
            lblWord3.Visible = true;
            lblWelcome.Visible = false;
            btnStart.Text = "Next";
            counter++;
            if (counter == 3)
            {
                btnStart.Text = "Return To Games"; 
            }
            if (counter == 4)
            {
                sp.Stop();
                cmbAnswer.Visible = false;
                lblChoise1.Visible = false;
                lblChoise2.Visible = false;
                lblChoise3.Visible = false;
                lblWord1.Visible = false;
                lblWord2.Visible = false;
                lblWord3.Visible = false;
                lblWelcome.Visible = false;
                btnStart.Text = "Start";
                MessageBox.Show("you got " + points + " right answers." + "\nyou got " + (3 - points) + " wrong answers.");
                counter = 0;
                this.Close();
            }
        }

        //בלחיצה נקבע את התשובה ונקבל משוב אם התשובה נכונה או לא
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbAnswer.SelectedIndex == x)
            {
                MessageBox.Show("you answer is correct");
                points++;
            }
            else
            {
                MessageBox.Show("you answer is not correct");
                StreamWriter sw = new StreamWriter(@".\OUTPUT\" + CurrentUser.Username + "_Wrong.txt", true);
                sw.WriteLine(y.ToString());
                sw.Close();
            }
            btnSubmit.Visible = false;
            btnStart.Visible = true;
            cmbAnswer.SelectedIndex = -1;
            cmbAnswer.Enabled = false;
        }
    }
}

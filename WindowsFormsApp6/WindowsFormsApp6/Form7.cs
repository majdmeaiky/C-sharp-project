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
    //משחק 3- בהינתן תמונה ושמע למשתמש יש 7 שניות לכתוב את המילה המתאימה לתמונה ולשמע 
    //תשובה נכונה ובזמן תזכה את השחקן בנקודה
    public partial class Form7 : Form
    {
        List<ImageAndVoice> tmp = AllLitters.CreateCurrentWordList(); // ליסט של כל המילים 
        static int counter = 0; // משתנה הסופר חזרות
        string answer; // משתנה לשמירת התשובה הנכונה 
        int idx; // משתנה לשמירת ת.ז המילה הנכונה 
        int timeToFinish = 5; 
        int ticks;
        int points = 0;//נקודות
        SoundPlayer sp;
        Queue<int> usedWords = new Queue<int>(); //תור של מילים שהמשתמש קיבל , משמש אותנו כדי שהמשתמש יקבל מילים מגוונות במשחק
        public Form7()
        {
            InitializeComponent();
            sp = new SoundPlayer();

        }
        //חמתודה המפעילה את המשחק ,מגרילה  מילה מבין מערך המילים /מילה אחד לתרגול מבין הטעויות למשתמש ותיק
        //מחזירה את המילה הנבחרת
        public string Game3()
        {
            int lines = File.ReadLines(@".\OUTPUT\" + CurrentUser.Username + "_Wrong.txt").Count();
            //משתמש ותיק הוא מי שיש לו מעל שלוש טעויות
            if (counter == 1 && lines >3)
            {
                StreamReader sr = new StreamReader(@".\OUTPUT\" + CurrentUser.Username + "_Wrong.txt");
              
                int[] mistakes = new int[lines];//מערך טעויות
                for (int i = 0; i < lines; i++)
                {
                    mistakes[i] = int.Parse(sr.ReadLine());

                }
                Random rnd1 = new Random();
                int tmpidx = rnd1.Next(lines); // הגרלת האינדקס של המילה מבין מערך הטעויות
                idx = mistakes[tmpidx]; // משתנה המחזיק ת.ז של המילה שנבחרה
                while (usedWords.Contains(idx))//בדיקה שהמילה שנבחרה לא הייתה לאחרונה
                {
                    tmpidx = rnd1.Next(lines);
                    idx = mistakes[tmpidx];

                }
                sr.Close();
            }
            else//למשתמש לא וותיק
            {
                Random rnd = new Random(); // הגרלת מילה מבין מאגר המילים
                idx = rnd.Next(0, tmp.Count);
                while (usedWords.Contains(idx))//בדיקה שלא הייתה לאחרונה 
                {
                    idx = rnd.Next(0, tmp.Count);
                }
            }
           
            usedWords.Enqueue(idx);//השמת המילה לתור היה לאחרונה 
            picGame.Image = Image.FromFile(@".\DIMAGE\" + tmp[idx].Image);
            sp.SoundLocation = @".\VOICE\" + tmp[idx].Voice;
            sp.Play();
            return tmp[idx].TheWord;//החזרת המילה הנבחרת
        }

        //בלחיצה מפעילים את המשחק ,ממשיכים ויוצאים בצורה מסודרת ומציגים את הניקוד
        private void btnStart_Click(object sender, EventArgs e)
        {
            if(counter<4)
            {
                ticks = 0;
                lblWelcome.Visible = false;
                btnStart.Visible = false;
                txtAnswer.Visible = true;
                picGame.Visible = true;
                txtAnswer.Enabled = true;
                btnSubmit.Visible = true;
                txtAnswer.Visible = true;
                timer1.Start();
                answer = Game3();
            }
            if (counter == 2)
            {
                lblTime1.Text = ""; 
            }
            if(counter==3)
            {
                sp.Stop();
                picGame.Visible = false;
                lblTime1.Visible = false;
                txtAnswer.Visible = false;
                btnSubmit.Visible = false;
                MessageBox.Show("you got " + points + " right answers." + "\nyou got " + (3 - points) + " wrong answers.");
                counter = 0;
                timer1.Stop();
                this.Close();
            }
        }

        //בלחיצה המתודה נקבע את התשובה ונוסיף ניקוד על תשובה נכונה ,נציג אם צדק או טעה 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStart.Text = "Next";
            if (answer == txtAnswer.Text)
            {
                MessageBox.Show("your answer is correct");
                points++;
                txtAnswer.Enabled = false;
            }
            if(counter==2)
            {
                btnStart.Text = "Return To Games";
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
            ticks = 0;
            counter++;
            btnSubmit.Visible = false;
            btnStart.Visible = true;
            txtAnswer.Text = "";
        }
        //מתודה שסופרת את הזמן הנותר לצורך הצגה ,אם הזמן תם התשובה תחשב כלא נכונה והמשתמש לא ירוויח נקודה
        private void timer1_Tick(object sender, EventArgs e)
        {
            int timeLeft = timeToFinish - ticks;
            ticks++;
            if (timeLeft <= 5)
            {
                lblTime1.Text = "you have" + timeLeft + "left";
            }
            if (counter < 3 )
            {
                if (timeLeft == 0)
                {
                    ticks = 0;
                    timer1.Stop();
                    counter++;
                
                    btnStart.Text = "Next";
                    if(counter == 3 && timeLeft == 0)
                    {
                        btnStart.Text = "Return To Games";
                    }
                    StreamWriter sw = new StreamWriter(@".\OUTPUT\" + CurrentUser.Username + "_Wrong.txt", true);
                    sw.WriteLine(idx.ToString());
                    sw.Close();
                    btnSubmit.Visible = false;
                    btnStart.Visible = true;
                    txtAnswer.Text = "";
                    txtAnswer.Visible = false;
                    MessageBox.Show("your time has expired, it counts as a wrong answer");
                }
            }
        }
    }
}
        

 





   
 
   

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

    public partial class Form5 : Form
    {
        //  משחק מספר 1 - בחירת התמונה המתאימה למילה , בסיום המשחק נציג לשחקן את מספר התשובות הנכונות והשגויות
        //  במהלך המשחק כל תשובה נכונה תזכה אותו בנקודה


        List<ImageAndVoice> tmp = AllLitters.CreateCurrentWordList();//ליסט של כל המילים בפורנט "תמונה ושמע"
        int x;
        int y;
        int points = 0;
        static int counter = 0; //סופר כמה סיבובים עברו במשחק
        Queue<int> usedWords = new Queue<int>();
        //תור של מילים שהמשתמש קיבל , משמש אותנו כדי שהמשתמש יקבל מילים מגוונות במשחק
        public Form5()
        {
            InitializeComponent();
        }
        //בלחיצה נפעיל את המשחק נתקדם בסיבובים נציג ניקוד סוף ונצא
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnSubmit.Visible = true;
            x = Game1(); // הפעלת המשחק 
            lblWord.Visible = true;

            cmbPic.Visible = true;

            pic1.Visible = true;
            pic2.Visible = true;
            pic3.Visible = true;

            lblChoise1.Visible = true;
            lblChoise2.Visible = true;
            lblChoise3.Visible = true;
            lblWelcome.Visible = false;

            btnStart.Text = "Next";
            counter++;
            if (counter == 3)//סיבוב לפני אחרון להפוך את הכפתור למצב סיום
            {
                btnStart.Text = "Return To Games";
            }
            if (counter == 4)//המשחק נגמר נציג הודעה ניקוד ונצא באופן מסודר
            {
                lblWord.Visible = false;
                cmbPic.Visible = false;
                //btnSubmit.Visible = false;
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
                lblChoise1.Visible = false;
                lblChoise2.Visible = false;
                lblChoise3.Visible = false;
                lblWelcome.Text = "Good Luck, Bye Bye";

                btnStart.Text = "Start";
                counter = 0;

                MessageBox.Show("you got " + points + " right answers" + "\nyou got " + (3 - points) + " wrong answers");
                this.Close();
            }
        }
        //
        public int Game1()
        {
            int correct, correctidx;// משתנים להחזקת ת.ז של המילה הנכונה והאינדקס של התשובה
            int first, second, third;//משתנים להחזקת המילים
            Random rnd1 = new Random();
            int lines = File.ReadLines(@".\OUTPUT\" + CurrentUser.Username + "_Wrong.txt").Count();

            // שחקן יחשב ותיק אם צבר מעל שלוש טעיות ,אם יש לו מעל שלוש טעויות ניתן לו מילה אחת במכוון מהטעויות לתרגול 
            if (counter == 1 && lines > 3)
            {
                StreamReader sr = new StreamReader(@".\OUTPUT\" + CurrentUser.Username + "_Wrong.txt");
                int[] mistakes = new int[lines];//מערך של המילית שבהם טעה 
                for (int i = 0; i < lines; i++)
                {
                    mistakes[i] = int.Parse(sr.ReadLine());
                }

                int tmpidx = rnd1.Next(lines); //הגרלת המילה שבה טעה 
                correct = mistakes[tmpidx];

                Random rand = new Random();
                first = rand.Next(0, tmp.Count);//הגרלת המילה הראשונה
                while (usedWords.Contains(first))//בדיקה אם קיבל את המילה לאחרונה והחלפתה אם כן
                {
                    first = rand.Next(0, tmp.Count);
                }
                usedWords.Enqueue(first);

                second = correct;
                while (usedWords.Contains(correct))//בדיקה אם קיבל את המילה לאחרונה והחלפתה אם כן
                {
                    tmpidx = rnd1.Next(lines);
                    correct = mistakes[tmpidx];
                    second = correct;
                }
                correctidx = 1;
                usedWords.Enqueue(second);
                third = rnd1.Next(0, tmp.Count);//הגרלת מילה 
                while (usedWords.Contains(third))//בדיקה אם הייתה והחלפתה אם כן
                {
                    third = rnd1.Next(0, tmp.Count);
                }
                usedWords.Enqueue(third);
                sr.Close();
            }
            else
            {
                first = rnd1.Next(0, tmp.Count);//הגרלת המילה הראשונה
                while (usedWords.Contains(first))// בדיקה אם הייתה והחלפתה אם כן
                {
                    first = rnd1.Next(0, tmp.Count);
                }
                usedWords.Enqueue(first);
                second = rnd1.Next(0, tmp.Count);//הגרלת המילה הראשונה
                while (usedWords.Contains(second))// בדיקה אם הייתה והחלפתה אם כן
                {
                    second = rnd1.Next(0, tmp.Count);
                }
                usedWords.Enqueue(second);
                third = rnd1.Next(0, tmp.Count);//הגרלת המילה הראשונה
                while (usedWords.Contains(third))// בדיקה אם הייתה והחלפתה אם כן
                {
                    third = rnd1.Next(0, tmp.Count);
                }
                usedWords.Enqueue(third);
                correctidx = rnd1.Next(0, 3);
            }
            int[] arr = { first, second, third };

            correct = arr[correctidx];//קביעת המילה הנכונה
            pic1.Image = Image.FromFile(@".\DIMAGE\" + tmp[first].Image);
            pic2.Image = Image.FromFile(@".\DIMAGE\" + tmp[second].Image);
            pic3.Image = Image.FromFile(@".\DIMAGE\" + tmp[third].Image);

            lblWord.Text = tmp[correct].TheWord;//הצגת המילה
            cmbPic.SelectedIndex = -1;
            y = correct; // השמה של ת.ז של המילה של התשובה הנכונה
            return correctidx;//החזרת האינדקס של התשובה
        }

        //הפעלת המשחק הצגת תשובה נכונה או לא 
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {

            btnStart.Visible = true;
            btnSubmit.Visible = false;
            cmbPic.Visible = false;
            if (cmbPic.SelectedIndex == x)
            {
                points++;
                MessageBox.Show("your answer is correct");
            }
            else
            {
                MessageBox.Show("your answer is not correct");
                StreamWriter sw = new StreamWriter(@".\OUTPUT\" + CurrentUser.Username + "_Wrong.txt", true);
                sw.WriteLine(y.ToString());
                sw.Close();
            }
        }


    }
}
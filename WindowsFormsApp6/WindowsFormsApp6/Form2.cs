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
    public partial class Form2 : Form
    {
        static int i = 0;
        SoundPlayer sp;
        static Letter[] letters = AllLitters.Createletters();
        List<ImageAndVoice> ivl = AllLitters.CreateCurrentWordList();
        int ticks;
        int timeToFinish = 5;

        public Form2()
        {
            InitializeComponent();
            sp = new SoundPlayer();
        }

        //מתודה שבודקת אם כל הנתונים נבחרו ותקינים אם לא תזרק חריגה
        public void IfChecked()
        {
            if (cmbChoice.SelectedIndex == -1 || cmbLetter.SelectedIndex == -1)
            {
                throw new ArgumentException();
                return;
            }
        }

        //המשתמש מתחיל את הלימוד בצורה ידנית או אוטומטית לפי בחירה 
        //באופן ידני מתי שיחליט לעבור
        //באופן אוטומטי מעבר בין תמונות כל חמש שניות
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            try
            {
                IfChecked();
                btnExit.Visible = false;
                if (cmbChoice.Text == "Manually")
                {
                    txtWord.Visible = true;
                    picWord.Visible = true;
                    btnNext.Visible = true;
                    btnStart.Visible = false;
                    txtWord.Text = letters[cmbLetter.SelectedIndex].Words[0].TheWord;
                    picWord.Image = Image.FromFile(letters[cmbLetter.SelectedIndex].Words[0].Image);
                    sp.SoundLocation = letters[cmbLetter.SelectedIndex].Words[0].Voice;
                    sp.Play();
                    cmbLetter.Visible = false;
                    i++;
                }
                else
                {
                    ticks = 0;
                    btnStart.Visible = false;
                    btnNext.Visible = false;
                    txtWord.Visible = true;
                    timer1.Stop();
                    lblTime1.Visible = true;
                    timer1.Start();
                    picWord.Visible = true;
                    txtWord.Text = letters[cmbLetter.SelectedIndex].Words[0].TheWord;
                    picWord.Image = Image.FromFile(letters[cmbLetter.SelectedIndex].Words[0].Image);
                    sp.SoundLocation = letters[cmbLetter.SelectedIndex].Words[0].Voice;
                    sp.Play();
                    cmbLetter.Visible = false;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Not all the information has been choosed, please try again!");
            }

        }
        //בלימוד ידני מעביר בין המילים
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            txtWord.Text = letters[cmbLetter.SelectedIndex].Words[i].TheWord;
            picWord.Image = Image.FromFile(letters[cmbLetter.SelectedIndex].Words[i].Image);
            sp.SoundLocation = letters[cmbLetter.SelectedIndex].Words[i].Voice;
            sp.Play();
            i++;
            hideOptions();
        }

        //מתודה המודיעה על סיום לימוד של אות ומדליקה את הכפתורים הקלוונטים
        private void hideOptions()
        {
            if (i == letters[cmbLetter.SelectedIndex].Words.Count)
            {
                btnNext.Visible = false;
                //txtWord.Visible = false;
                btnStart.Visible = false;
                cmbLetter.Visible = true;
                i = 0;

                MessageBox.Show("we have finished, good job!\nIf you want to enter another learning session please choose the way you want to learn and wich letter then click START.\nIf you want to exit please click Exit");
                cmbChoice.SelectedIndex = -1;
                cmbLetter.SelectedIndex = -1;
                picWord.Visible = false;
                txtWord.Visible = false;
                sp.Stop();
                btnStart.Visible = true;
                btnExit.Visible = true;
                return;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int timeLeft = timeToFinish - ticks;
            ticks++;

            if (i != letters[cmbLetter.SelectedIndex].Words.Count)
            {
                lblTime1.Visible = false;
                if (timeLeft == 0)
                {
                    timer1.Stop();
                    timer1.Start();
                    if (i == letters[cmbLetter.SelectedIndex].Words.Count - 1)
                    {
                        timer1.Stop();
                        i = 0;
                        sp.Stop();
                        timer1.Stop();
                        cmbChoice.SelectedIndex = -1;
                        cmbLetter.SelectedIndex = -1;
                        txtWord.Visible = false;
                        btnNext.Visible = false;
                        picWord.Visible = false;
                        cmbLetter.Visible = true;
                        MessageBox.Show("we have finished, good job!\nIf you want to enter another learning session please choose the way you want to learn and wich letter then click START.\nIf you want to exit please click Exit");
                        btnStart.Visible = true;
                        txtWord.Visible = false;
                        btnExit.Visible = true;
                        lblTime1.Text = "";
                        return;
                    }
                    sp.Stop();
                    i++;
                    ticks = 0;
                    picWord.Image = Image.FromFile(letters[cmbLetter.SelectedIndex].Words[i].Image);
                    sp.SoundLocation = letters[cmbLetter.SelectedIndex].Words[i].Voice;
                    sp.Play();
                }

                if (timeLeft <= 5)
                {
                    lblTime1.Visible = true;
                    lblTime1.Text = "you have" + timeLeft + "left";
                    txtWord.Text = letters[cmbLetter.SelectedIndex].Words[i].TheWord;
                }
                return;
            }
        }

        //מתודה שיוצאת בצורה מסודרת
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}

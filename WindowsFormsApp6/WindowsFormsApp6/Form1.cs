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
    public partial class Form1 : Form
    {
        Letter[] l = AllLitters.Createletters(); //מערך של מילים
        SoundPlayer sp;
        public Form1()
        {
            InitializeComponent();
            sp = new SoundPlayer();
        }
        //בלחיצה נעבור למסך המבחירה ונוסיף משתמש חדש או נברך משתמש קיים על חזרתו
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            try
            {
                //lblWelcome.Visible = false;
                string ex = txtUserName.Text;
                string userName = ex.Split('@')[0];

                CheckMail(txtUserName.Text);
                if (!File.Exists(@".\OUTPUT\" + userName + "_Wrong.txt"))
                {
                    Player p = new Player(userName);
                    CurrentUser.Username = userName;
                    AllUsers.Users.Add(p);
                    MessageBox.Show("hey its your first time! thank you for joining");
                    StreamWriter sw = File.CreateText(@".\OUTPUT\" + userName + "_Wrong.txt");
                    sw.Close();
                }
                else
                {
                    CurrentUser.Username = userName;
                    MessageBox.Show("Welcome Back");
                }

                showOptions();
                lblInfo.Visible = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("The email you enterd is illegal, please try again!");
            }
        }

        //מתודה שבודקת את תקינות המייל אם לא תקין זורקת חריגה
        public void CheckMail(string email)
        {
            string userName = email.Split('@')[0];
            string[] arr2 = email.Split('@');

            if (!email.Contains('@') || email.Contains(' '))
            {
                throw new ArgumentException();
            }
            if (userName.All(char.IsDigit))
            {
                throw new ArgumentException();
            }
            char[] tmp = userName.ToCharArray();

            if (!Char.IsLetter(tmp[0]))
            {
                throw new ArgumentException();
            }

            if (arr2[0].All(char.IsLetter))

                if (arr2[0] == "" || arr2[1] == "")
                {
                    throw new ArgumentException();
                }
            if (!arr2[1].Contains('.'))
            {
                throw new ArgumentException();
            }

            if (arr2[1].Contains('.') || arr2[0].Contains('.'))
            {
                string[] arr3 = arr2[1].Split('.');
                string[] arr4 = arr2[0].Split('.');

                if (!arr3[0].All(Char.IsLetter) || !arr3[1].All(char.IsLetter))
                {
                    throw new ArgumentException();
                }
                if (arr3[0] == "" || arr3[1] == "")
                {
                    throw new ArgumentException();
                }
            }
        }

        //מתודה שמפעילה את המקשים של מסף ההמשך
        public void showOptions()
        {
            lblUserName.Visible = false;
            txtUserName.Visible = false;
            btnSubmit.Visible = false;
            btnData.Visible = true;
            btnGames.Visible = true;
            btnLearning.Visible = true;
            lbliNstructions.Visible = true;
            btnExit.Visible = true;
        }

        //פותחת את אפליקציית הלמידה
        private void btnLearning_Click_1(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        //פותחת את מסך העלאת הקבצים
        private void btnData_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            //AllLitters.WriteCurrentWordsArr(l);
        }

        //פותחת את מסך המשחקים
        private void btnGames_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists(@".\OUTPUT\" + CurrentUser.Username + "_Wrong.txt"))
            {
                StreamWriter rw = File.CreateText(@".\OUTPUT\" + CurrentUser.Username + "_Wrong.txt");
                rw.Close();
            }

            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        //מבצעת יציאה מסודרת ומוחקת את קבצי המשתמש אם בוחר בכך
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            string message = "Do you want to delete your game history?";
            string title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                File.Delete(@".\OUTPUT\" + CurrentUser.Username + "_Wrong.txt");
                MessageBox.Show("Your history was deleted");
            }
            MessageBox.Show("Thak you, bye bye");
            this.Close();
        }

      
    }
}
    
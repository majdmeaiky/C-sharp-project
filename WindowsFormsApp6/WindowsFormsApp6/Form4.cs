using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{ //מסך בחירת משחקים
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //בלחיצה מעבר למשחק 1
        private void button1_Click_1(object sender, EventArgs e)
        {
            //button1.Visible = false;
            //button2.Visible = false;
            //button3.Visible = false;
            //button4.Visible = false;
            MessageBox.Show("                                   You have 3 levels.\nFor every level you have to choose the correct image that matches the word.");

           Form5 f5  = new Form5();
            f5.ShowDialog();
        }

        //בלחיצה מעבר למשחק 2
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                                  You have 3 levels.\nFor every level you have to write the word that matches the image.");
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        //בלחיצה מעבר למשחק 3
        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("                                   You have 3 levels.\nFor every level you have to write the word that matches the image and the sound you heard.");

            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        //בלחיצה מעבר למשחק 4
        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("                                   You have 3 levels.\nFor every level you have to choose the word that matches the sound you heard.");

            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        //בלחיצה יציאה מסודרת
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
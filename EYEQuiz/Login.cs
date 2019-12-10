using System;
using System.Drawing;
using System.Windows.Forms;

namespace EYEQuiz
{
    public partial class frmMain : Form
    {
        QuizMenu Quizmenu = new QuizMenu();


        public frmMain()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            timer_SlideMenu_1.Start();
            Quizmenu.ShowDialog();
        }



        private void label_X_Click(object sender, EventArgs e)
        {
            Timer_For_Exit.Start();

        }

        private void label_X_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.FromArgb(238, 66, 102);
        }

        private void label_X_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Teal;
        }

        private void Timer_For_Exit_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.2;
            }
            else
            {
                Timer_For_Exit.Stop();
                Application.Exit();
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            Quizmenu.Left += 35;
            if (Quizmenu.Left >= this.Right)
            {
                timer_SlideMenu_1.Stop();
                this.TopMost = false;
                timer_SlideMenu_2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Quizmenu.Left -= 35;
            if (Quizmenu.Left <= Left)
            {
                timer_SlideMenu_2.Stop();
                this.Visible = false;

            }
        }


        private void textBox_UserName_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).ForeColor = Color.Black;
            panel_Username.BackColor = Color.FromArgb(238, 66, 102);
            pictureBox_username.Image = Properties.Resources.icons_username_black;

            if ((sender as TextBox).Text == "Full Name")
                (sender as TextBox).Text = "";
        }


        private void textBox_UserName_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).ForeColor = Color.Gray;
            panel_Username.BackColor = Color.Teal;
            pictureBox_username.Image = Properties.Resources.icon_username_gray;


            if ((sender as TextBox).Text == "")
                (sender as TextBox).Text = "Full Name";
        }


        private void textBox_Password_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).ForeColor = Color.Black;
            panel_Pass1.BackColor = Color.FromArgb(238,66,102);
            pictureBox_pass.Image = Properties.Resources.icons_password_black;


            if ((sender as TextBox).Text == "Password")
                (sender as TextBox).Text = "";
        }


        private void textBox_Passwword_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).ForeColor = Color.Gray;
            panel_Pass1.BackColor = Color.Teal;
            pictureBox_pass.Image = Properties.Resources.icon_password_gray;


            if ((sender as TextBox).Text == "")
                (sender as TextBox).Text = "Password";
        }

        private void lbl_QuizApplication_MouseEnter(object sender, EventArgs e)
        {
            lbl_QuizApplication.ForeColor= Color.FromArgb(238, 66, 102);

        }

        private void lbl_QuizApplication_MouseLeave(object sender, EventArgs e)
        {
            lbl_QuizApplication.ForeColor = Color.White;
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            lbl_login.Focus();
        }

        private void pictureBox_Login_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Login.Image = Properties.Resources.icon_Login_Red;
        }

        private void pictureBox_Login_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Login.Image = Properties.Resources.icon_Login_Teal;
        }
    }
}
using StartQuizNameSpace;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace EYEQuiz
{
    public partial class QuizMenu : Form
    {
        public QuizMenu()
        {
            InitializeComponent();
        }

        private void button_CreateQuiz_Click(object sender, EventArgs e)
        {
            CreateQuiz createQuiz = new CreateQuiz(this);
            Visible = false;
            createQuiz.ShowDialog();
        }

        private void QuizMenu_Load(object sender, EventArgs e)
        {
            // for gradient panel
            Panel_Bottom_View.BackgroundImageLayout = ImageLayout.None;
            //



            string folderName = $@"C:\Users\{Environment.UserName}\Documents\Quiz App";
            System.IO.Directory.CreateDirectory(folderName);



            string DirName =$@"C:\Users\{Environment.UserName}\Documents\Quiz App";
            string[] files = System.IO.Directory.GetFiles(DirName, "*.xml");

            foreach (string s in files)
            {
                System.IO.FileInfo fi = null;
                try
                {
                    fi = new System.IO.FileInfo(s);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue;
                }

                Button btn = new Button
                {
                    Size = new Size(50, 100),
                    Dock = DockStyle.Left,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Ink Free", 10f, FontStyle.Bold | FontStyle.Italic),
                    Text = "Q\nu\ne\ns\nt\ni\no\nn\ns",
                    Cursor = Cursors.Hand,
                    Tag = fi.Name

                };
                toolTip.SetToolTip(btn, fi.Name.Remove(fi.Name.Length - 4));
                btn.Click += Btn_Click;


                Random rand = new Random();

                int red = 0;
                int green = 0;
                int blue = 0;

                red = rand.Next(30, 230);
                Thread.Sleep(7);
                green = rand.Next(30, 230);
                Thread.Sleep(7);
                blue = rand.Next(30, 230);

                btn.BackColor = Color.FromArgb(red,  green, blue);
                btn.ForeColor = Color.FromArgb(51, 51, 51);




                panel_Main.Controls.Add(btn);
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
            StartQuiz startQuiz = new StartQuiz($@"C:\Users\{Environment.UserName}\Documents\Quiz App\{(sender as Button).Tag?.ToString()}");
            Visible = false;
            startQuiz.Show();

        }

        private void label_X_Click(object sender, EventArgs e)
        {
            Timer_For_Exit.Start();
        }

        private void label_X_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Black;
        }

        private void label_X_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.White;
        }

        private void txt_Search_MouseLeave(object sender, EventArgs e)
        {
            panel_Top.Select();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string temp = "";
            string senderText = (sender as TextBox).Text.ToLower();

            foreach (var item in panel_Main.Controls)
            {
                if (item is Button btn)
                {
                    btn.Visible = true;
                    temp = btn.Tag?.ToString().ToLower();
                    if (!temp.Contains(senderText))
                        btn.Visible = false;
                }
            }
        }

        private void button_CreateQuiz_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.icon_Black_Add;
        }

        private void button_CreateQuiz_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.icon_AddNewQuiz_Teal;
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

        private void Timer_For_Label_Tick(object sender, EventArgs e)
        {
            if (lbl_2019.Visible == true)
            {
                if (lbl_2019.Location.X < lbl_2019.Parent.Width)
                {
                    lbl_2019.Location = new Point(lbl_2019.Location.X + 2, lbl_2019.Location.Y);
                    if (lbl_2019.Location.X + lbl_2019.Width > lbl_2019.Parent.Width)
                    {
                        lbl_By_Me.Visible = true;
                        lbl_By_Me.Location = new Point(0 - lbl_By_Me.Width, lbl_By_Me.Location.Y);
                    }
                }
                else
                {
                    lbl_2019.Visible = false;
                }
            }

            if (lbl_By_Me.Visible == true)
            {
                if (lbl_By_Me.Location.X < lbl_By_Me.Parent.Width)
                {
                    lbl_By_Me.Location = new Point(lbl_By_Me.Location.X + 2, lbl_By_Me.Location.Y);
                    if (lbl_By_Me.Location.X + lbl_By_Me.Width > lbl_By_Me.Parent.Width)
                    {
                        lbl_2019.Visible = true;
                        lbl_2019.Location = new Point(0 - lbl_2019.Width, lbl_2019.Location.Y);
                    }
                }
                else
                {
                    lbl_By_Me.Visible = false;
                    lbl_2019.Location = new Point(0 - lbl_2019.Width, lbl_2019.Location.Y);
                }
            }
        }



        int r = 0, g = 128, b = 129;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (b <= 76)
            {
                r += 1;
                Timers_Tick();

                if (r >= 200)
                {
                    timer1.Stop();
                    timer2.Start();
                }
            }

            if (b >= 222)
            {
                r -= 1;
                Timers_Tick();

                if (r <= 76)
                {
                    timer1.Stop();
                    timer2.Start();
                }
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (r <= 76)
            {
                g += 1;
                Timers_Tick();

                if (g >= 222)
                {
                    timer2.Stop();
                    timer3.Start();
                }
            }

            if (r >= 200)
            {
                g -= 1;
                Timers_Tick();

                if (g <= 76)
                {
                    timer2.Stop();
                    timer3.Start();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (g <= 76)
            {
                b += 1;
                Timers_Tick();


                if (b >= 222)
                {
                    timer3.Stop();
                    timer1.Start();
                }
            }

            if (g >= 222)
            {
                b -= 1;
                Timers_Tick();

                if (b <= 76)
                {
                    timer3.Stop();
                    timer1.Start();
                }
            }
        }



        private void Timers_Tick()
        {
            Panel_Bottom_View.GradientBottomRight = Color.FromArgb(r, g, b);
            Panel_Bottom_View.GradientTopLeft = Color.FromArgb(r, g, b);
        }
    }
}

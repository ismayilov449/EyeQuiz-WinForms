using StartQuizNameSpace;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace EYEQuiz
{
    public partial class CreateQuiz : Form
    {
        Form forBackMenu = null;

        public List<QuestionBlock> QuestionsDragDrop = null;

        int QuestionCount = 1;

        bool isCorrect = false;



        public CreateQuiz(Form form)
        {
            InitializeComponent();
            forBackMenu = form;
        }

        private void button_AddQuestion_Click(object sender, EventArgs e)
        {

            Panel panel = new Panel
            {
                Size = new Size(550, 190),
                BackColor = Color.FromArgb(232, 242, 244),
                Tag = QuestionCount,
                Dock = DockStyle.Top
            };

            Panel panelForView = new Panel
            {
                Size = new Size(550, 5),
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(232, 242, 244),
                Tag = "View",
                BackgroundImageLayout = ImageLayout.None
            };

            Panel panelOption = new Panel
            {
                Location = new Point(40, 80),
                Size = new Size(550, 28),
            };


            Label LabelQuestionCount = new Label
            {
                Location = new Point(10, 40),
                AutoSize = true,
                Font = new Font("Palatino Linotype", 12f, FontStyle.Regular),
                Text = $"{QuestionCount.ToString()}.",
                Tag = "ID"

            };
            toolTip.SetToolTip(LabelQuestionCount, "Question Number");

            TextBox TextBoxQuestion = new TextBox
            {
                Location = new Point(40, 40),
                Size = new Size(550, 25),
                Multiline = true,
                Font = new Font("Palatino Linotype", 10f, FontStyle.Regular),
                Tag = "Question",
                Text = "Question"
            };


            TextBox TextBoxAnswer = new TextBox
            {
                Location = new Point(25, 1),
                Size = new Size(300, 25),
                Multiline = true,
                Font = new Font("Palatino Linotype", 10f, FontStyle.Regular),
                Text = " Option 1",
                Tag = "No"
            };



            RadioButton RadioButtonAnswer = new RadioButton
            {
                Location = new Point(0, 5),
                Text = "",
                AutoSize = true,
                Enabled = false

            };






            Label Delete = new Label
            {
                Location = new Point(335, 4),
                Size = new Size(17, 17),
                Image = Properties.Resources.icon_Delete,
                Cursor = Cursors.Hand,
                Visible = false,
                Tag = "Delete",
            };
            toolTip.SetToolTip(Delete, "Delete");


            Label CorrectAnswer = new Label
            {
                Location = new Point(355, 4),
                Size = new Size(17, 17),
                Image = Properties.Resources.icon_CorrectAnswer,
                Cursor = Cursors.Hand,
                Visible = false,
                Tag = "Correct"
            };
            toolTip.SetToolTip(CorrectAnswer, "Correct Answer");

            Label DeleteQuestion = new Label
            {
                Location = new Point(578, 9),
                Size = new Size(17, 17),
                Image = Properties.Resources.icon_Delete,
                Cursor = Cursors.Hand,
                Tag = QuestionCount
            };
            toolTip.SetToolTip(DeleteQuestion, "Delete Question");



            Button ButtonAddOption = new Button
            {
                Location = new Point(40, 115),
                Size = new Size(120, 32),
                Font = new Font("Palatino Linotype", 10f, FontStyle.Regular),
                BackColor = Color.Teal,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Text = "Add Option",
                TextAlign = ContentAlignment.MiddleRight,
                Image = Properties.Resources.icon_AddOption,
                ImageAlign = ContentAlignment.MiddleLeft,
                Cursor = Cursors.Hand
            };
            //toolTip.SetToolTip(ButtonAddOption, "Add Option");

            //Add control
            Panel_Main.Controls.Add(panel);


            panelOption.Controls.Add(RadioButtonAnswer);
            panelOption.Controls.Add(TextBoxAnswer);
            panelOption.Controls.Add(Delete);
            panelOption.Controls.Add(CorrectAnswer);

            panel.Controls.Add(LabelQuestionCount);
            panel.Controls.Add(TextBoxQuestion);
            panel.Controls.Add(panelOption);
            panel.Controls.Add(ButtonAddOption);
            panel.Controls.Add(panelForView);
            panel.Controls.Add(DeleteQuestion);


            //Events
            TextBoxQuestion.TextChanged += TextBox_TextChanged;
            ButtonAddOption.Click += ButtonAddOption_Click;
            panel.MouseEnter += Panel_MouseEnter;
            panel.MouseLeave += Panel_MouseLeave;
            CorrectAnswer.Click += Correct_Click;
            Delete.Click += Delete_Click;
            DeleteQuestion.Click += DeleteQuestion_Click;

            // Delete ve Correct secimleri ucun
            panelOption.MouseEnter += PanelOption_MouseEnter;
            TextBoxAnswer.MouseEnter += TextBoxAnswer_MouseEnter;
            TextBoxAnswer.MouseLeave += TextBoxAnswer_MouseLeave;

            QuestionCount++;

            panel.Select();
        }

        private void DeleteQuestion_Click(object sender, EventArgs e)
        {
            Label LabelDelQuestion = sender as Label;
            int IdDelQuestion = int.Parse(LabelDelQuestion.Tag?.ToString());
            int TempID = 0;

            foreach (var mainPanel in LabelDelQuestion.Parent.Parent.Controls)
            {
                if (mainPanel is Panel panelQuestionBlock)
                    foreach (var LabelNumber in panelQuestionBlock.Controls)
                    {
                        if (LabelNumber is Label label)
                            if (label.Tag?.ToString() == "ID")
                            {
                                TempID = (int)(double.Parse(label.Text));
                                if (TempID > IdDelQuestion)
                                {
                                    label.Text = (TempID - 1).ToString();
                                }
                            }

                    }
            }


            QuestionCount--;
            LabelDelQuestion.Parent.Dispose();
        }

        private void TextBoxAnswer_MouseLeave(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;

            //bu delete ve correcte gore
            foreach (var any in textbox.Parent.Controls)
                if (any is Label l)
                    l.Visible = false;

        }

        private void TextBoxAnswer_MouseEnter(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;

            //bu delete ve correcte gore
            foreach (var any in textbox.Parent.Controls)
                if (any is Label l)
                    l.Visible = true;
        }

        private void PanelOption_MouseLeave(object sender, EventArgs e)
        {
            foreach (var any in (sender as Panel).Controls)
            {
                if (any is Label l)
                    l.Visible = false;
            }
        }


        private void PanelOption_MouseEnter(object sender, EventArgs e)
        {
            foreach (var label in (sender as Panel).Controls)
                if (label is Label l)
                    l.Visible = true;
        }










        private void Correct_Click(object sender, EventArgs e)
        {

            Label CorrectAnswer = (sender as Label);

            foreach (var any in CorrectAnswer.Parent.Parent.Controls)
            {
                if (any is Panel p)
                {
                    foreach (var item in p.Controls)
                    {
                        if (item is TextBox tb)
                            if (tb.Tag?.ToString() == "Yes")
                                isCorrect = true;
                    }
                }

            }

            if (isCorrect == false)
            {
                foreach (var any in CorrectAnswer.Parent.Controls)
                {
                    if (any is TextBox tb)
                        tb.Tag = "Yes";
                }

                CorrectAnswer.ImageAlign = ContentAlignment.MiddleLeft;
                CorrectAnswer.TextAlign = ContentAlignment.MiddleLeft;
                CorrectAnswer.Font = new Font("Palatino Linotype", 9f, FontStyle.Regular);
                CorrectAnswer.ForeColor = Color.Teal;
                CorrectAnswer.Size = new Size(130, 17);
                CorrectAnswer.Text = "       Correct answer";
            }
            else
            {
                foreach (var any in CorrectAnswer.Parent.Controls)
                {
                    if (any is TextBox tb)
                        tb.Tag = "No";
                }

                CorrectAnswer.ImageAlign = ContentAlignment.MiddleCenter;
                CorrectAnswer.Size = new Size(17, 17);
                CorrectAnswer.Text = "";
            }

            isCorrect = false;
        }







        private void Delete_Click(object sender, EventArgs e)
        {
            var Delete = sender as Label;

            //Optionu silenden sora nomreleri sort etmek ucun
            Button forSortTemp = new Button();

            //Optionu silenden sora locationlari sort elemek ucun
            foreach (var any in Delete.Parent.Parent.Controls)
            {

                if (any is Panel panel)
                    if (panel.Location.Y > Delete.Parent.Location.Y)
                        panel.Location = new Point(panel.Location.X, panel.Location.Y - 35);


                if (any is Button btn)
                {
                    btn.Location = new Point(btn.Location.X, btn.Location.Y - 35);
                    forSortTemp = btn;
                }
            }


            Delete.Parent.Parent.Height -= 35;
            Delete.Parent.Parent.Parent.Height -= 35;
            Delete.Parent.Dispose();


            SortOptionNumber(forSortTemp);
        }




        private void ButtonAddOption_Click(object sender, EventArgs e)
        {


            Button button = (sender as Button);
            int newLocation_Y = button.Location.Y;

            Panel panelOption = new Panel
            {
                Location = new Point(40, newLocation_Y),
                Size = new Size(550, 28),
            };


            TextBox TextBoxAnswer = new TextBox
            {
                Location = new Point(25, 1),
                Size = new Size(300, 25),
                Multiline = true,
                Font = new Font("Palatino Linotype", 10f, FontStyle.Regular),
                Text = " Option ",
                Tag = "No"
            };


            RadioButton RadioButtonAnswer = new RadioButton
            {
                Location = new Point(0, 5),
                Text = "",
                AutoSize = true,
                Enabled = false
            };


            Label Delete = new Label
            {
                Location = new Point(335, 4),
                Size = new Size(17, 17),
                Image = Properties.Resources.icon_Delete,
                Cursor = Cursors.Hand,
                Visible = false,
                Tag = "Delete",
            };
            toolTip.SetToolTip(Delete, "Delete");


            Label CorrectAnswer = new Label
            {
                Location = new Point(355, 4),
                Size = new Size(17, 17),
                Image = Properties.Resources.icon_CorrectAnswer,
                Cursor = Cursors.Hand,
                Visible = false,
                Tag = "Correct"
            };
            toolTip.SetToolTip(CorrectAnswer, "Correct Answer");



            panelOption.Controls.Add(RadioButtonAnswer);
            panelOption.Controls.Add(TextBoxAnswer);
            panelOption.Controls.Add(Delete);
            panelOption.Controls.Add(CorrectAnswer);
            button.Parent.Controls.Add(panelOption);

            button.Parent.Height += 35;
            //button.Parent.Parent.Height += 35;

            button.Location = new Point(button.Location.X, button.Location.Y + 35);

            panelOption.MouseEnter += PanelOption_MouseEnter;
            TextBoxAnswer.MouseEnter += TextBoxAnswer_MouseEnter;
            TextBoxAnswer.MouseLeave += TextBoxAnswer_MouseLeave;
            Delete.MouseClick += Delete_Click;
            CorrectAnswer.MouseClick += Correct_Click;


            SortOptionNumber(button);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            int TempHeight = (sender as TextBox).Height;

            // Textboxsun olcusunu nizamlayir
            int textLength = ((TextBox)(sender)).Text.Length;
            int textLines = ((TextBox)(sender)).GetLineFromCharIndex(textLength) + 1;
            int Margin = ((TextBox)(sender)).Bounds.Height - ((TextBox)(sender)).ClientSize.Height;
            ((TextBox)(sender)).Height = (TextRenderer.MeasureText(" ", ((TextBox)(sender)).Font).Height * textLines) + Margin + 2;
            //


            if ((sender as TextBox).Height > TempHeight)
            {

                int new_Location_Y = (sender as TextBox).Height - TempHeight;

                foreach (var Any in (sender as TextBox).Parent.Controls)
                {

                    if (Any is Panel panel)
                        panel.Location = new Point(panel.Location.X, panel.Location.Y + new_Location_Y);


                    if (Any is Button btn)
                        btn.Location = new Point(btn.Location.X, btn.Location.Y + new_Location_Y);

                }

                (sender as TextBox).Parent.Height += new_Location_Y;
                //(sender as TextBox).Parent.Parent.Height += new_Location_Y;


                foreach (var panels in Panel_Main.Controls)
                {
                    if (panels is Panel p)
                        if (int.Parse(p.Tag?.ToString()) > int.Parse((sender as TextBox).Parent.Tag?.ToString()))
                            p.Location = new Point(p.Location.X, p.Location.Y + new_Location_Y);
                }

            }



            if ((sender as TextBox).Height < TempHeight)
            {

                int new_Location_Y = TempHeight - (sender as TextBox).Height;

                foreach (var Any in (sender as TextBox).Parent.Controls)
                {

                    if (Any is Panel p)
                        p.Location = new Point(p.Location.X, p.Location.Y - new_Location_Y);


                    if (Any is Button btn)
                        btn.Location = new Point(btn.Location.X, btn.Location.Y - new_Location_Y);

                }

                (sender as TextBox).Parent.Height -= new_Location_Y;
                (sender as TextBox).Parent.Parent.Height -= new_Location_Y;


                foreach (var panels in Panel_Main.Controls)
                {
                    if (panels is Panel p)
                        if (int.Parse(p.Tag?.ToString()) > int.Parse((sender as TextBox).Parent.Tag?.ToString()))
                            p.Location = new Point(p.Location.X, p.Location.Y - new_Location_Y);
                }


            }


        }




        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            Panel PanelQuestionBlock = sender as Panel;


            foreach (var AllPanels in PanelQuestionBlock.Parent.Controls)
            {
                if (AllPanels is Panel p)
                {
                    p.BackColor = Color.White;

                    foreach (var panel in p.Controls)
                    {
                        if (panel is Panel view)
                            if (view.Tag?.ToString() == "View")
                                view.BackColor = Color.White;
                    }
                }

            }


            PanelQuestionBlock.BackColor = Color.FromArgb(232, 242, 244);
            foreach (var any in PanelQuestionBlock.Controls)
            {
                if (any is Panel p)
                {
                    if (p.Tag?.ToString() == "View")
                        p.BackColor = Color.Teal;
                }
            }
        }


        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            foreach (var panel in (sender as Panel).Controls)
            {
                if (panel is Panel p)
                {
                    foreach (var any in p.Controls)
                    {
                        if (any is Label l)
                        {
                            if (l.Tag?.ToString() == "Delete" || l.Tag?.ToString() == "Correct")
                                l.Visible = false;
                        }

                    }
                }
            }
        }



        private void SortOptionNumber(Button button)
        {


            List<TextBox> Number = new List<TextBox>();

            foreach (var any in button.Parent.Controls)
            {
                if (any is Panel p)
                {
                    foreach (var item in p.Controls)
                    {
                        if (item is TextBox t)
                        {
                            if (t.Tag?.ToString() == "No" || t.Tag?.ToString() == "Yes")
                                Number.Add(t);
                        }
                    }
                }
            }


            foreach (var any in button.Parent.Controls)
            {
                if (any is Panel p)
                {
                    foreach (var item in p.Controls)
                    {
                        if (item is TextBox t)
                        {
                            if (t.Tag?.ToString() == "No" || t.Tag?.ToString() == "Yes")
                            {
                                for (int i = 0; i < Number.Count; i++)
                                {
                                    int temp = 1;
                                    for (int j = 0; j < Number.Count; j++)
                                    {
                                        if (Number[i].Parent.Location.Y > Number[j].Parent.Location.Y)
                                            temp++;
                                    }
                                    if (Number[i].Text.StartsWith(" Option ") && Number[i].Text.Length <= 9)
                                    {
                                        Number[i].Text = $" Option {temp}";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }












        private void button_Save_Click(object sender, EventArgs e)
        {
           

            List<QuestionBlock> Questions = new List<QuestionBlock>();
            QuestionBlock questionsXML;



            foreach (var panel in Panel_Main.Controls)
            {
                int tempAnswerID = 0;


                questionsXML = new QuestionBlock
                {
                    Answers = new List<Answer>()
                };



                if (panel is Panel p)
                {
                    foreach (var any in p.Controls)
                    {



                        if (any is TextBox t)
                        {
                            if (t.Tag?.ToString() == "Question")
                                questionsXML.Text = t.Text;
                        }


                        if (any is Label l)
                            if (l.Tag?.ToString() == "ID")
                                questionsXML.id = (int)(double.Parse(l.Text)) - 1;





                        if (any is Panel panelAnswers)
                        {

                            foreach (var answers in panelAnswers.Controls)
                            {
                                if (answers is TextBox tbAnswer)
                                {
                                    if (tbAnswer.Tag?.ToString() == "No" || tbAnswer.Tag?.ToString() == "Yes")
                                    {
                                        questionsXML.Answers.Add(new Answer { Text = tbAnswer.Text, id = tempAnswerID++, IsCorrect = tbAnswer.Tag?.ToString() });
                                    }
                                }
                            }

                        }

                    }
                    Questions.Add(questionsXML);
                }
            }

            if (textBox_QuizName.Text == "")
                textBox_QuizName.Text = DateTime.Now.ToShortDateString();

            var xml = new XmlSerializer(typeof(List<QuestionBlock>));
            using (var fs = new FileStream($@"C:\Users\{Environment.UserName}\Documents\Quiz App\{textBox_QuizName.Text}.xml", FileMode.Create))
            {
                xml.Serialize(fs, Questions);
                textBox_QuizName.Text = "";
                this.Select();
                MessageBox.Show("Ready!");
            }
        }

        private void Panel_Main_DragDrop(object sender, DragEventArgs e)
        {

            QuestionsDragDrop = null;
            QuestionCount = 1;
            isCorrect = false;

            List<Panel> forDeletePanels = new List<Panel>();

            foreach (var item in Panel_Main.Controls)
            {
                if (item is Panel p)
                {
                    forDeletePanels.Add(p);
                }
            }

            for (int i = 0; i < forDeletePanels.Count; i++)
            {
                forDeletePanels[i].Dispose();
            }










            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in droppedFiles)
            {
                string filename = getFilelName(file);
                MessageBox.Show("You dropped " + filename);
            }


            XmlSerializer ser = new XmlSerializer(typeof(List<QuestionBlock>));

            using (XmlReader reader = XmlReader.Create(droppedFiles[0]))
            {
                QuestionsDragDrop = (List<QuestionBlock>)ser.Deserialize(reader);
            }


            for (int i = 0; i < QuestionsDragDrop.Count; i++)
            {
                button_AddQuestion_Click(null, null);

            }


            int index = 0;
            int indexAnswers = 0;


            foreach (var any in Panel_Main.Controls)
            {



                if (any is Panel panel)
                {

                    foreach (var item in panel.Controls)
                    {

                        if (item is TextBox txt)
                        {
                            if (txt.Tag?.ToString() == "Question")
                            {
                                txt.Text = QuestionsDragDrop[index].Text;
                            }
                        }


                        if (item is Button button)
                        {
                            //countdan -1 ona gore cixiramki,Add question edende ozu avtomatik 1 Option yaradir.
                            for (int i = 0; i < QuestionsDragDrop[index].Answers.Count - 1; i++)
                            {
                                button.PerformClick();

                            }
                            index++;
                        }


                    }
                }


            }



            // bunu ona gore ayri yaziramki yuxarda Optionlar elave olunur, burda ise olarin texti.
            index = 0;
            foreach (var any in Panel_Main.Controls)
            {
                if (any is Panel panel)
                {
                    foreach (var item in panel.Controls)
                    {
                        if (item is Panel PanelAnswers)
                        {
                            foreach (var answer in PanelAnswers.Controls)
                            {


                                if (answer is TextBox t)
                                {
                                    t.Text = QuestionsDragDrop[index].Answers[indexAnswers].Text;

                                    if (QuestionsDragDrop[index].Answers[indexAnswers].IsCorrect == "Yes")
                                    {
                                        foreach (var lblCorrect in PanelAnswers.Controls)
                                        {
                                            if (lblCorrect is Label lbl)
                                            {
                                                if (lbl.Tag?.ToString() == "Correct")
                                                {
                                                    Correct_Click(lbl, e);
                                                }
                                            }
                                        }
                                    }
                                    indexAnswers++;
                                }

                            }

                        }
                    }


                    indexAnswers = 0;
                    index++;
                }
            }


        }


        private string getFilelName(string path)
        {
            return System.IO.Path.GetFileNameWithoutExtension(path);
        }

        private void Panel_Main_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }




        private void label_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateQuiz_Load(object sender, EventArgs e)
        {
            panel_Settings.BackgroundImageLayout = ImageLayout.None;
            button_AddQuestion_Click(null, null);
            textBox_QuizName.Visible = true;
            panel_Top.Height = 55;

        }

        private void button_AddQuiz_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.icon_Black_Add;


        }

        private void button_AddQuiz_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.icon_AddNewQuiz_Teal;

        }

        private void label_Exit_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Black;
        }

        private void label_Exit_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.White;
        }

        private void Timer_For_Arrow_Tick(object sender, EventArgs e)
        {
            if (panel_Top.Height > 22 && toolTip.GetToolTip(btn_Arrow) == "Up")
            {
                panel_Top.Height--;

                btn_Arrow.Location = new Point(336, -2);

                if (panel_Top.Height == 22)
                {
                    Timer_For_Arrow.Stop();
                    toolTip.SetToolTip(btn_Arrow, "Down");


                    btn_Arrow.Image = Properties.Resources.icon_Down_Teal;
                }
            }
            else
            {
                panel_Top.Height++;


                if (panel_Top.Height == 55)
                {
                    Timer_For_Arrow.Stop();
                    toolTip.SetToolTip(btn_Arrow, "Up");

                    btn_Arrow.Location = new Point(336, 32);
                    btn_Arrow.Image = Properties.Resources.icon_Up_Teal;


                }
            }
        }

        private void button_UpDown_Click(object sender, EventArgs e)
        {
            Timer_For_Arrow.Start();


            
        }

        private void pictureBoxs_MouseEnter(object sender, EventArgs e)
        {
            var picture = sender as PictureBox;

            if (picture.Tag?.ToString() == "Back")
                picture.Image = Properties.Resources.icons_Back_Black;

            if (picture.Tag?.ToString() == "Save")
                picture.Image = Properties.Resources.icon_Xml_Save_Black;

            if (picture.Tag?.ToString() == "Arrow")
            {
                if (panel_Top.Height == 55)
                    picture.Image = Properties.Resources.icon_Up_Black;
                else
                    picture.Image = Properties.Resources.icon_Down_Black;
            }

        }

        private void pictureBoxs_MouseLeave(object sender, EventArgs e)
        {
            var picture = sender as PictureBox;

            if (picture.Tag?.ToString() == "Back")
                picture.Image = Properties.Resources.icons_Back_Teal;

            if (picture.Tag?.ToString() == "Save")
                picture.Image = Properties.Resources.icon_Xml_Save_Teal;

            if (picture.Tag?.ToString() == "Arrow")
            {
                if (panel_Top.Height == 55)
                    picture.Image = Properties.Resources.icon_Up_Teal;
                else
                    picture.Image = Properties.Resources.icon_Down_Teal;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            forBackMenu.Visible = true;
            Visible = false;
            

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

        
    }


    
}
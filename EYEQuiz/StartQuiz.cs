using MetroFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace StartQuizNameSpace
{
    public partial class StartQuiz : Form
    {
        public Report report = new Report();
        Random random = new Random();
        public List<QuestionBlock> Questions = null;
        public List<Control> delete = new List<Control>();
        public List<int> BackAndNext = new List<int>();
        public int index = 0;

        public List<int[]> RandLocationRbtn;
        public List<int> ForNoAnswers;
        public int location = 10;
        public FormReport ForSubmit;


        public StartQuiz(string path)
        {
            InitializeComponent();

            XmlSerializer ser = new XmlSerializer(typeof(List<QuestionBlock>));

            using (XmlReader reader = XmlReader.Create(path))
            {
                Questions = (List<QuestionBlock>)ser.Deserialize(reader);
            }
            

            for (int i = 0; i < Questions.Count; i++)
            {
                BackAndNext.Add(i);
            }

            label_Info.Text = $"{Questions.Count - BackAndNext.Count}/{Questions.Count}";

            

            RandLocationRbtn = new List<int[]>();
            ForNoAnswers = new List<int>();


            for (int a = 0; a < Questions.Count; a++)
            {
                int Size = Questions[a].Answers.Count;
                int[] temp = new int[Size];

                for (int b = 0; b < Size; b++)
                {
                    temp[b] = random.Next(0, Size);

                    for (int c = 0; c < b; c++)
                    {
                        if (temp[b] == temp[c])
                        {
                            b--;
                            break;
                        }
                    }
                }
                RandLocationRbtn.Add(temp);
            }

            
            for (int i = 0; i < Questions.Count; i++)
            {
                report.YourAnswers[i] = $"";
            }
            
            report.RandLocationRbtn = RandLocationRbtn;


            Foo();
            
        }

        private void Foo()
        {

            if (index == BackAndNext.Count - 1)
                button_Next.Enabled = false;
            else
                button_Next.Enabled = true;

            if (index == 0)
                button_Back.Enabled = false;
            else
                button_Back.Enabled = true;


            label_Question_Number.Text = $"{ Questions[BackAndNext[index]].id + 1}.";
            textBox_Question.Text = Questions[BackAndNext[index]].Text;
            location = textBox_Question.Location.Y + textBox_Question.Height + 10;



            int[] tempArray = RandLocationRbtn[Questions[BackAndNext[index]].id];
            
            int tempForRandom = 0;
            for (int i = 0; i < Questions[BackAndNext[index]].Answers.Count; i++)
            {
                tempForRandom = tempArray[i];

                RadioButton radioButton = new RadioButton
                {
                    Location = new Point(60, location),
                    Size = new Size(590, 25),
                    BackColor = Color.White,
                    ForeColor = Color.Teal,
                    Font = new Font("Palatino Linotype", 11f, FontStyle.Bold | FontStyle.Italic),
                    Tag = Questions[BackAndNext[index]].Answers[tempForRandom].IsCorrect,
                    Cursor = Cursors.Hand,
                    TextAlign= ContentAlignment.MiddleCenter,
                };

                radioButton.TextChanged += textBox_Question_TextChanged;
                radioButton.Text = Questions[BackAndNext[index]].Answers[tempForRandom].Text;

                Label label = new Label
                {
                    Location = new Point(49, radioButton.Location.Y),
                    Size = new Size(10, radioButton.Height),
                    BackColor = Color.Teal,
                    Visible = false,
                };


                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                radioButton.MouseEnter += RadioButton_MouseEnter;
                radioButton.MouseLeave += RadioButton_MouseLeave;



                panel.Controls.Add(radioButton);
                panel.Controls.Add(label);


                location = radioButton.Location.Y + radioButton.Height + 7;
            }


        }

        private void RadioButton_MouseLeave(object sender, EventArgs e)
        {
            (sender as RadioButton).BackColor = Color.White;
            foreach (var any in panel.Controls)
            {
                if (any is Label l)
                    if (l.Tag?.ToString() != "Question_Number")
                        l.Visible = false;

            }
        }

        private void RadioButton_MouseEnter(object sender, EventArgs e)
        {
            (sender as RadioButton).BackColor = Color.AliceBlue;
            foreach (var any in panel.Controls)
            {
                if (any is Label l)
                    if (l.Location.Y == (sender as RadioButton).Location.Y)
                        l.Visible = true;

            }
        }
        




        TextBox temp = null;
        private void textBox_Question_TextChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                temp = new TextBox
                {
                    Size = new Size((sender as RadioButton).Size.Width, (sender as RadioButton).Size.Height),
                    Font = new Font("Palatino Linotype", 11f, FontStyle.Bold | FontStyle.Italic),
                    Multiline =true,
                };
                temp.TextChanged += textBox_Question_TextChanged;
                temp.Text = (sender as RadioButton).Text;

                (sender as RadioButton).Height = temp.Height;

            }
            else
            {

                int textLength = (sender as TextBox).Text.Length;
                int textLines = (sender as TextBox).GetLineFromCharIndex(textLength) + 1;
                int Margin = (sender as TextBox).Bounds.Height - (sender as TextBox).ClientSize.Height;
                (sender as TextBox).Height = (TextRenderer.MeasureText(" ", (sender as TextBox).Font).Height * textLines) + Margin + 2;
            }
        }







        private void button_Accept_Click(object sender, EventArgs e)
        {
            foreach (var rb in panel.Controls)
            {
                if (rb is RadioButton radioButton)
                {

                    if (radioButton.Checked)
                    {
                        report.YourAnswers[Questions[BackAndNext[index]].id] = radioButton.Text;
                        ForNoAnswers.Add(Questions[BackAndNext[index]].id);


                        if (radioButton.Tag.ToString() == "Yes")
                        {
                            report.CorrectAnswerSize++;
                            report.Corrects.Add(Questions[BackAndNext[index]]);

                        }
                        else
                        {
                            report.InCorrectAnswerSize++;
                            report.InCorrects.Add(Questions[BackAndNext[index]]);
                        }



                        button_Accept.ForeColor = SystemColors.ControlText;
                        DeleteQuestionBlock();
                        BackAndNext.RemoveAt(index);

                        label_Info.Text = $"{Questions.Count - BackAndNext.Count}/{Questions.Count}";
                        ProgressSpinner.Value = Questions.Count - BackAndNext.Count;



                        if (index == BackAndNext.Count)
                        {
                            if (BackAndNext.Count > 0)
                            {
                                index = 0;
                            }
                            else
                            {
                                button_Accept.Visible = false;
                                button_Back.Visible = false;
                                button_Next.Visible = false;
                                textBox_Question.Visible = false;
                                button_Submit.ForeColor = Color.FromArgb(30, 100, 30);
                            }
                        }

                        if (BackAndNext.Count > 0)
                            Foo();
                    }
                }
            }
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (Questions.Count - BackAndNext.Count == Questions.Count)
                result = DialogResult.Yes;

            else
                result = MetroMessageBox.Show(this, "\n\nDo you want Submit ?", "Important Query", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            if (result == DialogResult.Yes)
            {
                // Add No Answers
                for (int i = 0; i < Questions.Count; i++)
                {
                    bool check = false;
                    for (int j = 0; j < ForNoAnswers.Count; j++)
                    {
                        if (Questions[i].id == ForNoAnswers[j])
                        {
                            check = true;
                        }
                    }

                    if (!check)
                    {
                        report.NoAnswers.Add(Questions[i]);
                    }
                }
                //


                ForSubmit = new FormReport(Questions, report);
                Visible = false;
                ForSubmit.Show();
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            button_Accept.ForeColor = SystemColors.ControlText;
            DeleteQuestionBlock();

            if (index > 0)
                index--;

            Foo();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            button_Accept.ForeColor = SystemColors.ControlText;
            DeleteQuestionBlock(); //and textbox and label

            if (index < BackAndNext.Count - 1)
                index++;

            Foo();
        }

        private void DeleteQuestionBlock()
        {
            foreach (var item in panel.Controls)
            {

                if (item is TextBox t)
                {
                    if (t.Tag?.ToString() != "Question")
                    {
                        delete.Add(t);
                    }
                }

                if (item is RadioButton rb)
                {
                    delete.Add(rb);
                }

                if (item is Label l)
                {
                    if (l.Tag?.ToString() != "Question_Number")
                    delete.Add(l);
                }
            }

            for (int i = 0; i < delete.Count; i++)
            {
                delete[i].Dispose();
            }
            
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            button_Accept.Select();
            button_Accept.ForeColor = Color.DarkCyan;
        }

        

        private void button_Accept_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = SystemColors.Control;
        }

        private void button_Accept_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(108, 207, 246);

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
    }



    public class Report
    {
        public Dictionary<int, string> YourAnswers = new Dictionary<int, string>();

        public List<QuestionBlock> Corrects = new List<QuestionBlock>();
        public List<QuestionBlock> InCorrects = new List<QuestionBlock>();
        public List<QuestionBlock> NoAnswers = new List<QuestionBlock>();



        public List<int[]> RandLocationRbtn;
        public int CorrectAnswerSize { get; set; }
        public int InCorrectAnswerSize { get; set; }



    }


    [Serializable]
    public class QuestionBlock
    {
        [XmlAttribute]
        public int id { get; set; }
        [XmlElement]
        public string Text { get; set; }
        [XmlArray]
        public List<Answer> Answers { get; set; }
    }
    [Serializable]
    public class Answer
    {
        [XmlAttribute]
        public string IsCorrect { get; set; }
        [XmlAttribute]
        public int id { get; set; }
        [XmlElement]
        public string Text { get; set; }
    }


}
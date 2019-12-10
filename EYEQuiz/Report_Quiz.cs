using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf;

namespace StartQuizNameSpace
{
    public partial class FormReport : Form
    {
        public Report report = null;
        public List<QuestionBlock> Questions;
        public List<Control> delete = new List<Control>();
        public int index = 0;
        private int location = 0;


        public FormReport(List<QuestionBlock> questions, Report report)
        {
            InitializeComponent();

            this.report = report;
            this.Questions = questions;


            label_CorrectAnswers.Text = report.CorrectAnswerSize.ToString();
            label_inCorrectAnswers.Text = report.InCorrectAnswerSize.ToString();
            label_noAnswers.Text = (Questions.Count - (report.CorrectAnswerSize + report.InCorrectAnswerSize)).ToString();

            int One = panel_Bottom.Width / questions.Count;

            panel_Correct.Width = One * report.CorrectAnswerSize;

            panel_InCorrect.Location = new Point(panel_Correct.Location.X + panel_Correct.Width + 1, 33);
            panel_InCorrect.Width = One * report.InCorrectAnswerSize;

            panel_NoAnswers.Location = new Point(panel_InCorrect.Location.X + panel_InCorrect.Width + 1, 33);
            panel_NoAnswers.Width = panel_Bottom.Width - panel_Correct.Width - panel_InCorrect.Width;
            Foo();
        }

        private void Foo()
        {
            if (index == Questions.Count - 1)
                button_Next.Enabled = false;
            else
                button_Next.Enabled = true;

            if (index == 0)
                button_Back.Enabled = false;
            else
                button_Back.Enabled = true;


            label_Question_Number.Text = $"{index + 1}.";
            textBox_Question.Text = Questions[index].Text;
            location = textBox_Question.Location.Y + textBox_Question.Height + 10;



            int[] tempArray = report.RandLocationRbtn[Questions[index].id];

            int tempForRandom = 0;

            for (int i = 0; i < Questions[index].Answers.Count; i++)
            {
                tempForRandom = tempArray[i];

                RadioButton radioButton = new RadioButton
                {
                    Location = new Point(60, location),
                    Size = new Size(590, 25),
                    BackColor = Color.White,
                    ForeColor = Color.Teal,
                    Font = new Font("Palatino Linotype", 11f, FontStyle.Bold | FontStyle.Italic),
                    Tag = Questions[index].Answers[tempForRandom].IsCorrect,
                    Cursor = Cursors.Hand,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Enabled = false,
                };

                radioButton.TextChanged += TextBox_TextChanged;
                radioButton.Text = Questions[index].Answers[tempForRandom].Text;


                Label labelCorrect = new Label
                {
                    Size = new Size(24, 24),
                    Location = new Point(10, radioButton.Location.Y + (radioButton.Height / 2) - 12),
                    Image = EYEQuiz.Properties.Resources.icon_Correct,
                    Tag = Questions[index].Answers[tempForRandom].IsCorrect,
                    Visible = false,
                };

                Label label = new Label
                {
                    Location = new Point(49, radioButton.Location.Y),
                    Size = new Size(10, radioButton.Height),
                    BackColor = Color.Teal,
                    Visible = false,
                    Tag = "View"
                };


                radioButton.MouseEnter += RadioButton_MouseEnter;
                radioButton.MouseLeave += RadioButton_MouseLeave;



                panel.Controls.Add(radioButton);
                panel.Controls.Add(label);
                panel.Controls.Add(labelCorrect);

                location = radioButton.Location.Y + radioButton.Height + 7;
            }






            foreach (var any in panel.Controls)
            {
                if (any is RadioButton rb)
                {
                    if (rb.Text == report.YourAnswers[index])
                        rb.Checked = true;

                }

            }


            foreach (var any in panel.Controls)
            {

                if (any is Label l)
                {
                    if (l.Tag?.ToString() == "Yes")
                        l.Visible = true;

                }
            }


        }

        private void RadioButton_MouseLeave(object sender, EventArgs e)
        {
            (sender as RadioButton).BackColor = Color.White;
            foreach (var any in panel.Controls)
            {
                if (any is Label l)
                    if (l.Tag?.ToString() == "View")
                        l.Visible = false;

            }
        }

        private void RadioButton_MouseEnter(object sender, EventArgs e)
        {
            (sender as RadioButton).BackColor = Color.AliceBlue;
            foreach (var any in panel.Controls)
            {
                if (any is Label l)
                    if (l.Tag?.ToString() == "View")
                        if (l.Location.Y == (sender as RadioButton).Location.Y)
                            l.Visible = true;

            }
        }

        TextBox temp = null;
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                temp = new TextBox
                {
                    Size = new Size((sender as RadioButton).Size.Width, (sender as RadioButton).Size.Height),
                    Font = new Font("Palatino Linotype", 11f, FontStyle.Bold | FontStyle.Italic),
                    Multiline = true,
                };
                temp.TextChanged += TextBox_TextChanged;
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

        private void button_Next_Click(object sender, EventArgs e)
        {


            DeleteQuestionBlock();

            if (index < Questions.Count - 1)
                index++;


            Foo();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {

            DeleteQuestionBlock();

            if (index > 0)
                index--;

            Foo();
        }

        private void DeleteQuestionBlock()
        {
            foreach (var item in panel.Controls)
            {

                if (item is Control c)
                    if (c?.Tag != "Question" && c?.Tag != "Question_Number" && c?.Tag != "PanelPDF")
                    {
                        delete.Add(c);
                    }
            }

            for (int i = 0; i < delete.Count; i++)
            {
                delete[i].Dispose();
            }
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            panelPDF.Dispose();
            Timer_For_Exit.Start();
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

        private void label_Exit_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Black;
        }

        private void label_Exit_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.White;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = SystemColors.Control;
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(108, 207, 246);

        }

        private void button_SavePDF_Click(object sender, EventArgs e)
        {
            
            button_Back.Hide();
            button_Next.Hide();
            button_SavePDF.Hide();

            panelPDF.Visible = true;
        }

        private void btn_PDF_Cancel_Click(object sender, EventArgs e)
        {
            button_Back.Show();
            button_Next.Show();
            button_SavePDF.Show();


            panelPDF.Visible = false;


            chk_Correct.Checked = false;
            chk_InCorrect.Checked = false;
            chk_NoAnswer.Checked = false;
        }

        private void LabelExit_Click(object sender, EventArgs e)
        {
            ((sender as Label).Tag as Label).Dispose();
            (sender as Label).Dispose();


            button_Back.Show();
            button_Next.Show();
            button_SavePDF.Show();

            btn_PDF_Cancel.Visible = true;
            btn_PDF_Ok.Visible = true;
            chk_Correct.Checked = false;
            chk_InCorrect.Checked = false;
            chk_NoAnswer.Checked = false;
            panelPDF.Visible = false;
        }

        private void btn_PDF_Ok_Click(object sender, EventArgs e)
        {
            if (chk_Correct.Checked || chk_InCorrect.Checked || chk_NoAnswer.Checked)
            {

                #region Info For Save
                btn_PDF_Ok.Visible = false;
                btn_PDF_Cancel.Visible = false;

                Label labelSuccessfull = new Label
                {
                    BackColor = Color.Teal,
                    ForeColor = Color.FromArgb(51, 51, 51),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true,
                    Location = new Point(56, 135),
                    Text = "Success",
                };

                Label labelExit = new Label
                {
                    Font = new Font("Palatino Linotype", 14f, FontStyle.Bold),
                    BackColor = Color.Teal,
                    ForeColor = Color.FromArgb(51, 51, 51),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true,
                    Location = new Point(141, 0),
                    Text = "x",
                    Tag = labelSuccessfull,
                    Cursor = Cursors.Hand
                };

                panelPDF.Controls.Add(labelSuccessfull);
                panelPDF.Controls.Add(labelExit);

                labelExit.Click += LabelExit_Click;
                #endregion

                try
                {

                    string path = $@"C:\Users\{Environment.UserName}\Documents\Quiz App\PDF File.pdf";

                    iTextSharp.text.Document doc = new iTextSharp.text.Document();
                    PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));


                    doc.Open();

                    #region Add Image
                    Image ImagePDF = EYEQuiz.Properties.Resources.Image_Step_Akademiya;
                    var iTextImage = iTextSharp.text.Image.GetInstance(ImagePDF, System.Drawing.Imaging.ImageFormat.Png);
                    iTextImage.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    iTextImage.ScaleAbsolute(200f, 150f);
                    doc.Add(iTextImage);
                    

                    #endregion

                    #region Add Table
                    AddTable(doc);
                    #endregion

                    #region Add No Answers
                    if (chk_NoAnswer.Checked)
                        WriterNoAnswers(doc);
                    #endregion

                    #region Add InCorrect Answers
                    if (chk_InCorrect.Checked)
                        WriterInCorrectAnswers(doc);
                    #endregion

                    #region Add Correct Answers
                    if (chk_Correct.Checked)
                        WriterCorrectAnswers(doc);
                    #endregion

                    doc.Close();



                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    labelSuccessfull.Text = "Failure";
                }
                

            }
            else
            {
                return;
            }

        }

        /// <summary>
        /// Add Table
        /// </summary>
        private void AddTable(iTextSharp.text.Document doc)
        {
            var columnCount = 3;
            var columnWidths = new[] { 1f, 1f, 1f };

            PdfPTable table = new PdfPTable(columnWidths)
            {
                HorizontalAlignment = Left,
                WidthPercentage = 100,
                //DefaultCell = { MinimumHeight == 22f }
            };

            PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase("Quiz Info"))
            {
                Colspan = columnCount,
                HorizontalAlignment = 1, //left=0, centre=1, right=2
                MinimumHeight = 30f
            };
            cell.BackgroundColor= new iTextSharp.text.BaseColor(51, 102, 102);
            table.AddCell(cell);

            table.AddCell("             Type Answers");
            table.AddCell("                     Size");
            table.AddCell("                    Color");



            

            table.AddCell("No Answer");
            table.AddCell($"{Questions.Count - report.CorrectAnswerSize - report.InCorrectAnswerSize}");
            PdfPCell cellBlue = new PdfPCell()
            {
                BackgroundColor = new iTextSharp.text.BaseColor(Color.Blue),
                Phrase = new iTextSharp.text.Phrase("Blue"),
            };
            table.AddCell(cellBlue);




            table.AddCell("InCorrect");
            table.AddCell($"{report.InCorrectAnswerSize}");
            PdfPCell cellRed = new PdfPCell()
            {
                BackgroundColor = new iTextSharp.text.BaseColor(Color.Red),
                Phrase = new iTextSharp.text.Phrase("Red"),
            };
            table.AddCell(cellRed);




            table.AddCell("Correct");
            table.AddCell($"{report.CorrectAnswerSize}");
            PdfPCell cellGreen = new PdfPCell()
            {
                BackgroundColor = new iTextSharp.text.BaseColor(Color.Green),
                Phrase = new iTextSharp.text.Phrase("Green"),
            };
            table.AddCell(cellGreen);


            doc.Add(table);
        }

        /// <summary>
        /// Correct answers paragraph
        /// </summary>
        private void WriterCorrectAnswers(iTextSharp.text.Document doc)
        {
            iTextSharp.text.Paragraph CorrectAnswers = new iTextSharp.text.Paragraph();
            CorrectAnswers.Font.Color = new iTextSharp.text.BaseColor(Color.Green);
            CorrectAnswers.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
            CorrectAnswers.Add($"\n\n\nCorrect Answers\n\n");

            doc.Add(CorrectAnswers);
            CorrectAnswers.Clear();


            foreach (var question in report.Corrects)
            {
                CorrectAnswers.Font.Color = new iTextSharp.text.BaseColor(Color.Black);
                CorrectAnswers.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                CorrectAnswers.Add(question.Text);
                doc.Add(CorrectAnswers);
                CorrectAnswers.Clear();


                CorrectAnswers.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                foreach (var answer in question.Answers)
                {
                    if (answer.IsCorrect == "Yes")
                    {
                        CorrectAnswers.Font.Color = new iTextSharp.text.BaseColor(Color.Green);

                    }
                    else
                    {
                        CorrectAnswers.Font.Color = new iTextSharp.text.BaseColor(Color.DarkGray);
                    }

                    CorrectAnswers.Add(answer.Text);
                    doc.Add(CorrectAnswers);
                    CorrectAnswers.Clear();
                }
            }




        }

        /// <summary>
        /// InCorrect answers paragraph
        /// </summary>
        private void WriterInCorrectAnswers(iTextSharp.text.Document doc)
        {
            iTextSharp.text.Paragraph InCorrectAnswers = new iTextSharp.text.Paragraph();
            InCorrectAnswers.Font.Color = new iTextSharp.text.BaseColor(Color.DarkRed);
            InCorrectAnswers.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
            InCorrectAnswers.Add($"\n\n\nInCorrect Answers\n\n");


            doc.Add(InCorrectAnswers);
            InCorrectAnswers.Clear();

            foreach (var question in report.InCorrects)
            {
                InCorrectAnswers.Font.Color = new iTextSharp.text.BaseColor(Color.Black);
                InCorrectAnswers.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                InCorrectAnswers.Add(question.Text);
                doc.Add(InCorrectAnswers);
                InCorrectAnswers.Clear();


                InCorrectAnswers.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                foreach (var answer in question.Answers)
                {
                    if (answer.IsCorrect == "Yes")
                    {
                        InCorrectAnswers.Font.Color = new iTextSharp.text.BaseColor(Color.DarkGreen);

                    }
                    else if (report.YourAnswers[question.id] == answer.Text)
                    {
                        InCorrectAnswers.Font.Color = new iTextSharp.text.BaseColor(Color.DarkRed);
                    }
                    else
                    {
                        InCorrectAnswers.Font.Color = new iTextSharp.text.BaseColor(Color.DarkGray);
                    }


                    InCorrectAnswers.Add(answer.Text);
                    doc.Add(InCorrectAnswers);
                    InCorrectAnswers.Clear();
                }
            }


        }

        /// <summary>
        /// NoAnswers paragraph
        /// </summary>
        private void WriterNoAnswers(iTextSharp.text.Document doc)
        {
            iTextSharp.text.Paragraph NoAnswers = new iTextSharp.text.Paragraph();
            NoAnswers.Font.Color = new iTextSharp.text.BaseColor(Color.Blue);
            NoAnswers.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
            NoAnswers.Add("\n\n\nNo Answers\n\n");

            doc.Add(NoAnswers);
            NoAnswers.Clear();

            foreach (var question in report.NoAnswers)
            {
                NoAnswers.Font.Color = new iTextSharp.text.BaseColor(Color.Black);
                NoAnswers.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                NoAnswers.Add(question.Text);
                doc.Add(NoAnswers);
                NoAnswers.Clear();


                NoAnswers.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                foreach (var answer in question.Answers)
                {
                    if (answer.IsCorrect == "Yes")
                    {
                        NoAnswers.Font.Color = new iTextSharp.text.BaseColor(Color.Blue);

                    }
                    else
                    {
                        NoAnswers.Font.Color = new iTextSharp.text.BaseColor(Color.DarkGray);
                    }

                    NoAnswers.Add(answer.Text);
                    doc.Add(NoAnswers);
                    NoAnswers.Clear();
                }
            }

            

        }

    }
}
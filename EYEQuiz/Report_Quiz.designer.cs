namespace StartQuizNameSpace
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.lbl_CorrectAnswers = new System.Windows.Forms.Label();
            this.lbl_inCorrectAnswers = new System.Windows.Forms.Label();
            this.lblNoAnswers = new System.Windows.Forms.Label();
            this.panel_Settings = new System.Windows.Forms.Panel();
            this.label_X = new System.Windows.Forms.Label();
            this.textBox_Question = new System.Windows.Forms.TextBox();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.panel_NoAnswers = new System.Windows.Forms.Panel();
            this.button_SavePDF = new System.Windows.Forms.Button();
            this.panel_InCorrect = new System.Windows.Forms.Panel();
            this.panel_Correct = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_inCorrectAnswers = new System.Windows.Forms.Label();
            this.label_CorrectAnswers = new System.Windows.Forms.Label();
            this.label_noAnswers = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.panelPDF = new System.Windows.Forms.Panel();
            this.chk_NoAnswer = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chk_InCorrect = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chk_Correct = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btn_PDF_Ok = new System.Windows.Forms.Button();
            this.btn_PDF_Cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Question_Number = new System.Windows.Forms.Label();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Timer_For_Exit = new System.Windows.Forms.Timer(this.components);
            this.ElipsePDFWindow = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_Settings.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.panelPDF.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CorrectAnswers
            // 
            this.lbl_CorrectAnswers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_CorrectAnswers.AutoSize = true;
            this.lbl_CorrectAnswers.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CorrectAnswers.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CorrectAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.lbl_CorrectAnswers.Location = new System.Drawing.Point(41, 6);
            this.lbl_CorrectAnswers.Name = "lbl_CorrectAnswers";
            this.lbl_CorrectAnswers.Size = new System.Drawing.Size(101, 17);
            this.lbl_CorrectAnswers.TabIndex = 55;
            this.lbl_CorrectAnswers.Text = "Correct answers";
            // 
            // lbl_inCorrectAnswers
            // 
            this.lbl_inCorrectAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_inCorrectAnswers.AutoSize = true;
            this.lbl_inCorrectAnswers.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inCorrectAnswers.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_inCorrectAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.lbl_inCorrectAnswers.Location = new System.Drawing.Point(313, 6);
            this.lbl_inCorrectAnswers.Name = "lbl_inCorrectAnswers";
            this.lbl_inCorrectAnswers.Size = new System.Drawing.Size(110, 17);
            this.lbl_inCorrectAnswers.TabIndex = 56;
            this.lbl_inCorrectAnswers.Text = "Incorrect answers";
            // 
            // lblNoAnswers
            // 
            this.lblNoAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNoAnswers.AutoSize = true;
            this.lblNoAnswers.BackColor = System.Drawing.Color.Transparent;
            this.lblNoAnswers.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNoAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.lblNoAnswers.Location = new System.Drawing.Point(607, 6);
            this.lblNoAnswers.Name = "lblNoAnswers";
            this.lblNoAnswers.Size = new System.Drawing.Size(76, 17);
            this.lblNoAnswers.TabIndex = 66;
            this.lblNoAnswers.Text = "No Answers";
            // 
            // panel_Settings
            // 
            this.panel_Settings.BackColor = System.Drawing.Color.Teal;
            this.panel_Settings.Controls.Add(this.label_X);
            this.panel_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Settings.Location = new System.Drawing.Point(0, 0);
            this.panel_Settings.Name = "panel_Settings";
            this.panel_Settings.Size = new System.Drawing.Size(700, 30);
            this.panel_Settings.TabIndex = 78;
            // 
            // label_X
            // 
            this.label_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_X.BackColor = System.Drawing.Color.Transparent;
            this.label_X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_X.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_X.ForeColor = System.Drawing.Color.White;
            this.label_X.Image = global::EYEQuiz.Properties.Resources.icon_Exit;
            this.label_X.Location = new System.Drawing.Point(670, 5);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(20, 20);
            this.label_X.TabIndex = 12;
            this.label_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.label_X, "Exit");
            this.label_X.Click += new System.EventHandler(this.label_Exit_Click);
            this.label_X.MouseEnter += new System.EventHandler(this.label_Exit_MouseEnter);
            this.label_X.MouseLeave += new System.EventHandler(this.label_Exit_MouseLeave);
            // 
            // textBox_Question
            // 
            this.textBox_Question.BackColor = System.Drawing.Color.White;
            this.textBox_Question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Question.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Question.Enabled = false;
            this.textBox_Question.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Question.Location = new System.Drawing.Point(67, 26);
            this.textBox_Question.Multiline = true;
            this.textBox_Question.Name = "textBox_Question";
            this.textBox_Question.Size = new System.Drawing.Size(593, 25);
            this.textBox_Question.TabIndex = 79;
            this.textBox_Question.Tag = "Question";
            this.textBox_Question.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.White;
            this.panel_Bottom.Controls.Add(this.panel_NoAnswers);
            this.panel_Bottom.Controls.Add(this.button_SavePDF);
            this.panel_Bottom.Controls.Add(this.panel_InCorrect);
            this.panel_Bottom.Controls.Add(this.panel_Correct);
            this.panel_Bottom.Controls.Add(this.panel1);
            this.panel_Bottom.Controls.Add(this.button_Back);
            this.panel_Bottom.Controls.Add(this.button_Next);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 430);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(700, 70);
            this.panel_Bottom.TabIndex = 79;
            // 
            // panel_NoAnswers
            // 
            this.panel_NoAnswers.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_NoAnswers.Location = new System.Drawing.Point(468, 33);
            this.panel_NoAnswers.Name = "panel_NoAnswers";
            this.panel_NoAnswers.Size = new System.Drawing.Size(232, 7);
            this.panel_NoAnswers.TabIndex = 81;
            // 
            // button_SavePDF
            // 
            this.button_SavePDF.BackColor = System.Drawing.Color.Transparent;
            this.button_SavePDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SavePDF.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_SavePDF.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button_SavePDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.button_SavePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SavePDF.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_SavePDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_SavePDF.Image = global::EYEQuiz.Properties.Resources.icon_pdf;
            this.button_SavePDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SavePDF.Location = new System.Drawing.Point(555, 1);
            this.button_SavePDF.Name = "button_SavePDF";
            this.button_SavePDF.Size = new System.Drawing.Size(107, 30);
            this.button_SavePDF.TabIndex = 81;
            this.button_SavePDF.Text = "Save PDF";
            this.button_SavePDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.button_SavePDF, "Save PDF");
            this.button_SavePDF.UseVisualStyleBackColor = false;
            this.button_SavePDF.Click += new System.EventHandler(this.button_SavePDF_Click);
            this.button_SavePDF.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_SavePDF.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // panel_InCorrect
            // 
            this.panel_InCorrect.BackColor = System.Drawing.Color.Purple;
            this.panel_InCorrect.Location = new System.Drawing.Point(234, 33);
            this.panel_InCorrect.Name = "panel_InCorrect";
            this.panel_InCorrect.Size = new System.Drawing.Size(233, 7);
            this.panel_InCorrect.TabIndex = 81;
            // 
            // panel_Correct
            // 
            this.panel_Correct.BackColor = System.Drawing.Color.Green;
            this.panel_Correct.Location = new System.Drawing.Point(0, 33);
            this.panel_Correct.Name = "panel_Correct";
            this.panel_Correct.Size = new System.Drawing.Size(233, 7);
            this.panel_Correct.TabIndex = 80;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label_inCorrectAnswers);
            this.panel1.Controls.Add(this.lbl_CorrectAnswers);
            this.panel1.Controls.Add(this.lblNoAnswers);
            this.panel1.Controls.Add(this.label_CorrectAnswers);
            this.panel1.Controls.Add(this.label_noAnswers);
            this.panel1.Controls.Add(this.lbl_inCorrectAnswers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 30);
            this.panel1.TabIndex = 80;
            // 
            // label_inCorrectAnswers
            // 
            this.label_inCorrectAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_inCorrectAnswers.BackColor = System.Drawing.Color.Transparent;
            this.label_inCorrectAnswers.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_inCorrectAnswers.Image = ((System.Drawing.Image)(resources.GetObject("label_inCorrectAnswers.Image")));
            this.label_inCorrectAnswers.Location = new System.Drawing.Point(283, 3);
            this.label_inCorrectAnswers.Name = "label_inCorrectAnswers";
            this.label_inCorrectAnswers.Size = new System.Drawing.Size(24, 24);
            this.label_inCorrectAnswers.TabIndex = 58;
            this.label_inCorrectAnswers.Text = "0";
            this.label_inCorrectAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.label_inCorrectAnswers, "Incorrect answers size");
            // 
            // label_CorrectAnswers
            // 
            this.label_CorrectAnswers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_CorrectAnswers.BackColor = System.Drawing.Color.Transparent;
            this.label_CorrectAnswers.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_CorrectAnswers.Image = ((System.Drawing.Image)(resources.GetObject("label_CorrectAnswers.Image")));
            this.label_CorrectAnswers.Location = new System.Drawing.Point(11, 3);
            this.label_CorrectAnswers.Name = "label_CorrectAnswers";
            this.label_CorrectAnswers.Size = new System.Drawing.Size(24, 24);
            this.label_CorrectAnswers.TabIndex = 57;
            this.label_CorrectAnswers.Text = "0";
            this.label_CorrectAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.label_CorrectAnswers, "Correct Answers Size");
            // 
            // label_noAnswers
            // 
            this.label_noAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_noAnswers.BackColor = System.Drawing.Color.Transparent;
            this.label_noAnswers.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_noAnswers.Image = ((System.Drawing.Image)(resources.GetObject("label_noAnswers.Image")));
            this.label_noAnswers.Location = new System.Drawing.Point(577, 3);
            this.label_noAnswers.Name = "label_noAnswers";
            this.label_noAnswers.Size = new System.Drawing.Size(24, 24);
            this.label_noAnswers.TabIndex = 70;
            this.label_noAnswers.Text = "0";
            this.label_noAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.label_noAnswers, "No Answers Size");
            // 
            // button_Back
            // 
            this.button_Back.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Back.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_Back.Image = ((System.Drawing.Image)(resources.GetObject("button_Back.Image")));
            this.button_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Back.Location = new System.Drawing.Point(267, 1);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(80, 30);
            this.button_Back.TabIndex = 39;
            this.button_Back.Text = "Back";
            this.button_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.button_Back, "Back");
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            this.button_Back.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_Back.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_Next
            // 
            this.button_Next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Next.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Next.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button_Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Next.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_Next.Image = ((System.Drawing.Image)(resources.GetObject("button_Next.Image")));
            this.button_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Next.Location = new System.Drawing.Point(353, 1);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(80, 30);
            this.button_Next.TabIndex = 38;
            this.button_Next.Text = "Next";
            this.button_Next.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.button_Next, "Next");
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            this.button_Next.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_Next.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 25;
            this.Elipse.TargetControl = this;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.panelPDF);
            this.panel.Controls.Add(this.label_Question_Number);
            this.panel.Controls.Add(this.textBox_Question);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(700, 400);
            this.panel.TabIndex = 85;
            // 
            // panelPDF
            // 
            this.panelPDF.BackColor = System.Drawing.Color.Teal;
            this.panelPDF.Controls.Add(this.chk_NoAnswer);
            this.panelPDF.Controls.Add(this.chk_InCorrect);
            this.panelPDF.Controls.Add(this.chk_Correct);
            this.panelPDF.Controls.Add(this.btn_PDF_Ok);
            this.panelPDF.Controls.Add(this.btn_PDF_Cancel);
            this.panelPDF.Controls.Add(this.label4);
            this.panelPDF.Controls.Add(this.label1);
            this.panelPDF.Controls.Add(this.label3);
            this.panelPDF.Controls.Add(this.label2);
            this.panelPDF.Location = new System.Drawing.Point(265, 117);
            this.panelPDF.Name = "panelPDF";
            this.panelPDF.Size = new System.Drawing.Size(166, 172);
            this.panelPDF.TabIndex = 84;
            this.panelPDF.Tag = "PanelPDF";
            this.panelPDF.Visible = false;
            // 
            // chk_NoAnswer
            // 
            this.chk_NoAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_NoAnswer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.chk_NoAnswer.ChechedOffColor = System.Drawing.Color.DeepSkyBlue;
            this.chk_NoAnswer.Checked = false;
            this.chk_NoAnswer.CheckedOnColor = System.Drawing.Color.DeepSkyBlue;
            this.chk_NoAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_NoAnswer.ForeColor = System.Drawing.Color.White;
            this.chk_NoAnswer.Location = new System.Drawing.Point(20, 97);
            this.chk_NoAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.chk_NoAnswer.Name = "chk_NoAnswer";
            this.chk_NoAnswer.Size = new System.Drawing.Size(20, 20);
            this.chk_NoAnswer.TabIndex = 101;
            // 
            // chk_InCorrect
            // 
            this.chk_InCorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_InCorrect.BackColor = System.Drawing.Color.Purple;
            this.chk_InCorrect.ChechedOffColor = System.Drawing.Color.Purple;
            this.chk_InCorrect.Checked = false;
            this.chk_InCorrect.CheckedOnColor = System.Drawing.Color.Purple;
            this.chk_InCorrect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_InCorrect.ForeColor = System.Drawing.Color.White;
            this.chk_InCorrect.Location = new System.Drawing.Point(20, 67);
            this.chk_InCorrect.Margin = new System.Windows.Forms.Padding(4);
            this.chk_InCorrect.Name = "chk_InCorrect";
            this.chk_InCorrect.Size = new System.Drawing.Size(20, 20);
            this.chk_InCorrect.TabIndex = 100;
            // 
            // chk_Correct
            // 
            this.chk_Correct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_Correct.BackColor = System.Drawing.Color.Green;
            this.chk_Correct.ChechedOffColor = System.Drawing.Color.Green;
            this.chk_Correct.Checked = false;
            this.chk_Correct.CheckedOnColor = System.Drawing.Color.Green;
            this.chk_Correct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_Correct.ForeColor = System.Drawing.Color.White;
            this.chk_Correct.Location = new System.Drawing.Point(20, 37);
            this.chk_Correct.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Correct.Name = "chk_Correct";
            this.chk_Correct.Size = new System.Drawing.Size(20, 20);
            this.chk_Correct.TabIndex = 99;
            // 
            // btn_PDF_Ok
            // 
            this.btn_PDF_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PDF_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PDF_Ok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_PDF_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PDF_Ok.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_PDF_Ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_PDF_Ok.Location = new System.Drawing.Point(19, 135);
            this.btn_PDF_Ok.Name = "btn_PDF_Ok";
            this.btn_PDF_Ok.Size = new System.Drawing.Size(61, 28);
            this.btn_PDF_Ok.TabIndex = 98;
            this.btn_PDF_Ok.Text = "Ok";
            this.btn_PDF_Ok.UseVisualStyleBackColor = true;
            this.btn_PDF_Ok.Click += new System.EventHandler(this.btn_PDF_Ok_Click);
            // 
            // btn_PDF_Cancel
            // 
            this.btn_PDF_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_PDF_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PDF_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_PDF_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PDF_Cancel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_PDF_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_PDF_Cancel.Location = new System.Drawing.Point(86, 135);
            this.btn_PDF_Cancel.Name = "btn_PDF_Cancel";
            this.btn_PDF_Cancel.Size = new System.Drawing.Size(61, 28);
            this.btn_PDF_Cancel.TabIndex = 97;
            this.btn_PDF_Cancel.Text = "Cancel";
            this.btn_PDF_Cancel.UseVisualStyleBackColor = true;
            this.btn_PDF_Cancel.Click += new System.EventHandler(this.btn_PDF_Cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 96;
            this.label4.Text = "Select";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(45, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 95;
            this.label1.Text = "No Answers";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(45, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "Correct answers";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(45, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 93;
            this.label2.Text = "Incorrect answers";
            // 
            // label_Question_Number
            // 
            this.label_Question_Number.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Question_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_Question_Number.Location = new System.Drawing.Point(19, 26);
            this.label_Question_Number.Name = "label_Question_Number";
            this.label_Question_Number.Size = new System.Drawing.Size(37, 25);
            this.label_Question_Number.TabIndex = 80;
            this.label_Question_Number.Tag = "Question_Number";
            this.label_Question_Number.Text = "1.";
            this.label_Question_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.panel_Settings;
            this.DragControl.Vertical = true;
            // 
            // Timer_For_Exit
            // 
            this.Timer_For_Exit.Tick += new System.EventHandler(this.Timer_For_Exit_Tick);
            // 
            // ElipsePDFWindow
            // 
            this.ElipsePDFWindow.ElipseRadius = 25;
            this.ElipsePDFWindow.TargetControl = this.panelPDF;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.panel_Settings);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_Settings.ResumeLayout(false);
            this.panel_Bottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panelPDF.ResumeLayout(false);
            this.panelPDF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Label lbl_CorrectAnswers;
        private System.Windows.Forms.Label lbl_inCorrectAnswers;
        private System.Windows.Forms.Label label_CorrectAnswers;
        private System.Windows.Forms.Label label_inCorrectAnswers;
        private System.Windows.Forms.Label lblNoAnswers;
        private System.Windows.Forms.Label label_noAnswers;
        private System.Windows.Forms.Panel panel_Settings;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.TextBox textBox_Question;
        private System.Windows.Forms.Panel panel_Bottom;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Panel panel;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer Timer_For_Exit;
        private System.Windows.Forms.Panel panel_NoAnswers;
        private System.Windows.Forms.Panel panel_InCorrect;
        private System.Windows.Forms.Panel panel_Correct;
        private System.Windows.Forms.Label label_Question_Number;
        private System.Windows.Forms.Button button_SavePDF;
        private System.Windows.Forms.Panel panelPDF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_PDF_Cancel;
        private Bunifu.Framework.UI.BunifuElipse ElipsePDFWindow;
        private System.Windows.Forms.Button btn_PDF_Ok;
        private Bunifu.Framework.UI.BunifuCheckbox chk_NoAnswer;
        private Bunifu.Framework.UI.BunifuCheckbox chk_InCorrect;
        private Bunifu.Framework.UI.BunifuCheckbox chk_Correct;
    }
}
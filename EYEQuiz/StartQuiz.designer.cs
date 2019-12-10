namespace StartQuizNameSpace
{
    partial class StartQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartQuiz));
            this.panel_Settings = new System.Windows.Forms.Panel();
            this.label_X = new System.Windows.Forms.Label();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.panelBottomBlack = new System.Windows.Forms.Panel();
            this.ProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.label_Info = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_Accept = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label_Question_Number = new System.Windows.Forms.Label();
            this.textBox_Question = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Timer_For_Exit = new System.Windows.Forms.Timer(this.components);
            this.panel_Settings.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            this.panelBottomBlack.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Settings
            // 
            this.panel_Settings.BackColor = System.Drawing.Color.Teal;
            this.panel_Settings.Controls.Add(this.label_X);
            this.panel_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Settings.Location = new System.Drawing.Point(0, 0);
            this.panel_Settings.Name = "panel_Settings";
            this.panel_Settings.Size = new System.Drawing.Size(700, 30);
            this.panel_Settings.TabIndex = 32;
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
            this.label_X.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip.SetToolTip(this.label_X, "Exit");
            this.label_X.Click += new System.EventHandler(this.label_X_Click);
            this.label_X.MouseEnter += new System.EventHandler(this.label_X_MouseEnter);
            this.label_X.MouseLeave += new System.EventHandler(this.label_X_MouseLeave);
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 25;
            this.Elipse.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.panel_Settings;
            this.DragControl.Vertical = true;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.White;
            this.panel_Bottom.Controls.Add(this.panelBottomBlack);
            this.panel_Bottom.Controls.Add(this.button_Submit);
            this.panel_Bottom.Controls.Add(this.button_Accept);
            this.panel_Bottom.Controls.Add(this.button_Next);
            this.panel_Bottom.Controls.Add(this.button_Back);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 437);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(700, 63);
            this.panel_Bottom.TabIndex = 33;
            // 
            // panelBottomBlack
            // 
            this.panelBottomBlack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelBottomBlack.Controls.Add(this.ProgressSpinner);
            this.panelBottomBlack.Controls.Add(this.label_Info);
            this.panelBottomBlack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBlack.Location = new System.Drawing.Point(0, 33);
            this.panelBottomBlack.Name = "panelBottomBlack";
            this.panelBottomBlack.Size = new System.Drawing.Size(700, 30);
            this.panelBottomBlack.TabIndex = 60;
            // 
            // ProgressSpinner
            // 
            this.ProgressSpinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ProgressSpinner.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProgressSpinner.EnsureVisible = false;
            this.ProgressSpinner.Location = new System.Drawing.Point(10, 3);
            this.ProgressSpinner.Maximum = 20;
            this.ProgressSpinner.Name = "ProgressSpinner";
            this.ProgressSpinner.Size = new System.Drawing.Size(25, 23);
            this.ProgressSpinner.Spinning = false;
            this.ProgressSpinner.Style = MetroFramework.MetroColorStyle.Lime;
            this.ProgressSpinner.TabIndex = 61;
            this.toolTip.SetToolTip(this.ProgressSpinner, "Answered");
            this.ProgressSpinner.UseCustomBackColor = true;
            this.ProgressSpinner.UseSelectable = true;
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.label_Info.Location = new System.Drawing.Point(37, 6);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(31, 17);
            this.label_Info.TabIndex = 59;
            this.label_Info.Text = "Info";
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.Color.Transparent;
            this.button_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Submit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Submit.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button_Submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.button_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Submit.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Submit.ForeColor = System.Drawing.Color.Black;
            this.button_Submit.Image = ((System.Drawing.Image)(resources.GetObject("button_Submit.Image")));
            this.button_Submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Submit.Location = new System.Drawing.Point(562, 1);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(95, 30);
            this.button_Submit.TabIndex = 60;
            this.button_Submit.Text = "Submit";
            this.button_Submit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.button_Submit, "Submit");
            this.button_Submit.UseVisualStyleBackColor = false;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            this.button_Submit.MouseEnter += new System.EventHandler(this.button_Accept_MouseEnter);
            this.button_Submit.MouseLeave += new System.EventHandler(this.button_Accept_MouseLeave);
            // 
            // button_Accept
            // 
            this.button_Accept.BackColor = System.Drawing.Color.Transparent;
            this.button_Accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Accept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Accept.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button_Accept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.button_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Accept.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Accept.ForeColor = System.Drawing.Color.Black;
            this.button_Accept.Image = ((System.Drawing.Image)(resources.GetObject("button_Accept.Image")));
            this.button_Accept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Accept.Location = new System.Drawing.Point(243, 1);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(90, 30);
            this.button_Accept.TabIndex = 51;
            this.button_Accept.Text = "Accept";
            this.button_Accept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.button_Accept, "Accept");
            this.button_Accept.UseVisualStyleBackColor = false;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            this.button_Accept.MouseEnter += new System.EventHandler(this.button_Accept_MouseEnter);
            this.button_Accept.MouseLeave += new System.EventHandler(this.button_Accept_MouseLeave);
            // 
            // button_Next
            // 
            this.button_Next.BackColor = System.Drawing.Color.Transparent;
            this.button_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Next.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Next.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button_Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Next.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Next.ForeColor = System.Drawing.Color.Black;
            this.button_Next.Image = ((System.Drawing.Image)(resources.GetObject("button_Next.Image")));
            this.button_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Next.Location = new System.Drawing.Point(157, 1);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(80, 30);
            this.button_Next.TabIndex = 54;
            this.button_Next.Text = "Next";
            this.button_Next.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.button_Next, "Next");
            this.button_Next.UseVisualStyleBackColor = false;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            this.button_Next.MouseEnter += new System.EventHandler(this.button_Accept_MouseEnter);
            this.button_Next.MouseLeave += new System.EventHandler(this.button_Accept_MouseLeave);
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.Transparent;
            this.button_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Back.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Back.ForeColor = System.Drawing.Color.Black;
            this.button_Back.Image = ((System.Drawing.Image)(resources.GetObject("button_Back.Image")));
            this.button_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Back.Location = new System.Drawing.Point(71, 1);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(80, 30);
            this.button_Back.TabIndex = 52;
            this.button_Back.Text = "Back";
            this.button_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.button_Back, "Back");
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            this.button_Back.MouseEnter += new System.EventHandler(this.button_Accept_MouseEnter);
            this.button_Back.MouseLeave += new System.EventHandler(this.button_Accept_MouseLeave);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.label_Question_Number);
            this.panel.Controls.Add(this.textBox_Question);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(700, 407);
            this.panel.TabIndex = 34;
            // 
            // label_Question_Number
            // 
            this.label_Question_Number.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Question_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_Question_Number.Location = new System.Drawing.Point(19, 26);
            this.label_Question_Number.Name = "label_Question_Number";
            this.label_Question_Number.Size = new System.Drawing.Size(37, 25);
            this.label_Question_Number.TabIndex = 60;
            this.label_Question_Number.Tag = "Question_Number";
            this.label_Question_Number.Text = "1.";
            this.label_Question_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Question
            // 
            this.textBox_Question.BackColor = System.Drawing.Color.White;
            this.textBox_Question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Question.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Question.Enabled = false;
            this.textBox_Question.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Question.Location = new System.Drawing.Point(62, 28);
            this.textBox_Question.Multiline = true;
            this.textBox_Question.Name = "textBox_Question";
            this.textBox_Question.Size = new System.Drawing.Size(593, 25);
            this.textBox_Question.TabIndex = 59;
            this.textBox_Question.Tag = "Question";
            this.textBox_Question.TextChanged += new System.EventHandler(this.textBox_Question_TextChanged);
            // 
            // Timer_For_Exit
            // 
            this.Timer_For_Exit.Tick += new System.EventHandler(this.Timer_For_Exit_Tick);
            // 
            // StartQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.ControlBox = false;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.panel_Settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "StartQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.LawnGreen;
            this.panel_Settings.ResumeLayout(false);
            this.panel_Bottom.ResumeLayout(false);
            this.panelBottomBlack.ResumeLayout(false);
            this.panelBottomBlack.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Settings;
        private System.Windows.Forms.Label label_X;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Panel panel;
        private MetroFramework.Controls.MetroProgressSpinner ProgressSpinner;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Back;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.TextBox textBox_Question;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panelBottomBlack;
        private System.Windows.Forms.Timer Timer_For_Exit;
        private System.Windows.Forms.Label label_Question_Number;
    }
}


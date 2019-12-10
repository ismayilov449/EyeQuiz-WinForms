namespace EYEQuiz
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label_X = new System.Windows.Forms.Label();
            this.Timer_For_Exit = new System.Windows.Forms.Timer(this.components);
            this.timer_SlideMenu_1 = new System.Windows.Forms.Timer(this.components);
            this.timer_SlideMenu_2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_login = new System.Windows.Forms.Label();
            this.txt_Password1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_Pass1 = new System.Windows.Forms.Panel();
            this.panel_Username = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.Elipse_Button = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox_pass = new System.Windows.Forms.PictureBox();
            this.pictureBox_username = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lbl_QuizApplication = new System.Windows.Forms.Label();
            this.pictureBox_Login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_username)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 25;
            this.Elipse.TargetControl = this;
            this.Elipse.TargetControlResized += new System.EventHandler(this.label_X_Click);
            // 
            // label_X
            // 
            this.label_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_X.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_X.ForeColor = System.Drawing.Color.Teal;
            this.label_X.Location = new System.Drawing.Point(671, -3);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(27, 27);
            this.label_X.TabIndex = 11;
            this.label_X.Text = "x";
            this.label_X.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip.SetToolTip(this.label_X, "Exit");
            this.label_X.Click += new System.EventHandler(this.label_X_Click);
            this.label_X.MouseEnter += new System.EventHandler(this.label_X_MouseEnter);
            this.label_X.MouseLeave += new System.EventHandler(this.label_X_MouseLeave);
            // 
            // Timer_For_Exit
            // 
            this.Timer_For_Exit.Tick += new System.EventHandler(this.Timer_For_Exit_Tick);
            // 
            // timer_SlideMenu_1
            // 
            this.timer_SlideMenu_1.Interval = 1;
            this.timer_SlideMenu_1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_SlideMenu_2
            // 
            this.timer_SlideMenu_2.Interval = 1;
            this.timer_SlideMenu_2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_login.ForeColor = System.Drawing.Color.Teal;
            this.lbl_login.Location = new System.Drawing.Point(376, 24);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(83, 32);
            this.lbl_login.TabIndex = 13;
            this.lbl_login.Text = "Log In";
            // 
            // txt_Password1
            // 
            this.txt_Password1.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Password1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Password1.ForeColor = System.Drawing.Color.Gray;
            this.txt_Password1.Location = new System.Drawing.Point(405, 309);
            this.txt_Password1.Name = "txt_Password1";
            this.txt_Password1.PasswordChar = '*';
            this.txt_Password1.Size = new System.Drawing.Size(259, 22);
            this.txt_Password1.TabIndex = 20;
            this.txt_Password1.TabStop = false;
            this.txt_Password1.Text = "Password";
            this.txt_Password1.Enter += new System.EventHandler(this.textBox_Password_Enter);
            this.txt_Password1.Leave += new System.EventHandler(this.textBox_Passwword_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(378, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password:";
            // 
            // panel_Pass1
            // 
            this.panel_Pass1.BackColor = System.Drawing.Color.Teal;
            this.panel_Pass1.Location = new System.Drawing.Point(379, 333);
            this.panel_Pass1.Name = "panel_Pass1";
            this.panel_Pass1.Size = new System.Drawing.Size(287, 3);
            this.panel_Pass1.TabIndex = 22;
            this.panel_Pass1.Tag = "";
            // 
            // panel_Username
            // 
            this.panel_Username.BackColor = System.Drawing.Color.Teal;
            this.panel_Username.Location = new System.Drawing.Point(379, 252);
            this.panel_Username.Name = "panel_Username";
            this.panel_Username.Size = new System.Drawing.Size(287, 3);
            this.panel_Username.TabIndex = 25;
            this.panel_Username.Tag = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(378, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "User Name:";
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Username.ForeColor = System.Drawing.Color.Gray;
            this.txt_Username.Location = new System.Drawing.Point(405, 228);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(259, 22);
            this.txt_Username.TabIndex = 23;
            this.txt_Username.TabStop = false;
            this.txt_Username.Text = "Full Name";
            this.txt_Username.Enter += new System.EventHandler(this.textBox_UserName_Enter);
            this.txt_Username.Leave += new System.EventHandler(this.textBox_UserName_Leave);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.Teal;
            this.btn_SignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SignUp.FlatAppearance.BorderSize = 0;
            this.btn_SignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_SignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SignUp.ForeColor = System.Drawing.Color.White;
            this.btn_SignUp.Location = new System.Drawing.Point(379, 422);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(285, 40);
            this.btn_SignUp.TabIndex = 29;
            this.btn_SignUp.Text = "Log In";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // Elipse_Button
            // 
            this.Elipse_Button.ElipseRadius = 25;
            this.Elipse_Button.TargetControl = this.btn_SignUp;
            // 
            // pictureBox_pass
            // 
            this.pictureBox_pass.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_pass.Image = global::EYEQuiz.Properties.Resources.icon_password_gray;
            this.pictureBox_pass.Location = new System.Drawing.Point(379, 309);
            this.pictureBox_pass.Name = "pictureBox_pass";
            this.pictureBox_pass.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pass.TabIndex = 31;
            this.pictureBox_pass.TabStop = false;
            // 
            // pictureBox_username
            // 
            this.pictureBox_username.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_username.Image = global::EYEQuiz.Properties.Resources.icon_username_gray;
            this.pictureBox_username.Location = new System.Drawing.Point(379, 228);
            this.pictureBox_username.Name = "pictureBox_username";
            this.pictureBox_username.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_username.TabIndex = 30;
            this.pictureBox_username.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Teal;
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMain.Controls.Add(this.lbl_QuizApplication);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(350, 500);
            this.panelMain.TabIndex = 5;
            // 
            // lbl_QuizApplication
            // 
            this.lbl_QuizApplication.AutoSize = true;
            this.lbl_QuizApplication.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_QuizApplication.ForeColor = System.Drawing.Color.White;
            this.lbl_QuizApplication.Location = new System.Drawing.Point(91, 397);
            this.lbl_QuizApplication.Name = "lbl_QuizApplication";
            this.lbl_QuizApplication.Size = new System.Drawing.Size(168, 25);
            this.lbl_QuizApplication.TabIndex = 30;
            this.lbl_QuizApplication.Text = "Quiz Application";
            this.lbl_QuizApplication.MouseEnter += new System.EventHandler(this.lbl_QuizApplication_MouseEnter);
            this.lbl_QuizApplication.MouseLeave += new System.EventHandler(this.lbl_QuizApplication_MouseLeave);
            // 
            // pictureBox_Login
            // 
            this.pictureBox_Login.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Login.Image = global::EYEQuiz.Properties.Resources.icon_Login_Teal;
            this.pictureBox_Login.Location = new System.Drawing.Point(480, 100);
            this.pictureBox_Login.Name = "pictureBox_Login";
            this.pictureBox_Login.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_Login.TabIndex = 32;
            this.pictureBox_Login.TabStop = false;
            this.pictureBox_Login.MouseEnter += new System.EventHandler(this.pictureBox_Login_MouseEnter);
            this.pictureBox_Login.MouseLeave += new System.EventHandler(this.pictureBox_Login_MouseLeave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.pictureBox_Login);
            this.Controls.Add(this.pictureBox_pass);
            this.Controls.Add(this.pictureBox_username);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.panel_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.panel_Pass1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Password1);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.label_X);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Click += new System.EventHandler(this.frmMain_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_username)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label_X;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer Timer_For_Exit;
        private System.Windows.Forms.Timer timer_SlideMenu_1;
        private System.Windows.Forms.Timer timer_SlideMenu_2;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Password1;
        private System.Windows.Forms.Panel panel_Pass1;
        private System.Windows.Forms.Panel panel_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Button btn_SignUp;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Button;
        private System.Windows.Forms.Label lbl_QuizApplication;
        private System.Windows.Forms.PictureBox pictureBox_pass;
        private System.Windows.Forms.PictureBox pictureBox_username;
        private System.Windows.Forms.PictureBox pictureBox_Login;
    }
}


namespace EYEQuiz
{
    partial class QuizMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizMenu));
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel_Settings = new System.Windows.Forms.Panel();
            this.label_X = new System.Windows.Forms.Label();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CreateQuiz = new System.Windows.Forms.PictureBox();
            this.pictureBox_Search = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Bottom_Add = new System.Windows.Forms.Panel();
            this.Panel_Bottom_View = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lbl_By_Me = new System.Windows.Forms.Label();
            this.lbl_2019 = new System.Windows.Forms.Label();
            this.txt_Search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Timer_For_Exit = new System.Windows.Forms.Timer(this.components);
            this.Timer_For_Label = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateQuiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).BeginInit();
            this.panel_Bottom_Add.SuspendLayout();
            this.Panel_Bottom_View.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.panel_Settings;
            this.DragControl.Vertical = true;
            // 
            // panel_Settings
            // 
            this.panel_Settings.BackColor = System.Drawing.Color.Teal;
            this.panel_Settings.Controls.Add(this.label_X);
            this.panel_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Settings.Location = new System.Drawing.Point(0, 0);
            this.panel_Settings.Name = "panel_Settings";
            this.panel_Settings.Size = new System.Drawing.Size(700, 30);
            this.panel_Settings.TabIndex = 31;
            // 
            // label_X
            // 
            this.label_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_X.BackColor = System.Drawing.Color.Transparent;
            this.label_X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_X.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_X.ForeColor = System.Drawing.Color.White;
            this.label_X.Location = new System.Drawing.Point(670, -5);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(27, 27);
            this.label_X.TabIndex = 12;
            this.label_X.Text = "x";
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
            // CreateQuiz
            // 
            this.CreateQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateQuiz.BackColor = System.Drawing.Color.Transparent;
            this.CreateQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateQuiz.Image = global::EYEQuiz.Properties.Resources.icon_AddNewQuiz_Teal;
            this.CreateQuiz.Location = new System.Drawing.Point(603, 11);
            this.CreateQuiz.Name = "CreateQuiz";
            this.CreateQuiz.Size = new System.Drawing.Size(48, 48);
            this.CreateQuiz.TabIndex = 2;
            this.CreateQuiz.TabStop = false;
            this.toolTip.SetToolTip(this.CreateQuiz, "New Quiz");
            this.CreateQuiz.Click += new System.EventHandler(this.button_CreateQuiz_Click);
            this.CreateQuiz.MouseEnter += new System.EventHandler(this.button_CreateQuiz_MouseEnter);
            this.CreateQuiz.MouseLeave += new System.EventHandler(this.button_CreateQuiz_MouseLeave);
            // 
            // pictureBox_Search
            // 
            this.pictureBox_Search.Image = global::EYEQuiz.Properties.Resources.icon_Search;
            this.pictureBox_Search.Location = new System.Drawing.Point(529, 27);
            this.pictureBox_Search.Name = "pictureBox_Search";
            this.pictureBox_Search.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_Search.TabIndex = 22;
            this.pictureBox_Search.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox_Search, "Search");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Quiz";
            // 
            // panel_Bottom_Add
            // 
            this.panel_Bottom_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel_Bottom_Add.Controls.Add(this.Panel_Bottom_View);
            this.panel_Bottom_Add.Controls.Add(this.panelBottom);
            this.panel_Bottom_Add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom_Add.Location = new System.Drawing.Point(0, 400);
            this.panel_Bottom_Add.Name = "panel_Bottom_Add";
            this.panel_Bottom_Add.Size = new System.Drawing.Size(700, 100);
            this.panel_Bottom_Add.TabIndex = 30;
            // 
            // Panel_Bottom_View
            // 
            this.Panel_Bottom_View.BackColor = System.Drawing.Color.Teal;
            this.Panel_Bottom_View.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Bottom_View.BackgroundImage")));
            this.Panel_Bottom_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Bottom_View.Controls.Add(this.CreateQuiz);
            this.Panel_Bottom_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Bottom_View.GradientBottomLeft = System.Drawing.Color.Teal;
            this.Panel_Bottom_View.GradientBottomRight = System.Drawing.Color.Teal;
            this.Panel_Bottom_View.GradientTopLeft = System.Drawing.Color.Teal;
            this.Panel_Bottom_View.GradientTopRight = System.Drawing.Color.Teal;
            this.Panel_Bottom_View.Location = new System.Drawing.Point(0, 0);
            this.Panel_Bottom_View.Name = "Panel_Bottom_View";
            this.Panel_Bottom_View.Quality = 10;
            this.Panel_Bottom_View.Size = new System.Drawing.Size(700, 70);
            this.Panel_Bottom_View.TabIndex = 4;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelBottom.Controls.Add(this.lbl_By_Me);
            this.panelBottom.Controls.Add(this.lbl_2019);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 70);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(700, 30);
            this.panelBottom.TabIndex = 3;
            // 
            // lbl_By_Me
            // 
            this.lbl_By_Me.AutoSize = true;
            this.lbl_By_Me.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_By_Me.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.lbl_By_Me.Location = new System.Drawing.Point(551, 7);
            this.lbl_By_Me.Name = "lbl_By_Me";
            this.lbl_By_Me.Size = new System.Drawing.Size(137, 17);
            this.lbl_By_Me.TabIndex = 2;
            this.lbl_By_Me.Text = "App by Tural Novruzov";
            this.lbl_By_Me.Visible = false;
            // 
            // lbl_2019
            // 
            this.lbl_2019.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_2019.AutoSize = true;
            this.lbl_2019.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_2019.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.lbl_2019.Location = new System.Drawing.Point(16, 7);
            this.lbl_2019.Name = "lbl_2019";
            this.lbl_2019.Size = new System.Drawing.Size(142, 17);
            this.lbl_2019.TabIndex = 1;
            this.lbl_2019.Text = "© Quiz Application. 2019";
            // 
            // txt_Search
            // 
            this.txt_Search.Depth = 0;
            this.txt_Search.Hint = "Search quiz title";
            this.txt_Search.Location = new System.Drawing.Point(559, 28);
            this.txt_Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.SelectedText = "";
            this.txt_Search.SelectionLength = 0;
            this.txt_Search.SelectionStart = 0;
            this.txt_Search.Size = new System.Drawing.Size(111, 23);
            this.txt_Search.TabIndex = 21;
            this.toolTip.SetToolTip(this.txt_Search, "Search");
            this.txt_Search.UseSystemPasswordChar = false;
            this.txt_Search.MouseLeave += new System.EventHandler(this.txt_Search_MouseLeave);
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.txt_Search);
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Controls.Add(this.pictureBox_Search);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 30);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(700, 70);
            this.panel_Top.TabIndex = 32;
            // 
            // panel_Left
            // 
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 100);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(30, 300);
            this.panel_Left.TabIndex = 33;
            // 
            // panel_Right
            // 
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(670, 100);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(30, 300);
            this.panel_Right.TabIndex = 34;
            // 
            // panel_Main
            // 
            this.panel_Main.AutoScroll = true;
            this.panel_Main.BackColor = System.Drawing.SystemColors.Window;
            this.panel_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(30, 100);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(640, 300);
            this.panel_Main.TabIndex = 35;
            this.panel_Main.Tag = "Main";
            // 
            // Timer_For_Exit
            // 
            this.Timer_For_Exit.Tick += new System.EventHandler(this.Timer_For_Exit_Tick);
            // 
            // Timer_For_Label
            // 
            this.Timer_For_Label.Enabled = true;
            this.Timer_For_Label.Interval = 50;
            this.Timer_For_Label.Tick += new System.EventHandler(this.Timer_For_Label_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // QuizMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Settings);
            this.Controls.Add(this.panel_Bottom_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuizMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.QuizMenu_Load);
            this.panel_Settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CreateQuiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).EndInit();
            this.panel_Bottom_Add.ResumeLayout(false);
            this.Panel_Bottom_View.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Panel panel_Bottom_Add;
        private System.Windows.Forms.Label lbl_2019;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_By_Me;
        private System.Windows.Forms.PictureBox CreateQuiz;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Search;
        private System.Windows.Forms.PictureBox pictureBox_Search;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Settings;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer Timer_For_Exit;
        private System.Windows.Forms.Timer Timer_For_Label;
        private Bunifu.Framework.UI.BunifuGradientPanel Panel_Bottom_View;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}
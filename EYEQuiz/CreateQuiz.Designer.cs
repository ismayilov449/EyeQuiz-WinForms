namespace EYEQuiz
{
    partial class CreateQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateQuiz));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button_AddQuestion = new System.Windows.Forms.PictureBox();
            this.label_Exit = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.PictureBox();
            this.btn_Back = new System.Windows.Forms.PictureBox();
            this.btn_Arrow = new System.Windows.Forms.PictureBox();
            this.label_Edit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Elipse_Main = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_Top = new System.Windows.Forms.Panel();
            this.textBox_QuizName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel_Settings = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel_Bottom_Add = new System.Windows.Forms.Panel();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.lbl_By_Me = new System.Windows.Forms.Label();
            this.lbl_2019 = new System.Windows.Forms.Label();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.Timer_For_Label = new System.Windows.Forms.Timer(this.components);
            this.Timer_For_Arrow = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.button_AddQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Arrow)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.panel_Settings.SuspendLayout();
            this.panel_Bottom_Add.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_AddQuestion
            // 
            this.button_AddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddQuestion.BackColor = System.Drawing.Color.Transparent;
            this.button_AddQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddQuestion.Image = global::EYEQuiz.Properties.Resources.icon_AddNewQuiz_Teal;
            this.button_AddQuestion.Location = new System.Drawing.Point(600, 4);
            this.button_AddQuestion.Name = "button_AddQuestion";
            this.button_AddQuestion.Size = new System.Drawing.Size(48, 48);
            this.button_AddQuestion.TabIndex = 2;
            this.button_AddQuestion.TabStop = false;
            this.toolTip.SetToolTip(this.button_AddQuestion, "New Question");
            this.button_AddQuestion.Click += new System.EventHandler(this.button_AddQuestion_Click);
            this.button_AddQuestion.MouseEnter += new System.EventHandler(this.button_AddQuiz_MouseEnter);
            this.button_AddQuestion.MouseLeave += new System.EventHandler(this.button_AddQuiz_MouseLeave);
            // 
            // label_Exit
            // 
            this.label_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Exit.BackColor = System.Drawing.Color.Transparent;
            this.label_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Exit.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Exit.ForeColor = System.Drawing.Color.White;
            this.label_Exit.Location = new System.Drawing.Point(670, -5);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(27, 27);
            this.label_Exit.TabIndex = 12;
            this.label_Exit.Text = "x";
            this.label_Exit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip.SetToolTip(this.label_Exit, "Exit");
            this.label_Exit.Click += new System.EventHandler(this.label_X_Click);
            this.label_Exit.MouseEnter += new System.EventHandler(this.label_Exit_MouseEnter);
            this.label_Exit.MouseLeave += new System.EventHandler(this.label_Exit_MouseLeave);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Image = global::EYEQuiz.Properties.Resources.icon_Xml_Save_Teal;
            this.btn_Save.Location = new System.Drawing.Point(59, 22);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(24, 24);
            this.btn_Save.TabIndex = 34;
            this.btn_Save.TabStop = false;
            this.btn_Save.Tag = "Save";
            this.toolTip.SetToolTip(this.btn_Save, "Save XML");
            this.btn_Save.Click += new System.EventHandler(this.button_Save_Click);
            this.btn_Save.MouseEnter += new System.EventHandler(this.pictureBoxs_MouseEnter);
            this.btn_Save.MouseLeave += new System.EventHandler(this.pictureBoxs_MouseLeave);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Image = global::EYEQuiz.Properties.Resources.icons_Back_Teal;
            this.btn_Back.Location = new System.Drawing.Point(29, 22);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(24, 24);
            this.btn_Back.TabIndex = 35;
            this.btn_Back.TabStop = false;
            this.btn_Back.Tag = "Back";
            this.toolTip.SetToolTip(this.btn_Back, "Back Menu");
            this.btn_Back.Click += new System.EventHandler(this.Back_Click);
            this.btn_Back.MouseEnter += new System.EventHandler(this.pictureBoxs_MouseEnter);
            this.btn_Back.MouseLeave += new System.EventHandler(this.pictureBoxs_MouseLeave);
            // 
            // btn_Arrow
            // 
            this.btn_Arrow.BackColor = System.Drawing.Color.Transparent;
            this.btn_Arrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Arrow.Image = global::EYEQuiz.Properties.Resources.icon_Up_Teal;
            this.btn_Arrow.Location = new System.Drawing.Point(336, 34);
            this.btn_Arrow.Name = "btn_Arrow";
            this.btn_Arrow.Size = new System.Drawing.Size(24, 24);
            this.btn_Arrow.TabIndex = 33;
            this.btn_Arrow.TabStop = false;
            this.btn_Arrow.Tag = "Arrow";
            this.toolTip.SetToolTip(this.btn_Arrow, "Up");
            this.btn_Arrow.Click += new System.EventHandler(this.button_UpDown_Click);
            this.btn_Arrow.MouseEnter += new System.EventHandler(this.pictureBoxs_MouseEnter);
            this.btn_Arrow.MouseLeave += new System.EventHandler(this.pictureBoxs_MouseLeave);
            // 
            // label_Edit
            // 
            this.label_Edit.Image = ((System.Drawing.Image)(resources.GetObject("label_Edit.Image")));
            this.label_Edit.Location = new System.Drawing.Point(529, 22);
            this.label_Edit.Name = "label_Edit";
            this.label_Edit.Size = new System.Drawing.Size(24, 23);
            this.label_Edit.TabIndex = 37;
            this.toolTip.SetToolTip(this.label_Edit, "Xml Name");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(351, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Questions";
            // 
            // Elipse_Main
            // 
            this.Elipse_Main.ElipseRadius = 25;
            this.Elipse_Main.TargetControl = this;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel_Top.Controls.Add(this.label_Edit);
            this.panel_Top.Controls.Add(this.textBox_QuizName);
            this.panel_Top.Controls.Add(this.btn_Back);
            this.panel_Top.Controls.Add(this.btn_Save);
            this.panel_Top.Controls.Add(this.btn_Arrow);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 30);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(700, 55);
            this.panel_Top.TabIndex = 27;
            // 
            // textBox_QuizName
            // 
            this.textBox_QuizName.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_QuizName.Depth = 0;
            this.textBox_QuizName.Hint = "Untitled quiz";
            this.textBox_QuizName.Location = new System.Drawing.Point(559, 24);
            this.textBox_QuizName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox_QuizName.Name = "textBox_QuizName";
            this.textBox_QuizName.PasswordChar = '\0';
            this.textBox_QuizName.SelectedText = "";
            this.textBox_QuizName.SelectionLength = 0;
            this.textBox_QuizName.SelectionStart = 0;
            this.textBox_QuizName.Size = new System.Drawing.Size(111, 23);
            this.textBox_QuizName.TabIndex = 36;
            this.textBox_QuizName.UseSystemPasswordChar = false;
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
            this.panel_Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Settings.BackgroundImage")));
            this.panel_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Settings.Controls.Add(this.label_Exit);
            this.panel_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Settings.GradientBottomLeft = System.Drawing.Color.Teal;
            this.panel_Settings.GradientBottomRight = System.Drawing.Color.Teal;
            this.panel_Settings.GradientTopLeft = System.Drawing.Color.Teal;
            this.panel_Settings.GradientTopRight = System.Drawing.Color.Teal;
            this.panel_Settings.Location = new System.Drawing.Point(0, 0);
            this.panel_Settings.Name = "panel_Settings";
            this.panel_Settings.Quality = 10;
            this.panel_Settings.Size = new System.Drawing.Size(700, 30);
            this.panel_Settings.TabIndex = 26;
            // 
            // panel_Bottom_Add
            // 
            this.panel_Bottom_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel_Bottom_Add.Controls.Add(this.button_AddQuestion);
            this.panel_Bottom_Add.Controls.Add(this.panel_Bottom);
            this.panel_Bottom_Add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom_Add.Location = new System.Drawing.Point(0, 414);
            this.panel_Bottom_Add.Name = "panel_Bottom_Add";
            this.panel_Bottom_Add.Size = new System.Drawing.Size(700, 86);
            this.panel_Bottom_Add.TabIndex = 31;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel_Bottom.Controls.Add(this.lbl_By_Me);
            this.panel_Bottom.Controls.Add(this.lbl_2019);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 56);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(700, 30);
            this.panel_Bottom.TabIndex = 1;
            // 
            // lbl_By_Me
            // 
            this.lbl_By_Me.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_By_Me.AutoSize = true;
            this.lbl_By_Me.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_By_Me.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.lbl_By_Me.Location = new System.Drawing.Point(553, 5);
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
            this.lbl_2019.Location = new System.Drawing.Point(26, 5);
            this.lbl_2019.Name = "lbl_2019";
            this.lbl_2019.Size = new System.Drawing.Size(142, 17);
            this.lbl_2019.TabIndex = 1;
            this.lbl_2019.Text = "© Quiz Application. 2019";
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 85);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(25, 329);
            this.panel_Left.TabIndex = 32;
            // 
            // panel_Right
            // 
            this.panel_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(675, 85);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(25, 329);
            this.panel_Right.TabIndex = 33;
            // 
            // Panel_Main
            // 
            this.Panel_Main.AllowDrop = true;
            this.Panel_Main.AutoScroll = true;
            this.Panel_Main.BackColor = System.Drawing.Color.White;
            this.Panel_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(25, 85);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(650, 329);
            this.Panel_Main.TabIndex = 34;
            this.Panel_Main.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_Main_DragDrop);
            this.Panel_Main.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_Main_DragEnter);
            // 
            // Timer_For_Label
            // 
            this.Timer_For_Label.Enabled = true;
            this.Timer_For_Label.Interval = 50;
            this.Timer_For_Label.Tick += new System.EventHandler(this.Timer_For_Label_Tick);
            // 
            // Timer_For_Arrow
            // 
            this.Timer_For_Arrow.Interval = 10;
            this.Timer_For_Arrow.Tick += new System.EventHandler(this.Timer_For_Arrow_Tick);
            // 
            // CreateQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.Panel_Main);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panel_Bottom_Add);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Settings);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CreateQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.button_AddQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Arrow)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Settings.ResumeLayout(false);
            this.panel_Bottom_Add.ResumeLayout(false);
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Bottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Main;
        private System.Windows.Forms.Panel panel_Top;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_Settings;
        private System.Windows.Forms.Label label_Exit;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.Panel panel_Bottom_Add;
        private System.Windows.Forms.PictureBox button_AddQuestion;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Label lbl_By_Me;
        private System.Windows.Forms.Label lbl_2019;
        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.PictureBox btn_Arrow;
        private System.Windows.Forms.PictureBox btn_Save;
        private System.Windows.Forms.PictureBox btn_Back;
        private System.Windows.Forms.Timer Timer_For_Label;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox_QuizName;
        private System.Windows.Forms.Label label_Edit;
        private System.Windows.Forms.Timer Timer_For_Arrow;
    }
}
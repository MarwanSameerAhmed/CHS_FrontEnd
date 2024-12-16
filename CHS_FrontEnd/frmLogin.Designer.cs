namespace CHS_FrontEnd
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Closebtn = new System.Windows.Forms.Button();
            this.UserNametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(138)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 530);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(100, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = " CARE SYSTEM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(57, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "CENTRAL HEALTH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CHS_FrontEnd.Properties.Resources.Leonardo_Phoenix_A_modern_minimalist_logo_design_for_the_Centr_3;
            this.pictureBox1.Location = new System.Drawing.Point(105, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.passwordtxt);
            this.panel2.Controls.Add(this.UserNametxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Closebtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(180)))));
            this.panel2.Location = new System.Drawing.Point(364, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 530);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(148, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "مرحبا بك";
            this.label1.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(66, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "سجل الدخول الى حسابك";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Closebtn.Location = new System.Drawing.Point(414, 0);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(35, 35);
            this.Closebtn.TabIndex = 0;
            this.Closebtn.Text = "X";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // UserNametxt
            // 
            this.UserNametxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(138)))), ((int)(((byte)(195)))));
            this.UserNametxt.BorderRadius = 10;
            this.UserNametxt.BorderThickness = 2;
            this.UserNametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNametxt.DefaultText = "";
            this.UserNametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserNametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserNametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNametxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserNametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNametxt.IconRight = global::CHS_FrontEnd.Properties.Resources.user;
            this.UserNametxt.IconRightOffset = new System.Drawing.Point(5, 0);
            this.UserNametxt.Location = new System.Drawing.Point(63, 229);
            this.UserNametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.PasswordChar = '\0';
            this.UserNametxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.UserNametxt.PlaceholderText = "اسم المستخدم";
            this.UserNametxt.SelectedText = "";
            this.UserNametxt.Size = new System.Drawing.Size(266, 48);
            this.UserNametxt.TabIndex = 7;
            this.UserNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UserNametxt.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // passwordtxt
            // 
            this.passwordtxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(138)))), ((int)(((byte)(195)))));
            this.passwordtxt.BorderRadius = 10;
            this.passwordtxt.BorderThickness = 2;
            this.passwordtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtxt.DefaultText = "";
            this.passwordtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordtxt.IconRight = global::CHS_FrontEnd.Properties.Resources.padlock__1_1;
            this.passwordtxt.IconRightOffset = new System.Drawing.Point(5, 0);
            this.passwordtxt.Location = new System.Drawing.Point(63, 285);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '1';
            this.passwordtxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.passwordtxt.PlaceholderText = "كلمة المرور";
            this.passwordtxt.SelectedText = "";
            this.passwordtxt.Size = new System.Drawing.Size(266, 48);
            this.passwordtxt.TabIndex = 8;
            this.passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(138)))), ((int)(((byte)(195)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.guna2Button1.Location = new System.Drawing.Point(107, 361);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "دخول";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(138)))), ((int)(((byte)(195)))));
            this.linkLabel1.Location = new System.Drawing.Point(143, 420);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 17);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "نسيت كلمة المرور";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox UserNametxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox passwordtxt;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


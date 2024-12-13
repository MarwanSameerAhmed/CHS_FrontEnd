using System.Drawing;
using System.Windows.Forms;

namespace CHS_FrontEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelM = new System.Windows.Forms.Panel();
            this.emergrncyManagementBtn = new FontAwesome.Sharp.IconButton();
            this.setteingsBtn = new FontAwesome.Sharp.IconButton();
            this.logOutBtn = new FontAwesome.Sharp.IconButton();
            this.pharmacyManagementBtn = new FontAwesome.Sharp.IconButton();
            this.labsManagementBtn = new FontAwesome.Sharp.IconButton();
            this.patientManagementBtn = new FontAwesome.Sharp.IconButton();
            this.employeeManagementBtn = new FontAwesome.Sharp.IconButton();
            this.mainPageBtn = new FontAwesome.Sharp.IconButton();
            this.panellogo = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.avatarUser = new System.Windows.Forms.PictureBox();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.panelM.SuspendLayout();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelM
            // 
            this.panelM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(138)))), ((int)(((byte)(195)))));
            this.panelM.Controls.Add(this.emergrncyManagementBtn);
            this.panelM.Controls.Add(this.setteingsBtn);
            this.panelM.Controls.Add(this.logOutBtn);
            this.panelM.Controls.Add(this.pharmacyManagementBtn);
            this.panelM.Controls.Add(this.labsManagementBtn);
            this.panelM.Controls.Add(this.patientManagementBtn);
            this.panelM.Controls.Add(this.employeeManagementBtn);
            this.panelM.Controls.Add(this.mainPageBtn);
            this.panelM.Controls.Add(this.panellogo);
            this.panelM.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelM.Location = new System.Drawing.Point(0, 0);
            this.panelM.Name = "panelM";
            this.panelM.Size = new System.Drawing.Size(250, 813);
            this.panelM.TabIndex = 0;
            // 
            // emergrncyManagementBtn
            // 
            this.emergrncyManagementBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.emergrncyManagementBtn.FlatAppearance.BorderSize = 0;
            this.emergrncyManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emergrncyManagementBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergrncyManagementBtn.ForeColor = System.Drawing.Color.White;
            this.emergrncyManagementBtn.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.emergrncyManagementBtn.IconColor = System.Drawing.Color.White;
            this.emergrncyManagementBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.emergrncyManagementBtn.IconSize = 32;
            this.emergrncyManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emergrncyManagementBtn.Location = new System.Drawing.Point(0, 561);
            this.emergrncyManagementBtn.Name = "emergrncyManagementBtn";
            this.emergrncyManagementBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.emergrncyManagementBtn.Size = new System.Drawing.Size(250, 75);
            this.emergrncyManagementBtn.TabIndex = 8;
            this.emergrncyManagementBtn.Text = "إدارة قسم الطوارئ";
            this.emergrncyManagementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emergrncyManagementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.emergrncyManagementBtn.UseVisualStyleBackColor = true;
            // 
            // setteingsBtn
            // 
            this.setteingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.setteingsBtn.FlatAppearance.BorderSize = 0;
            this.setteingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setteingsBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setteingsBtn.ForeColor = System.Drawing.Color.White;
            this.setteingsBtn.IconChar = FontAwesome.Sharp.IconChar.Atom;
            this.setteingsBtn.IconColor = System.Drawing.Color.White;
            this.setteingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.setteingsBtn.IconSize = 32;
            this.setteingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setteingsBtn.Location = new System.Drawing.Point(0, 663);
            this.setteingsBtn.Name = "setteingsBtn";
            this.setteingsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.setteingsBtn.Size = new System.Drawing.Size(250, 75);
            this.setteingsBtn.TabIndex = 7;
            this.setteingsBtn.Text = "الاعدادات";
            this.setteingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setteingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.setteingsBtn.UseVisualStyleBackColor = true;
            this.setteingsBtn.Click += new System.EventHandler(this.setteingsBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.logOutBtn.IconColor = System.Drawing.Color.White;
            this.logOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logOutBtn.IconSize = 32;
            this.logOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutBtn.Location = new System.Drawing.Point(0, 738);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.logOutBtn.Size = new System.Drawing.Size(250, 75);
            this.logOutBtn.TabIndex = 6;
            this.logOutBtn.Text = "تسجيل الخروج";
            this.logOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // pharmacyManagementBtn
            // 
            this.pharmacyManagementBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pharmacyManagementBtn.FlatAppearance.BorderSize = 0;
            this.pharmacyManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pharmacyManagementBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharmacyManagementBtn.ForeColor = System.Drawing.Color.White;
            this.pharmacyManagementBtn.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
            this.pharmacyManagementBtn.IconColor = System.Drawing.Color.White;
            this.pharmacyManagementBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pharmacyManagementBtn.IconSize = 32;
            this.pharmacyManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pharmacyManagementBtn.Location = new System.Drawing.Point(0, 486);
            this.pharmacyManagementBtn.Name = "pharmacyManagementBtn";
            this.pharmacyManagementBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.pharmacyManagementBtn.Size = new System.Drawing.Size(250, 75);
            this.pharmacyManagementBtn.TabIndex = 5;
            this.pharmacyManagementBtn.Text = "إدارة قسم الصيدلة";
            this.pharmacyManagementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pharmacyManagementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pharmacyManagementBtn.UseVisualStyleBackColor = true;
            this.pharmacyManagementBtn.Click += new System.EventHandler(this.pharmacyManagementBtn_Click);
            // 
            // labsManagementBtn
            // 
            this.labsManagementBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.labsManagementBtn.FlatAppearance.BorderSize = 0;
            this.labsManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labsManagementBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsManagementBtn.ForeColor = System.Drawing.Color.White;
            this.labsManagementBtn.IconChar = FontAwesome.Sharp.IconChar.LaptopMedical;
            this.labsManagementBtn.IconColor = System.Drawing.Color.White;
            this.labsManagementBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.labsManagementBtn.IconSize = 32;
            this.labsManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labsManagementBtn.Location = new System.Drawing.Point(0, 411);
            this.labsManagementBtn.Name = "labsManagementBtn";
            this.labsManagementBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.labsManagementBtn.Size = new System.Drawing.Size(250, 75);
            this.labsManagementBtn.TabIndex = 4;
            this.labsManagementBtn.Text = "إدارة المختبرات";
            this.labsManagementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labsManagementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.labsManagementBtn.UseVisualStyleBackColor = true;
            this.labsManagementBtn.Click += new System.EventHandler(this.managements_Click);
            // 
            // patientManagementBtn
            // 
            this.patientManagementBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientManagementBtn.FlatAppearance.BorderSize = 0;
            this.patientManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientManagementBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientManagementBtn.ForeColor = System.Drawing.Color.White;
            this.patientManagementBtn.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            this.patientManagementBtn.IconColor = System.Drawing.Color.White;
            this.patientManagementBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.patientManagementBtn.IconSize = 32;
            this.patientManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientManagementBtn.Location = new System.Drawing.Point(0, 336);
            this.patientManagementBtn.Name = "patientManagementBtn";
            this.patientManagementBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.patientManagementBtn.Size = new System.Drawing.Size(250, 75);
            this.patientManagementBtn.TabIndex = 3;
            this.patientManagementBtn.Text = "إدارة المرضى";
            this.patientManagementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientManagementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientManagementBtn.UseVisualStyleBackColor = true;
            this.patientManagementBtn.Click += new System.EventHandler(this.patientManagementBtn_Click);
            // 
            // employeeManagementBtn
            // 
            this.employeeManagementBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeManagementBtn.FlatAppearance.BorderSize = 0;
            this.employeeManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeManagementBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeManagementBtn.ForeColor = System.Drawing.Color.White;
            this.employeeManagementBtn.IconChar = FontAwesome.Sharp.IconChar.PeopleLine;
            this.employeeManagementBtn.IconColor = System.Drawing.Color.White;
            this.employeeManagementBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.employeeManagementBtn.IconSize = 32;
            this.employeeManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeManagementBtn.Location = new System.Drawing.Point(0, 261);
            this.employeeManagementBtn.Name = "employeeManagementBtn";
            this.employeeManagementBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.employeeManagementBtn.Size = new System.Drawing.Size(250, 75);
            this.employeeManagementBtn.TabIndex = 2;
            this.employeeManagementBtn.Text = "إدارة الموظفين";
            this.employeeManagementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeManagementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employeeManagementBtn.UseVisualStyleBackColor = true;
            this.employeeManagementBtn.Click += new System.EventHandler(this.employeeManagementBtn_Click);
            // 
            // mainPageBtn
            // 
            this.mainPageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPageBtn.FlatAppearance.BorderSize = 0;
            this.mainPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainPageBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPageBtn.ForeColor = System.Drawing.Color.White;
            this.mainPageBtn.IconChar = FontAwesome.Sharp.IconChar.House;
            this.mainPageBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.mainPageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mainPageBtn.IconSize = 32;
            this.mainPageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainPageBtn.Location = new System.Drawing.Point(0, 186);
            this.mainPageBtn.Name = "mainPageBtn";
            this.mainPageBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.mainPageBtn.Size = new System.Drawing.Size(250, 75);
            this.mainPageBtn.TabIndex = 1;
            this.mainPageBtn.Text = "الصفحة الرئيسية";
            this.mainPageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainPageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainPageBtn.UseVisualStyleBackColor = true;
            this.mainPageBtn.Click += new System.EventHandler(this.dashbord_Click);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(138)))), ((int)(((byte)(195)))));
            this.panellogo.Controls.Add(this.logoLabel);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(250, 186);
            this.panellogo.TabIndex = 0;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.White;
            this.logoLabel.Location = new System.Drawing.Point(58, 45);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(85, 45);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "CHS";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(100, 23);
            this.welcomeLabel.TabIndex = 0;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Location = new System.Drawing.Point(0, 0);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(100, 50);
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(138)))), ((int)(((byte)(195)))));
            this.panelUser.Controls.Add(this.userLabel);
            this.panelUser.Controls.Add(this.avatarUser);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(250, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(988, 100);
            this.panelUser.TabIndex = 2;
            // 
            // userLabel
            // 
            this.userLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(769, 32);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(136, 23);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "مرحبا , محمد علي";
            // 
            // avatarUser
            // 
            this.avatarUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.avatarUser.Image = ((System.Drawing.Image)(resources.GetObject("avatarUser.Image")));
            this.avatarUser.Location = new System.Drawing.Point(928, 22);
            this.avatarUser.Name = "avatarUser";
            this.avatarUser.Size = new System.Drawing.Size(48, 40);
            this.avatarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarUser.TabIndex = 0;
            this.avatarUser.TabStop = false;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Location = new System.Drawing.Point(366, -148);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(948, 949);
            this.dockPanel1.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 813);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.panelM);
            this.Name = "frmMain";
            this.Text = "CENTRAL HEALTH CARE SYSTEM";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelM.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelM;
        private FontAwesome.Sharp.IconButton mainPageBtn;
        private FontAwesome.Sharp.IconButton labsManagementBtn;
        private FontAwesome.Sharp.IconButton patientManagementBtn;
        private FontAwesome.Sharp.IconButton employeeManagementBtn;
        private FontAwesome.Sharp.IconButton pharmacyManagementBtn;
        private System.Windows.Forms.Panel panellogo;
        private FontAwesome.Sharp.IconButton logOutBtn;
        private FlowLayoutPanel flowLayoutPanel;
        private Label welcomeLabel;
        private PictureBox avatarPictureBox;
        private Panel panelUser;
        private PictureBox avatarUser;
        private FontAwesome.Sharp.IconButton setteingsBtn;
        private Label logoLabel;
        private FontAwesome.Sharp.IconButton emergrncyManagementBtn;
        private Label userLabel;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
    }
}
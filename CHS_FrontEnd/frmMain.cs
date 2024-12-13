using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using WeifenLuo.WinFormsUI.Docking;

namespace CHS_FrontEnd
{
    public partial class frmMain : Form
    {
        private IconButton CurrentBtn;
        private Panel leftBor;
        private DockPanel dockPanel;
        private bool isMenuCollapsed = false;
        private Form currfrm = null;
        private Form currentForm = null;
        public frmMain()
        {
           
            InitializeComponent();
            CustomizeMenu();
            leftBor = new Panel();
            leftBor.Size = new Size(10, 60);
            panelM.Controls.Add(leftBor);
            this.WindowState = FormWindowState.Maximized;
            dockPanel = new DockPanel() { Dock = DockStyle.Fill };
            var theme = new VS2015BlueTheme();
            theme.Skin.DockPaneStripSkin.TextFont = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dockPanel.Theme = theme;
            this.Controls.Add(dockPanel);
            dockPanel.BringToFront();
           
        }

        private void OpenForm(Form childForm)
        {

            if (currentForm != null && currentForm.GetType() == childForm.GetType())
            {
             
                return;
            }
            currentForm = childForm;


            childForm.TopLevel = false;

            var dockContent = new DockContent()
            {
                Text = childForm.Text
            };

            childForm.Dock = DockStyle.Fill;
            dockContent.Controls.Add(childForm);
            childForm.Show();
            dockContent.Show(dockPanel);
           
        }
      





        private void Activiat(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                Disable();
                CurrentBtn = (IconButton)senderBtn;
                CurrentBtn.BackColor = System.Drawing.Color.FromArgb(1,87,155);
                CurrentBtn.ForeColor = System.Drawing.Color.White;
                CurrentBtn.TextAlign = ContentAlignment.MiddleCenter;
                CurrentBtn.IconColor = System.Drawing.Color.White;
                CurrentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBor.BackColor = System.Drawing.Color.White;
                CurrentBtn.FlatAppearance.BorderSize = 1;
                leftBor.Location = new Point(0, CurrentBtn.Location.Y);
                leftBor.Visible = true;
                leftBor.BringToFront();
                this.Load += new EventHandler(Form2_Load);
                

            }

        }

        private struct Rgb
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(60, 138, 195);
        }
        private void Disable()
        {
            if (CurrentBtn != null)
            {
                CurrentBtn.BackColor = System.Drawing.Color.FromArgb(60, 138, 195);
                CurrentBtn.ForeColor = System.Drawing.Color.White;
                CurrentBtn.FlatAppearance.BorderSize = 0;
                CurrentBtn.TextAlign = ContentAlignment.MiddleLeft;
                CurrentBtn.IconColor = System.Drawing.Color.Gainsboro;  ;
                CurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
            

        }

        
        

        private void Form2_Load(object sender, EventArgs e)
        {

            mainPageBtn.PerformClick();
            
        }

        private void dashbord_Click(object sender, EventArgs e)
        {
            Activiat(sender,Rgb.color1);
            show();
           
           
        }



       

        private void managements_Click(object sender, EventArgs e)
        {
            Activiat(sender, Rgb.color1);
        }

    

        private void show()
        {
            MainServicePage fr = new MainServicePage();
            OpenForm(fr);
        }


      
        private void pharmacyManagementBtn_Click(object sender, EventArgs e)
        {
            Activiat(sender, Rgb.color1);
        }

        private void setteingsBtn_Click(object sender, EventArgs e)
        {
            Activiat(sender, Rgb.color1);
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Activiat(sender, Rgb.color1);
        }

     

        private void CustomizeMenu()
        {
       
            IconButton btnHamburger = new IconButton
            {
                IconChar = IconChar.Bars,
                IconColor = System.Drawing.Color.White,
                Dock = DockStyle.None, 
                FlatStyle = FlatStyle.Flat,
                Height = 30, 
                Width = 30,  
                Location = new System.Drawing.Point(20, 30) 
            };
            btnHamburger.FlatAppearance.BorderSize = 0; 
            btnHamburger.Click += BtnHamburger_Click; 
           
            panelUser.Controls.Add(btnHamburger);
            panelUser.Controls.SetChildIndex(btnHamburger, 0);
        }

        private void BtnHamburger_Click(object sender, EventArgs e)
        {
            if (isMenuCollapsed)
            {
                panelM.Width = 250;
                foreach (Control ctrl in panelM.Controls)
                {
                    if (ctrl is IconButton button && button != null)
                    {
                        button.Text = button.Tag?.ToString(); 
                        button.TextAlign = ContentAlignment.MiddleLeft;
                        button.IconSize = 32;
                        button.Padding = new Padding(10, 0, 20, 0);
                    }
                }
                isMenuCollapsed = false;
            }
            else
            {
                
                panelM.Width = 55; 
                foreach (Control ctrl in panelM.Controls)
                {
                    if (ctrl is IconButton button && button != null)
                    {
                        button.Tag = button.Text; 
                        button.Text = ""; 
                        button.TextAlign = ContentAlignment.MiddleCenter;
                        button.IconSize = 40;
                        button.Padding = new Padding(0);
                    }
                }
                isMenuCollapsed = true;
            }
        }

        private void employeeManagementBtn_Click(object sender, EventArgs e)
        {
            Activiat(sender, Rgb.color1);
          //  OpenForm(new employeeManagementPage(dockPanel));
        }

        private void patientManagementBtn_Click(object sender, EventArgs e)
        {
             Activiat(sender,Rgb.color1);
           // OpenForm(new patientManagementPage(dockPanel));

        }

       
    }
}

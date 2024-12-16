using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace CHS_FrontEnd
{
    public partial class Mainfrm : Form
    {
        private DockPanel dockPanel;
     
        private Form currentForm = null;
        private bool isCollapsed = false;



        public Mainfrm()
        {
            InitializeComponent();
            customDes();
            this.WindowState = FormWindowState.Maximized;
            dockPanel = new DockPanel() { Dock = DockStyle.Fill };
            var theme = new VS2015BlueTheme();
            theme.Skin.DockPaneStripSkin.TextFont = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dockPanel.Theme = theme;
            this.Controls.Add(dockPanel);
            dockPanel.BringToFront();

        }





        private void Form1_Load(object sender, EventArgs e)
        {
            MainPage.PerformClick();
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


        private void show()
        {
            MainServicePage fr = new MainServicePage();
            OpenForm(fr);
        }

        private void customDes()
        {
            PatientsubMenuPanel.Visible = false;
            EmployeesSubMenu.Visible = false;
            LabDepSubMenu.Visible = false;  
        }

        private void hideSub()
        {
            if (PatientsubMenuPanel.Visible == true)
                PatientsubMenuPanel.Visible = false;
            if (EmployeesSubMenu.Visible == true)
                EmployeesSubMenu.Visible = false;
            if (LabDepSubMenu.Visible == true)
                LabDepSubMenu.Visible = false;



        }

       

        private void showSub(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSub();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;

            }

        }
        private void LabDepBtn_Click(object sender, EventArgs e)
        {
            showSub(LabDepSubMenu);
        }

        private void PatientManagementBtn_Click(object sender, EventArgs e)
        {
           
            showSub(PatientsubMenuPanel);

        }

        private void patientAddFrmBtn_Click(object sender, EventArgs e)
        {
            OpenForm(new addingPatientFrm(dockPanel));
            hideSub();
        }

        private void PatientSearchFrmBtn_Click(object sender, EventArgs e)
        {
           OpenForm(new searchPatientFrm(dockPanel));
            hideSub();

        }


        private void EmployeesManagementBtn_Click(object sender, EventArgs e)
        {
            showSub(EmployeesSubMenu);
            
        }


        private void HmbSizeBtn_Click(object sender, EventArgs e)
        {

            if (isCollapsed)
            {
              
                SideMenuPanel.Width = 250;
                foreach (Control control in SideMenuPanel.Controls)
                {
                    if (control is Button button)
                    {
                        button.Text = button.Tag?.ToString(); 
                    }
                }
                isCollapsed = false;
            }
            else
            {
                // تصغير القائمة
                SideMenuPanel.Width = 59;
                foreach (Control control in SideMenuPanel.Controls)
                {
                    if (control is Button button)
                    {
                        button.Tag = button.Text; 
                        button.Text = "";
                        hideSub();
                    }
                }
                isCollapsed = true;
            }
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            show();
        }

        private void EmergencyDepBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class searchPatientFrm : Form
    {
        private DockPanel dockPanel;
        public searchPatientFrm(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;
        }

        private void guna2ContainerControl3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            searchPatientView.MouseWheel += searchPatientView_MouseWheel;
            searchPatientView.Rows.Add("أحمد صالح", "771234567", 35, "صنعاء", "1001");
            searchPatientView.Rows.Add("سعاد محمد", "772345678", 28, "عدن", "1002");
            searchPatientView.Rows.Add("خالد عبد الله", "733456789", 42, "تعز", "1003");
            searchPatientView.Rows.Add("مريم أحمد", "774567890", 30, "إب", "1004");
            searchPatientView.Rows.Add("يوسف علي", "711234890", 50, "حضرموت", "1005");
            searchPatientView.Rows.Add("فاطمة سعيد", "733890123", 25, "الحديدة", "1006");
            searchPatientView.Rows.Add("عبد الرحمن عبد", "712345678", 39, "ذمار", "1007");
            searchPatientView.Rows.Add("ليلى جمال", "733567890", 33, "البيضاء", "1008");
            searchPatientView.Rows.Add("حسين عادل", "711567432", 47, "عمران", "1009");
            searchPatientView.Rows.Add("نور الهدى عمر", "774321789", 22, "المهرة", "1010");
            searchPatientView.Rows.Add("عبد الرحمن عبد", "712345678", 39, "ذمار", "1007");
            searchPatientView.Rows.Add("ليلى جمال", "733567890", 33, "البيضاء", "1008");
            searchPatientView.Rows.Add("حسين عادل", "711567432", 47, "عمران", "1009");
            searchPatientView.Rows.Add("نور الهدى عمر", "774321789", 22, "المهرة", "1010");
            UpdateScrollBar();


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            searchPatientView.FirstDisplayedScrollingRowIndex = guna2VScrollBar1.Value;
        }
        private void UpdateScrollBar()
        {
            if (searchPatientView.RowCount > 0)
            {
                guna2VScrollBar1.Maximum = searchPatientView.RowCount - 1;
                guna2VScrollBar1.LargeChange = searchPatientView.DisplayedRowCount(false);
                guna2VScrollBar1.SmallChange = 1;

                // تأكد أن القيمة الحالية ضمن النطاق
                if (guna2VScrollBar1.Value > guna2VScrollBar1.Maximum)
                {
                    guna2VScrollBar1.Value = guna2VScrollBar1.Maximum;
                }
            }
            else
            {
                guna2VScrollBar1.Maximum = 0;
                guna2VScrollBar1.LargeChange = 0;
                guna2VScrollBar1.SmallChange = 0;
            }
        }


        private void RemoveData()
        {
            if (searchPatientView.Rows.Count > 0)
            {
                searchPatientView.Rows.RemoveAt(0);
                UpdateScrollBar();
            }
        }
        private void searchPatientView_MouseWheel(object sender, MouseEventArgs e)
        {
            if (searchPatientView.RowCount > 0)
            {
                int scrollAmount = e.Delta > 0 ? -1 : 1; 
                int newValue = guna2VScrollBar1.Value + scrollAmount;

                if (newValue >= guna2VScrollBar1.Minimum && newValue <= guna2VScrollBar1.Maximum)
                {
                    guna2VScrollBar1.Value = newValue;
                    searchPatientView.FirstDisplayedScrollingRowIndex = guna2VScrollBar1.Value;
                }
            }
        }

       
        
    }
}

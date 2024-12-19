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
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

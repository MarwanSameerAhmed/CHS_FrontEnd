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

   
    public partial class patientAddingPage : Form
    {
        private DockPanel dockPanel;
        public patientAddingPage(DockPanel parentDockPanel)
        {
            InitializeComponent();
            this.dockPanel = parentDockPanel;

        }



        private TextBox CreateTextBox()
        {
            return new TextBox
            {
                Font = new Font("Segoe UI", 14F),
                Width=300,
                Height=100,
             
                Margin = new Padding(5),
                TextAlign = HorizontalAlignment.Left

            };
        }

        private DateTimePicker CreateDatePicker()
        {
            return new DateTimePicker
            {
                Font = new Font("Segoe UI", 14F),
                Dock = DockStyle.Fill,
                Format = DateTimePickerFormat.Short,
                Margin = new Padding(5),
                RightToLeft = RightToLeft.Yes
            };
        }

        private ComboBox CreateComboBox(string[] items)
        {
            ComboBox comboBox = new ComboBox
            {
                Font = new Font("Segoe UI", 14F),
                Dock = DockStyle.Left,
                Margin = new Padding(5),
                DropDownStyle = ComboBoxStyle.DropDownList,
                RightToLeft = RightToLeft.Yes
            };
            comboBox.Items.AddRange(items);
            return comboBox;
        }

        
        private Panel CreateCategory(string title, (string, Control)[] fields)
        {
            Panel categoryPanel = new Panel
            {
                BackColor = Color.AliceBlue,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                Padding = new Padding(10),
                Dock = DockStyle.Top,
                AutoSize = true
            };

          
            Label categoryTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(138)))), ((int)(((byte)(195))))),
                Dock = DockStyle.Top,
                Height = 40,
                Margin = new Padding(0, 0, 0, 10),
                TextAlign = ContentAlignment.MiddleLeft 
            };

            
            TableLayoutPanel categoryLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                AutoSize = true,
                Padding = new Padding(10)
            };

           
            categoryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F)); 
            categoryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F)); 

         
            foreach (var (labelText, control) in fields)
            {
                Label label = new Label
                {
                    Text = labelText,
                    Font = new Font("Segoe UI", 14F),
                    ForeColor = Color.Black,
                    TextAlign = ContentAlignment.MiddleLeft, 
                    Dock = DockStyle.Fill,
                    Margin = new Padding(5)
                };
                categoryLayout.Controls.Add(label);
                categoryLayout.Controls.Add(control);
            }

            categoryPanel.Controls.Add(categoryLayout);
            categoryPanel.Controls.Add(categoryTitle);
            return categoryPanel;
        }


        private TextBox CreateAutoCompleteTextBox(string[] suggestions)
        {
            TextBox textBox = new TextBox
            {
                Font = new Font("Segoe UI", 14F),
                Dock = DockStyle.Fill,
                Margin = new Padding(5),
                TextAlign = HorizontalAlignment.Left,
                AutoCompleteMode = AutoCompleteMode.SuggestAppend,
                AutoCompleteSource = AutoCompleteSource.CustomSource
            };

         
            AutoCompleteStringCollection autoSource = new AutoCompleteStringCollection();
            autoSource.AddRange(suggestions);
            textBox.AutoCompleteCustomSource = autoSource;

            return textBox;
        }







        private void textlabelinfo_Click(object sender, EventArgs e)
        {

        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

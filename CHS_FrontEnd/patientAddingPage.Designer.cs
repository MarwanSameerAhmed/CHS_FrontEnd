using System.Drawing;
using System.Windows.Forms;

namespace CHS_FrontEnd
{
    partial class patientAddingPage
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
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Text = " إضافة ملف طبي";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.FormBorderStyle = FormBorderStyle.None;

            Label titleLabel = new Label
            {
                Text = "إضافة ملف طبي جديد",
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(138)))), ((int)(((byte)(195))))),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 70,
               // Margin = new Padding(0, 10, 30,0 ),
            };
            this.Controls.Add(titleLabel);

         
            Label subtitleLabel = new Label
            {
                Text = "تتيح هذه الصفحة إضافة بيانات المريض الشخصية والطبية بسهولة، \nمع تصنيفات واضحة تساعد في سرعة الادخال ، تاكد من ادخال البيانات بعناية",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.Gray,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 80,
                Margin = new Padding(0, 10, 0, 10),
               
                

            };

          
            Panel cardPanel = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };

          
            TableLayoutPanel mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3,
                Padding = new Padding(10),
                AutoScroll = true,
            };

            
            mainLayout.Controls.Add(CreateCategory("المعلومات الشخصية", new (string, Control)[]
            {
        ("اسم المريض:", CreateTextBox()),
        ("رقم الهاتف:", CreateTextBox()),
        ("مكان الإقامة:", CreateTextBox()),
        ("مكان الميلاد:", CreateTextBox()),
        ("تاريخ الميلاد:", CreateDatePicker()),
        ("العمر:", CreateTextBox())
            }));


            mainLayout.Controls.Add(CreateCategory("المعلومات الطبية", new (string, Control)[]
            {
    ("فصيلة الدم:", CreateComboBox(new[] { "A", "B", "AB", "O" })),
    ("الأمراض المزمنة:", CreateAutoCompleteTextBox(new[] { "السكري", "الضغط", "الربو", "أمراض القلب" })),
    ("الأدوية الحالية:", CreateAutoCompleteTextBox(new[] { "بانادول", "أوغمنتين", "بروفين", "باراسيتامول" }))
            }));

            mainLayout.Controls.Add(CreateCategory("معلومات إضافية", new (string, Control)[]
            {
    ("اسم الوصي:", CreateAutoCompleteTextBox(new[] { "محمد", "علي", "أحمد", "فاطمة", "سارة" })),
    ("الحالة الاجتماعية:", CreateComboBox(new[] { "أعزب", "متزوج", "مطلق", "أرمل" }))
            }));

            
            Button saveButton = new Button
            {
                Text = "إضافة",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155))))),
                ForeColor = Color.White,
                Height = 50,
                Dock = DockStyle.Bottom,
                Width = 200,
                Margin = new Padding(10,10,10,10)
            };
            saveButton.Click += (s, e) => MessageBox.Show("تم الحفظ بنجاح!");

            
            cardPanel.Controls.Add(mainLayout);
            this.Controls.Add(cardPanel);
            this.Controls.Add(saveButton);
            this.Controls.Add(subtitleLabel);
            this.Controls.Add(titleLabel);
        }



        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox birthPlaceTextBox;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.ComboBox maritalStatusComboBox;
        private System.Windows.Forms.TextBox guardianNameTextBox;
        private System.Windows.Forms.ComboBox bloodTypeComboBox;
        private System.Windows.Forms.TextBox chronicDiseasesTextBox;
        private System.Windows.Forms.TextBox allergiesTextBox;
        private System.Windows.Forms.TextBox medicationsTextBox;
        private System.Windows.Forms.Button saveButton;
        private TableLayoutPanel formPanel;
    }


}
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHS_FrontEnd
{
    public partial class MainServicePage : Form
    {
        public MainServicePage()
        {
            InitializeComponent();
        }

        private void MainPageLogo_Load(object sender, EventArgs e)
        {
            AddButton("البحث عن ملف طبي", FontAwesome.Sharp.IconChar.Search);
            AddButton("إضافة ملف طبي جديد", FontAwesome.Sharp.IconChar.FileMedical);
            AddButton("البحث عن موظف", FontAwesome.Sharp.IconChar.Search);
            AddButton("الإعدادات", FontAwesome.Sharp.IconChar.Cogs);
            AddButton("قسم الأطباء", FontAwesome.Sharp.IconChar.UserMd);
        }


        private void AddButton(string text, FontAwesome.Sharp.IconChar icon)
        {
            // إنشاء زر جديد
            IconButton button = new IconButton
            {
                Text = text,
                IconChar = icon, 
                IconColor = Color.White, 
                IconSize = 60, 
                Dock = DockStyle.None, 
                Width = 160, 
                Height = 160, 
                TextAlign = ContentAlignment.BottomCenter, 
                ImageAlign = ContentAlignment.TopCenter,
                FlatStyle = FlatStyle.Flat, 
                Padding = new Padding(10, 15, 10, 20), 
                BackColor = Color.FromArgb(60, 138, 195), 
                ForeColor = Color.White, 
                Font = new Font("Segoe UI", 12, FontStyle.Bold), 
            };

            
            button.FlatAppearance.BorderSize = 0;

            // استخدام GraphicsPath لتحديد الزوايا الدائرية
            button.Paint += (sender, e) =>
            {
                GraphicsPath path = new GraphicsPath();
                int radius = 30; // قيمة نصف قطر الحدود الدائرية
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(button.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(button.Width - radius - 1, button.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, button.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();
                button.Region = new Region(path); // تعيين المنطقة للزر لجعله ذو حواف دائرية
            };

            
            button.MouseHover += (sender, args) =>
            {
                button.BackColor = Color.FromArgb(1, 87, 155); 
                button.ForeColor = Color.LightGray; 
            };
            button.MouseLeave += (sender, args) =>
            {
                button.BackColor = Color.FromArgb(60, 138, 195); 
                button.ForeColor = Color.White; 
            };

         
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(1,87,155); 
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 87, 155); 

           
     

           
            panelButtons.Controls.Add(button);
        }
    }
    }


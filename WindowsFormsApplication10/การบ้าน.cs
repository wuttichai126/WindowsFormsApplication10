using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans = ("สรุปความพึงพอใจ " + Environment.NewLine);
            if (radioButton1.Checked == true)
            {
                ans = ans + "เพศ  :  ชาย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "เพศ  :  หญิง" + Environment.NewLine;
            }
            if (radioButton3.Checked == true)
            {
                ans = ans + "สถานภาพ  :  โสด" + Environment.NewLine;
            }
            else if (radioButton4.Checked == true)
            {
                ans = ans + "สถานภาพ  :  สมรส" + Environment.NewLine;
            }
            else
            {
                ans = ans + "สถานภาพ  :  หย่าร้าง/แยกกันอยู่" + Environment.NewLine;
            }
            if (radioButton6.Checked == true)
            {
                ans = ans + "ระดับการศึกษา  :  มัธยมศึกษา" + Environment.NewLine;
            }
            else if (radioButton7.Checked == true)
            {
                ans = ans + "ระดับการศึกษา  :  ปริญญาตรี" + Environment.NewLine;
            }
            else if (radioButton8.Checked == true)
            {
                ans = ans + "ระดับการศึกษา  :  ปริญญาโท" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ระดับการศึกษา  :  ปริญญาเอก" + Environment.NewLine;
            }
            if (radioButton10.Checked == true)
            {
                ans = ans + "อายุ  :  น้อยกว่า15 ปี" + Environment.NewLine;
            }
            else if (radioButton11.Checked == true)
            {
                ans = ans + "อายุ  :  15 -18 ปี" + Environment.NewLine;
            }
            else if (radioButton12.Checked == true)
            {
                ans = ans + "อายุ  :  19 -25 ปี" + Environment.NewLine;
            }
            else
            {
                ans = ans + "อายุ  :  มากกว่า 25 ปี" + Environment.NewLine;
            }
            ans = ans + "คุณใช้บริการบ่อยแค่ไหน : ";
            if (radioButton14.Checked == true)
            {
                ans = ans + "บ่อยมาก" + Environment.NewLine;
            }
            else if (radioButton15.Checked == true)
            {
                ans = ans + "บ่อย" + Environment.NewLine;
            }
            else if (radioButton16.Checked == true)
            {
                ans = ans + "พอสมควร" + Environment.NewLine;
            }
            else if (radioButton17.Checked == true)
            {
                ans = ans + "น้อย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ไม่เคย" + Environment.NewLine;
            } 
            ans = ans + "จำนวนพนักงานเพียงพอกับการให้บริการมั้ย : ";
            if (radioButton19.Checked == true)
            {
                ans = ans + "มากเกินไป" + Environment.NewLine;
            }
            else if (radioButton20.Checked == true)
            {
                ans = ans + "มาก" + Environment.NewLine;
            }
            else if (radioButton21.Checked == true)
            {
                ans = ans + "พอดี" + Environment.NewLine;
            }
            else if (radioButton22.Checked == true)
            {
                ans = ans + "น้อย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "น้อยเกินไป" + Environment.NewLine;
            } 
            ans = ans + "การบริการของพนักงาน : ";
            if (radioButton24.Checked == true)
            {
                ans = ans + "ดีมาก" + Environment.NewLine;
            }
            else if (radioButton25.Checked == true)
            {
                ans = ans + "ดี" + Environment.NewLine;
            }
            else if (radioButton26.Checked == true)
            {
                ans = ans + "พอใช้" + Environment.NewLine;
            }
            else if (radioButton27.Checked == true)
            {
                ans = ans + "แย่" + Environment.NewLine;
            }
            else
            {
                ans = ans + "แย่มาก" + Environment.NewLine;
            } 
            ans = ans + "ปริมาณสินค้าเพียงพอกับการให้บริการมั้ย : ";
            if (radioButton29.Checked == true)
            {
                ans = ans + "มากเกินไป" + Environment.NewLine;
            }
            else if (radioButton30.Checked == true)
            {
                ans = ans + "มาก" + Environment.NewLine;
            }
            else if (radioButton31.Checked == true)
            {
                ans = ans + "พอดี" + Environment.NewLine;
            }
            else if (radioButton32.Checked == true)
            {
                ans = ans + "น้อย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "น้อยเกินไป" + Environment.NewLine;
            } 
            ans = ans + "ความพึงพอใจกับ 7-11 ภายในมหาลัย : ";
            if (radioButton34.Checked == true)
            {
                ans = ans + "ดีมาก" + Environment.NewLine;
            }
            else if (radioButton35.Checked == true)
            {
                ans = ans + "ดี" + Environment.NewLine;
            }
            else if (radioButton36.Checked == true)
            {
                ans = ans + "พอใช้" + Environment.NewLine;
            }
            else if (radioButton37.Checked == true)
            {
                ans = ans + "แย่" + Environment.NewLine;
            }
            else
            {
                ans = ans + "แย่มาก" + Environment.NewLine;
            }
            ans = ans + "จัดทำโดย นาย วุฒิชัย บุญแนบ 553266126";
            MessageBox.Show(ans, "คำตอบของคุณ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(Tx1.Text);
            int input2 = int.Parse(Tx2.Text);
            int resuft = 0;
            if(Cb1.Checked == true)
            {
                resuft = USCLN(input1, input2);
            }
            else
            {
                Console.WriteLine("Lỗi");
            }
            if (Cb2.Checked == true)
            {
                resuft = BSCNN(input1, input2);
            }
            else
            {
                Console.WriteLine("Lỗi");
            }
            Tx3.Text = resuft.ToString();
        }
        private int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        // ✅ Hàm tính Bội số chung nhỏ nhất (LCM)
        private int BSCNN(int a, int b)
        {
            return Math.Abs(a * b) / USCLN(a, b);
        }

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {
            Tx1.Text = "";
            Tx2.Text = "";
            Tx3.Text = "";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void Cb1_CheckedChanged(object sender, EventArgs e)
        {
            if(Cb2.Checked == true)
            {
                Cb2.Checked = false;
                
            }
        }

        private void Cb2_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb1.Checked == true)
            {
                Cb1.Checked = false;
               
            }
        }
    }
}

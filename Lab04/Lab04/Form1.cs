using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Cb2_Makewhite1213123 : Form
    {
       
        

        public Cb2_Makewhite1213123()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TinhTong_Click(object sender, EventArgs e)
        {
            if(Tx_Top.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Tên ?", "Tiêu đề thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            int cb1Price = 0;
            if(Cb1_Clean.Checked == true)
            {
                cb1Price = 100;
            }
            int cb2Price = 0;
            if (Cb2_MakeWhite.Checked == true)
            {
                cb2Price = 1200;
            }
            int cb3Price = 0;
            if (Cb1_Clean.Checked == true)
            {
                cb3Price = 200;
            }
            int priceTramRang = (int)numberV.Value*800;
            int sumMoney = cb1Price + cb2Price + cb3Price + priceTramRang;
            MessageBox.Show("Hóa Dơn Khách Hàng "+Tx_Top.Text+" Là "+"$"+sumMoney.ToString(), "1"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            Tb2_TongTien.Text ="$"+sumMoney.ToString();
        }
    }
}

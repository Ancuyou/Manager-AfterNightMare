using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Manager
{
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }
        void SelectTxt(Guna2TextBox txt)
        {
            txt.BackColor = Color.FromArgb(139, 199, 255);
        }
        void SelectTxt(Guna2ComboBox txt)
        {
            txt.BackColor = Color.FromArgb(139, 199, 255);
        }
        void LeaveTxt(Guna2TextBox txt)
        {
            txt.BackColor = Color.White;
        }
        void LeaveTxt(Guna2ComboBox txt)
        {
            txt.BackColor = Color.White;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            timer.Start();
            tbpnlTop.Enabled = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SelectTxt(txtName);
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTxt(cbbCategory);
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            SelectTxt(txtPrice);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            LeaveTxt(txtName);
        }

        private void cbbCategory_Leave(object sender, EventArgs e)
        {
            LeaveTxt(cbbCategory);
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            LeaveTxt(txtPrice);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            timer.Start();
            tbpnlTop.Enabled = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            timer.Start();
            tbpnlTop.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pnlEditProduct.Width == 470)
            {
                tblEditProduct.Visible = false;
                for (int i = 0; i < 10; i++)
                {
                    pnlEditProduct.Width = pnlEditProduct.Width - 47;
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    pnlEditProduct.Width = pnlEditProduct.Width + 47;
                }
                tblEditProduct.Visible = true;
            }
            timer.Stop();
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {
            pnlEditProduct.Width = 0;
            dgvProduct.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvProduct.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);

            dgvProduct.Rows.Add(new object[] { "001", "Apple", "Fruit", "10.00", "100" });
            dgvProduct.Rows.Add(new object[] { "002", "Banana", "Fruit", "8.00", "120" });
            dgvProduct.Rows.Add(new object[] { "003", "Chicken Breast", "Meat", "15.00", "50" });
            dgvProduct.Rows.Add(new object[] { "004", "Salmon", "Fish", "20.00", "30" });
            dgvProduct.Rows.Add(new object[] { "005", "Milk", "Dairy", "5.00", "60" });
            dgvProduct.Rows.Add(new object[] { "006", "Carrots", "Vegetable", "3.00", "200" });
            dgvProduct.Rows.Add(new object[] { "007", "Orange", "Fruit", "9.00", "80" });
            dgvProduct.Rows.Add(new object[] { "008", "Beef", "Meat", "18.00", "40" });
            dgvProduct.Rows.Add(new object[] { "009", "Cheese", "Dairy", "12.00", "70" });
            dgvProduct.Rows.Add(new object[] { "010", "Broccoli", "Vegetable", "4.50", "150" });
        }
    }
}

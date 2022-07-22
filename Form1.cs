using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var stringNumber = txt_Number.Text;
            int isNumeric = 0;
            bool isNumber = int.TryParse(stringNumber, out isNumeric);

            if (isNumber)
            {
                MessageBox.Show("Inventory Number: " + txt_InvNum.Text + "\n"
                            + "Number: " + txt_Number.Text + "\n"
                            + "Item Name: " + txt_Name.Text + "\n"
                            + "Counnt: " + txt_count.Text + "\n"
                            + "Price: " + txt_price.Text + "\n"
                            + "Date: " + DateTime.Now.ToString() + "\n"
                            + "\t" + "Product Successfully Added.");
            }
            else
            {
                MessageBox.Show("Invalid Input!!!");
            }

        }

        private void txt_Number_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

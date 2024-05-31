using System;
using System.Windows.Forms;
using frmLoginAccount;

namespace frmLoginAccount
{
    public partial class Form1 : Form
    {
        private double totalAmount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = textBox1.Text;
                double itemPrice = Convert.ToDouble(textBox2.Text);
                double itemDiscount = Convert.ToDouble(textBox3.Text) * 0.01;
                int itemQuantity = Convert.ToInt32(textBox4.Text);

                DiscountedItem discountItem = new DiscountedItem(itemName, itemPrice, itemQuantity, itemDiscount);
                totalAmount = discountItem.getTotalPrice();
                label5.Text = totalAmount.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double paymentReceived = Convert.ToDouble(textBox5.Text);

                DiscountedItem discountItem = new DiscountedItem("", 0, 0, 0);
                discountItem.setPayment(paymentReceived);
                double change = discountItem.getChange(totalAmount);
                label7.Text = change.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
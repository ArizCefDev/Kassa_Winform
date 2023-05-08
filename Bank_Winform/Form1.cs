using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Product p = new Product();
        decimal total = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "122")
            {
                object[] list = { p.Name = "Lays", p.Price = 2.99M };

                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
                total = total + p.Price;

            }
            else if (textBox1.Text == "123")
            {
                object[] list = { p.Name = "Coca-cola", p.Price = 1.19M };

                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }

                total = total + p.Price;
            }

            else if (textBox1.Text == "342")
            {
                object[] list = { p.Name = "Kurassan", p.Price = 1.39M };

                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }

                total = total + p.Price;
            }
            label3.Text = total.ToString() + " " + "manat";

            QRCodeEncoder encoder = new QRCodeEncoder();
            pictureBox1.Image = encoder.Encode(textBox1.Text);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "122: Lays \n " +
                "123: Coca-Cola \n" +
                "342: Kurassan \n"
                );
        }

        private void button12_Click(object sender, EventArgs e)
        {

            decimal money = Convert.ToDecimal(textBox2.Text);

            if (money < total)
            {
                label4.Visible = true;
                label4.Text = "Ödəniləcək məbləğ tutardan az ola bilməz";
                label5.ForeColor = Color.Red;
                label5.Text = money.ToString() + " " + "manat";
            }
            else
            {
                decimal res = money - total;
                label7.Text = res.ToString() + " " + "manat";
                label4.Visible = false;
                label5.ForeColor = Color.White;
                label5.Text = money.ToString() + " " + "manat";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }
    }
}


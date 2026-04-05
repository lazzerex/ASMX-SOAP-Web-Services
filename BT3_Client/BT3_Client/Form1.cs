using BT3_Client.ServiceReference2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            var result = client.HelloWorld(textBox1.Text);
            textBox2.Text = result;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            int b = int.Parse(textBox4.Text);
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            var kq = client.AddCalculator(a, b).ToString();
            MessageBox.Show("Ket qua: " + kq);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            int b = int.Parse(textBox4.Text);
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            var kq = client.SubtractCalculator(a, b).ToString();
            MessageBox.Show("Ket qua: " + kq);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            int b = int.Parse(textBox4.Text);
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            var kq = client.MultiplyCalculator(a, b).ToString();
            MessageBox.Show("Ket qua: " + kq);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            int b = int.Parse(textBox4.Text);
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            var kq = client.DivideCalculator(a, b).ToString();
            MessageBox.Show("Ket qua: " + kq);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ServiceReference2.TempConvertSoapClient client = new ServiceReference2.TempConvertSoapClient("TempConvertSoap");
            var f = client.CelsiusToFahrenheit(textBox5.Text);
            MessageBox.Show($"{textBox5.Text} C = {f} F");
        }
    }
}

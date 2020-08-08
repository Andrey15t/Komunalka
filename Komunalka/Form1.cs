using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Komunalka
{
    public partial class Form1 : Form
    {

        int pe, pw, pg;
        double te, tw, tg;

        StreamWriter file = new StreamWriter(@"C:\Komunalka.txt");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // List<String> s = new List<String>() { };
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pe = Convert.ToInt32(textBox1.Text);
                te = Convert.ToDouble(textBox2.Text);

                pw = Convert.ToInt32(textBox3.Text);
                tw = Convert.ToDouble(textBox4.Text);

                pg = Convert.ToInt32(textBox6.Text);
                tg = Convert.ToDouble(textBox5.Text);

                Electrical el = new Electrical(pe, te);
                Water wa = new Water(pw, tw);
                Gas ga = new Gas(pg, tg);

                Summa sa = new Summa();


                listBox1.Items.Add("\n-------------------------------------------------------------------------------------------------");
                listBox1.Items.Add("\nСумма за электричество: " + Math.Round((el.getSum()),2).ToString());
                listBox1.Items.Add("\nСумма за воду: " + Math.Round(wa.getSum(),2).ToString());
                listBox1.Items.Add("\nСумма за газ: " + Math.Round(ga.getSum(),2).ToString());
                listBox1.Items.Add(Environment.NewLine);
                listBox1.Items.Add(Environment.NewLine);
                listBox1.Items.Add("\n-------------------------------------------------------------------------------------------------");
                listBox1.Items.Add("\nОбщая сумма за комуналку: " + Math.Round((sa.getSumma(el.getSum(), wa.getSum(), ga.getSum())),2).ToString());
                listBox1.Items.Add("\n-------------------------------------------------------------------------------------------------");
                listBox1.Items.Add(Environment.NewLine);
                listBox1.Items.Add(Environment.NewLine);
                listBox1.Items.Add(Environment.NewLine);
                listBox1.Items.Add(Environment.NewLine);

    

                file.Write(Math.Round((el.getSum()), 2).ToString());
                file.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка!!! Неправильный формат данных введен!");
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

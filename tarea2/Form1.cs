using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Button2_Click(object sender, EventArgs e)
        {
            string luki = textBox1.Text;
            MessageBox.Show("Holaa, " + luki);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rojo");

        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Azul");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verde");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amarillo");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Morado");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naranja");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rosa");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}

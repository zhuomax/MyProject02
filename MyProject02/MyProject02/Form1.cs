using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = float.Parse(textBox1.Text);
            var y = float.Parse(textBox2.Text);
            var z = float.Parse(textBox3.Text);
            if (x + y > z && x + z > y && y + z > x)
            {
                var p = (x + y + z) / 2;
                var s = System.Math.Sqrt(p * (p - x) * (p - y) * (p - z));
                this.label5.Text = s.ToString();
            }
            else
            {
                this.label5.Text = "无法求得";
                this.label6.Text = "（三边无法构成三角形）";
            }
        }
    }
}

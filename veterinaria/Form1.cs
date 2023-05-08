using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           cliente objfrm = new cliente();
            objfrm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mascota objfrm  = new mascota();
            objfrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vacuna objfrm = new vacuna();
            objfrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            desp objfrm = new desp();
            objfrm.Show();
        }
    }
}

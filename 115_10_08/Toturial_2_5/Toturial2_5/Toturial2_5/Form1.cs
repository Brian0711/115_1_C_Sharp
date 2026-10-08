using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toturial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CardBackpictureBox.Visible = true;
            CardFacepictureBox.Visible = false;
        }

        private void Showfacebutton1_Click(object sender, EventArgs e)
        {
            CardBackpictureBox.Visible = false;
            CardFacepictureBox.Visible = true;
        }
    }
}

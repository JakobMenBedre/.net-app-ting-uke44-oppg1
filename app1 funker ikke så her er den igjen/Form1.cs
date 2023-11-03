using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1_funker_ikke_så_her_er_den_igjen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void knapp_Click(object sender, EventArgs e)
        {
            tekst.Text = "HEI VERDEN!!!";
        }
    }
}

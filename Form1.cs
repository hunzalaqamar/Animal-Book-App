using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_Q2
{
    public partial class zooAppCoverForm : Form
    {
        public zooAppCoverForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_zooCoverForm_Click(object sender, EventArgs e)
        {
            AnimalsForm AF = new AnimalsForm();
            AF.Show();
            this.Hide();

        }

        private void btn2_zooCoverForm_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void zooAppCoverForm_Load(object sender, EventArgs e)
        {

        }
    }
}

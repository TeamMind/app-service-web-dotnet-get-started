using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindOptimizerWeatherApp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnWeatherAPI_Click(object sender, EventArgs e)
        {
            Form1 weatherForm = new Form1();
            weatherForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 weatherForm = new Form1();
            weatherForm.Show();
        }
    }
}

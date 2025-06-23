using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstEmployeeDesktop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show(); 
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginPage h = new LoginPage();
            h.Show();    
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View v = new View();
            v.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           
            LoginPage Form = new LoginPage();
            Form.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AttandanceGrid at = new AttandanceGrid();
            at.Show();
            this.Hide();
        }
    }
}

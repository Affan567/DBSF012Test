using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbProject
{
    public partial class StudentVisitorForm : StudentHeader
    {
        public StudentVisitorForm()
        {
            InitializeComponent();
        }

        private void StudentVisitorForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            dll.BL.Student v = new dll.BL.Student();
            v.GetRegNO();


            //dataGridView1.DataSource = dt;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

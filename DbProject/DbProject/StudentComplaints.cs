using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dll;
using dll.BL;

namespace DbProject
{
    public partial class StudentComplaints : StudentHeader
    {
        public StudentComplaints()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {
            dll.BL.Complaints c = new dll.BL.Complaints();
            int userID = Login.GetUserID();
            DataTable dt = c.GetComplaint(userID);

            dataGridView1.DataSource = dt;



            //// Add Delete Button Column
            //if (!dataGridView1.Columns.Contains("btnDelete"))
            //{
            //    DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();

            //    btnDelete.FlatStyle = FlatStyle.Flat;
            //    btnDelete.HeaderText = "Delete Course";
            //    btnDelete.Text = "Delete";
            //    btnDelete.Name = "btnDelete";
            //    btnDelete.UseColumnTextForButtonValue = true;
            //    btnDelete.DefaultCellStyle.BackColor = Color.Red;
            //    btnDelete.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            //    dataGridView1.Columns.Add(btnDelete);
            //}
        }
        private void StudentComplaints_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtTheme_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

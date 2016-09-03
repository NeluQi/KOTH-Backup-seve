using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace MultiUser_Steam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddSteam_Click(object sender, EventArgs e)
        {
            string login = textLogin.Text;
            string pass = textPass.Text;

            dataGridView1.Rows.Add(login, pass);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int ind = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(ind);
            }
        }
    }
}

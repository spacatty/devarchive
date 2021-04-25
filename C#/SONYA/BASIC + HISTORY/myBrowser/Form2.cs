using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myBrowser
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;
        public Form2(Form1 sharedForm)
        {
            InitializeComponent();
            dataGridView1.Rows.Add("www.google.com");
            mainForm = sharedForm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void initRow(string Row)
        {
            dataGridView1.Rows.Add(Row.ToString());
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mainForm.navigateFromHistory(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString());
        }
    }   
}

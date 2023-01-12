using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pharmacy_managemint.BL;
namespace pharmacy_managemint.PL
{
    public partial class FRM_CATEGORYMANAGEMENT : Form
    {
        public FRM_CATEGORYMANAGEMENT()
        {
            InitializeComponent();
            btnSelectALL_Click(null, null);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
        private void FRM_CATEGORYMANAGEMENT_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectALL_Click(object sender, EventArgs e)
        {
            DataTable dT = CLASS_CATEGORY.SP_SELECTALLCATEGGORIES();
            dgvCatigories.DataSource = dT;
        }
        
        private void dgvCatigories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void dgvCatigories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCatID.Text = dgvCatigories.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCatNAME.Text = dgvCatigories.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (txtSearech.Text == String.Empty)
            {
                MessageBox.Show("يجب ادخال الكلمة المراد البحث عنها");
                return;
            }
            DataTable dt = CLASS_CATEGORY.SP_SEARCHCATEGORIES(txtSearech.Text);
            dgvCatigories.DataSource = dt;
        }

       /* public static int SP_UPDATECATEGORE(int CATID,String CATNAME)
        {
            
        }*/
    }
}

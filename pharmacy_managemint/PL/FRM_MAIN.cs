using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pharmacy_managemint.PL
{
    public partial class FRM_MAIN : Form
    {
        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void ادارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TSMTypesManagement_Click(object sender, EventArgs e)
        {
            FRM_CATEGORYMANAGEMENT cat = new FRM_CATEGORYMANAGEMENT();
            cat.ShowDialog();
        }

        private void TSMAddProduct_Click(object sender, EventArgs e)
        {
            FRM_ADDNEWPRODUCT ADP = new FRM_ADDNEWPRODUCT();
                ADP.ShowDialog();
        }

        private void TSMProductManagement_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTMANAGEMENT pro = new FRM_PRODUCTMANAGEMENT();
            pro.ShowDialog();
        }

        private void TSMAddTypesnew_Click(object sender, EventArgs e)
        {
            FRM_ADDCATEGORY cat = new FRM_ADDCATEGORY();
            cat.ShowDialog();
        }
    }
}

﻿using System;
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
    public partial class FRM_ADDCATEGORY : Form
    {
        public FRM_ADDCATEGORY()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == string.Empty)
            {
                MessageBox.Show("يحب ادخال اسم الصنف");
                return;
            }
           int i= CLASS_CATEGORY.SP_ADDNEWCATEGORY(txtCategory.Text);
            MessageBox.Show("تم اضافة عدد" + i + "من الصفوف");
            txtCategory.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}

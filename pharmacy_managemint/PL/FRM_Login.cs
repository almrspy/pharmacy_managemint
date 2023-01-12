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
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUName.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال اسم المستخدم");
                return;
            }
            if(txtUPass.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال كلمة المرور");
                return;
            }
            DataTable dt = CLASS_LOGIN.SpLogin(txtUName.Text, txtUPass.Text);
            if (dt.Rows.Count>0)
                MessageBox.Show("تم الدخول بنجاح");
            else
                MessageBox.Show("اسم المستخدم او كلمة المرور خاطئة");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_MAIN min = new FRM_MAIN();
            min.ShowDialog();
        }
    }
}

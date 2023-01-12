namespace pharmacy_managemint.PL
{
    partial class FRM_MAIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMProductManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMTypesManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddTypesnew = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCostomer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCustomersManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddCustomerNew = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMBuyManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMNewBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSuppliersManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMSellsManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNewSell = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMUsersManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("PT Bold Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMFile,
            this.TSMProduct,
            this.TSMCostomer,
            this.TSMSuppliers,
            this.TSMUsers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 43);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMFile
            // 
            this.TSMFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMLogin,
            this.TSMClose,
            this.toolStripSeparator1,
            this.TSMBackup,
            this.TSMRestore});
            this.TSMFile.Name = "TSMFile";
            this.TSMFile.Size = new System.Drawing.Size(63, 39);
            this.TSMFile.Text = "ملف";
            // 
            // TSMLogin
            // 
            this.TSMLogin.Name = "TSMLogin";
            this.TSMLogin.Size = new System.Drawing.Size(217, 40);
            this.TSMLogin.Text = "تسجيل الدحول";
            // 
            // TSMClose
            // 
            this.TSMClose.Name = "TSMClose";
            this.TSMClose.Size = new System.Drawing.Size(217, 40);
            this.TSMClose.Text = "تسجيل الخروج";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // TSMBackup
            // 
            this.TSMBackup.Name = "TSMBackup";
            this.TSMBackup.Size = new System.Drawing.Size(217, 40);
            this.TSMBackup.Text = "Backup";
            // 
            // TSMRestore
            // 
            this.TSMRestore.Name = "TSMRestore";
            this.TSMRestore.Size = new System.Drawing.Size(217, 40);
            this.TSMRestore.Text = "Restore";
            // 
            // TSMProduct
            // 
            this.TSMProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMProductManagement,
            this.TSMAddProduct,
            this.toolStripSeparator2,
            this.TSMTypesManagement,
            this.TSMAddTypesnew});
            this.TSMProduct.Name = "TSMProduct";
            this.TSMProduct.Size = new System.Drawing.Size(91, 39);
            this.TSMProduct.Text = "المنتجات";
            // 
            // TSMProductManagement
            // 
            this.TSMProductManagement.Name = "TSMProductManagement";
            this.TSMProductManagement.Size = new System.Drawing.Size(238, 40);
            this.TSMProductManagement.Text = "ادارة المنتجات";
            this.TSMProductManagement.Click += new System.EventHandler(this.TSMProductManagement_Click);
            // 
            // TSMAddProduct
            // 
            this.TSMAddProduct.Name = "TSMAddProduct";
            this.TSMAddProduct.Size = new System.Drawing.Size(238, 40);
            this.TSMAddProduct.Text = "اضاقة منتج جديد";
            this.TSMAddProduct.Click += new System.EventHandler(this.TSMAddProduct_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(235, 6);
            // 
            // TSMTypesManagement
            // 
            this.TSMTypesManagement.Name = "TSMTypesManagement";
            this.TSMTypesManagement.Size = new System.Drawing.Size(238, 40);
            this.TSMTypesManagement.Text = "ادارة الاصناف";
            this.TSMTypesManagement.Click += new System.EventHandler(this.TSMTypesManagement_Click);
            // 
            // TSMAddTypesnew
            // 
            this.TSMAddTypesnew.Name = "TSMAddTypesnew";
            this.TSMAddTypesnew.Size = new System.Drawing.Size(238, 40);
            this.TSMAddTypesnew.Text = "اضافة صنف جديد";
            this.TSMAddTypesnew.Click += new System.EventHandler(this.TSMAddTypesnew_Click);
            // 
            // TSMCostomer
            // 
            this.TSMCostomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMCustomersManagement,
            this.TSMAddCustomerNew,
            this.TSMBuyManagment,
            this.toolStripSeparator3,
            this.TSMNewBuy});
            this.TSMCostomer.Name = "TSMCostomer";
            this.TSMCostomer.Size = new System.Drawing.Size(81, 39);
            this.TSMCostomer.Text = "العملاء";
            // 
            // TSMCustomersManagement
            // 
            this.TSMCustomersManagement.Name = "TSMCustomersManagement";
            this.TSMCustomersManagement.Size = new System.Drawing.Size(238, 40);
            this.TSMCustomersManagement.Text = "ادارة العملاء";
            // 
            // TSMAddCustomerNew
            // 
            this.TSMAddCustomerNew.Name = "TSMAddCustomerNew";
            this.TSMAddCustomerNew.Size = new System.Drawing.Size(238, 40);
            this.TSMAddCustomerNew.Text = "اضافة عميل جديد";
            // 
            // TSMBuyManagment
            // 
            this.TSMBuyManagment.Name = "TSMBuyManagment";
            this.TSMBuyManagment.Size = new System.Drawing.Size(238, 40);
            this.TSMBuyManagment.Text = "ادارة المبيعات";
            this.TSMBuyManagment.Click += new System.EventHandler(this.ادارةالمبيعاتToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(235, 6);
            // 
            // TSMNewBuy
            // 
            this.TSMNewBuy.Name = "TSMNewBuy";
            this.TSMNewBuy.Size = new System.Drawing.Size(238, 40);
            this.TSMNewBuy.Text = "عملية بيع جديدة";
            // 
            // TSMSuppliers
            // 
            this.TSMSuppliers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMSuppliersManagement,
            this.TSMAddSupplier,
            this.toolStripSeparator4,
            this.TSMSellsManagement,
            this.TSMNewSell});
            this.TSMSuppliers.Name = "TSMSuppliers";
            this.TSMSuppliers.Size = new System.Drawing.Size(88, 39);
            this.TSMSuppliers.Text = "الموردين";
            // 
            // TSMSuppliersManagement
            // 
            this.TSMSuppliersManagement.Name = "TSMSuppliersManagement";
            this.TSMSuppliersManagement.Size = new System.Drawing.Size(241, 40);
            this.TSMSuppliersManagement.Text = "ادارة الموردين";
            // 
            // TSMAddSupplier
            // 
            this.TSMAddSupplier.Name = "TSMAddSupplier";
            this.TSMAddSupplier.Size = new System.Drawing.Size(241, 40);
            this.TSMAddSupplier.Text = "اضافة مورد جديد";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(238, 6);
            // 
            // TSMSellsManagement
            // 
            this.TSMSellsManagement.Name = "TSMSellsManagement";
            this.TSMSellsManagement.Size = new System.Drawing.Size(241, 40);
            this.TSMSellsManagement.Text = "ادارة المشتريات";
            // 
            // TSMNewSell
            // 
            this.TSMNewSell.Name = "TSMNewSell";
            this.TSMNewSell.Size = new System.Drawing.Size(241, 40);
            this.TSMNewSell.Text = "عملية شراء جديدة";
            // 
            // TSMUsers
            // 
            this.TSMUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMUsersManagement,
            this.TSMAddNewUser,
            this.toolStripSeparator5});
            this.TSMUsers.Name = "TSMUsers";
            this.TSMUsers.Size = new System.Drawing.Size(116, 39);
            this.TSMUsers.Text = "المستخدمين";
            // 
            // TSMUsersManagement
            // 
            this.TSMUsersManagement.Name = "TSMUsersManagement";
            this.TSMUsersManagement.Size = new System.Drawing.Size(262, 40);
            this.TSMUsersManagement.Text = "ادارة المستخدمين";
            // 
            // TSMAddNewUser
            // 
            this.TSMAddNewUser.Name = "TSMAddNewUser";
            this.TSMAddNewUser.Size = new System.Drawing.Size(262, 40);
            this.TSMAddNewUser.Text = "اضافة مستخدم جديد";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(259, 6);
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_MAIN";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مشروع مبيعات ومشتريات صيدلية";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMFile;
        private System.Windows.Forms.ToolStripMenuItem TSMLogin;
        private System.Windows.Forms.ToolStripMenuItem TSMClose;
        private System.Windows.Forms.ToolStripMenuItem TSMProduct;
        private System.Windows.Forms.ToolStripMenuItem TSMCostomer;
        private System.Windows.Forms.ToolStripMenuItem TSMSuppliers;
        private System.Windows.Forms.ToolStripMenuItem TSMUsers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMBackup;
        private System.Windows.Forms.ToolStripMenuItem TSMRestore;
        private System.Windows.Forms.ToolStripMenuItem TSMProductManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMAddProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMTypesManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMAddTypesnew;
        private System.Windows.Forms.ToolStripMenuItem TSMCustomersManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMAddCustomerNew;
        private System.Windows.Forms.ToolStripMenuItem TSMBuyManagment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem TSMNewBuy;
        private System.Windows.Forms.ToolStripMenuItem TSMSuppliersManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMAddSupplier;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem TSMSellsManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMNewSell;
        private System.Windows.Forms.ToolStripMenuItem TSMUsersManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMAddNewUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}
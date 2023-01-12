namespace pharmacy_managemint.PL
{
    partial class FRM_CATEGORYMANAGEMENT
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCatigories = new System.Windows.Forms.DataGridView();
            this.btnSelectALL = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearech = new System.Windows.Forms.TextBox();
            this.txtCatNAME = new System.Windows.Forms.TextBox();
            this.txtCatID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatigories)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCatigories);
            this.groupBox1.Font = new System.Drawing.Font("PT Bold Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاصناف";
            // 
            // dgvCatigories
            // 
            this.dgvCatigories.AllowUserToAddRows = false;
            this.dgvCatigories.AllowUserToDeleteRows = false;
            this.dgvCatigories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatigories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatigories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCatigories.Location = new System.Drawing.Point(3, 35);
            this.dgvCatigories.Name = "dgvCatigories";
            this.dgvCatigories.ReadOnly = true;
            this.dgvCatigories.RowHeadersWidth = 51;
            this.dgvCatigories.RowTemplate.Height = 26;
            this.dgvCatigories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatigories.Size = new System.Drawing.Size(705, 310);
            this.dgvCatigories.TabIndex = 0;
            this.dgvCatigories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatigories_CellClick);
            this.dgvCatigories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatigories_CellContentClick);
            // 
            // btnSelectALL
            // 
            this.btnSelectALL.Location = new System.Drawing.Point(229, 35);
            this.btnSelectALL.Name = "btnSelectALL";
            this.btnSelectALL.Size = new System.Drawing.Size(138, 43);
            this.btnSelectALL.TabIndex = 1;
            this.btnSelectALL.Text = "عرض كل الاصناف";
            this.btnSelectALL.UseVisualStyleBackColor = true;
            this.btnSelectALL.Click += new System.EventHandler(this.btnSelectALL_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(229, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 43);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف الصنف المحدد";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(18, 93);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(194, 45);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "طباعة الاصناف";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(18, 35);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(194, 43);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "تعديل بيانات الصنف المحدد";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("PT Bold Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDisplay.Location = new System.Drawing.Point(201, 19);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(203, 45);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "عرض الصنف المحدد";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Bold Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(770, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "البحث باسم الصنف او رقم او رقم الصنف:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "معرف الصنف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "الصنف";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSearech
            // 
            this.txtSearech.Font = new System.Drawing.Font("PT Bold Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearech.Location = new System.Drawing.Point(423, 19);
            this.txtSearech.Name = "txtSearech";
            this.txtSearech.Size = new System.Drawing.Size(346, 39);
            this.txtSearech.TabIndex = 9;
            // 
            // txtCatNAME
            // 
            this.txtCatNAME.Location = new System.Drawing.Point(18, 75);
            this.txtCatNAME.Name = "txtCatNAME";
            this.txtCatNAME.Size = new System.Drawing.Size(267, 34);
            this.txtCatNAME.TabIndex = 10;
            this.txtCatNAME.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCatID
            // 
            this.txtCatID.Location = new System.Drawing.Point(66, 30);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.ReadOnly = true;
            this.txtCatID.Size = new System.Drawing.Size(219, 34);
            this.txtCatID.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCatNAME);
            this.groupBox2.Controls.Add(this.txtCatID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("PT Bold Heading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(729, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 152);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الصنف المحدد";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSelectALL);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Font = new System.Drawing.Font("PT Bold Heading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(729, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 190);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات على الاصناف";
            // 
            // FRM_CATEGORYMANAGEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 535);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSearech);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FRM_CATEGORYMANAGEMENT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الاصناف";
            this.Load += new System.EventHandler(this.FRM_CATEGORYMANAGEMENT_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatigories)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCatigories;
        private System.Windows.Forms.Button btnSelectALL;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearech;
        private System.Windows.Forms.TextBox txtCatNAME;
        private System.Windows.Forms.TextBox txtCatID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
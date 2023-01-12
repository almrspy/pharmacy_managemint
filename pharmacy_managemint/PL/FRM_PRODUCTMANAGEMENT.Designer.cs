namespace pharmacy_managemint.PL
{
    partial class FRM_PRODUCTMANAGEMENT
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
            this.dgvPRODUCTS = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.btnSAVETOEXCEL = new System.Windows.Forms.Button();
            this.btnPRINTSELECTEDPRODUCT = new System.Windows.Forms.Button();
            this.btnPRINTALLPRODUCT = new System.Windows.Forms.Button();
            this.btnDISPLAYPRODUCT = new System.Windows.Forms.Button();
            this.btnDELETEPRODUCT = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnADDNEWPRODUCT = new System.Windows.Forms.Button();
            this.btnDISPLAYALL = new System.Windows.Forms.Button();
            this.TXTSEARCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPRODUCTS);
            this.groupBox1.Location = new System.Drawing.Point(-1, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1221, 557);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المنتجات";
            // 
            // dgvPRODUCTS
            // 
            this.dgvPRODUCTS.AllowUserToAddRows = false;
            this.dgvPRODUCTS.AllowUserToDeleteRows = false;
            this.dgvPRODUCTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRODUCTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPRODUCTS.Location = new System.Drawing.Point(3, 20);
            this.dgvPRODUCTS.MultiSelect = false;
            this.dgvPRODUCTS.Name = "dgvPRODUCTS";
            this.dgvPRODUCTS.ReadOnly = true;
            this.dgvPRODUCTS.RowHeadersVisible = false;
            this.dgvPRODUCTS.RowHeadersWidth = 51;
            this.dgvPRODUCTS.RowTemplate.Height = 26;
            this.dgvPRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPRODUCTS.Size = new System.Drawing.Size(1215, 534);
            this.dgvPRODUCTS.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEXIT);
            this.groupBox2.Controls.Add(this.btnSAVETOEXCEL);
            this.groupBox2.Controls.Add(this.btnPRINTSELECTEDPRODUCT);
            this.groupBox2.Controls.Add(this.btnPRINTALLPRODUCT);
            this.groupBox2.Controls.Add(this.btnDISPLAYPRODUCT);
            this.groupBox2.Controls.Add(this.btnDELETEPRODUCT);
            this.groupBox2.Controls.Add(this.btnUPDATE);
            this.groupBox2.Controls.Add(this.btnADDNEWPRODUCT);
            this.groupBox2.Controls.Add(this.btnDISPLAYALL);
            this.groupBox2.Location = new System.Drawing.Point(-1, 611);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1206, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            // 
            // btnEXIT
            // 
            this.btnEXIT.Font = new System.Drawing.Font("PT Bold Heading", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEXIT.Location = new System.Drawing.Point(287, 109);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(110, 46);
            this.btnEXIT.TabIndex = 8;
            this.btnEXIT.Text = "خروج";
            this.btnEXIT.UseVisualStyleBackColor = true;
            // 
            // btnSAVETOEXCEL
            // 
            this.btnSAVETOEXCEL.Font = new System.Drawing.Font("PT Bold Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSAVETOEXCEL.Location = new System.Drawing.Point(408, 109);
            this.btnSAVETOEXCEL.Name = "btnSAVETOEXCEL";
            this.btnSAVETOEXCEL.Size = new System.Drawing.Size(254, 46);
            this.btnSAVETOEXCEL.TabIndex = 7;
            this.btnSAVETOEXCEL.Text = "حفظ قائمة المنتجات كملف اكسل";
            this.btnSAVETOEXCEL.UseVisualStyleBackColor = true;
            this.btnSAVETOEXCEL.Click += new System.EventHandler(this.btnSAVETOEXCEL_Click);
            // 
            // btnPRINTSELECTEDPRODUCT
            // 
            this.btnPRINTSELECTEDPRODUCT.Font = new System.Drawing.Font("PT Bold Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPRINTSELECTEDPRODUCT.Location = new System.Drawing.Point(673, 110);
            this.btnPRINTSELECTEDPRODUCT.Name = "btnPRINTSELECTEDPRODUCT";
            this.btnPRINTSELECTEDPRODUCT.Size = new System.Drawing.Size(157, 45);
            this.btnPRINTSELECTEDPRODUCT.TabIndex = 6;
            this.btnPRINTSELECTEDPRODUCT.Text = "طباعة المنتج المحدد";
            this.btnPRINTSELECTEDPRODUCT.UseVisualStyleBackColor = true;
            // 
            // btnPRINTALLPRODUCT
            // 
            this.btnPRINTALLPRODUCT.Font = new System.Drawing.Font("PT Bold Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPRINTALLPRODUCT.Location = new System.Drawing.Point(74, 24);
            this.btnPRINTALLPRODUCT.Name = "btnPRINTALLPRODUCT";
            this.btnPRINTALLPRODUCT.Size = new System.Drawing.Size(170, 47);
            this.btnPRINTALLPRODUCT.TabIndex = 5;
            this.btnPRINTALLPRODUCT.Text = "طباعة كل المنتجات";
            this.btnPRINTALLPRODUCT.UseVisualStyleBackColor = true;
            // 
            // btnDISPLAYPRODUCT
            // 
            this.btnDISPLAYPRODUCT.Font = new System.Drawing.Font("PT Bold Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDISPLAYPRODUCT.Location = new System.Drawing.Point(255, 24);
            this.btnDISPLAYPRODUCT.Name = "btnDISPLAYPRODUCT";
            this.btnDISPLAYPRODUCT.Size = new System.Drawing.Size(153, 47);
            this.btnDISPLAYPRODUCT.TabIndex = 4;
            this.btnDISPLAYPRODUCT.Text = "عرض صورة المنتج";
            this.btnDISPLAYPRODUCT.UseVisualStyleBackColor = true;
            // 
            // btnDELETEPRODUCT
            // 
            this.btnDELETEPRODUCT.Font = new System.Drawing.Font("PT Bold Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDELETEPRODUCT.Location = new System.Drawing.Point(414, 24);
            this.btnDELETEPRODUCT.Name = "btnDELETEPRODUCT";
            this.btnDELETEPRODUCT.Size = new System.Drawing.Size(154, 47);
            this.btnDELETEPRODUCT.TabIndex = 3;
            this.btnDELETEPRODUCT.Text = "حذف المنتج المحدد";
            this.btnDELETEPRODUCT.UseVisualStyleBackColor = true;
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Font = new System.Drawing.Font("PT Bold Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUPDATE.Location = new System.Drawing.Point(665, 23);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(165, 48);
            this.btnUPDATE.TabIndex = 2;
            this.btnUPDATE.Text = "تعديل المنتج المحدد";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            // 
            // btnADDNEWPRODUCT
            // 
            this.btnADDNEWPRODUCT.Font = new System.Drawing.Font("PT Bold Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnADDNEWPRODUCT.Location = new System.Drawing.Point(836, 24);
            this.btnADDNEWPRODUCT.Name = "btnADDNEWPRODUCT";
            this.btnADDNEWPRODUCT.Size = new System.Drawing.Size(178, 47);
            this.btnADDNEWPRODUCT.TabIndex = 1;
            this.btnADDNEWPRODUCT.Text = "اضافة منتج جديد";
            this.btnADDNEWPRODUCT.UseVisualStyleBackColor = true;
            // 
            // btnDISPLAYALL
            // 
            this.btnDISPLAYALL.Font = new System.Drawing.Font("PT Bold Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDISPLAYALL.Location = new System.Drawing.Point(1020, 23);
            this.btnDISPLAYALL.Name = "btnDISPLAYALL";
            this.btnDISPLAYALL.Size = new System.Drawing.Size(180, 48);
            this.btnDISPLAYALL.TabIndex = 0;
            this.btnDISPLAYALL.Text = "عرض كل المنتجات";
            this.btnDISPLAYALL.UseVisualStyleBackColor = true;
            // 
            // TXTSEARCH
            // 
            this.TXTSEARCH.Font = new System.Drawing.Font("PT Bold Heading", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXTSEARCH.Location = new System.Drawing.Point(368, 9);
            this.TXTSEARCH.Name = "TXTSEARCH";
            this.TXTSEARCH.Size = new System.Drawing.Size(463, 38);
            this.TXTSEARCH.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Bold Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(833, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "المنتج المراد البحث عنة";
            // 
            // FRM_PRODUCTMANAGEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 795);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTSEARCH);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FRM_PRODUCTMANAGEMENT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ادارة المنتجات";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPRODUCTS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Button btnSAVETOEXCEL;
        private System.Windows.Forms.Button btnPRINTSELECTEDPRODUCT;
        private System.Windows.Forms.Button btnPRINTALLPRODUCT;
        private System.Windows.Forms.Button btnDISPLAYPRODUCT;
        private System.Windows.Forms.Button btnDELETEPRODUCT;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnADDNEWPRODUCT;
        private System.Windows.Forms.Button btnDISPLAYALL;
        private System.Windows.Forms.TextBox TXTSEARCH;
        private System.Windows.Forms.Label label1;
    }
}
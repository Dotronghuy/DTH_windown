
namespace WindowsFormsApp1
{
    partial class FormNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbDC = new System.Windows.Forms.TextBox();
            this.dgwNV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpkNS = new System.Windows.Forms.DateTimePicker();
            this.cmbMP = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNV
            // 
            this.tbNV.Location = new System.Drawing.Point(108, 29);
            this.tbNV.Name = "tbNV";
            this.tbNV.Size = new System.Drawing.Size(100, 22);
            this.tbNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên NV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã Phòng:";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(108, 65);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(100, 22);
            this.tbTen.TabIndex = 6;
            // 
            // tbDC
            // 
            this.tbDC.Location = new System.Drawing.Point(316, 65);
            this.tbDC.Name = "tbDC";
            this.tbDC.Size = new System.Drawing.Size(100, 22);
            this.tbDC.TabIndex = 8;
            // 
            // dgwNV
            // 
            this.dgwNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNV.Location = new System.Drawing.Point(40, 144);
            this.dgwNV.Name = "dgwNV";
            this.dgwNV.RowHeadersWidth = 51;
            this.dgwNV.RowTemplate.Height = 24;
            this.dgwNV.Size = new System.Drawing.Size(717, 167);
            this.dgwNV.TabIndex = 9;
            this.dgwNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgwNV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwNV_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpkNS);
            this.groupBox1.Controls.Add(this.cmbMP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDC);
            this.groupBox1.Controls.Add(this.tbNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(40, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 126);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dpkNS
            // 
            this.dpkNS.Location = new System.Drawing.Point(316, 32);
            this.dpkNS.Name = "dpkNS";
            this.dpkNS.Size = new System.Drawing.Size(152, 22);
            this.dpkNS.TabIndex = 18;
            // 
            // cmbMP
            // 
            this.cmbMP.FormattingEnabled = true;
            this.cmbMP.Location = new System.Drawing.Point(564, 46);
            this.cmbMP.Name = "cmbMP";
            this.cmbMP.Size = new System.Drawing.Size(121, 24);
            this.cmbMP.TabIndex = 17;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(55, 36);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(228, 36);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(387, 36);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(92, 23);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(547, 36);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Location = new System.Drawing.Point(40, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 83);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng:";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwNV);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbDC;
        private System.Windows.Forms.DataGridView dgwNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMP;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dpkNS;
    }
}
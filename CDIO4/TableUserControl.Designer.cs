namespace CDIO4
{
    partial class TableUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_GoiMon = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic_table = new System.Windows.Forms.PictureBox();
            this.btn_OpenTable = new System.Windows.Forms.Button();
            this.lb_NameTable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_table)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(41, 201);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(112, 39);
            this.btn_ThanhToan.TabIndex = 1;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_GoiMon
            // 
            this.btn_GoiMon.Location = new System.Drawing.Point(149, 201);
            this.btn_GoiMon.Name = "btn_GoiMon";
            this.btn_GoiMon.Size = new System.Drawing.Size(111, 39);
            this.btn_GoiMon.TabIndex = 2;
            this.btn_GoiMon.Text = "Gọi món";
            this.btn_GoiMon.UseVisualStyleBackColor = true;
            this.btn_GoiMon.Click += new System.EventHandler(this.btn_GoiMon_Click);
            // 
            // pic_table
            // 
            this.pic_table.Location = new System.Drawing.Point(80, 35);
            this.pic_table.Name = "pic_table";
            this.pic_table.Size = new System.Drawing.Size(147, 163);
            this.pic_table.TabIndex = 0;
            this.pic_table.TabStop = false;
            // 
            // btn_OpenTable
            // 
            this.btn_OpenTable.Location = new System.Drawing.Point(41, 201);
            this.btn_OpenTable.Name = "btn_OpenTable";
            this.btn_OpenTable.Size = new System.Drawing.Size(219, 36);
            this.btn_OpenTable.TabIndex = 3;
            this.btn_OpenTable.Text = "Mở Bàn";
            this.btn_OpenTable.UseVisualStyleBackColor = true;
            this.btn_OpenTable.Click += new System.EventHandler(this.btn_OpenTable_Click);
            // 
            // lb_NameTable
            // 
            this.lb_NameTable.AutoSize = true;
            this.lb_NameTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameTable.Location = new System.Drawing.Point(122, 163);
            this.lb_NameTable.Name = "lb_NameTable";
            this.lb_NameTable.Size = new System.Drawing.Size(66, 24);
            this.lb_NameTable.TabIndex = 4;
            this.lb_NameTable.Text = "label1";
            // 
            // TableUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_NameTable);
            this.Controls.Add(this.btn_OpenTable);
            this.Controls.Add(this.btn_GoiMon);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.pic_table);
            this.Name = "TableUserControl";
            this.Size = new System.Drawing.Size(312, 282);
            ((System.ComponentModel.ISupportInitialize)(this.pic_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_table;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_GoiMon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_OpenTable;
        private System.Windows.Forms.Label lb_NameTable;
    }
}

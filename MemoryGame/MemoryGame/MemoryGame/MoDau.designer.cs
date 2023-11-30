namespace MemoryGame
{
    partial class frmMoDau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoDau));
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.gbxHuongDan = new System.Windows.Forms.GroupBox();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.rdoDe = new System.Windows.Forms.RadioButton();
            this.gbxChonMucDo = new System.Windows.Forms.GroupBox();
            this.rdoKho = new System.Windows.Forms.RadioButton();
            this.rdoBThuong = new System.Windows.Forms.RadioButton();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.gbxHuongDan.SuspendLayout();
            this.gbxChonMucDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(150, 7);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(251, 26);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Game Moving Memory";
            // 
            // gbxHuongDan
            // 
            this.gbxHuongDan.BackColor = System.Drawing.Color.Transparent;
            this.gbxHuongDan.Controls.Add(this.lblHuongDan);
            this.gbxHuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHuongDan.ForeColor = System.Drawing.Color.OrangeRed;
            this.gbxHuongDan.Location = new System.Drawing.Point(9, 48);
            this.gbxHuongDan.Margin = new System.Windows.Forms.Padding(2);
            this.gbxHuongDan.Name = "gbxHuongDan";
            this.gbxHuongDan.Padding = new System.Windows.Forms.Padding(2);
            this.gbxHuongDan.Size = new System.Drawing.Size(560, 139);
            this.gbxHuongDan.TabIndex = 1;
            this.gbxHuongDan.TabStop = false;
            this.gbxHuongDan.Text = "HƯỚNG DẪN CHƠI GAME";
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.BackColor = System.Drawing.SystemColors.Control;
            this.lblHuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuongDan.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHuongDan.Location = new System.Drawing.Point(12, 21);
            this.lblHuongDan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(538, 108);
            this.lblHuongDan.TabIndex = 0;
            this.lblHuongDan.Text = resources.GetString("lblHuongDan.Text");
            // 
            // btnBatDau
            // 
            this.btnBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Location = new System.Drawing.Point(260, 312);
            this.btnBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(69, 33);
            this.btnBatDau.TabIndex = 2;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // rdoDe
            // 
            this.rdoDe.AutoSize = true;
            this.rdoDe.Checked = true;
            this.rdoDe.ForeColor = System.Drawing.Color.Green;
            this.rdoDe.Location = new System.Drawing.Point(4, 17);
            this.rdoDe.Margin = new System.Windows.Forms.Padding(2);
            this.rdoDe.Name = "rdoDe";
            this.rdoDe.Size = new System.Drawing.Size(41, 17);
            this.rdoDe.TabIndex = 1;
            this.rdoDe.TabStop = true;
            this.rdoDe.Text = "Dễ";
            this.rdoDe.UseVisualStyleBackColor = true;
            this.rdoDe.CheckedChanged += new System.EventHandler(this.rdoDe_CheckedChanged);
            // 
            // gbxChonMucDo
            // 
            this.gbxChonMucDo.Controls.Add(this.rdoKho);
            this.gbxChonMucDo.Controls.Add(this.rdoBThuong);
            this.gbxChonMucDo.Controls.Add(this.rdoDe);
            this.gbxChonMucDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxChonMucDo.ForeColor = System.Drawing.Color.Orange;
            this.gbxChonMucDo.Location = new System.Drawing.Point(176, 259);
            this.gbxChonMucDo.Margin = new System.Windows.Forms.Padding(2);
            this.gbxChonMucDo.Name = "gbxChonMucDo";
            this.gbxChonMucDo.Padding = new System.Windows.Forms.Padding(2);
            this.gbxChonMucDo.Size = new System.Drawing.Size(212, 49);
            this.gbxChonMucDo.TabIndex = 4;
            this.gbxChonMucDo.TabStop = false;
            this.gbxChonMucDo.Text = "Chọn mức độ";
            // 
            // rdoKho
            // 
            this.rdoKho.AutoSize = true;
            this.rdoKho.ForeColor = System.Drawing.Color.Green;
            this.rdoKho.Location = new System.Drawing.Point(166, 17);
            this.rdoKho.Margin = new System.Windows.Forms.Padding(2);
            this.rdoKho.Name = "rdoKho";
            this.rdoKho.Size = new System.Drawing.Size(47, 17);
            this.rdoKho.TabIndex = 3;
            this.rdoKho.TabStop = true;
            this.rdoKho.Text = "Khó";
            this.rdoKho.UseVisualStyleBackColor = true;
            this.rdoKho.CheckedChanged += new System.EventHandler(this.rdoKho_CheckedChanged);
            // 
            // rdoBThuong
            // 
            this.rdoBThuong.AutoSize = true;
            this.rdoBThuong.ForeColor = System.Drawing.Color.Green;
            this.rdoBThuong.Location = new System.Drawing.Point(60, 17);
            this.rdoBThuong.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBThuong.Name = "rdoBThuong";
            this.rdoBThuong.Size = new System.Drawing.Size(93, 17);
            this.rdoBThuong.TabIndex = 2;
            this.rdoBThuong.TabStop = true;
            this.rdoBThuong.Text = "Bình thường";
            this.rdoBThuong.UseVisualStyleBackColor = true;
            this.rdoBThuong.CheckedChanged += new System.EventHandler(this.rdoBThuong_CheckedChanged);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(185, 237);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(26, 13);
            this.lblTen.TabIndex = 5;
            this.lblTen.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(217, 234);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(150, 20);
            this.txtTen.TabIndex = 6;
            // 
            // frmMoDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 366);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.gbxChonMucDo);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.gbxHuongDan);
            this.Controls.Add(this.lblTieuDe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMoDau";
            this.Text = "MoDau";
            this.gbxHuongDan.ResumeLayout(false);
            this.gbxChonMucDo.ResumeLayout(false);
            this.gbxChonMucDo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox gbxHuongDan;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.RadioButton rdoDe;
        private System.Windows.Forms.GroupBox gbxChonMucDo;
        private System.Windows.Forms.RadioButton rdoKho;
        private System.Windows.Forms.RadioButton rdoBThuong;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
    }
}
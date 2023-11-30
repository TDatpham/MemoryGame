namespace MemoryGame
{
    partial class frmMovingMemory
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlBang = new System.Windows.Forms.Panel();
            this.gbxTenNCHienTai = new System.Windows.Forms.GroupBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblTenNC = new System.Windows.Forms.Label();
            this.gbxTenNCCaoNhat = new System.Windows.Forms.GroupBox();
            this.lblMaxTime = new System.Windows.Forms.Label();
            this.lblMaxTG = new System.Windows.Forms.Label();
            this.lblSoDiemCaoNhat = new System.Windows.Forms.Label();
            this.lblDiemCaoNhat = new System.Windows.Forms.Label();
            this.lblTenNCCaoNhat = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.gbxTenNCHienTai.SuspendLayout();
            this.gbxTenNCCaoNhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(178, 7);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(220, 24);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Game Moving Memory";
            // 
            // pnlBang
            // 
            this.pnlBang.BackColor = System.Drawing.Color.Transparent;
            this.pnlBang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBang.Location = new System.Drawing.Point(9, 33);
            this.pnlBang.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBang.Name = "pnlBang";
            this.pnlBang.Size = new System.Drawing.Size(582, 582);
            this.pnlBang.TabIndex = 2;
            // 
            // gbxTenNCHienTai
            // 
            this.gbxTenNCHienTai.Controls.Add(this.lblScore);
            this.gbxTenNCHienTai.Controls.Add(this.lblDiem);
            this.gbxTenNCHienTai.Controls.Add(this.lblTenNC);
            this.gbxTenNCHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTenNCHienTai.Location = new System.Drawing.Point(604, 33);
            this.gbxTenNCHienTai.Margin = new System.Windows.Forms.Padding(2);
            this.gbxTenNCHienTai.Name = "gbxTenNCHienTai";
            this.gbxTenNCHienTai.Padding = new System.Windows.Forms.Padding(2);
            this.gbxTenNCHienTai.Size = new System.Drawing.Size(206, 98);
            this.gbxTenNCHienTai.TabIndex = 9;
            this.gbxTenNCHienTai.TabStop = false;
            this.gbxTenNCHienTai.Text = "Tên người chơi hiện tại";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.ForeColor = System.Drawing.Color.Orange;
            this.lblScore.Location = new System.Drawing.Point(57, 61);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(15, 15);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0";
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.ForeColor = System.Drawing.Color.Red;
            this.lblDiem.Location = new System.Drawing.Point(4, 61);
            this.lblDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(45, 15);
            this.lblDiem.TabIndex = 1;
            this.lblDiem.Text = "Điểm:";
            // 
            // lblTenNC
            // 
            this.lblTenNC.AutoSize = true;
            this.lblTenNC.ForeColor = System.Drawing.Color.Blue;
            this.lblTenNC.Location = new System.Drawing.Point(4, 25);
            this.lblTenNC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNC.Name = "lblTenNC";
            this.lblTenNC.Size = new System.Drawing.Size(15, 15);
            this.lblTenNC.TabIndex = 0;
            this.lblTenNC.Text = "a";
            // 
            // gbxTenNCCaoNhat
            // 
            this.gbxTenNCCaoNhat.Controls.Add(this.lblMaxTime);
            this.gbxTenNCCaoNhat.Controls.Add(this.lblMaxTG);
            this.gbxTenNCCaoNhat.Controls.Add(this.lblSoDiemCaoNhat);
            this.gbxTenNCCaoNhat.Controls.Add(this.lblDiemCaoNhat);
            this.gbxTenNCCaoNhat.Controls.Add(this.lblTenNCCaoNhat);
            this.gbxTenNCCaoNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTenNCCaoNhat.Location = new System.Drawing.Point(611, 302);
            this.gbxTenNCCaoNhat.Margin = new System.Windows.Forms.Padding(2);
            this.gbxTenNCCaoNhat.Name = "gbxTenNCCaoNhat";
            this.gbxTenNCCaoNhat.Padding = new System.Windows.Forms.Padding(2);
            this.gbxTenNCCaoNhat.Size = new System.Drawing.Size(204, 98);
            this.gbxTenNCCaoNhat.TabIndex = 10;
            this.gbxTenNCCaoNhat.TabStop = false;
            this.gbxTenNCCaoNhat.Text = "Tên người chơi có điểm cao nhất";
            // 
            // lblMaxTime
            // 
            this.lblMaxTime.AutoSize = true;
            this.lblMaxTime.Location = new System.Drawing.Point(151, 61);
            this.lblMaxTime.Name = "lblMaxTime";
            this.lblMaxTime.Size = new System.Drawing.Size(43, 15);
            this.lblMaxTime.TabIndex = 4;
            this.lblMaxTime.Text = "00:00";
            // 
            // lblMaxTG
            // 
            this.lblMaxTG.AutoSize = true;
            this.lblMaxTG.Location = new System.Drawing.Point(82, 61);
            this.lblMaxTG.Name = "lblMaxTG";
            this.lblMaxTG.Size = new System.Drawing.Size(71, 15);
            this.lblMaxTG.TabIndex = 16;
            this.lblMaxTG.Text = "Thời gian:";
            // 
            // lblSoDiemCaoNhat
            // 
            this.lblSoDiemCaoNhat.AutoSize = true;
            this.lblSoDiemCaoNhat.ForeColor = System.Drawing.Color.Orange;
            this.lblSoDiemCaoNhat.Location = new System.Drawing.Point(55, 61);
            this.lblSoDiemCaoNhat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoDiemCaoNhat.Name = "lblSoDiemCaoNhat";
            this.lblSoDiemCaoNhat.Size = new System.Drawing.Size(15, 15);
            this.lblSoDiemCaoNhat.TabIndex = 2;
            this.lblSoDiemCaoNhat.Text = "0";
            // 
            // lblDiemCaoNhat
            // 
            this.lblDiemCaoNhat.AutoSize = true;
            this.lblDiemCaoNhat.ForeColor = System.Drawing.Color.Red;
            this.lblDiemCaoNhat.Location = new System.Drawing.Point(4, 61);
            this.lblDiemCaoNhat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiemCaoNhat.Name = "lblDiemCaoNhat";
            this.lblDiemCaoNhat.Size = new System.Drawing.Size(45, 15);
            this.lblDiemCaoNhat.TabIndex = 1;
            this.lblDiemCaoNhat.Text = "Điểm:";
            // 
            // lblTenNCCaoNhat
            // 
            this.lblTenNCCaoNhat.AutoSize = true;
            this.lblTenNCCaoNhat.ForeColor = System.Drawing.Color.Blue;
            this.lblTenNCCaoNhat.Location = new System.Drawing.Point(4, 37);
            this.lblTenNCCaoNhat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNCCaoNhat.Name = "lblTenNCCaoNhat";
            this.lblTenNCCaoNhat.Size = new System.Drawing.Size(15, 15);
            this.lblTenNCCaoNhat.TabIndex = 0;
            this.lblTenNCCaoNhat.Text = "a";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(674, 260);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(71, 25);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(670, 136);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Bắt Đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(670, 165);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 13;
            this.btnPause.Text = "Tạm Dừng";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(670, 223);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.Text = "Menu Chính";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(670, 194);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(75, 23);
            this.btnRetry.TabIndex = 15;
            this.btnRetry.Text = "Chơi lại";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // frmMovingMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 609);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.gbxTenNCCaoNhat);
            this.Controls.Add(this.gbxTenNCHienTai);
            this.Controls.Add(this.pnlBang);
            this.Controls.Add(this.lblTieuDe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMovingMemory";
            this.Text = "Moving Memory";
            this.Load += new System.EventHandler(this.frmMovingMemory_Load);
            this.gbxTenNCHienTai.ResumeLayout(false);
            this.gbxTenNCHienTai.PerformLayout();
            this.gbxTenNCCaoNhat.ResumeLayout(false);
            this.gbxTenNCCaoNhat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel pnlBang;
        private System.Windows.Forms.GroupBox gbxTenNCHienTai;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblTenNC;
        private System.Windows.Forms.GroupBox gbxTenNCCaoNhat;
        private System.Windows.Forms.Label lblSoDiemCaoNhat;
        private System.Windows.Forms.Label lblDiemCaoNhat;
        private System.Windows.Forms.Label lblTenNCCaoNhat;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblMaxTime;
        private System.Windows.Forms.Label lblMaxTG;
        private System.Windows.Forms.Button btnRetry;
    }
}


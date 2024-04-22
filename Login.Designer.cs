namespace QuanLiQuanCaPhe
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_mk = new System.Windows.Forms.TextBox();
            this.btt_dangnhap = new System.Windows.Forms.Button();
            this.btt_thoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(209, 84);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(183, 22);
            this.tbx_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(52, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(52, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // tbx_mk
            // 
            this.tbx_mk.Location = new System.Drawing.Point(209, 158);
            this.tbx_mk.Name = "tbx_mk";
            this.tbx_mk.Size = new System.Drawing.Size(183, 22);
            this.tbx_mk.TabIndex = 3;
            this.tbx_mk.UseSystemPasswordChar = true;
            // 
            // btt_dangnhap
            // 
            this.btt_dangnhap.BackColor = System.Drawing.Color.Lime;
            this.btt_dangnhap.Image = ((System.Drawing.Image)(resources.GetObject("btt_dangnhap.Image")));
            this.btt_dangnhap.Location = new System.Drawing.Point(52, 243);
            this.btt_dangnhap.Name = "btt_dangnhap";
            this.btt_dangnhap.Size = new System.Drawing.Size(114, 32);
            this.btt_dangnhap.TabIndex = 4;
            this.btt_dangnhap.Text = "Đăng nhập";
            this.btt_dangnhap.UseVisualStyleBackColor = false;
            this.btt_dangnhap.Click += new System.EventHandler(this.btt_dangnhap_Click);
            // 
            // btt_thoat
            // 
            this.btt_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btt_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btt_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btt_thoat.Image")));
            this.btt_thoat.Location = new System.Drawing.Point(223, 243);
            this.btt_thoat.Name = "btt_thoat";
            this.btt_thoat.Size = new System.Drawing.Size(76, 34);
            this.btt_thoat.TabIndex = 5;
            this.btt_thoat.Text = "Thoát";
            this.btt_thoat.UseVisualStyleBackColor = false;
            this.btt_thoat.Click += new System.EventHandler(this.btt_thoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(416, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 364);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btt_dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btt_thoat;
            this.ClientSize = new System.Drawing.Size(1193, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btt_thoat);
            this.Controls.Add(this.btt_dangnhap);
            this.Controls.Add(this.tbx_mk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_name);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_mk;
        private System.Windows.Forms.Button btt_dangnhap;
        private System.Windows.Forms.Button btt_thoat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


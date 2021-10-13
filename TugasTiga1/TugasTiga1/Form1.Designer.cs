
namespace TugasTiga1
{
    partial class frmTugasTiga1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnKosongkan = new System.Windows.Forms.Button();
            this.lblNim = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas :";
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(62, 162);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(121, 33);
            this.btnTampilkan.TabIndex = 3;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnKosongkan
            // 
            this.btnKosongkan.Location = new System.Drawing.Point(205, 162);
            this.btnKosongkan.Name = "btnKosongkan";
            this.btnKosongkan.Size = new System.Drawing.Size(121, 33);
            this.btnKosongkan.TabIndex = 4;
            this.btnKosongkan.Text = "Kosongkan";
            this.btnKosongkan.UseVisualStyleBackColor = true;
            this.btnKosongkan.Click += new System.EventHandler(this.btnKosongkan_Click);
            // 
            // lblNim
            // 
            this.lblNim.AutoSize = true;
            this.lblNim.Location = new System.Drawing.Point(91, 37);
            this.lblNim.Name = "lblNim";
            this.lblNim.Size = new System.Drawing.Size(0, 17);
            this.lblNim.TabIndex = 5;
            this.lblNim.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(91, 77);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(0, 17);
            this.lblNama.TabIndex = 6;
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(91, 115);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(0, 17);
            this.lblKelas.TabIndex = 7;
            // 
            // frmTugasTiga1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 347);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNim);
            this.Controls.Add(this.btnKosongkan);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTugasTiga1";
            this.Text = "Tugas 3.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnKosongkan;
        private System.Windows.Forms.Label lblNim;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKelas;
    }
}


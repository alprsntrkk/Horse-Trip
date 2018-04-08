namespace HorseTrip
{
    partial class Form1
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
            this.rdBes = new System.Windows.Forms.RadioButton();
            this.rdAlti = new System.Windows.Forms.RadioButton();
            this.rdYedi = new System.Windows.Forms.RadioButton();
            this.rdSekiz = new System.Windows.Forms.RadioButton();
            this.rdDokuz = new System.Windows.Forms.RadioButton();
            this.btnOyna = new System.Windows.Forms.Button();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.grdOyun = new System.Windows.Forms.DataGridView();
            this.lblTebrik = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdOyun)).BeginInit();
            this.SuspendLayout();
            // 
            // rdBes
            // 
            this.rdBes.AutoSize = true;
            this.rdBes.Location = new System.Drawing.Point(95, 12);
            this.rdBes.Name = "rdBes";
            this.rdBes.Size = new System.Drawing.Size(51, 21);
            this.rdBes.TabIndex = 0;
            this.rdBes.TabStop = true;
            this.rdBes.Text = "5x5";
            this.rdBes.UseVisualStyleBackColor = true;
            // 
            // rdAlti
            // 
            this.rdAlti.AutoSize = true;
            this.rdAlti.Location = new System.Drawing.Point(95, 39);
            this.rdAlti.Name = "rdAlti";
            this.rdAlti.Size = new System.Drawing.Size(51, 21);
            this.rdAlti.TabIndex = 1;
            this.rdAlti.TabStop = true;
            this.rdAlti.Text = "6x6";
            this.rdAlti.UseVisualStyleBackColor = true;
            // 
            // rdYedi
            // 
            this.rdYedi.AutoSize = true;
            this.rdYedi.Location = new System.Drawing.Point(95, 66);
            this.rdYedi.Name = "rdYedi";
            this.rdYedi.Size = new System.Drawing.Size(51, 21);
            this.rdYedi.TabIndex = 2;
            this.rdYedi.TabStop = true;
            this.rdYedi.Text = "7x7";
            this.rdYedi.UseVisualStyleBackColor = true;
            // 
            // rdSekiz
            // 
            this.rdSekiz.AutoSize = true;
            this.rdSekiz.Location = new System.Drawing.Point(152, 12);
            this.rdSekiz.Name = "rdSekiz";
            this.rdSekiz.Size = new System.Drawing.Size(51, 21);
            this.rdSekiz.TabIndex = 3;
            this.rdSekiz.TabStop = true;
            this.rdSekiz.Text = "8x8";
            this.rdSekiz.UseVisualStyleBackColor = true;
            // 
            // rdDokuz
            // 
            this.rdDokuz.AutoSize = true;
            this.rdDokuz.Location = new System.Drawing.Point(152, 39);
            this.rdDokuz.Name = "rdDokuz";
            this.rdDokuz.Size = new System.Drawing.Size(51, 21);
            this.rdDokuz.TabIndex = 4;
            this.rdDokuz.TabStop = true;
            this.rdDokuz.Text = "9x9";
            this.rdDokuz.UseVisualStyleBackColor = true;
            // 
            // btnOyna
            // 
            this.btnOyna.Location = new System.Drawing.Point(221, 12);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(91, 75);
            this.btnOyna.TabIndex = 5;
            this.btnOyna.Text = "Oyna";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(328, 16);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(41, 17);
            this.lblSkor.TabIndex = 6;
            this.lblSkor.Text = "Skor:";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(375, 16);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(0, 17);
            this.lblPuan.TabIndex = 7;
            // 
            // grdOyun
            // 
            this.grdOyun.AllowUserToResizeColumns = false;
            this.grdOyun.AllowUserToResizeRows = false;
            this.grdOyun.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdOyun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdOyun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdOyun.ColumnHeadersVisible = false;
            this.grdOyun.Location = new System.Drawing.Point(12, 93);
            this.grdOyun.Name = "grdOyun";
            this.grdOyun.ReadOnly = true;
            this.grdOyun.RowHeadersVisible = false;
            this.grdOyun.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdOyun.RowTemplate.Height = 40;
            this.grdOyun.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdOyun.Size = new System.Drawing.Size(482, 509);
            this.grdOyun.TabIndex = 8;
            this.grdOyun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridClick);
            // 
            // lblTebrik
            // 
            this.lblTebrik.AutoSize = true;
            this.lblTebrik.Location = new System.Drawing.Point(12, 605);
            this.lblTebrik.Name = "lblTebrik";
            this.lblTebrik.Size = new System.Drawing.Size(0, 17);
            this.lblTebrik.TabIndex = 9;
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Location = new System.Drawing.Point(375, 66);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(0, 17);
            this.lblZaman.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Süre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblTebrik);
            this.Controls.Add(this.grdOyun);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.btnOyna);
            this.Controls.Add(this.rdDokuz);
            this.Controls.Add(this.rdSekiz);
            this.Controls.Add(this.rdYedi);
            this.Controls.Add(this.rdAlti);
            this.Controls.Add(this.rdBes);
            this.Name = "Form1";
            this.Text = "Horse Trip";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOyun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdBes;
        private System.Windows.Forms.RadioButton rdAlti;
        private System.Windows.Forms.RadioButton rdYedi;
        private System.Windows.Forms.RadioButton rdSekiz;
        private System.Windows.Forms.RadioButton rdDokuz;
        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.DataGridView grdOyun;
        private System.Windows.Forms.Label lblTebrik;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Label label1;
    }
}


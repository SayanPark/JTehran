namespace JTehran
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
            this.bttnPro = new System.Windows.Forms.Button();
            this.bttnStu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnPro
            // 
            this.bttnPro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPro.Location = new System.Drawing.Point(113, 57);
            this.bttnPro.Name = "bttnPro";
            this.bttnPro.Size = new System.Drawing.Size(119, 40);
            this.bttnPro.TabIndex = 0;
            this.bttnPro.Text = "بخش اساتید";
            this.bttnPro.UseVisualStyleBackColor = true;
            this.bttnPro.Click += new System.EventHandler(this.bttnPro_Click);
            // 
            // bttnStu
            // 
            this.bttnStu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnStu.Location = new System.Drawing.Point(113, 100);
            this.bttnStu.Name = "bttnStu";
            this.bttnStu.Size = new System.Drawing.Size(119, 40);
            this.bttnStu.TabIndex = 1;
            this.bttnStu.Text = "بخش دانشجویان";
            this.bttnStu.UseVisualStyleBackColor = true;
            this.bttnStu.Click += new System.EventHandler(this.bttnStu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 153);
            this.Controls.Add(this.bttnStu);
            this.Controls.Add(this.bttnPro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جهاد دانشگاهی تهران";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnPro;
        private System.Windows.Forms.Button bttnStu;
    }
}



namespace FoodRecomv2
{
    partial class LittleHungry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LittleHungry));
            this.btnAsin = new System.Windows.Forms.Button();
            this.btnManis = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.picGorengan = new System.Windows.Forms.PictureBox();
            this.picBakso = new System.Windows.Forms.PictureBox();
            this.lblGorengan = new System.Windows.Forms.Label();
            this.lblBakso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGorengan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBakso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsin
            // 
            this.btnAsin.Location = new System.Drawing.Point(108, 12);
            this.btnAsin.Name = "btnAsin";
            this.btnAsin.Size = new System.Drawing.Size(129, 41);
            this.btnAsin.TabIndex = 0;
            this.btnAsin.Text = "Asin";
            this.btnAsin.UseVisualStyleBackColor = true;
            this.btnAsin.Click += new System.EventHandler(this.btnAsin_Click);
            // 
            // btnManis
            // 
            this.btnManis.Location = new System.Drawing.Point(444, 12);
            this.btnManis.Name = "btnManis";
            this.btnManis.Size = new System.Drawing.Size(129, 41);
            this.btnManis.TabIndex = 1;
            this.btnManis.Text = "Manis";
            this.btnManis.UseVisualStyleBackColor = true;
            this.btnManis.Click += new System.EventHandler(this.btnManis_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 321);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 33);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picGorengan
            // 
            this.picGorengan.Image = ((System.Drawing.Image)(resources.GetObject("picGorengan.Image")));
            this.picGorengan.Location = new System.Drawing.Point(79, 83);
            this.picGorengan.Name = "picGorengan";
            this.picGorengan.Size = new System.Drawing.Size(211, 187);
            this.picGorengan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGorengan.TabIndex = 7;
            this.picGorengan.TabStop = false;
            this.picGorengan.Visible = false;
            // 
            // picBakso
            // 
            this.picBakso.Image = ((System.Drawing.Image)(resources.GetObject("picBakso.Image")));
            this.picBakso.Location = new System.Drawing.Point(388, 83);
            this.picBakso.Name = "picBakso";
            this.picBakso.Size = new System.Drawing.Size(254, 187);
            this.picBakso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBakso.TabIndex = 8;
            this.picBakso.TabStop = false;
            this.picBakso.Visible = false;
            // 
            // lblGorengan
            // 
            this.lblGorengan.AutoSize = true;
            this.lblGorengan.Location = new System.Drawing.Point(142, 273);
            this.lblGorengan.Name = "lblGorengan";
            this.lblGorengan.Size = new System.Drawing.Size(81, 20);
            this.lblGorengan.TabIndex = 9;
            this.lblGorengan.Text = "Gorengan";
            this.lblGorengan.Visible = false;
            // 
            // lblBakso
            // 
            this.lblBakso.AutoSize = true;
            this.lblBakso.Location = new System.Drawing.Point(459, 273);
            this.lblBakso.Name = "lblBakso";
            this.lblBakso.Size = new System.Drawing.Size(100, 20);
            this.lblBakso.TabIndex = 10;
            this.lblBakso.Text = "Bakso Bakar";
            this.lblBakso.Visible = false;
            // 
            // LittleHungry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 366);
            this.Controls.Add(this.lblBakso);
            this.Controls.Add(this.lblGorengan);
            this.Controls.Add(this.picBakso);
            this.Controls.Add(this.picGorengan);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnManis);
            this.Controls.Add(this.btnAsin);
            this.Name = "LittleHungry";
            this.Text = "LittleHungry";
            ((System.ComponentModel.ISupportInitialize)(this.picGorengan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBakso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsin;
        private System.Windows.Forms.Button btnManis;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picGorengan;
        private System.Windows.Forms.PictureBox picBakso;
        private System.Windows.Forms.Label lblGorengan;
        private System.Windows.Forms.Label lblBakso;
    }
}
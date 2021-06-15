
namespace FoodRecomv2
{
    partial class OpsiLain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpsiLain));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAsin = new System.Windows.Forms.Button();
            this.btnManis = new System.Windows.Forms.Button();
            this.picCake = new System.Windows.Forms.PictureBox();
            this.picPie = new System.Windows.Forms.PictureBox();
            this.lblCake = new System.Windows.Forms.Label();
            this.lblPie = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 334);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 33);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAsin
            // 
            this.btnAsin.Location = new System.Drawing.Point(156, 12);
            this.btnAsin.Name = "btnAsin";
            this.btnAsin.Size = new System.Drawing.Size(109, 38);
            this.btnAsin.TabIndex = 3;
            this.btnAsin.Text = "Asin";
            this.btnAsin.UseVisualStyleBackColor = true;
            this.btnAsin.Click += new System.EventHandler(this.btnAsin_Click);
            // 
            // btnManis
            // 
            this.btnManis.Location = new System.Drawing.Point(498, 12);
            this.btnManis.Name = "btnManis";
            this.btnManis.Size = new System.Drawing.Size(109, 38);
            this.btnManis.TabIndex = 4;
            this.btnManis.Text = "Manis";
            this.btnManis.UseVisualStyleBackColor = true;
            this.btnManis.Click += new System.EventHandler(this.btnManis_Click);
            // 
            // picCake
            // 
            this.picCake.Image = ((System.Drawing.Image)(resources.GetObject("picCake.Image")));
            this.picCake.Location = new System.Drawing.Point(98, 56);
            this.picCake.Name = "picCake";
            this.picCake.Size = new System.Drawing.Size(215, 216);
            this.picCake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCake.TabIndex = 5;
            this.picCake.TabStop = false;
            this.picCake.Visible = false;
            // 
            // picPie
            // 
            this.picPie.Image = ((System.Drawing.Image)(resources.GetObject("picPie.Image")));
            this.picPie.Location = new System.Drawing.Point(421, 75);
            this.picPie.Name = "picPie";
            this.picPie.Size = new System.Drawing.Size(275, 183);
            this.picPie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPie.TabIndex = 6;
            this.picPie.TabStop = false;
            this.picPie.Visible = false;
            // 
            // lblCake
            // 
            this.lblCake.AutoSize = true;
            this.lblCake.Location = new System.Drawing.Point(182, 275);
            this.lblCake.Name = "lblCake";
            this.lblCake.Size = new System.Drawing.Size(37, 20);
            this.lblCake.TabIndex = 7;
            this.lblCake.Text = "Kue";
            this.lblCake.Visible = false;
            // 
            // lblPie
            // 
            this.lblPie.AutoSize = true;
            this.lblPie.Location = new System.Drawing.Point(546, 275);
            this.lblPie.Name = "lblPie";
            this.lblPie.Size = new System.Drawing.Size(31, 20);
            this.lblPie.TabIndex = 8;
            this.lblPie.Text = "Pie";
            this.lblPie.Visible = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarning.Location = new System.Drawing.Point(98, 308);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(330, 20);
            this.lblWarning.TabIndex = 9;
            this.lblWarning.Text = "*Jangan makan terlalu banyak nanti diabetes.";
            this.lblWarning.Visible = false;
            // 
            // OpsiLain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 379);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblPie);
            this.Controls.Add(this.lblCake);
            this.Controls.Add(this.picPie);
            this.Controls.Add(this.picCake);
            this.Controls.Add(this.btnManis);
            this.Controls.Add(this.btnAsin);
            this.Controls.Add(this.btnBack);
            this.Name = "OpsiLain";
            this.Text = "OpsiLain";
            ((System.ComponentModel.ISupportInitialize)(this.picCake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAsin;
        private System.Windows.Forms.Button btnManis;
        private System.Windows.Forms.PictureBox picCake;
        private System.Windows.Forms.PictureBox picPie;
        private System.Windows.Forms.Label lblCake;
        private System.Windows.Forms.Label lblPie;
        private System.Windows.Forms.Label lblWarning;
    }
}
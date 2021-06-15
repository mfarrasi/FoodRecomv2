
namespace FoodRecomv2
{
    partial class BigHungry
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOpsiLain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playball", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(32, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pergi aja ke rumah makan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 292);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 33);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOpsiLain
            // 
            this.btnOpsiLain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpsiLain.Location = new System.Drawing.Point(205, 188);
            this.btnOpsiLain.Name = "btnOpsiLain";
            this.btnOpsiLain.Size = new System.Drawing.Size(240, 87);
            this.btnOpsiLain.TabIndex = 2;
            this.btnOpsiLain.Text = "Lihat opsi lain...";
            this.btnOpsiLain.UseVisualStyleBackColor = true;
            this.btnOpsiLain.Click += new System.EventHandler(this.btnOpsiLain_Click);
            // 
            // BigHungry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 337);
            this.Controls.Add(this.btnOpsiLain);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "BigHungry";
            this.Text = "BigHungry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOpsiLain;
    }
}
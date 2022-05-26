
namespace HatsuneMiku_ProjectDIVA
{
    partial class Ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayuda));
            this.lbAyuda = new System.Windows.Forms.Label();
            this.pbReglas = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbReglas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAyuda
            // 
            this.lbAyuda.AutoSize = true;
            this.lbAyuda.BackColor = System.Drawing.Color.Transparent;
            this.lbAyuda.Font = new System.Drawing.Font("Caladea", 21.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAyuda.Location = new System.Drawing.Point(24, 9);
            this.lbAyuda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAyuda.Name = "lbAyuda";
            this.lbAyuda.Size = new System.Drawing.Size(143, 52);
            this.lbAyuda.TabIndex = 0;
            this.lbAyuda.Text = "Ayuda";
            // 
            // pbReglas
            // 
            this.pbReglas.BackColor = System.Drawing.Color.White;
            this.pbReglas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbReglas.BackgroundImage")));
            this.pbReglas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbReglas.Location = new System.Drawing.Point(33, 83);
            this.pbReglas.Name = "pbReglas";
            this.pbReglas.Size = new System.Drawing.Size(678, 368);
            this.pbReglas.TabIndex = 9;
            this.pbReglas.TabStop = false;
            // 
            // pbBack
            // 
            this.pbBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBack.BackgroundImage")));
            this.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBack.Location = new System.Drawing.Point(34, 474);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(104, 75);
            this.pbBack.TabIndex = 10;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 537);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.pbReglas);
            this.Controls.Add(this.lbAyuda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1162, 593);
            this.MinimumSize = new System.Drawing.Size(1162, 593);
            this.Name = "Ayuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectDiva";
            ((System.ComponentModel.ISupportInitialize)(this.pbReglas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAyuda;
        private System.Windows.Forms.PictureBox pbReglas;
        private System.Windows.Forms.PictureBox pbBack;
    }
}
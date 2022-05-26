
namespace HatsuneMiku_ProjectDIVA
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pbStart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStart
            // 
            this.pbStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbStart.BackColor = System.Drawing.Color.Transparent;
            this.pbStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbStart.BackgroundImage")));
            this.pbStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbStart.Location = new System.Drawing.Point(255, 402);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(268, 195);
            this.pbStart.TabIndex = 1;
            this.pbStart.TabStop = false;
            this.pbStart.Click += new System.EventHandler(this.pbStart_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 537);
            this.Controls.Add(this.pbStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1162, 593);
            this.MinimumSize = new System.Drawing.Size(1162, 593);
            this.Name = "Inicio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectDiva";
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbStart;
    }
}



namespace HatsuneMiku_ProjectDIVA
{
    partial class PartidaPerdidaSinglePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartidaPerdidaSinglePlayer));
            this.lbContinuar = new System.Windows.Forms.Label();
            this.lbPuntos = new System.Windows.Forms.Label();
            this.lbTextoPuntos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbContinuar
            // 
            this.lbContinuar.AutoSize = true;
            this.lbContinuar.BackColor = System.Drawing.Color.Transparent;
            this.lbContinuar.Font = new System.Drawing.Font("Caladea", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContinuar.Location = new System.Drawing.Point(-1, 494);
            this.lbContinuar.Name = "lbContinuar";
            this.lbContinuar.Size = new System.Drawing.Size(204, 26);
            this.lbContinuar.TabIndex = 0;
            this.lbContinuar.Text = "\'ESC\' para continuar";
            // 
            // lbPuntos
            // 
            this.lbPuntos.AutoSize = true;
            this.lbPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lbPuntos.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntos.Location = new System.Drawing.Point(789, 408);
            this.lbPuntos.Name = "lbPuntos";
            this.lbPuntos.Size = new System.Drawing.Size(25, 28);
            this.lbPuntos.TabIndex = 1;
            this.lbPuntos.Text = "0";
            // 
            // lbTextoPuntos
            // 
            this.lbTextoPuntos.AutoSize = true;
            this.lbTextoPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lbTextoPuntos.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextoPuntos.Location = new System.Drawing.Point(685, 408);
            this.lbTextoPuntos.Name = "lbTextoPuntos";
            this.lbTextoPuntos.Size = new System.Drawing.Size(86, 28);
            this.lbTextoPuntos.TabIndex = 2;
            this.lbTextoPuntos.Text = "Puntos:";
            // 
            // PartidaPerdidaSinglePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 537);
            this.Controls.Add(this.lbTextoPuntos);
            this.Controls.Add(this.lbPuntos);
            this.Controls.Add(this.lbContinuar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1162, 593);
            this.MinimumSize = new System.Drawing.Size(1162, 593);
            this.Name = "PartidaPerdidaSinglePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectDiva";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartidaPerdida_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbContinuar;
        public System.Windows.Forms.Label lbPuntos;
        public System.Windows.Forms.Label lbTextoPuntos;
    }
}
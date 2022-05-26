
namespace HatsuneMiku_ProjectDIVA
{
    partial class PartidaPerdidaMultiPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartidaPerdidaMultiPlayer));
            this.lbContinuar = new System.Windows.Forms.Label();
            this.lbTextoPuntos1 = new System.Windows.Forms.Label();
            this.lbTextoPuntos2 = new System.Windows.Forms.Label();
            this.lbPuntos1 = new System.Windows.Forms.Label();
            this.lbPuntos2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbContinuar
            // 
            this.lbContinuar.AutoSize = true;
            this.lbContinuar.BackColor = System.Drawing.Color.Transparent;
            this.lbContinuar.Font = new System.Drawing.Font("Caladea", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContinuar.Location = new System.Drawing.Point(-6, 501);
            this.lbContinuar.Name = "lbContinuar";
            this.lbContinuar.Size = new System.Drawing.Size(204, 26);
            this.lbContinuar.TabIndex = 1;
            this.lbContinuar.Text = "\'ESC\' para continuar";
            // 
            // lbTextoPuntos1
            // 
            this.lbTextoPuntos1.AutoSize = true;
            this.lbTextoPuntos1.BackColor = System.Drawing.Color.Transparent;
            this.lbTextoPuntos1.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextoPuntos1.Location = new System.Drawing.Point(652, 406);
            this.lbTextoPuntos1.Name = "lbTextoPuntos1";
            this.lbTextoPuntos1.Size = new System.Drawing.Size(123, 28);
            this.lbTextoPuntos1.TabIndex = 3;
            this.lbTextoPuntos1.Text = "Puntos pj1:";
            // 
            // lbTextoPuntos2
            // 
            this.lbTextoPuntos2.AutoSize = true;
            this.lbTextoPuntos2.BackColor = System.Drawing.Color.Transparent;
            this.lbTextoPuntos2.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextoPuntos2.Location = new System.Drawing.Point(652, 451);
            this.lbTextoPuntos2.Name = "lbTextoPuntos2";
            this.lbTextoPuntos2.Size = new System.Drawing.Size(123, 28);
            this.lbTextoPuntos2.TabIndex = 4;
            this.lbTextoPuntos2.Text = "Puntos pj2:";
            // 
            // lbPuntos1
            // 
            this.lbPuntos1.AutoSize = true;
            this.lbPuntos1.BackColor = System.Drawing.Color.Transparent;
            this.lbPuntos1.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntos1.Location = new System.Drawing.Point(790, 406);
            this.lbPuntos1.Name = "lbPuntos1";
            this.lbPuntos1.Size = new System.Drawing.Size(25, 28);
            this.lbPuntos1.TabIndex = 5;
            this.lbPuntos1.Text = "0";
            // 
            // lbPuntos2
            // 
            this.lbPuntos2.AutoSize = true;
            this.lbPuntos2.BackColor = System.Drawing.Color.Transparent;
            this.lbPuntos2.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntos2.Location = new System.Drawing.Point(790, 451);
            this.lbPuntos2.Name = "lbPuntos2";
            this.lbPuntos2.Size = new System.Drawing.Size(25, 28);
            this.lbPuntos2.TabIndex = 6;
            this.lbPuntos2.Text = "0";
            // 
            // PartidaPerdidaMultiPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 537);
            this.Controls.Add(this.lbPuntos2);
            this.Controls.Add(this.lbPuntos1);
            this.Controls.Add(this.lbTextoPuntos2);
            this.Controls.Add(this.lbTextoPuntos1);
            this.Controls.Add(this.lbContinuar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1162, 593);
            this.MinimumSize = new System.Drawing.Size(1162, 593);
            this.Name = "PartidaPerdidaMultiPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectDiva";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartidaPerdidaMultiPlayer_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbContinuar;
        public System.Windows.Forms.Label lbTextoPuntos1;
        public System.Windows.Forms.Label lbTextoPuntos2;
        public System.Windows.Forms.Label lbPuntos1;
        public System.Windows.Forms.Label lbPuntos2;
    }
}
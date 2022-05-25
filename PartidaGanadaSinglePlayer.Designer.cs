
namespace HatsuneMiku_ProjectDIVA
{
    partial class PartidaGanadaSinglePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartidaGanadaSinglePlayer));
            this.pbWin = new System.Windows.Forms.PictureBox();
            this.lbTextoPuntos = new System.Windows.Forms.Label();
            this.lbPuntos = new System.Windows.Forms.Label();
            this.btRanking = new System.Windows.Forms.Button();
            this.lbESC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWin
            // 
            this.pbWin.BackColor = System.Drawing.Color.Transparent;
            this.pbWin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWin.BackgroundImage")));
            this.pbWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWin.Location = new System.Drawing.Point(720, 136);
            this.pbWin.Name = "pbWin";
            this.pbWin.Size = new System.Drawing.Size(395, 65);
            this.pbWin.TabIndex = 0;
            this.pbWin.TabStop = false;
            // 
            // lbTextoPuntos
            // 
            this.lbTextoPuntos.AutoSize = true;
            this.lbTextoPuntos.BackColor = System.Drawing.Color.Orchid;
            this.lbTextoPuntos.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextoPuntos.Location = new System.Drawing.Point(839, 247);
            this.lbTextoPuntos.Name = "lbTextoPuntos";
            this.lbTextoPuntos.Size = new System.Drawing.Size(93, 28);
            this.lbTextoPuntos.TabIndex = 3;
            this.lbTextoPuntos.Text = "Puntos:";
            // 
            // lbPuntos
            // 
            this.lbPuntos.AutoSize = true;
            this.lbPuntos.BackColor = System.Drawing.Color.Orchid;
            this.lbPuntos.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntos.Location = new System.Drawing.Point(934, 247);
            this.lbPuntos.Name = "lbPuntos";
            this.lbPuntos.Size = new System.Drawing.Size(26, 28);
            this.lbPuntos.TabIndex = 4;
            this.lbPuntos.Text = "0";
            // 
            // btRanking
            // 
            this.btRanking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRanking.BackColor = System.Drawing.Color.White;
            this.btRanking.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btRanking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btRanking.FlatAppearance.BorderSize = 0;
            this.btRanking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRanking.Font = new System.Drawing.Font("Caladea", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRanking.ForeColor = System.Drawing.Color.HotPink;
            this.btRanking.Location = new System.Drawing.Point(804, 297);
            this.btRanking.Name = "btRanking";
            this.btRanking.Size = new System.Drawing.Size(198, 35);
            this.btRanking.TabIndex = 5;
            this.btRanking.Text = "Guardar Partida";
            this.btRanking.UseVisualStyleBackColor = false;
            this.btRanking.Click += new System.EventHandler(this.btRanking_Click);
            // 
            // lbESC
            // 
            this.lbESC.AutoSize = true;
            this.lbESC.BackColor = System.Drawing.Color.Transparent;
            this.lbESC.Font = new System.Drawing.Font("Caladea", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbESC.Location = new System.Drawing.Point(-4, 504);
            this.lbESC.Name = "lbESC";
            this.lbESC.Size = new System.Drawing.Size(192, 23);
            this.lbESC.TabIndex = 6;
            this.lbESC.Text = "ESC para continuar";
            // 
            // PartidaGanadaSinglePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 537);
            this.Controls.Add(this.lbESC);
            this.Controls.Add(this.btRanking);
            this.Controls.Add(this.lbPuntos);
            this.Controls.Add(this.lbTextoPuntos);
            this.Controls.Add(this.pbWin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1162, 593);
            this.MinimumSize = new System.Drawing.Size(1162, 593);
            this.Name = "PartidaGanadaSinglePlayer";
            this.Text = "ProjectDiva";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartidaGanada_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWin;
        public System.Windows.Forms.Label lbTextoPuntos;
        public System.Windows.Forms.Label lbPuntos;
        private System.Windows.Forms.Button btRanking;
        private System.Windows.Forms.Label lbESC;
    }
}
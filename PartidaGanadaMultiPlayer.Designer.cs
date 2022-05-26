
namespace HatsuneMiku_ProjectDIVA
{
    partial class PartidaGanadaMultiPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartidaGanadaMultiPlayer));
            this.pbWin = new System.Windows.Forms.PictureBox();
            this.lbTextoPuntos1 = new System.Windows.Forms.Label();
            this.lbPuntos1 = new System.Windows.Forms.Label();
            this.btRanking = new System.Windows.Forms.Button();
            this.lbESC = new System.Windows.Forms.Label();
            this.lbTextoPuntos2 = new System.Windows.Forms.Label();
            this.lbPuntos2 = new System.Windows.Forms.Label();
            this.lbTextoGanador = new System.Windows.Forms.Label();
            this.lbGanador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWin
            // 
            this.pbWin.BackColor = System.Drawing.Color.Transparent;
            this.pbWin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWin.BackgroundImage")));
            this.pbWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWin.Location = new System.Drawing.Point(722, 82);
            this.pbWin.Name = "pbWin";
            this.pbWin.Size = new System.Drawing.Size(395, 65);
            this.pbWin.TabIndex = 2;
            this.pbWin.TabStop = false;
            // 
            // lbTextoPuntos1
            // 
            this.lbTextoPuntos1.AutoSize = true;
            this.lbTextoPuntos1.BackColor = System.Drawing.Color.Orchid;
            this.lbTextoPuntos1.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextoPuntos1.Location = new System.Drawing.Point(802, 264);
            this.lbTextoPuntos1.Name = "lbTextoPuntos1";
            this.lbTextoPuntos1.Size = new System.Drawing.Size(134, 28);
            this.lbTextoPuntos1.TabIndex = 4;
            this.lbTextoPuntos1.Text = "Puntos pj1:";
            // 
            // lbPuntos1
            // 
            this.lbPuntos1.AutoSize = true;
            this.lbPuntos1.BackColor = System.Drawing.Color.Orchid;
            this.lbPuntos1.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntos1.Location = new System.Drawing.Point(966, 264);
            this.lbPuntos1.Name = "lbPuntos1";
            this.lbPuntos1.Size = new System.Drawing.Size(26, 28);
            this.lbPuntos1.TabIndex = 5;
            this.lbPuntos1.Text = "0";
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
            this.btRanking.Location = new System.Drawing.Point(809, 389);
            this.btRanking.Name = "btRanking";
            this.btRanking.Size = new System.Drawing.Size(198, 35);
            this.btRanking.TabIndex = 6;
            this.btRanking.Text = "Guardar Partida";
            this.btRanking.UseVisualStyleBackColor = false;
            this.btRanking.Click += new System.EventHandler(this.btRanking_Click);
            // 
            // lbESC
            // 
            this.lbESC.AutoSize = true;
            this.lbESC.BackColor = System.Drawing.Color.Transparent;
            this.lbESC.Font = new System.Drawing.Font("Caladea", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbESC.Location = new System.Drawing.Point(-4, 501);
            this.lbESC.Name = "lbESC";
            this.lbESC.Size = new System.Drawing.Size(192, 23);
            this.lbESC.TabIndex = 7;
            this.lbESC.Text = "ESC para continuar";
            // 
            // lbTextoPuntos2
            // 
            this.lbTextoPuntos2.AutoSize = true;
            this.lbTextoPuntos2.BackColor = System.Drawing.Color.Orchid;
            this.lbTextoPuntos2.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextoPuntos2.Location = new System.Drawing.Point(802, 312);
            this.lbTextoPuntos2.Name = "lbTextoPuntos2";
            this.lbTextoPuntos2.Size = new System.Drawing.Size(134, 28);
            this.lbTextoPuntos2.TabIndex = 8;
            this.lbTextoPuntos2.Text = "Puntos pj2:";
            // 
            // lbPuntos2
            // 
            this.lbPuntos2.AutoSize = true;
            this.lbPuntos2.BackColor = System.Drawing.Color.Orchid;
            this.lbPuntos2.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntos2.Location = new System.Drawing.Point(966, 312);
            this.lbPuntos2.Name = "lbPuntos2";
            this.lbPuntos2.Size = new System.Drawing.Size(26, 28);
            this.lbPuntos2.TabIndex = 9;
            this.lbPuntos2.Text = "0";
            // 
            // lbTextoGanador
            // 
            this.lbTextoGanador.AutoSize = true;
            this.lbTextoGanador.BackColor = System.Drawing.Color.Pink;
            this.lbTextoGanador.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextoGanador.Location = new System.Drawing.Point(802, 179);
            this.lbTextoGanador.Name = "lbTextoGanador";
            this.lbTextoGanador.Size = new System.Drawing.Size(114, 28);
            this.lbTextoGanador.TabIndex = 10;
            this.lbTextoGanador.Text = "Ganador:";
            // 
            // lbGanador
            // 
            this.lbGanador.AutoSize = true;
            this.lbGanador.BackColor = System.Drawing.Color.Pink;
            this.lbGanador.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGanador.Location = new System.Drawing.Point(938, 179);
            this.lbGanador.Name = "lbGanador";
            this.lbGanador.Size = new System.Drawing.Size(83, 28);
            this.lbGanador.TabIndex = 11;
            this.lbGanador.Text = "ambos";
            // 
            // PartidaGanadaMultiPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 537);
            this.Controls.Add(this.lbGanador);
            this.Controls.Add(this.lbTextoGanador);
            this.Controls.Add(this.lbPuntos2);
            this.Controls.Add(this.lbTextoPuntos2);
            this.Controls.Add(this.lbESC);
            this.Controls.Add(this.btRanking);
            this.Controls.Add(this.lbPuntos1);
            this.Controls.Add(this.lbTextoPuntos1);
            this.Controls.Add(this.pbWin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1162, 593);
            this.MinimumSize = new System.Drawing.Size(1162, 593);
            this.Name = "PartidaGanadaMultiPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectDiva";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartidaGanadaMultiPlayer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWin;
        public System.Windows.Forms.Label lbTextoPuntos1;
        public System.Windows.Forms.Label lbPuntos1;
        private System.Windows.Forms.Label lbESC;
        public System.Windows.Forms.Label lbTextoPuntos2;
        public System.Windows.Forms.Label lbPuntos2;
        public System.Windows.Forms.Label lbTextoGanador;
        public System.Windows.Forms.Label lbGanador;
        public System.Windows.Forms.Button btRanking;
    }
}
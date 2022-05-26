
namespace HatsuneMiku_ProjectDIVA
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btPlay = new System.Windows.Forms.Button();
            this.btRanking = new System.Windows.Forms.Button();
            this.btAyuda = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPlay
            // 
            this.btPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btPlay.BackColor = System.Drawing.Color.White;
            this.btPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btPlay.FlatAppearance.BorderSize = 0;
            this.btPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlay.Font = new System.Drawing.Font("Caladea", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlay.ForeColor = System.Drawing.Color.HotPink;
            this.btPlay.Location = new System.Drawing.Point(42, 60);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(416, 62);
            this.btPlay.TabIndex = 0;
            this.btPlay.Text = "PLAY";
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btRanking
            // 
            this.btRanking.BackColor = System.Drawing.Color.White;
            this.btRanking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btRanking.FlatAppearance.BorderSize = 0;
            this.btRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRanking.Font = new System.Drawing.Font("Caladea", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRanking.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btRanking.Location = new System.Drawing.Point(85, 179);
            this.btRanking.Name = "btRanking";
            this.btRanking.Size = new System.Drawing.Size(416, 62);
            this.btRanking.TabIndex = 1;
            this.btRanking.Text = "RANKING";
            this.btRanking.UseVisualStyleBackColor = false;
            this.btRanking.Click += new System.EventHandler(this.btRanking_Click);
            // 
            // btAyuda
            // 
            this.btAyuda.BackColor = System.Drawing.Color.White;
            this.btAyuda.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAyuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btAyuda.FlatAppearance.BorderSize = 0;
            this.btAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAyuda.Font = new System.Drawing.Font("Caladea", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAyuda.ForeColor = System.Drawing.Color.LightGreen;
            this.btAyuda.Location = new System.Drawing.Point(119, 292);
            this.btAyuda.Name = "btAyuda";
            this.btAyuda.Size = new System.Drawing.Size(416, 62);
            this.btAyuda.TabIndex = 2;
            this.btAyuda.Text = "AYUDA";
            this.btAyuda.UseVisualStyleBackColor = false;
            this.btAyuda.Click += new System.EventHandler(this.btAyuda_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.White;
            this.btSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSalir.FlatAppearance.BorderSize = 0;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Font = new System.Drawing.Font("Caladea", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.Color.Orange;
            this.btSalir.Location = new System.Drawing.Point(158, 405);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(416, 62);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "SALIR";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btSalir;
            this.ClientSize = new System.Drawing.Size(1140, 537);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAyuda);
            this.Controls.Add(this.btRanking);
            this.Controls.Add(this.btPlay);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1162, 593);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1162, 593);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectDiva";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btRanking;
        private System.Windows.Forms.Button btAyuda;
        private System.Windows.Forms.Button btSalir;
    }
}
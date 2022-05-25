
namespace HatsuneMiku_ProjectDIVA
{
    partial class Reproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            this.lbListaVideos = new System.Windows.Forms.ListBox();
            this.lbCanciones = new System.Windows.Forms.Label();
            this.btReproducir = new System.Windows.Forms.Button();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbListaVideos
            // 
            this.lbListaVideos.BackColor = System.Drawing.SystemColors.Window;
            this.lbListaVideos.Font = new System.Drawing.Font("Caladea", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListaVideos.FormattingEnabled = true;
            this.lbListaVideos.ItemHeight = 27;
            this.lbListaVideos.Location = new System.Drawing.Point(32, 91);
            this.lbListaVideos.Name = "lbListaVideos";
            this.lbListaVideos.Size = new System.Drawing.Size(181, 193);
            this.lbListaVideos.TabIndex = 0;
            // 
            // lbCanciones
            // 
            this.lbCanciones.AutoSize = true;
            this.lbCanciones.Font = new System.Drawing.Font("Caladea", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCanciones.Location = new System.Drawing.Point(68, 34);
            this.lbCanciones.Name = "lbCanciones";
            this.lbCanciones.Size = new System.Drawing.Size(136, 32);
            this.lbCanciones.TabIndex = 1;
            this.lbCanciones.Text = "Canciones\r\n";
            // 
            // btReproducir
            // 
            this.btReproducir.Font = new System.Drawing.Font("Caladea", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReproducir.Location = new System.Drawing.Point(44, 341);
            this.btReproducir.Name = "btReproducir";
            this.btReproducir.Size = new System.Drawing.Size(144, 48);
            this.btReproducir.TabIndex = 3;
            this.btReproducir.Text = "Reproducir";
            this.btReproducir.UseVisualStyleBackColor = true;
            this.btReproducir.Click += new System.EventHandler(this.btReproducir_Click);
            // 
            // pbBack
            // 
            this.pbBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBack.BackgroundImage")));
            this.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBack.Location = new System.Drawing.Point(-4, 469);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(87, 68);
            this.pbBack.TabIndex = 12;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(169, 22);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(576, 328);
            this.axWindowsMediaPlayer.TabIndex = 13;
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1138, 529);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.btReproducir);
            this.Controls.Add(this.lbCanciones);
            this.Controls.Add(this.lbListaVideos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1162, 593);
            this.MinimumSize = new System.Drawing.Size(1162, 593);
            this.Name = "Reproductor";
            this.Text = "ProjectDiva";
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListaVideos;
        private System.Windows.Forms.Label lbCanciones;
        private System.Windows.Forms.Button btReproducir;
        private System.Windows.Forms.PictureBox pbBack;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
    }
}
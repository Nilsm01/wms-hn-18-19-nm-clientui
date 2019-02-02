namespace ClientUI
{
    partial class MediaPlayer
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.metroTrackBar1.Location = new System.Drawing.Point(934, 9);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(146, 23);
            this.metroTrackBar1.TabIndex = 0;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientUI.Properties.Resources.placeholder;
            this.pictureBox1.Location = new System.Drawing.Point(471, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1096, 1);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 31);
            this.label2.TabIndex = 3;
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTrackBar1);
            this.Name = "MediaPlayer";
            this.Size = new System.Drawing.Size(1096, 41);
            this.Load += new System.EventHandler(this.MediaPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

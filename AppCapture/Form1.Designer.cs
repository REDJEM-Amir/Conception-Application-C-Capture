namespace AppCapture
{
    partial class Application
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            this.imageCapture = new System.Windows.Forms.PictureBox();
            this.ButtonStream = new System.Windows.Forms.Button();
            this.ButtonScreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCapture
            // 
            this.imageCapture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imageCapture.Location = new System.Drawing.Point(12, 12);
            this.imageCapture.Name = "imageCapture";
            this.imageCapture.Size = new System.Drawing.Size(1240, 571);
            this.imageCapture.TabIndex = 0;
            this.imageCapture.TabStop = false;
            this.imageCapture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ButtonStream
            // 
            this.ButtonStream.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonStream.Location = new System.Drawing.Point(476, 589);
            this.ButtonStream.Name = "ButtonStream";
            this.ButtonStream.Size = new System.Drawing.Size(146, 43);
            this.ButtonStream.TabIndex = 1;
            this.ButtonStream.Text = "Stream";
            this.ButtonStream.UseVisualStyleBackColor = false;
            this.ButtonStream.Click += new System.EventHandler(this.buttonStream_Click);
            // 
            // ButtonScreen
            // 
            this.ButtonScreen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonScreen.Location = new System.Drawing.Point(660, 589);
            this.ButtonScreen.Name = "ButtonScreen";
            this.ButtonScreen.Size = new System.Drawing.Size(146, 43);
            this.ButtonScreen.TabIndex = 2;
            this.ButtonScreen.Text = "Capture";
            this.ButtonScreen.UseVisualStyleBackColor = false;
            this.ButtonScreen.Click += new System.EventHandler(this.ButtonScreen_Click);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ButtonScreen);
            this.Controls.Add(this.ButtonStream);
            this.Controls.Add(this.imageCapture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            ((System.ComponentModel.ISupportInitialize)(this.imageCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageCapture;
        private System.Windows.Forms.Button ButtonStream;
        private System.Windows.Forms.Button ButtonScreen;
    }
}


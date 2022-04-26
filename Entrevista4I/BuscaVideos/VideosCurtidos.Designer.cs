namespace BuscaVideos
{
    partial class videosCurtidos
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
            this.listaVideos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listaVideos
            // 
            this.listaVideos.Location = new System.Drawing.Point(12, 12);
            this.listaVideos.Multiline = true;
            this.listaVideos.Name = "listaVideos";
            this.listaVideos.ReadOnly = true;
            this.listaVideos.Size = new System.Drawing.Size(386, 504);
            this.listaVideos.TabIndex = 0;
            // 
            // videosCurtidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 528);
            this.Controls.Add(this.listaVideos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "videosCurtidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "videosCurtidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox listaVideos;
    }
}
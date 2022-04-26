namespace MarcaVideos
{
    partial class F_abaPesquisa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.clb_listavideos = new System.Windows.Forms.CheckedListBox();
            this.bt_addVideo = new System.Windows.Forms.Button();
            this.lb_video = new System.Windows.Forms.Label();
            this.tb_nomeVideo = new System.Windows.Forms.TextBox();
            this.tb_mostrar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clb_listavideos
            // 
            this.clb_listavideos.FormattingEnabled = true;
            this.clb_listavideos.Location = new System.Drawing.Point(12, 76);
            this.clb_listavideos.Name = "clb_listavideos";
            this.clb_listavideos.Size = new System.Drawing.Size(391, 310);
            this.clb_listavideos.TabIndex = 0;
            // 
            // bt_addVideo
            // 
            this.bt_addVideo.Location = new System.Drawing.Point(264, 39);
            this.bt_addVideo.Name = "bt_addVideo";
            this.bt_addVideo.Size = new System.Drawing.Size(144, 36);
            this.bt_addVideo.TabIndex = 1;
            this.bt_addVideo.Text = "Adicionar Video";
            this.bt_addVideo.UseVisualStyleBackColor = true;
            this.bt_addVideo.Click += new System.EventHandler(this.bt_addVideo_Click);
            // 
            // lb_video
            // 
            this.lb_video.AutoSize = true;
            this.lb_video.Location = new System.Drawing.Point(9, 9);
            this.lb_video.Name = "lb_video";
            this.lb_video.Size = new System.Drawing.Size(146, 16);
            this.lb_video.TabIndex = 2;
            this.lb_video.Text = "Digite o nome do vídeo";
            // 
            // tb_nomeVideo
            // 
            this.tb_nomeVideo.Location = new System.Drawing.Point(12, 39);
            this.tb_nomeVideo.Name = "tb_nomeVideo";
            this.tb_nomeVideo.Size = new System.Drawing.Size(246, 22);
            this.tb_nomeVideo.TabIndex = 3;
            // 
            // tb_mostrar
            // 
            this.tb_mostrar.Location = new System.Drawing.Point(12, 392);
            this.tb_mostrar.Name = "tb_mostrar";
            this.tb_mostrar.Size = new System.Drawing.Size(391, 34);
            this.tb_mostrar.TabIndex = 4;
            this.tb_mostrar.Text = "Videos Curtidos";
            this.tb_mostrar.UseVisualStyleBackColor = true;
            this.tb_mostrar.Click += new System.EventHandler(this.tb_mostrar_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(12, 445);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(391, 34);
            this.bt_limpar.TabIndex = 5;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // F_abaPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 493);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.tb_mostrar);
            this.Controls.Add(this.tb_nomeVideo);
            this.Controls.Add(this.lb_video);
            this.Controls.Add(this.bt_addVideo);
            this.Controls.Add(this.clb_listavideos);
            this.MaximizeBox = false;
            this.Name = "F_abaPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aba de pesquisa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_listavideos;
        private System.Windows.Forms.Button bt_addVideo;
        private System.Windows.Forms.Label lb_video;
        private System.Windows.Forms.TextBox tb_nomeVideo;
        private System.Windows.Forms.Button tb_mostrar;
        private System.Windows.Forms.Button bt_limpar;
    }
}


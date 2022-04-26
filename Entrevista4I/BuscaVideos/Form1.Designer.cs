namespace BuscaVideos
{
    partial class Principal
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
            this.bt_pesquisa = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.nomeDoVideo = new System.Windows.Forms.TextBox();
            this.listaDeVideos = new System.Windows.Forms.TextBox();
            this.bt_mostrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarVideosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeCurtidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_pesquisa
            // 
            this.bt_pesquisa.Location = new System.Drawing.Point(260, 86);
            this.bt_pesquisa.Name = "bt_pesquisa";
            this.bt_pesquisa.Size = new System.Drawing.Size(130, 33);
            this.bt_pesquisa.TabIndex = 0;
            this.bt_pesquisa.Text = "Pesquisar";
            this.bt_pesquisa.UseVisualStyleBackColor = true;
            this.bt_pesquisa.Click += new System.EventHandler(this.bt_pesquisa_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(12, 520);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(378, 35);
            this.bt_limpar.TabIndex = 1;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // nomeDoVideo
            // 
            this.nomeDoVideo.Location = new System.Drawing.Point(12, 97);
            this.nomeDoVideo.Name = "nomeDoVideo";
            this.nomeDoVideo.Size = new System.Drawing.Size(242, 22);
            this.nomeDoVideo.TabIndex = 2;
            this.nomeDoVideo.TextChanged += new System.EventHandler(this.nomeDoVideo_TextChanged);
            // 
            // listaDeVideos
            // 
            this.listaDeVideos.Location = new System.Drawing.Point(12, 125);
            this.listaDeVideos.Multiline = true;
            this.listaDeVideos.Name = "listaDeVideos";
            this.listaDeVideos.ReadOnly = true;
            this.listaDeVideos.Size = new System.Drawing.Size(378, 374);
            this.listaDeVideos.TabIndex = 3;
            // 
            // bt_mostrar
            // 
            this.bt_mostrar.Location = new System.Drawing.Point(12, 561);
            this.bt_mostrar.Name = "bt_mostrar";
            this.bt_mostrar.Size = new System.Drawing.Size(378, 39);
            this.bt_mostrar.TabIndex = 4;
            this.bt_mostrar.Text = "Mostrar videos";
            this.bt_mostrar.UseVisualStyleBackColor = true;
            this.bt_mostrar.Click += new System.EventHandler(this.bt_mostrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarVideosToolStripMenuItem,
            this.listaDeCurtidosToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // visualizarVideosToolStripMenuItem
            // 
            this.visualizarVideosToolStripMenuItem.Name = "visualizarVideosToolStripMenuItem";
            this.visualizarVideosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.visualizarVideosToolStripMenuItem.Text = "Visualizar videos";
            this.visualizarVideosToolStripMenuItem.Click += new System.EventHandler(this.visualizarVideosToolStripMenuItem_Click);
            // 
            // listaDeCurtidosToolStripMenuItem
            // 
            this.listaDeCurtidosToolStripMenuItem.Name = "listaDeCurtidosToolStripMenuItem";
            this.listaDeCurtidosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaDeCurtidosToolStripMenuItem.Text = "Lista de Curtidos";
            this.listaDeCurtidosToolStripMenuItem.Click += new System.EventHandler(this.listaDeCurtidosToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 612);
            this.Controls.Add(this.bt_mostrar);
            this.Controls.Add(this.listaDeVideos);
            this.Controls.Add(this.nomeDoVideo);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_pesquisa);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Janela de pesquisa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_pesquisa;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.TextBox nomeDoVideo;
        private System.Windows.Forms.TextBox listaDeVideos;
        private System.Windows.Forms.Button bt_mostrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarVideosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeCurtidosToolStripMenuItem;
    }
}


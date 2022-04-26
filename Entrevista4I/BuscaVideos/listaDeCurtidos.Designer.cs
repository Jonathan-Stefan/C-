namespace BuscaVideos
{
    partial class listaDeCurtidos
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
            this.listaGostei = new System.Windows.Forms.CheckedListBox();
            this.bt_mostrarselecionados = new System.Windows.Forms.Button();
            this.bt_limparLista = new System.Windows.Forms.Button();
            this.tb_addVideo = new System.Windows.Forms.TextBox();
            this.bt_adicionarNovoVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaGostei
            // 
            this.listaGostei.Location = new System.Drawing.Point(12, 12);
            this.listaGostei.Name = "listaGostei";
            this.listaGostei.Size = new System.Drawing.Size(188, 293);
            this.listaGostei.TabIndex = 0;
            // 
            // bt_mostrarselecionados
            // 
            this.bt_mostrarselecionados.Location = new System.Drawing.Point(227, 12);
            this.bt_mostrarselecionados.Name = "bt_mostrarselecionados";
            this.bt_mostrarselecionados.Size = new System.Drawing.Size(144, 31);
            this.bt_mostrarselecionados.TabIndex = 1;
            this.bt_mostrarselecionados.Text = "Mostrar selecionados";
            this.bt_mostrarselecionados.UseVisualStyleBackColor = true;
            this.bt_mostrarselecionados.Click += new System.EventHandler(this.bt_mostrarselecionados_Click);
            // 
            // bt_limparLista
            // 
            this.bt_limparLista.Location = new System.Drawing.Point(227, 49);
            this.bt_limparLista.Name = "bt_limparLista";
            this.bt_limparLista.Size = new System.Drawing.Size(144, 33);
            this.bt_limparLista.TabIndex = 2;
            this.bt_limparLista.Text = "Limpar Lista";
            this.bt_limparLista.UseVisualStyleBackColor = true;
            // 
            // tb_addVideo
            // 
            this.tb_addVideo.Location = new System.Drawing.Point(206, 213);
            this.tb_addVideo.Name = "tb_addVideo";
            this.tb_addVideo.Size = new System.Drawing.Size(165, 22);
            this.tb_addVideo.TabIndex = 3;
            // 
            // bt_adicionarNovoVideo
            // 
            this.bt_adicionarNovoVideo.Location = new System.Drawing.Point(256, 251);
            this.bt_adicionarNovoVideo.Name = "bt_adicionarNovoVideo";
            this.bt_adicionarNovoVideo.Size = new System.Drawing.Size(115, 22);
            this.bt_adicionarNovoVideo.TabIndex = 4;
            this.bt_adicionarNovoVideo.Text = "Adicionar novo video";
            this.bt_adicionarNovoVideo.UseVisualStyleBackColor = true;
            this.bt_adicionarNovoVideo.Click += new System.EventHandler(this.bt_adicionarNovoVideo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite novo video";
            // 
            // listaDeCurtidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_adicionarNovoVideo);
            this.Controls.Add(this.tb_addVideo);
            this.Controls.Add(this.bt_limparLista);
            this.Controls.Add(this.bt_mostrarselecionados);
            this.Controls.Add(this.listaGostei);
            this.MaximizeBox = false;
            this.Name = "listaDeCurtidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listaDeCurtidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listaGostei;
        private System.Windows.Forms.Button bt_mostrarselecionados;
        private System.Windows.Forms.Button bt_limparLista;
        private System.Windows.Forms.TextBox tb_addVideo;
        private System.Windows.Forms.Button bt_adicionarNovoVideo;
        private System.Windows.Forms.Label label1;
    }
}
namespace Bloco_de_Notas
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tsmArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaJanelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.smiDesfazer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.smiRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLocalizar = new System.Windows.Forms.ToolStripMenuItem();
            this.smiSubstituir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelecionarTudo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDataHora = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuebraLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAmpliar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReduzir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRestaurarZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreOBlocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(747, 355);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // tsmArquivo
            // 
            this.tsmArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.novaJanelaToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.tsmArquivo.Name = "tsmArquivo";
            this.tsmArquivo.Size = new System.Drawing.Size(61, 19);
            this.tsmArquivo.Text = "Arquivo";
            this.tsmArquivo.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.novoToolStripMenuItem.Text = "Novo (Ctrl+N)";
            // 
            // novaJanelaToolStripMenuItem
            // 
            this.novaJanelaToolStripMenuItem.Name = "novaJanelaToolStripMenuItem";
            this.novaJanelaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.novaJanelaToolStripMenuItem.Text = "Nova Janela (Ctrl+Shift+N)";
            this.novaJanelaToolStripMenuItem.Click += new System.EventHandler(this.novaJanelaToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.abrirToolStripMenuItem.Text = "Abrir (Ctrl+O)";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.salvarToolStripMenuItem.Text = "Salvar (Ctrl+S)";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como (Ctrl+Shift+S)";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tsmEditar
            // 
            this.tsmEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiDesfazer,
            this.toolStripSeparator4,
            this.smiRecortar,
            this.tsmiCopiar,
            this.tsmiColar,
            this.tsmiExcluir,
            this.toolStripSeparator5,
            this.tsmiLocalizar,
            this.smiSubstituir,
            this.toolStripSeparator6,
            this.tsmiSelecionarTudo,
            this.tsmiDataHora});
            this.tsmEditar.Name = "tsmEditar";
            this.tsmEditar.Size = new System.Drawing.Size(49, 19);
            this.tsmEditar.Text = "Editar";
            // 
            // smiDesfazer
            // 
            this.smiDesfazer.Name = "smiDesfazer";
            this.smiDesfazer.Size = new System.Drawing.Size(204, 22);
            this.smiDesfazer.Text = "Desfazer (Ctrl+z)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(201, 6);
            // 
            // smiRecortar
            // 
            this.smiRecortar.Enabled = false;
            this.smiRecortar.Name = "smiRecortar";
            this.smiRecortar.Size = new System.Drawing.Size(204, 22);
            this.smiRecortar.Text = "Recortar (Ctrl+X)";
            // 
            // tsmiCopiar
            // 
            this.tsmiCopiar.Enabled = false;
            this.tsmiCopiar.Name = "tsmiCopiar";
            this.tsmiCopiar.Size = new System.Drawing.Size(204, 22);
            this.tsmiCopiar.Text = "Copiar (Ctrl+C)";
            this.tsmiCopiar.Click += new System.EventHandler(this.tsmiCopiar_Click);
            // 
            // tsmiColar
            // 
            this.tsmiColar.Name = "tsmiColar";
            this.tsmiColar.Size = new System.Drawing.Size(204, 22);
            this.tsmiColar.Text = "Colar (Ctrl+V)";
            this.tsmiColar.Click += new System.EventHandler(this.tsmiColar_Click);
            // 
            // tsmiExcluir
            // 
            this.tsmiExcluir.Enabled = false;
            this.tsmiExcluir.Name = "tsmiExcluir";
            this.tsmiExcluir.Size = new System.Drawing.Size(204, 22);
            this.tsmiExcluir.Text = "Excluir (Del)";
            this.tsmiExcluir.Click += new System.EventHandler(this.tsmiExcluir_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(201, 6);
            // 
            // tsmiLocalizar
            // 
            this.tsmiLocalizar.Enabled = false;
            this.tsmiLocalizar.Name = "tsmiLocalizar";
            this.tsmiLocalizar.Size = new System.Drawing.Size(204, 22);
            this.tsmiLocalizar.Text = "Localizar (Ctrl+F)";
            this.tsmiLocalizar.Click += new System.EventHandler(this.tsmiLocalizar_Click);
            // 
            // smiSubstituir
            // 
            this.smiSubstituir.Name = "smiSubstituir";
            this.smiSubstituir.Size = new System.Drawing.Size(204, 22);
            this.smiSubstituir.Text = "Substituir (Ctrl+H)";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(201, 6);
            // 
            // tsmiSelecionarTudo
            // 
            this.tsmiSelecionarTudo.Name = "tsmiSelecionarTudo";
            this.tsmiSelecionarTudo.Size = new System.Drawing.Size(204, 22);
            this.tsmiSelecionarTudo.Text = "Selecionar Tudo (Ctrl+A)";
            this.tsmiSelecionarTudo.Click += new System.EventHandler(this.tsmiSelecionarTudo_Click);
            // 
            // tsmiDataHora
            // 
            this.tsmiDataHora.Name = "tsmiDataHora";
            this.tsmiDataHora.Size = new System.Drawing.Size(204, 22);
            this.tsmiDataHora.Text = "Data/Hora (F5)";
            this.tsmiDataHora.Click += new System.EventHandler(this.tsmiDataHora_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQuebraLinha});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 19);
            this.toolStripMenuItem1.Text = "Formatar";
            // 
            // tsmQuebraLinha
            // 
            this.tsmQuebraLinha.Image = global::Bloco_de_Notas.Properties.Resources._326572_check_icon__1_;
            this.tsmQuebraLinha.Name = "tsmQuebraLinha";
            this.tsmQuebraLinha.Size = new System.Drawing.Size(221, 22);
            this.tsmQuebraLinha.Text = "Quebra automática de linha";
            this.tsmQuebraLinha.Click += new System.EventHandler(this.tsmQuebraLinha_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAmpliar,
            this.tsmiReduzir,
            this.tsmiRestaurarZoom});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // tsmiAmpliar
            // 
            this.tsmiAmpliar.Name = "tsmiAmpliar";
            this.tsmiAmpliar.Size = new System.Drawing.Size(198, 22);
            this.tsmiAmpliar.Text = "Ampliar";
            this.tsmiAmpliar.Click += new System.EventHandler(this.tsmiAmpliar_Click);
            // 
            // tsmiReduzir
            // 
            this.tsmiReduzir.Name = "tsmiReduzir";
            this.tsmiReduzir.Size = new System.Drawing.Size(198, 22);
            this.tsmiReduzir.Text = "Reduzir";
            this.tsmiReduzir.Click += new System.EventHandler(this.tsmiReduzir_Click);
            // 
            // tsmiRestaurarZoom
            // 
            this.tsmiRestaurarZoom.Name = "tsmiRestaurarZoom";
            this.tsmiRestaurarZoom.Size = new System.Drawing.Size(198, 22);
            this.tsmiRestaurarZoom.Text = "Restaurar Zoom Padrão";
            this.tsmiRestaurarZoom.Click += new System.EventHandler(this.tsmiRestaurarZoom_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAjuda,
            this.toolStripSeparator3,
            this.sobreOBlocoDeNotasToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // tsmiAjuda
            // 
            this.tsmiAjuda.Name = "tsmiAjuda";
            this.tsmiAjuda.Size = new System.Drawing.Size(197, 22);
            this.tsmiAjuda.Text = "Exibir Ajuda";
            this.tsmiAjuda.Click += new System.EventHandler(this.tsmiAjuda_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(194, 6);
            // 
            // sobreOBlocoDeNotasToolStripMenuItem
            // 
            this.sobreOBlocoDeNotasToolStripMenuItem.Name = "sobreOBlocoDeNotasToolStripMenuItem";
            this.sobreOBlocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.sobreOBlocoDeNotasToolStripMenuItem.Text = "Sobre o Bloco de Notas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArquivo,
            this.tsmEditar,
            this.toolStripMenuItem1,
            this.exibirToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(747, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 380);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sem título - Bloco de Notas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmArquivo;
        private System.Windows.Forms.ToolStripMenuItem tsmEditar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmQuebraLinha;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaJanelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjuda;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAmpliar;
        private System.Windows.Forms.ToolStripMenuItem tsmiReduzir;
        private System.Windows.Forms.ToolStripMenuItem tsmiRestaurarZoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem sobreOBlocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smiDesfazer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem smiRecortar;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopiar;
        private System.Windows.Forms.ToolStripMenuItem tsmiColar;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocalizar;
        private System.Windows.Forms.ToolStripMenuItem smiSubstituir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelecionarTudo;
        private System.Windows.Forms.ToolStripMenuItem tsmiDataHora;
        private System.Windows.Forms.Timer timer1;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloco_de_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void tsmQuebraLinha_Click(object sender, EventArgs e)
        {
            if (richTextBox1.WordWrap)
                richTextBox1.WordWrap = false;
            else
                richTextBox1.WordWrap = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            timer1.Stop();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "arquivos txt (*.txt)|*.txt|All files (*.*)|";
            saveFileDialog1.RestoreDirectory = true;

            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text,Encoding.UTF8);
                MessageBox.Show("Salvo!");
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "arquivos txt (*.txt)|*.txt|All files (*.*)|";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog1.FileName, Encoding.UTF8);
                
                foreach(var line in lines)
                {
                    richTextBox1.Text += line;
                }
                Name = openFileDialog1.FileName + " - Bloco de Notas";
            }
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 bloco = new Form1();
            bloco.Show();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            saveFileDialog1.Filter = "arquivos txt (*.txt)|*.txt|All files (*.*)|";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text, Encoding.UTF8);
                MessageBox.Show("Salvo!");
            }*/
        }

        private void tsmiAjuda_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/search?client=opera-gx&q=obter+ajuda+com+o+bloco+de+notas+no+windows&sourceid=opera&ie=UTF-8&oe=UTF-8");
        }

        private void tsmiCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);

        }

        private void barraDeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiAmpliar_Click(object sender, EventArgs e)
        {
            richTextBox1.Font= new Font(FontFamily.GenericSansSerif,richTextBox1.Font.Size+1,FontStyle.Regular);
        }
        private void tsmiReduzir_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(FontFamily.GenericSansSerif, richTextBox1.Font.Size - 1, FontStyle.Regular);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5) // se apertou a tecla F5
                richTextBox1.Text += DateTime.Now + " ";

            else if (e.KeyCode==Keys.O && e.Control) // se apertou as teclas Ctrl + O
            {
                openFileDialog1.Filter = "arquivos txt (*.txt)|*.txt|All files (*.*)|";
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(openFileDialog1.FileName, Encoding.UTF8);

                    foreach (var line in lines)
                    {
                        richTextBox1.Text += line;
                    }
                    Name = openFileDialog1.FileName + " - Bloco de Notas";
                }
            }
            else if (e.KeyCode == Keys.S && e.Control) //se apertou as teclas Ctrl+S
            {
                saveFileDialog1.Filter = "arquivos txt (*.txt)|*.txt|All files (*.*)|";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text, Encoding.UTF8);
                    MessageBox.Show("Salvo!");
                }
            }
            else if (e.KeyCode == Keys.S && (e.Control&&e.Shift)) //se apertou as teclas Ctrl+Shift+S
            {
                saveFileDialog1.Filter = "arquivos txt (*.txt)|*.txt|All files (*.*)|";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text, Encoding.UTF8);
                    MessageBox.Show("Salvo!");
                }
            }
            else if (e.KeyCode == Keys.N && (e.Control && e.Shift)) //se apertou as teclas Ctrl+Shift+N
            {
                Form1 bloco = new Form1();
                bloco.Show();
            }
            else if(e.KeyCode==Keys.F&&e.Control) //se apertou as teclas Ctrl+F
            {
                frmLocalizar localizar = new frmLocalizar();
                localizar.richText = richTextBox1;
                localizar.ShowDialog();
            }
            else if (e.KeyCode == Keys.N && e.Control) //se apertou as teclas Ctrl+N
            {
                if(!string.IsNullOrEmpty(richTextBox1.Text))
                {
                    string mensagem = "Deseja salvar as alterações?";
                    var resultado= MessageBox.Show(mensagem,"Bloco de notas",MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        saveFileDialog1.Filter = "arquivos txt (*.txt)|*.txt|All files (*.*)|";
                        saveFileDialog1.RestoreDirectory = true;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text, Encoding.UTF8);
                            MessageBox.Show("Salvo!");

                            Form1 bloco = new Form1();
                            bloco.Show();
                        }
                    }
                }
            }
            else if(e.KeyCode==Keys.F1)
            {
                Process.Start("https://www.google.com/search?q=obter+ajuda+com+o+bloco+de+notas+no+windows");
            }
           else if (e.KeyCode==Keys.Add&&e.Control) //se apertou a tecla Ctrl mais +
            {
                richTextBox1.Font = new Font(FontFamily.GenericSansSerif, richTextBox1.Font.Size + 1, FontStyle.Regular);
            }
            else if (e.KeyCode == Keys.Subtract&& e.Control) //se apertou a tecla Ctrl mais +
            {
                richTextBox1.Font = new Font(FontFamily.GenericSansSerif, richTextBox1.Font.Size - 1, FontStyle.Regular);
            }
            else if ((e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0) && e.Control)
            {
                richTextBox1.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Regular);
            }
        }

        private void tsmiDataHora_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now + " ";
        }

        private void tsmiColar_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Clipboard.GetText();
        }

        private void tsmiExcluir_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void tsmiSelecionarTudo_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void tsmiLocalizar_Click(object sender, EventArgs e)
        {
            frmLocalizar localizar = new frmLocalizar();
            localizar.richText = richTextBox1;
            localizar.ShowDialog();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if(richTextBox1.WordWrap==false)
            {
                tsmQuebraLinha.Image=null;
            }
            else
            {
                tsmQuebraLinha.Image = Properties.Resources._326572_check_icon__1_; 
            }
            if(!string.IsNullOrEmpty(richTextBox1.Text) &&!string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                tsmiCopiar.Enabled = true;
                smiRecortar.Enabled = true;
                tsmiExcluir.Enabled = true;
                tsmiLocalizar.Enabled = true;
            }
            else
            {
                tsmiCopiar.Enabled = false;
                smiRecortar.Enabled = false;
                tsmiExcluir.Enabled = false;
                tsmiLocalizar.Enabled =false;
            }
        }

        private void tsmiRestaurarZoom_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Regular);
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

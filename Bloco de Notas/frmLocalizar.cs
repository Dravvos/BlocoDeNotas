using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloco_de_Notas
{
    public partial class frmLocalizar : Form
    {
        public frmLocalizar()
        {
            InitializeComponent();
        }
        public RichTextBox richText = null;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLocalizaProxima_Click(object sender, EventArgs e)
        {
            var text = richText.Text;
            if (text.Contains(txtLocalizar.Text))
            {
                int inicio=richText.Find(txtLocalizar.Text);
                richText.Select(inicio,txtLocalizar.Text.Length);
                Close();
            }
            else
            {
                MessageBox.Show("A palavra não foi encontrada");
            }
        }
    }
}

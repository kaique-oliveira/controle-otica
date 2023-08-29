using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kvision.Frame.Paginas
{
    public partial class Mensagem : Form
    {
        private readonly string _titulo;
        private readonly string _texto;
        private readonly bool _tipo; 
        public Mensagem(string titulo, string texto, bool tipo)
        {
            _titulo = titulo;
            _texto = texto;
            _tipo = tipo;
            InitializeComponent(); 
        }

        private void Mensagem_Load(object sender, EventArgs e)
        {
            lbl_titulo.ForeColor = _tipo == true ? Color.RoyalBlue : Color.Orange;
            lbl_titulo.Text = _titulo;
            lbl_texto.Text = _texto;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

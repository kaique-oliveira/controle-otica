using k_vision;
using Kvision.Dominio.ViewModel;
using System;
using System.Text.RegularExpressions;

namespace Kvision.Frame.Paginas.PgVendaProduto
{
    public partial class AddAdicional : Form
    {
        private MainFrame _mainFrame;
        private TelaBlur _blur;
        public AddAdicional(MainFrame mainFrame, TelaBlur blur)
        {
            _mainFrame = mainFrame;
            InitializeComponent();
            _blur = blur;
            this.ShowInTaskbar = false;
        }

        private void TextKeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals('\b'))
            {
                TextBox t = (TextBox)sender;
                string w = Regex.Replace(t.Text, "[^0-9]", string.Empty);


                if (e.KeyChar.Equals('\b'))
                {
                    if (w == string.Empty) w = "00";
                    w = w.Substring(0, w.Length - 1);
                }
                else
                {
                    w += e.KeyChar;

                    t.Text = string.Format("{0:#,##0.00}", Double.Parse(w) / 100);
                    t.Select(t.Text.Length, 0);
                    e.Handled = true;
                }
                return;
            }
            var x = e.KeyChar;
            e.Handled = true;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _blur.Close();
            this.Close();
        }

        private void bnt_confirmar_Click(object sender, EventArgs e)
        {
            Adicional adicional = new Adicional();

            if (!string.IsNullOrEmpty(txt_descricao.Text) && !string.IsNullOrEmpty(txt_valor.Text))
            {
                adicional.Descricao = txt_descricao.Text;
                adicional.Valor = decimal.Parse(txt_valor.Text.Replace(".", ","));

                _mainFrame.confirmarAdicional(adicional);

                MessageBox.Show("Adicional salvo com sucesso!", "Tudo certo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_descricao.Text = "";
                txt_valor.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos, para continuar!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

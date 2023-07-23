using Kvision.Database.Conexao;
using Kvision.Database.Interfaces;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Interfaces;
using Kvision.Frame.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Kvision.Frame.Paginas.PgExames
{
    public partial class MainReceita : Form
    {
        private readonly Cliente _cliente;
        public MainReceita(Cliente cliente)
        {
            _cliente = cliente;
            InitializeComponent();
        }


        ServicosReceita servicos = new ServicosReceita(new CrudReceita(new ConexaoDatabase()));
        ServicosPrescricao servicosPrescricao = new ServicosPrescricao(new CrudPrescricao(new ConexaoDatabase()));
        List<Receita> listaReceita = new List<Receita>();
        int indexlista = -1;


        public void atualizarGrid()
        {
            dg_receitas.AutoGenerateColumns = false;
            listaReceita = servicos.ConsultarTodos().FindAll(r => r.Cliente.Id == _cliente.Id);

            if (listaReceita.Count > 0)
            {
                dg_receitas.DataSource = listaReceita;
                indexlista = -1;
                dg_receitas.Rows[0].Cells[0].Selected = false;
            }
        }

        private void buscarPrescricao()
        {
            Prescricao prescricao = new Prescricao();

            var prescricoes  = servicosPrescricao.ConsultarTodos();

        }

        private void MainExames_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void bnt_cadastrar_Click(object sender, EventArgs e)
        {
            var persistirExame = new PersistirReceita(_cliente);
            persistirExame.ShowDialog();
        }

        private void dg_receitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexlista = dg_receitas.CurrentCell.RowIndex;
            buscarPrescricao();
        }
    }
}

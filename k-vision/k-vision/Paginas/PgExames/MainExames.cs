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
    public partial class MainExames : Form
    {
        int _idCliente = 0;
        public MainExames(int idCliente)
        {
            _idCliente = idCliente;
            InitializeComponent();
        }


        ServicosReceita servicos = new ServicosReceita(new CrudReceita(new ConexaoDatabase()));
        List<Receita> listaReceita = new List<Receita>();
        int indexlista = -1;
     

        public void atualizarGrid()
        {
            indexlista = -1;
            dg_receitas.AutoGenerateColumns = false;
            listaReceita = servicos.ConsultarTodos().FindAll(r => r.Cliente.Id == _idCliente);
            dg_receitas.DataSource = listaReceita;
            //dg_receitas.Rows[0].Cells[0].Selected = false;
        }
        private void MainExames_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }
    }
}

using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Interfaces;

namespace Kvision.Frame.Servicos
{
    public class ServicosCliente : IServicos<Cliente>
    {
        private readonly ICliente _cliente;

        public ServicosCliente(ICliente cliente)
        {
            _cliente = cliente;
        }

        public string Cadastrar(Cliente cliente)
        {
            string resultValidacao = ValidarCampos(cliente);

            if (resultValidacao == "")
            {
                if (_cliente.Insert(cliente))
                {
                    return "Cliente cadastro com sucesso!";
                }

                return "Ops, algo deu errado";
            }
            
            return resultValidacao;
        }

        public string Editar(Cliente cliente)
        {
            string resultValidacao = ValidarCampos(cliente);

            if (resultValidacao == "")
            {
                if (_cliente.Update(cliente))
                {
                    return "Cliente editado com sucesso!";
                }

                return "Ops, algo deu errado";
            }

            return resultValidacao;
        }

        public List<Cliente> ConsultarTodos() { 
 
            var result = _cliente.FindAll().ToList<Cliente>();

            return result;
        }

        private string ValidarCampos(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome) || string.IsNullOrEmpty(cliente.Telefone)) {
                return "Preencha todos os campos!";
            }

            return "";
        }

        public string Deletar(Cliente cliente)
        {
            if (_cliente.Delete(cliente))
            {
                    return "Cliente deletado com sucesso!";
            }
            else
            {
                return "Ops, algo deu errado";
            }
        }
    }
}

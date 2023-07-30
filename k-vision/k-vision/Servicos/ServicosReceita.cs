
using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Interfaces;

namespace Kvision.Frame.Servicos
{
    public class ServicosReceita : IServicos<Receita>
    {
        private readonly IReceita _receita;

        public ServicosReceita(IReceita receita)
        {
            _receita = receita;
        }

        public string Cadastrar(Receita receita)
        {
            string resultValidacao = ValidarCampos(receita);

            if (resultValidacao == "")
            {
                if (_receita.Insert(receita))
                {
                    return "Receita cadastrado com sucesso!";
                }

                return "Ops, algo deu errado";
            }

            return resultValidacao;
        }

        public List<Receita> ConsultarTodos()
        {
            var result = _receita.FindAll().ToList<Receita>();

            return result;
        }

        public string Deletar(Receita receita, List<Prescricao> prescricoes, ServicosPrescricao servicosPrescricao)
        {
            foreach (var presc in prescricoes)
            {
                servicosPrescricao.Deletar(presc);
            }
            if (_receita.Delete(receita))
            {
                return "Receita deletada com sucesso!";
            }
            else
            {
                return "Ops, algo deu errado";
            }
        }

        public string Deletar(Receita entidade)
        {
            throw new NotImplementedException();
        }

        public string Editar(Receita receita)
        {
            string resultValidacao = ValidarCampos(receita);

            if (resultValidacao == "")
            {
                if (_receita.Update(receita))
                {
                    return "Receita cadastrado com sucesso!";
                }

                return "Ops, algo deu errado";
            }

            return resultValidacao;
        }

        private string ValidarCampos(Receita receita)
        {
            if (string.IsNullOrEmpty(receita.DataExame.ToString()) 
                || string.IsNullOrEmpty(receita.DataValExame.ToString()) || string.IsNullOrEmpty(receita.NomeExaminador))
            {
                return "Preencha todos os campos!";
            }

            return "";
        }
    }
}

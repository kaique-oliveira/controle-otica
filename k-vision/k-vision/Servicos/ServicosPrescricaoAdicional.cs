using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Interfaces;

namespace Kvision.Frame.Servicos
{
    public class ServicosPrescricaoAdicional : IServicos<PrescricaoAdicional>
    {
        private readonly IPrescricaoAdicional _prescricaoAdcional;

        public ServicosPrescricaoAdicional(IPrescricaoAdicional prescricaoAdcional)
        {
            _prescricaoAdcional = prescricaoAdcional;
        }

        public string Cadastrar(PrescricaoAdicional prescAdicional)
        {
            _prescricaoAdcional.Insert(prescAdicional);

            return "ok";
        }

        public List<PrescricaoAdicional> ConsultarTodos()
        {
            var result = _prescricaoAdcional.FindAll().ToList<PrescricaoAdicional>();

            return result;
        }

        public string Deletar(PrescricaoAdicional prescAdicional)
        {
            _prescricaoAdcional.Delete(prescAdicional);
            return "ok";
        }

        public string Editar(PrescricaoAdicional prescAdicional)
        {
            _prescricaoAdcional.Update(prescAdicional);
            
            return "ok";    
        }
    }
}

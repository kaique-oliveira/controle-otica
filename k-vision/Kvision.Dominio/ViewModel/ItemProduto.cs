namespace Kvision.Dominio.ViewModel
{
    public class ItemProduto
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual decimal Valor { get; set; }
        public int Quantidade { get; set; }
    }
}

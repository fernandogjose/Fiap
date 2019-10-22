namespace Fiap.Domain.Entities
{
    public class Receita : BaseEntity<Receita>
    {
        public string Nome { get; set; }
        public string Ingredientes { get; set; }
        public string Preparo { get; set; }
        public int TempoPreparo { get; set; }
        public string Tags { get; set; }
        public int QuantidadePessoas { get; set; }
    }
}
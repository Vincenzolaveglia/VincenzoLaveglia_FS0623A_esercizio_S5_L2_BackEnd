namespace Gestionale_Edile.Models
{
    public class Dipendente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string CF { get; set; }
        public bool Coniugato { get; set; }
        public int FigliACarico { get; set; }
        public string Mansione { get; set; }

        public List<Pagamento> Pagamenti { get; set; }
    } 
}

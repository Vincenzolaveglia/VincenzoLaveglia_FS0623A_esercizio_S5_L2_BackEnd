namespace Gestionale_Edile.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public DateTime Periodo { get; set; }
        public double Totale { get; set; }
        public string TipoPagamento { get; set; }
        public int DipendenteId { get; set; } 
        public Dipendente Dipendente { get; set; }
    }
}

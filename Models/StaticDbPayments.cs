namespace Gestionale_Edile.Models
{
    public static class StaticDbPayments
    {
        private static int _maxId = 3;
        private static List<Pagamento> _pagamenti { get; set; } = [
            new Pagamento() { Id = 1, Periodo = DateTime.Today, Totale = 2000, TipoPagamento = "Stipendio", DipendenteId = 1 },
            new Pagamento() { Id = 2, Periodo = DateTime.Today, Totale = 4000, TipoPagamento = "Accantonamento", DipendenteId = 2 },
            new Pagamento() { Id = 3, Periodo = DateTime.Today, Totale = 2000, TipoPagamento = "Stipendio", DipendenteId = 3 }
        ];

        public static List<Pagamento> GetAll()
        {
            return _pagamenti;
        }

        public static Pagamento? GetById(int? id)
        {
            if (id is null) return null;
            for (int i = 0; i < _pagamenti.Count; i++)
            {
                Pagamento pagamento = _pagamenti[i];
                if (pagamento.Id == id)
                {
                    return pagamento;
                }
            }

            return null;
        }

        public static Pagamento Add(DateTime Periodo, double Totale, string TipoPagamento, int DipendenteId)
        {
            _maxId++;
            var pagamento = new Pagamento() { Id = _maxId, Periodo = Periodo, Totale = Totale, TipoPagamento=TipoPagamento, DipendenteId = DipendenteId };
            _pagamenti.Add(pagamento);
            return pagamento;
        }
    }
}

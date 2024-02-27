namespace Gestionale_Edile.Models
{
    public static class StaticDb
    {
        private static int _maxId = 3;
        private static List<Dipendente> _dipendenti { get; set; } = [
            new Dipendente() { Id = 1, Nome = "Mario", Cognome = "Rossi", Indirizzo = "Via Roma", CF = "MRRSS0102030", Coniugato = true, FigliACarico = 2, Mansione = "Ingegnere" },
            new Dipendente() { Id = 1, Nome = "Marco", Cognome = "Bianchi", Indirizzo = "Via Dante", CF = "MRBNH0852030", Coniugato = true, FigliACarico = 1, Mansione = "Muratore" },
            new Dipendente() { Id = 1, Nome = "Luisa", Cognome = "Marchi", Indirizzo = "Via Garibaldi", CF = "LSMRC0102951", Coniugato = false, FigliACarico = 0, Mansione = "Segretario" },
        ];

        public static List<Dipendente> GetAll()
        {
            return _dipendenti;
        }

        public static Dipendente? GetById(int? id)
        {
            if (id is null) return null;
            for(int i = 0; i < _dipendenti.Count; i++)
            {
                Dipendente dipendente = _dipendenti[i];
                if (dipendente.Id == id)
                {
                    return dipendente;
                }
            }
            return null;
        }

        public static Dipendente Add(string Nome, string Cognome, string Indirizzo, string CF, bool Coniugato, int FigliACarico, string Mansione)
        {
            _maxId++;
            var dipendente = new Dipendente() { Id = _maxId, Nome = Nome, Cognome = Cognome, Indirizzo = Indirizzo, CF = CF, Coniugato = Coniugato, FigliACarico = FigliACarico, Mansione = Mansione };
            _dipendenti.Add(dipendente);
            return dipendente;
        }
    }
}

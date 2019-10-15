using System;

namespace CulturaInglesa.Api.Models{
    public class FundoCapital
    {
        public FundoCapital()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; }

        public string nome { get; set; }

        public decimal valorNecessario { get; set; }

        public decimal valorAtual { get; set; }

        public DateTime? dataResgate { get; set; }
    }
}
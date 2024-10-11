using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectHosting.Models
{
    public class Booking
    {
        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int NightsBooked { get; set; }

        public Booking() {  }

        public Booking(int nightsBooked)
        {
            NightsBooked = nightsBooked;
        }

        public void RegisterGuests(List<Person> guests)
        {
            // TODO: Verificar se a capacidade é maior ao número de hóspedes sendo recebidos.
            if (guests.Count <= 10)
            {
                Guests = guests;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebidos.
                throw new InvalidOperationException("Número de hóspedes excede a capacidade da suíte.");
            }
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetGuestsQuantity()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Guests != null ? Guests.Count : 0;
        }

        public decimal CalcNightlyRate()
        {
            // TODO: Retornar o valor da diária
            
            decimal value = Suite.NightlyRate * NightsBooked;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (NightsBooked >= 10)
            {
                value *= 0.90m;
            }
            return value;
        }
    }
}
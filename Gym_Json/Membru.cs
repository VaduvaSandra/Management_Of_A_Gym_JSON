using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Json
{
    class Membru
    {
        public Membru() { } //Constructor implicit

        private string valabilitateAbonement;
        private DateTime dataInscriere;
        private string dataInscriere1;

        public Membru(string nume, string prenume, string telefon, string tipAbonament, string valabilitateAbonement, DateTime dataInscriere)
        {
            Nume = nume;
            Prenume = prenume;
            Telefon = telefon;
            TipAbonament = tipAbonament;
            ValabilitateAbonament = valabilitateAbonement;
            DataInscrierii = dataInscriere;
        }

        public Membru(string nume, string prenume, string telefon, string tipAbonament, string valabilitateAbonement, string dataInscriere1)
        {
            Nume = nume;
            Prenume = prenume;
            Telefon = telefon;
            TipAbonament = tipAbonament;
            ValabilitateAbonament = valabilitateAbonement;
            DataInscrierii = dataInscriere;
        }

        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string TipAbonament { get; set; }
        public string ValabilitateAbonament { get; set; }
        public DateTime DataInscrierii { get; set; }
    }
}

using System;

namespace Esercizio_2_c_sharp
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }


        public Persona(string nome, string cognome, int eta)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Eta = eta;
        }

        public string GetNome()
        {
            return $"il mio nome è {this.Nome}";
        }

        public string GetCognome()

        {
            return $"il mio cognome è {this.Cognome}";
        }

        public void getDettagli()
        {
            Console.WriteLine($"questa persona si chiama {this.Nome}, di cognome fa {this.Cognome} e ha un età di {this.Eta} anni ");
        }
    }
}

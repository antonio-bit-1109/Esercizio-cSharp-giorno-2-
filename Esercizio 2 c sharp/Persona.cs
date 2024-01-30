namespace Esercizio_2_c_sharp
{
    internal class Persona
    {
        // definizione proprietà classe
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }


        // definisco costruttore
        public Persona(string nome, string cognome, int eta)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Eta = eta;
        }

        // metodi return 
        public string GetNome()
        {
            return $"il mio nome è {this.Nome}";
        }

        public string GetCognome()

        {
            return $"il mio cognome è {this.Cognome}";
        }

        // procedura void 
        public string getDettagli()
        {
            return ($"questa persona si chiama {this.Nome}, di cognome fa {this.Cognome} e ha un età di {this.Eta} anni ");
        }
    }
}

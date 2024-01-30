using System;

namespace Esercizio_2_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Giancarlo", "Fumagalli", 99);
            Console.WriteLine(persona1.GetNome());
            Console.WriteLine(persona1.GetCognome());
            persona1.getDettagli();

            Console.WriteLine("\n");





            Console.WriteLine("inserisci il tuo Nome:");
            string nomeAltro = Console.ReadLine();

            Console.WriteLine("inserisci il tuo Cognome:");
            string cognomeAltro = Console.ReadLine();


            Console.WriteLine("Inserisci la tua età:");
            int inputetà = Convert.ToInt32(Console.ReadLine());


            //int inputetà; 

            /*while (!int.TryParse(Console.ReadLine() , out inputetà))
            {
                Console.WriteLine("Errore: Devi inserire un numero per l'età. Riprova:");
            }*/

            Persona antonio = new Persona(nomeAltro, cognomeAltro, inputetà);
            antonio.GetNome();
            antonio.GetCognome();
            Console.WriteLine(antonio.getDettagli());

            Console.ReadLine();
        }
    }
}

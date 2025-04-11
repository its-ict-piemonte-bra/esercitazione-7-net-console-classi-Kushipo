namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            //changing int to string
            //eg. int campo1; 
            //campo1 = ToString();

            //override cambia comportamento della funziona [public override string ToString() {...}

            //Costruttore

            //this.campo1 = campo1; modo di distinguire 
            //eg. rappresenta una classe da sopra *** cerca online 

            LessonInformation();
            Console.WriteLine("E ora gli esercizi");
            

            int[] array = { 1, 2, 3 };
            try
            {
                Vettore vettore = new Vettore(array);

                Console.WriteLine($"Inizializzata classe Vettore: {vettore}");
                Console.WriteLine($"Valore medio: {vettore.ValoreMedio()}");
                Console.WriteLine($"Valore minimo: {vettore.ValoreMinimo()}");
                Console.WriteLine($"Valore massimo: {vettore.ValoreMassimo()}");

                Console.WriteLine("I numeri pari sono i seguenti:");
                vettore.printEvenNumbers();
            }
            catch
            {
                Console.WriteLine("Errore");
            }
        }

        /// <summary>
        /// Contains information about today's lesson
        /// </summary>
        private static void LessonInformation()
        {
            // serializzazione / deserializzazione
            Console.WriteLine("Serializzazione: salvare informazioni relative a qualcosa fuori dal programmma");
            Console.WriteLine("Tipicamente si realizza su File");
            Console.WriteLine("Per farlo usiamo le classi StreamReader (per leggere/de-serializzare) oppure StreamWriter (per scrivere / serializzare");

            try
            {
                Vettore vect = new Vettore();
                vect.Serialize("mio-file.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante l'apertura del file: {ex.Message}");
            }
        }

        /// <summary>
        /// Carica un nuovo oggetto vettore a partire dal file specificato come parametro
        /// </summary>
        /// <param name="path">Il percorso del file</param>
        /// <returns>L'oggetto Vettore generato</returns>
        public static Vettore Deserialize(string path)
        {
            throw new NotImplementedException();
        }
    }
}

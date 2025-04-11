using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    /// <summary>
    /// Questa classe gestisce un vettore di interi e fornisce diversi metodi di appoggio
    /// </summary>
    public class Vettore
    {
        /// <summary>
        /// Il vettore di interi gestito 
        /// </summary>
        public int[] _vettore; // cambiamento _ per utilizzare this.vettore a linea 34

        /// <summary>
        /// Crea una nuova istanza(puntatore) vuota dell'oggetti Vettore
        /// </summary>
        public Vettore()
        {
            // Metodo costruttore 1 : vuoto
            _vettore = new int[0];
        }

        /// <summary>
        /// Crea una nuova istanza dell'oggetto Vettore, a partire dall'array specificato
        /// </summary>
        /// <param name="vettore">L'array da gestire</param>
        public Vettore(int[] vettore)
        {
            if (vettore == null)
            {
                throw new ArgumentNullException("Non è possibile inizializzare la classe con un vettore nullo");
            }
            _vettore = vettore;
        }

        /// <summary>
        /// Calcola il valore medio di tutte le celle
        /// </summary>
        /// <returns>Il valore medio</returns>
        public float ValoreMedio()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Non si può fare la media su un vettore vuoto");
            }

            float sum = 0;

            for(int i = 0; i < _vettore.Length; i++)
            {
                sum += _vettore[i];
            }

            return sum / _vettore.Length;
        }

        /// <summary>
        /// Restituisce se un vettore è vuoto oppure no
        /// </summary>
        /// <returns>true se il vettore è vuoto, altrimenti false</returns>
        public bool isEmpty()
        {
            return _vettore.Length == 0;
        }

        /// <summary>
        /// Restituisce il valore massimo all'interno del vettore
        /// </summary>
        /// <returns>Il valore massimo</returns>
        /// <exception cref="InvalidOperationException">Se il vettore è vuoto</exception>
        public int ValoreMassimo()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Non si può fare la media su un vettore vuoto");
            }

            int maxVal = _vettore[0];
            for (int i = 1; i < _vettore.Length; i++)
            {
                if (maxVal > _vettore[i])
                {
                    maxVal = _vettore[i];
                }
            }
            return maxVal;

        }
        

        /// <summary>
        /// Restituisce il valore minimo all'interno del vettore
        /// </summary>
        /// <returns>Il valore minimo</returns>
        /// <exception cref="InvalidOperationException">Se il vettore è vuoto</exception>
        public int ValoreMinimo()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Non si può fare la media su un vettore vuoto");
            }

            int minVal = _vettore[0];
            for (int i = 1; i < _vettore.Length; i++)
            {
                if (minVal < _vettore[i])
                {
                    minVal = _vettore[i];
                }
            }
            return minVal;
        }





        /// <summary>
        /// Restituisce la rappresentazione del vettore, sotto forma di Stringa CSV (common seperated value)
        /// </summary>
        /// <returns>La rappresentazione del vettore</returns>
        public override string ToString()
        {
            string result = "[ ";

            if (!isEmpty())
            {
                for (int i = 0; i < _vettore.Length - 1; i++)
                {
                    result += $"{_vettore[i]}, ";
                }

                result += $"{_vettore[_vettore.Length - 1]} ";
            }

            result += "]";

            return result;
        }

        /// <summary>
        /// Stampa solamente i numeri pari a video, uno per riga
        /// </summary>
        public void printEvenNumbers()
        {
            for (int i = 0; i < _vettore.Length; i++)
            {
                if (_vettore[i] % 2 == 0)
                {
                    Console.WriteLine($"{_vettore[i]}");
                }
            }
        }

        /// <summary>
        /// Ordina l'array con l'algoritmo di ordinamento per selezione
        /// </summary>
        public void sort()
        {
            for(int i = 0; i < _vettore.Length; i++)
            {
                int minIndex = i;
                int min = _vettore[i];
                for (int j = i + 1; j < _vettore.Length; j++)
                {                   
                    if (_vettore[j] < min)
                    {
                        minIndex = j;
                        min = _vettore[j];
                    }
                }

                if (minIndex != i)
                {
                    int temp = _vettore[i];
                    _vettore[i] = _vettore[minIndex];
                    _vettore[minIndex] = temp;
                }
            }
        }

        /// <summary>
        /// Serializza l'oggetto sul file specificato  [salvare fuori dal programma]
        /// </summary>
        /// <param name="path">Il percorso del file</param>
        public void Serialize(string path)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.Write(_vettore.ToString());
            writer.Close();
        }

    }
}

using System.Security.Cryptography;

namespace lab3ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la
            randul sau citit de la tastatura.
            Scrieti functii care vor returna
            • Cel mai mare numar din vector
            • Cel mai mic numar din vector
            • Numerele divizibile cu 3
            • Scrieti o functie care va inversa elementele vectorului, apelati-o si afisati-I
            rezultatul
            */
            Console.WriteLine("Introduceti lungimea vectorului:");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] vectorDeNumere = new int[length];
            for (int i = 0; i < length; i++)
            {
                vectorDeNumere[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(vectorDeNumere[i]);
                Console.WriteLine("Divizibil cu 3 ?: ");
                Console.WriteLine(GetDivisibleNumber(vectorDeNumere[i]));
            }
            
            Console.WriteLine("Cel mai mare numar din vector este: ");
            Console.WriteLine(GetBiggestNumber(vectorDeNumere));
            Console.WriteLine("Cel mai mic numar din vector este: ");
            Console.WriteLine(GetSmallestNumber(vectorDeNumere));

            Console.WriteLine("Elemente inversate: ");
            SwitchPositions(vectorDeNumere);
            ParcurgeVector(vectorDeNumere);


        }

        static int GetBiggestNumber(int[] vector) {
            int mare = 0;
            for(int i = 0;i < vector.Length;i++)
            {
                if (vector[i] < mare)
                {
                    continue;
                }
                else
                {
                    mare = vector[i];
                }
            }
            return mare ;
        }
        static int GetSmallestNumber(int[] vector)
        {
            int mic = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > mic)
                {
                    continue;
                }
                else
                {
                    mic = vector[i];
                }
            }
            return mic;
        }

        static bool GetDivisibleNumber(int numar)
        {
            bool isDivisible = false;
                if (numar % 3== 0)
                {
                    Console.WriteLine(numar + " este divizibil cu 3.");
                    isDivisible = true;
                    
                }
                else
                {
                    Console.WriteLine(numar + " nu este divizibil cu 3.");
                    isDivisible = false;
                }
            return isDivisible;
        }

        static void SwitchPositions(int[] vector)
        {
            Array.Reverse(vector);
        }

        static void ParcurgeVector(int[] vector)
        {
            for (int i = 0;i < vector.Length;i++)
            {
                Console.WriteLine(vector[i]);
            }
        }

    }
}
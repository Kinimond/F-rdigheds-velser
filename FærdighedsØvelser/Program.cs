namespace FærdighedsØvelser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ageSum = 0;

            Console.WriteLine("Hvor lang skal din liste være? ");
            int arrayLength = int.Parse(Console.ReadLine());
            double[] age = new double[arrayLength];
            Console.WriteLine("Hvilke tal vil du have på din liste? ");
            for (int i = 0; i < arrayLength; i++)
            {
                age[i] = double.Parse(Console.ReadLine());
            }


            for (int i = 0; i < age.Length; i++) 
            { 
                ageSum += age[i];
            }
            double averageAge = ageSum / age.Length;

            Console.WriteLine("Den gennemsnitlige alder er: " + averageAge);

            Console.WriteLine("Søg nu efter en alder du gerne vil se om vi har: ");
            int ageSearch = int.Parse(Console.ReadLine());
            bool isFound = false;
            int count = 0;

            for (int i = 0; i < age.Length; i++)
            {
                if (age[i] == ageSearch) {
                    count += 1; //Slettede break; for at kunne angive antal personer med den bestemte alder.
                    isFound = true; }

                } if (isFound) {
                    Console.WriteLine($"Dette tal blev fundet {count} gange");
                } else {
                    Console.WriteLine("Dette tal er ikke på listen. ");
                }
                    Console.ReadLine();
            }          
        }
    }


/*
 Opgave 3.1
           double rasmusAge = 19;
           double patrickAge = 22;
           double simonAge = 23;
           double jacobAge = 23;
           double dontknowAge =  29;
           double averageAge = (rasmusAge + simonAge + jacobAge + dontknowAge + patrickAge)/5;
           Console.WriteLine("Den gennemsnitlige alder er: " + averageAge );
*/

/*
 Opgave 3.2
            double ageSum = 0;
            double[] age = new double[5] { 22, 19, 23, 29, 23 };

            for (int i = 0; i < age.Length; i++) 
            { 
                ageSum += age[i];
            }
            double averageAge = ageSum / age.Length;

            Console.WriteLine("Den gennemsnitlige alder er: " + averageAge);
*/
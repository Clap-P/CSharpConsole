class Program
{
    static void Main(string[] args)
    {
        int number = 10;
        string name = "Rollon Normand";
        double percentage = 10.23;
        char gender = 'M';
        bool isVerified = true;
        Console.WriteLine("Id: " + number);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Percentage: " + percentage);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Verified: " + isVerified);

        // Exercice 2
        string[] Months = new string[] { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };
        Console.WriteLine("\nExercice 2\n\n");
        Console.Write("Salaire : ");

        bool salaryIsDouble = Double.TryParse(Console.ReadLine(), out double salary);
        if (salaryIsDouble)
        {
            switch (salary)
            {
                case > 50000:
                    Console.WriteLine("Paye tes impôts!");
                    break;
                case < (1500 * 12):
                    Console.WriteLine("Normal pour un alternant!");
                    break;
                case > 30000 when salary < 40000:
                    Console.WriteLine("Viens au CESI!");
                    break;
                default:
                    break;
            }
        }
        else
        {
            Console.WriteLine("Le Salaire n'est pas une donnée");
        }
        Console.Write("Taxe : ");
        // Vérification taxe
        bool taxIsDouble = Double.TryParse(Console.ReadLine(), out double tax);
        if (taxIsDouble)
        {
            Console.WriteLine("La taxe est une donnée ");
        }
        else
        {
            Console.WriteLine("La taxe n'est pas une donnée");
        }

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Salaire Brut : " + salary + " euros\nTaxe : " + tax + " %");
        Console.WriteLine("");

        double salaireNet = 0;
        for (int i = 0; i < 12; i++)
        {
            // Aout
            if (i == 7)
            {
                Console.Write("");
            }
            // Decembre
            else if (i == 11)
            {
                Console.Write("Prime de Décembre : ");
                bool bonusIsDouble = Double.TryParse(Console.ReadLine(), out double bonus);
                try
                {
                    Console.WriteLine(Months[i] + " : " + ((salary / 11) + ((salary * bonus) / 100)));
                    salaireNet = salaireNet + (((salary / 11) + ((salary * bonus) / 100)));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Le format de la prime est mauvais");
                }
                catch (Exception)
                {
                    Console.WriteLine("La prime vaut 0");
                }
            }
            else
            {
                Console.WriteLine(Months[i] + " : " + (salary / 11));
                salaireNet = salaireNet + (salary / 11);
            }
        }

        Console.WriteLine("\nSalaire Net : " + Taxes(salary, tax) + " Euros");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("\nPress Enter Key To Exit");
        Console.ReadLine();
    }

    static double Taxes(double salary, double tax)
    {
        return (salary * (1 - tax / 100));
    }
}
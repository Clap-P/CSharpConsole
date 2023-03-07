class Program
{

    static void Main(string[] args)
    {
        ////////////////  int number = 10;
        //////////////// string name = "Rollon Normand";
        //////////////// double percentage = 10.23;
        //////////////// char gender = 'M';
        //////////////// bool isVerified = true;
        ////////////////Console.WriteLine("Id: " + number);
        ////////////////Console.WriteLine("Name: " + name);
        ////////////////Console.WriteLine("Percentage " + percentage);
        //Console.WriteLine("Gender " + gender);
        //Console.WriteLine("Verified " + isVerified);
        //Console.ReadLine();


        //Fonction 2

        string[] Month = new string[] { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };
        Console.WriteLine("Exercice 2\n\n");
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
        //Vérification taxe
        bool taxIsDouble = Double.TryParse(Console.ReadLine(), out double tax);
        if (taxIsDouble)
        {
            Console.WriteLine("La taxe est une donnée ");
        }
        else
        {
            Console.WriteLine("La taxe n'est pas une donnée");
        }

        for (int i = 0; i < 12; i++)
        {
            if (i == 7)
            {
                Console.Write("");
            }
            else if (i == 11)
            {
                Console.WriteLine(Month[i] + " : " + ((salary / 12) + ((salary * 10) / 100)));
            }
            else
            {
                Console.WriteLine(Month[i] + " : " + (salary / 12));
            }
        }

        Console.WriteLine("Salaire Brut : " + salary + " Euros\nTaxe : " + tax + " %");
        salary = Taxes(salary, tax);
        Console.WriteLine("Salaire Net : " + salary + " Euros");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("\nPressEnterKeyToExit");
        Console.ReadLine();
    }

    

    static double Taxes(double salary, double tax)
    {
        return (salary * (1-tax/100));
    }
    //a
}
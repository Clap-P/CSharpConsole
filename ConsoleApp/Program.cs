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

        Console.WriteLine("Exercice 2\n\n");
        Console.Write("Salaire : ");
        double salary = Double.Parse(Console.ReadLine());
        Console.Write("Taxe : ");
        double tax = Double.Parse(Console.ReadLine());
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

}
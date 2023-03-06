class Program
{

    static void Main(string[] args)
    {
      //  int number = 10;
       // string name = "Rollon Normand";
       // double percentage = 10.23;
       // char gender = 'M';
       // bool isVerified = true;
        //Console.WriteLine("Id: " + number);
        //Console.WriteLine("Name: " + name);
        //Console.WriteLine("Percentage " + percentage);
        //Console.WriteLine("Gender " + gender);
        //Console.WriteLine("Verified " + isVerified);
        //Console.ReadLine();


        //Fonction 2
        double salary = 25000;
        double tax = 30;
        Console.WriteLine(salary + " " + tax);
        salary = Taxes(salary, tax);
        Console.WriteLine(salary + " " + tax);
        Console.WriteLine("PressEnterKeyToExit");
        Console.ReadLine();
    }
    static double Taxes(double salary, double tax)
    {
        return (salary * (1-tax/100));
    }

}
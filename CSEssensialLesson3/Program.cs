namespace CSEssensialLesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction\n");

            SportCar ferrari= new SportCar("red", "Ferrari F50");
            ferrari.ShowInfo();
            ferrari.CarryPeople();
            ferrari.Drive();
            ferrari.RecycleToMetal();

            Console.WriteLine(new string('-', 20));
            Truck peterbilt = new Truck("red", "Peterbilt 589");  
            peterbilt.ShowInfo();
            peterbilt.CarryLaggage();
            peterbilt.Drive();
            peterbilt.RecycleToMetal();

            Console.WriteLine(new string('-',40));

            Car lambo = new SportCar("red", "Lamborgini Marcielago");
            lambo.ShowInfo();
            lambo.Drive();
            Console.WriteLine("\nDowncasting\n");
            var lambo2 = (SportCar)lambo;

            lambo2.Drive(); //Now Lambo shows method from sportcar because CAR method drive is overrided in sportcar




            Console.ReadLine(); 

        }

         

        
        
    }
}
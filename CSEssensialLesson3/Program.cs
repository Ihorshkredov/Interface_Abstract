namespace CSEssensialLesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction\n");

            SportCar ferrari= new SportCar();
            ferrari.Colour = "red";
            ferrari.Model = "Ferrari F50";
            ferrari.ShowInfo();
            ferrari.CarryPeople();
            ferrari.Drive();
            ferrari.RecycleToMetal();

            Console.WriteLine(new string('-', 20));
            Truck peterbilt = new Truck();  
            peterbilt.Colour = "red";
            peterbilt.Model = "Peterbilt 589";
            peterbilt.ShowInfo();
            peterbilt.CarryLaggage();
            peterbilt.Drive();
            peterbilt.RecycleToMetal();

            Console.WriteLine(new string('-',40));

            Car lambo = new SportCar();
            lambo.Colour = "red";
            lambo.Model = "Lamborgini Marcielago";
            lambo.ShowInfo();
            lambo.Drive();
            Console.WriteLine("\nDowncasting\n");
            var lambo2 = (SportCar)lambo;

            lambo2.Drive();




            Console.ReadLine(); 

        }

         

        
        
    }
}
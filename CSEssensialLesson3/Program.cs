namespace CSEssensialLesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction\n");

            SportCar ferrari= new SportCar("red", "Ferrari F50");


            Console.WriteLine(new string('-', 20));
            Truck peterbilt = new Truck("red", "Peterbilt 589");  

            Console.WriteLine(new string('-',40));

            SportCar lambo = new SportCar("red", "Lamborgini Marcielago");
           

            SportCar ford = new SportCar("blue", "Ford Mustang GT");

            SportCar chevrolet = new SportCar(model:"Shevy Camaro",colour:"yellow");





            CarCollection myCollection = new CarCollection();

            myCollection[0] = ferrari;
            myCollection[1] = lambo;
            myCollection[2] = ford;
            myCollection[3] = chevrolet;

            for (int i = 0; i < 4; i++)
            {
                myCollection[i].ShowInfo();
                Console.WriteLine(new string ('-',40));

            }

            Console.ReadLine(); 

        }

         

        
        
    }
}
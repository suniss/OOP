using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ppeople = new Person();
            PersonHandler PpersonHandler = new PersonHandler();

            int age = int.Parse(Console.ReadLine());
            string fName = Console.ReadLine();
            string lName = Console.ReadLine();
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());



            try
            {

                /* var PpersonHandler = new PersonHandler(age, fName, lName, weight, height);*/
                /*CreatePerson(2, "sunne", "tem", 22.55, 66.66);
                Console.WriteLine(Ppeople.Age);*/
                Person personinfo = new Person();
                personinfo = PpersonHandler.CreatePerson(age, fName, lName, weight, height);


            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);

            }


        }
    }
}

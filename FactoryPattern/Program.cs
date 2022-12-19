namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to drink? The options are Rum Runner, Moscow Mule, Whiskey Sour, or an Old Fashioned. ");
            Console.WriteLine("There is also straight liqour if you like it like that.");
            var answer = Console.ReadLine();


            IDrink usersChoice = ChooseAnswerFactory.Answer(answer);
            usersChoice.Drink();
        }
    }
}

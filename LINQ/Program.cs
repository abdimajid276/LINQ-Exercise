namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameNames = new List<string>()
            {
                "Fallout : New Vegas",
                "Half Life ",
                "Doom",
                "Halo Reach",
                "Mario"
            };
            gameNames.OrderBy(gameNames => gameNames.Length).ToList().ForEach(game => Console.WriteLine(game));
            {
                
            }
        }
    }
}

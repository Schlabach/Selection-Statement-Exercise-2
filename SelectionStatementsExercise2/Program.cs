namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
           			 Console.WriteLine("What is your favorite school subject?");

            var subject = Console.Readline();

            switch (subject.ToLower)
            {
                case "math":
                    Console.WriteLine("Awesome, let's be algebros!");
                    break;
                case "science":
                    Console.WriteLine("Two blood cells met and fell in love, but it was all in vein"); 
                    break;
                case "english":
                    Console.WriteLine("Your dinner vs You're dinner. One leaves you nourished, the other leaves you dead.");
                    break;
                case "history":
                    Console.WriteLine("The early ages were called the Dark Ages because there were too many knights.");
                    break;
                case "gym":
                    Console.WriteLine("Odin's son stopped working out because he was Thor.");
                    break;
                default:
                    Console.WriteLine("Ah I haven't taken that subject before");
                    break;
            }
        }
    }
}
namespace SelectionStatementsExercise2
{
    public class Program
    {
        public static void FavSubjectStatement(string subject)
        {
            switch (subject)
            {
                case "Math":
                    Console.WriteLine($"You're favorite subject is {subject}. You would probably enjoy Data Science or Software Development.");
                    break;
                case "Science":
                    Console.WriteLine($"You're favorite subject is {subject}. You would probably enjoy Data Science, Software Development, or Medical Writing.");
                    break;
                case "English":
                    Console.WriteLine($"You're favorite subject is {subject}. You would probably enjoy Copywriting.");
                    break;
                case "History":
                    Console.WriteLine($"You're favorite subject is {subject}. You would probably enjoy Technical Writing.");
                    break;
                case "Art":
                    Console.WriteLine($"You're favorite subject is {subject}. You would probably enjoy Web Design or Graphic Design.");
                    break;
                default:
                    Console.WriteLine($"You're favorite subject is {subject}. I can't recommend a good remote job.");
                    break;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Let's see if I can recommend a good remote job for you.");
            Console.WriteLine("What is your favorite school subject(make sure first letter is uppercase)?");
            var favSubject = Console.ReadLine();
            FavSubjectStatement(favSubject);
        }
    }
}
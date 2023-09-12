namespace Lab1_2910
{
    internal class Program
    {
        static void Main()
        {
            List<VideoGame> videoGames = new List<VideoGame>();
            string[] lines = File.ReadAllLines("videogame.csv");

            foreach (string line in lines.Skip(1)) 
            {
                string[] columns = line.Split(',');
                VideoGame game = new VideoGame
                {
                    Title = columns[0],
                    Platform = columns[1],
                    Year = columns[2],
                    Genre = columns[3],
                    Publisher = columns[4],
                };
                videoGames.Add(game);
            }
            var nintendoGames = videoGames.Where(game => game.Publisher == "Nintendo").OrderBy(game => game.Title);
            foreach (var game in nintendoGames)
            {
                Console.WriteLine(game);
            }
            int totalGames = videoGames.Count;
            int nintendoGamesCount = nintendoGames.Count();

            double percentage = (double)nintendoGamesCount / totalGames * 100;
            Console.WriteLine($"Out of {totalGames} games, {nintendoGamesCount} are developed by Nintendo, which is {percentage:F2}%");

            var rolePlayingGames = videoGames.Where(game => game.Genre == "Role-Playing").OrderBy(game => game.Title);
            foreach (var game in rolePlayingGames)
            {
                Console.WriteLine(game);
            }
            int totalGames1 = videoGames.Count;
            int rolePlayingGamesCount = rolePlayingGames.Count();

            double percentage1 = (double)rolePlayingGamesCount / totalGames * 100;
            Console.WriteLine($"Out of {totalGames} games, {rolePlayingGamesCount} are Role-Playing games, which is {percentage:F2}%");

            static void PublisherData(List<VideoGame> videoGames)
            {
                Console.Write("Enter the publisher: ");
                string publisherInput = Console.ReadLine();

                var publisherGames = videoGames
                .Where(game => game.Publisher.Equals(publisherInput, StringComparison.OrdinalIgnoreCase))
                .OrderBy(game => game.Title)
                .ToList();

                int totalGames = videoGames.Count;
                int publisherGamesCount = publisherGames.Count();
                double percentage = (double)publisherGamesCount / totalGames * 100;



                Console.WriteLine($"Out of {totalGames} games, {publisherGamesCount} are developed by {publisherInput}, which is {percentage:F2}%");
            }


        }
    }
}
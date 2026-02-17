using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Challenge.Pages
{
    public class DadJokesModel : PageModel
    {
        public string[] AllJokes { get; set; } =
        {
            "I had a quiet game of tennis today. There was no racket.",
            "Why do melons have weddings? They cantelope.",
            "I went to the aquarium this weekend, but I didn’t stay long. There’s something fishy about that place.",
            "Why can't dinosaurs clap their hands? Because they're extinct.",
            "Who won the neck decorating contest? It was a tie.",
            "Dogs can't operate MRI machines. But catscan.",
            "How is my wallet like an onion? Every time I open it, I cry.",
            "Which vegetable has the best kung fu? Broc-lee.",
            "Why did the egg have a day off? Because it was Fryday.",
            "What word can you make shorter by adding two letters? Short.",
            "What happened when two slices of bread went on a date? It was loaf at first sight.",
            "Why do crabs never volunteer? Because they're shell-fish."
        };

        public List<string> CurrentJokes { get; set; } = new List<string>();

        public int JokesToShow { get; set; } = 2;

        public void OnGet()
        {
            LoadRandomJokes();
        }

        public void OnPost()
        {
            LoadRandomJokes();
        }
        private void LoadRandomJokes()
        {
            Random rnd = new Random();
            CurrentJokes.Clear();

            while (CurrentJokes.Count < JokesToShow)
            {
                int index = rnd.Next(0, AllJokes.Length);
                string joke = AllJokes[index];

                
                if (!CurrentJokes.Contains(joke))
                {
                    CurrentJokes.Add(joke);
                }
            }
        }
    }
}

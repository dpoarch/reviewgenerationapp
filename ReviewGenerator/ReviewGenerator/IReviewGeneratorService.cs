using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace ReviewGenerator
{
    public interface IReviewGeneratorService
    {
        (string reviewText, int starRating) GenerateReview();
    }

    public class ReviewGeneratorService : IReviewGeneratorService
    {
        private List<Review> _reviews;
        private Random _random;
        private Dictionary<string, List<string>> _markovModel;

        public ReviewGeneratorService(IReviewDataService reviewDataService)
        {
            _reviews = reviewDataService.GetReviews();
            _random = new Random();
            _markovModel = BuildMarkovModel(); // Build the Markov chain model
        }

        public (string reviewText, int starRating) GenerateReview()
        {
            var startingWord = GetRandomStartingWord();
            var generatedWords = GenerateWords(startingWord, 30); // Generate 30 words

            var reviewText = string.Join(" ", generatedWords);
            var starRating = _random.Next(1, 6);

            return (reviewText, starRating);
        }

        private Dictionary<string, List<string>> BuildMarkovModel()
        {
            var markovModel = new Dictionary<string, List<string>>();

            foreach (var review in _reviews)
            {
                var words = review.ReviewText.Split();

                for (int i = 0; i < words.Length - 1; i++)
                {
                    var currentWord = words[i];
                    var nextWord = words[i + 1];

                    if (!markovModel.ContainsKey(currentWord))
                    {
                        markovModel[currentWord] = new List<string>();
                    }

                    markovModel[currentWord].Add(nextWord);
                }
            }

            return markovModel;
        }

        private string GetRandomStartingWord()
        {
            var randomIndex = _random.Next(_reviews.Count);
            var review = _reviews[randomIndex];
            var words = review.ReviewText.Split();
            return words[0];
        }

        private List<string> GenerateWords(string startingWord, int count)
        {
            var generatedWords = new List<string>();
            var currentWord = startingWord;

            for (int i = 0; i < count; i++)
            {
                if (_markovModel.ContainsKey(currentWord))
                {
                    var possibleNextWords = _markovModel[currentWord];
                    var nextWord = possibleNextWords[_random.Next(possibleNextWords.Count)];
                    generatedWords.Add(nextWord);
                    currentWord = nextWord;
                }
                else
                {
                    break; // No more valid next words
                }
            }

            return generatedWords;
        }
    }

}

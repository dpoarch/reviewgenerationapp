using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ReviewGenerator
{
    public class Review
    {
        // Properties mapping to JSON structure
        public string? ReviewerID { get; set; }
        public string? Asin { get; set; }
        public string? ReviewerName { get; set; }
        public List<int>? Helpful { get; set; }
        public string? ReviewText { get; set; }
        public double Overall { get; set; }
        public string? Summary { get; set; }
        public long UnixReviewTime { get; set; }
        public string? ReviewTime { get; set; }
    }

    public interface IReviewDataService
    {
        List<Review> GetReviews();
    }

    public class ReviewDataService : IReviewDataService
    {
        private List<Review> _reviews;

        public ReviewDataService()
        {
            _reviews = LoadReviews();
        }

        public List<Review> GetReviews()
        {
            return _reviews;
        }

        private List<JObject> ReadJsonDataFromFile()
        {

            var jsonFile = Environment.CurrentDirectory + @"\reviews.json";
            var jsonReviews = new List<JObject>();

            foreach (string line in File.ReadAllLines(jsonFile).Take(1000))
            {
                var jObject = JObject.Parse(line);
                jsonReviews.Add(jObject);
            }

            return jsonReviews;
        }

        private List<Review> LoadReviews()
        {
            var reviews = new List<Review>();

            var jsonReviews = ReadJsonDataFromFile();

            foreach (var jsonReview in jsonReviews)
            {
                var review = new Review
                {
                    ReviewerID = jsonReview["reviewerID"].ToString(),
                    Asin = jsonReview["asin"].ToString(),
                    ReviewerName = jsonReview["reviewerName"].ToString(),
                    Helpful = jsonReview["helpful"].ToObject<List<int>>(),
                    ReviewText = jsonReview["reviewText"].ToString(),
                    Overall = jsonReview["overall"].ToObject<double>(),
                    Summary = jsonReview["summary"].ToString(),
                    UnixReviewTime = jsonReview["unixReviewTime"].ToObject<long>(),
                    ReviewTime = jsonReview["reviewTime"].ToString()
                };

                reviews.Add(review);
            }

            return reviews;
        }


    }

}

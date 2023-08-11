using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ReviewGenerator.Tests
{
    [TestClass]
    public class ReviewGeneratorTests
    {
        private IReviewGeneratorService? _reviewGeneratorService;

        [TestInitialize]
        public void Setup()
        {
            _reviewGeneratorService = new ReviewGeneratorService(new MockReviewDataService());
        }

        [TestMethod]
        public void TestGenerateReview_ReturnsNonEmptyReview()
        {
            var (reviewText, starRating) = _reviewGeneratorService.GenerateReview();

            Assert.IsFalse(string.IsNullOrWhiteSpace(reviewText));
        }

        [TestMethod]
        public void TestGenerateReview_ReturnsValidStarRating()
        {
            var (reviewText, starRating) = _reviewGeneratorService.GenerateReview();

            Assert.IsTrue(starRating >= 1 && starRating <= 5);
        }
    }

    public class MockReviewDataService : IReviewDataService
    {
        public List<Review> GetReviews()
        {
            return new List<Review>
            {

            };
        }
    }
}
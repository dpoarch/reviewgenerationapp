using Microsoft.AspNetCore.Mvc;

namespace ReviewGenerator.Controllers
{
    [ApiController]
    [Route("api")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewGeneratorService _reviewGeneratorService;

        public ReviewController(IReviewGeneratorService reviewGeneratorService)
        {
            _reviewGeneratorService = reviewGeneratorService;
        }

        [HttpGet("generate")]
        public IActionResult GenerateReview()
        {
            var (reviewText, starRating) = _reviewGeneratorService.GenerateReview();
            var review = new
            {
                ReviewText = reviewText,
                StarRating = starRating
            };
            return Ok(review);
        }
    }

}

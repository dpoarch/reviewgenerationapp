document.addEventListener("DOMContentLoaded", function () {
    const generateButton = document.getElementById("generateButton");
    const reviewTextElement = document.getElementById("reviewText");
    const starRatingElement = document.getElementById("starRating");

    generateButton.addEventListener("click", async () => {
        const response = await fetch("/api/generate");
        const data = await response.json();

        reviewTextElement.textContent = "Review: " + data.reviewText;
        starRatingElement.textContent = "Star Rating: " + data.starRating + " / 5";
    });
});

# Review Generation App

This ASP.NET Core application ingests training data (included within the project in reviews.json) and automatically generates a review (via use of of Markov chains) each time the "generate" endpoint is hit (or when the "Generate Review" button is clicked on the frontend).

# To build and run the ReviewGenerator project, follow these instructions:

1. **Clone the Repository:**<br/>
   Clone the GitHub repository containing the reviewgenerationapp project to your local machine.

2. **Navigate to Project Directory and Open the Project:**<br/>
   Navigate to the directory where you cloned the repository and open the project/solution in Visual Studio.

3. **Build and Run the Project:**<br/>
   Build the and run the ASP.NET Core project within Visual Studio.

4. **Access the Application:**<br/>
   Once the project is running, open a web browser and navigate to index.html to access the frontend of the application (i.e., localhost:7059/index.html).<br/>
   Alternatively, you may also hit the endpoint using Swagger (i.e., localhost:7059/swagger/index.html).

5. **Generate Reviews:**<br/>
   Using the frontend, click the "Generate Review" button on the webpage to generate a new review. The generated review will appear on the page with a randomized star rating. Clicking the button again will produce a regenerated response.<br/>
   If you use Swagger, then you can click "Get" -> "Try it out" -> "Execute" to generate a new review.  Clicking the button again will produce a regenerated response.

# Notes:

1.  **Unit Test:**<br/>
   Tests can be found in project/folder ReviewGenerator.Tests.

2.  **Front end:**<br/>
   Simple front-end supplied to supplement the Swagger page.

3.  **Azure hosting:**<br/>
   The application has previously been deployed to Azure and could be accessed here:  https://reviewgenerationapp.azurewebsites.net/index.html (currently stopped as it is only a free account)

4.  **Dockerization:**<br/>
   The Dockerfile is included within the ReviewGenerator project.



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
   See screenshots below.

3.  **Azure hosting:**<br/>
   The application has been deployed to Azure and can be accessed here:  https://reviewgenerationapp.azurewebsites.net/index.html

4.  **Dockerization:**<br/>
   The Dockerfile is included within the ReviewGenerator project.

# Screenshots:

1.  **Local testing (Frontend):**<br/>
![image](https://github.com/dpoarch/reviewgenerationapp/assets/9018327/3110cf13-cb55-40e9-93a8-22a2eded9879)
![image](https://github.com/dpoarch/reviewgenerationapp/assets/9018327/54dfcad6-ed24-45dc-8890-10c081c79c37)
![image](https://github.com/dpoarch/reviewgenerationapp/assets/9018327/0047ccca-a1b4-4d90-b4e1-4accbbc406f9)
![image](https://github.com/dpoarch/reviewgenerationapp/assets/9018327/e891860d-d2d6-4ef3-8d4a-93255468e45d)

2.  **Local testing (Swagger):**<br/>
![image](https://github.com/dpoarch/reviewgenerationapp/assets/9018327/391b7051-30e0-4440-99a9-2a1f48387b4c)
![image](https://github.com/dpoarch/reviewgenerationapp/assets/9018327/efb812b7-e80b-4cf5-bd23-40d2d0dc7b89)

3.  **Azure-deployed app:**<br/>
![image](https://github.com/dpoarch/reviewgenerationapp/assets/9018327/5a3f8b75-d98e-4fe1-b937-7641b1756638)


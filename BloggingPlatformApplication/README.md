# Blogging Platform Application - Exercise

## How to run application locally

In order to run this application, please ensure you are running Visual Studio 2022 or a software application compatible with running the ASP.NET framework.

If you do not already have Visual Studio 2022 installed, you can find the [instructions and documentation here](https://visualstudio.microsoft.com/free-developer-offers/).
    
Please note that support for Visual Studio for Mac is [planning to be retired on August 31, 2024](https://learn.microsoft.com/en-us/visualstudio/mac/what-happened-to-vs-for-mac?view=vsmac-2022), so please plan accordingly if you are running macOS.
    

1) Visit the repository at https://github.com/Yumacorn/BloggingPlatformApp

2) Using the green "Code" button, choose the HTTPS and copy the URL.

3) In your local IDE software (Interactive Development Environment), in my case Visual Studio 2022, navigate to your Terminal or Command Prompt 

4) (Optionally) Create a new directory, move into that directory, and then clone the repository to your local machine.

    ```
    mkdir BloggingExercise
    cd BloggingExercise
    
    git clone https://github.com/Yumacorn/BloggingPlatformApp.git
    ```
5) Once the repository succesfully is cloned, open the repo and in your IDE, on the Navigation Bar you should see a Menu Option which says **Debug > Start Debug (F5)**

6) This will open up the Project in your localhost default internet browser and allow you to explore the application.

    * If the browser does not open automatically, you may need to choose IIS for the emulator.
    

## The Assignment

Your assignment is below.

To goal of the exercises is to check how quickly you can grasp basics of .net development.
You don’t need to fulfil all the requirements.

* Submitting:

    * Please create github repo and push your progress regularly (I would like to see commits history). Once you are done, please send me the link.

* Assignment: Building a Blogging Platform

    * You are tasked with building a simple blogging platform where users can create and view blog posts. The application should have a backend API developed in ASP.NET Core and use Entity Framework for data access.

 

## Requirements:

### 1. Domain Model

Every User possesses the following attributes: ID, Username, and Email (which must be unique).
Each BlogPost is characterized by the following attributes: ID, Title, Content, and timestamps for creation and updates.
A User can be associated with multiple BlogPosts, and each BlogPost belongs to a single User.
 

### 2. Entity Framework: 

Use Entity Framework Core to create models for the Users and BlogPosts tables.
Implement a DbContext to configure the database connection and relationships between User and BlogPost entities.
Seed the database with at least two users and a few sample blog posts for each user using EF migrations or a data seeding mechanism.
 

### 3. API:

Create an API controller for managing blog posts.
Implement CRUD (Create, Read, Update, Delete) operations for blog posts.
Ensure that users can only edit/delete their own blog posts.
Create an API controller for managing user profiles.
Implement endpoints to retrieve user profiles and their associated blog posts.
Use appropriate HTTP methods (GET, POST, PUT, DELETE) and status codes.
Implement data validation and error handling in the API.
 

### 4. Testing:

Write unit tests for the API controller managing blog posts
 

### 5. Documentation:

Provide clear and concise documentation on how to run the application locally.
 

### 6. Bonus (Optional):

Implement user authentication and authorization using JWT tokens.
Add pagination and filtering options for retrieving blog posts.


## Checklist of Requirements:
[x] - Domain Model

[ ] - Entity Framework

[ ] - API

[ ] - Testing

[x] - Documentation

[ ] - Bonus (Optional)

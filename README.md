# MCA MVC App

## Context

This is the final project I produced for my .NET applications class.  We were given the choice to choose what we wanted this final project to be.  I thought it would be useful to learn more about MVC implementation and created a scenario in which I could do such a project.  My plan was to use the MVC to display information about locals laws concerning crime.  The usage of the project is meant to be strictly informative in regards to local law and devoid of commentary.  The project focuses only on one specific set of laws (Title 45) but is set up to be able to add other titles in the future.  

## Action

First, I needed to create a database that would store the information that would be displayed in the MVC.  In a separate project, I created a class library with a simple entity and implemented entity framework.  Instead of manually entering the data, I made a web scraper program to go with the class library that would get the necessary information for constructing my entities from the web.  See my [MCA Database and Web Scraper Project](https://github.com/tlhausler/mca-db-web-scraper).  In the MVC, I configured the project to use Entity Framework Core and its SqlServer package, as well as bootstrap for ease of website layout in the final product.  I added the MCA Database project as a project reference and put connection string details for the databse in appsettings.json. 

All logic for the MVC's functionality are stored in the HomeController.  A ViewModel was created to store data from the database locally.  A series of IActionResult interfaces were made in the HomeController to get the data from the database.  The final outcome was to have a page with a drop down menu that allows you to choose the Title, then the chapters under that title, the parts for the selected chapter, and so on, eventually getting to the content of the law.  Each IActionResult populates the drop down lists with the necessary items as one navigates through using it.  The views for these pages are simple, implementing bootstrap for a slightly cleaner output, and using the HtmlHelper method for creating a drop down list.  A submit button is given below the drop down.  The HtmlHelper method and button are both inside a using statement that generates a form and helps route the button to the next view when clicked. The Content view and IActionResult are different in that we are not populating a drop down but showing content on the page. 

## 

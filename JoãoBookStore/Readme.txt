2022-11-02 - Assignment 2 João Vitor Santana Ebrenz

10:00
Created new repository

10:05
Setted the project to use bootstrap
I choose darkly template, dowloaded it and replaced it.

10:35
I removed text-dark

10:45
I added dropdown menu and 3 libraries

11:25
I added 3 libraries (DataAccess, Models and Utility)

11:50
I delete the migrations folder

11:55
I added NugetPackages as said in the instructions.

12:00
I deleted Class1

12:02
I had a problem istalling packages, and to solve this I changed the version.

12:05
I renamed models folder to view models

12:15
I changed namespace  

12:20
I removed the using statement

12:30
I created a static details class called SD.cs

12:35
I added a custumers Area

12:50
I added admin area and view files to display data

1:00
I deleted the Controllers folder

1:05
I tested and everything works good...!

1:10
Finished part 1 of Assignment 2.

2022-03-2022
11:00
I had a problem with the commits, because I did the assgnment on my laptop, and accidently all commits disappeared.To solve my problem I commit everything and worked.
         /////////////////////////////////////////////////////////////////////////////////////////////

2002-11-07  1750

Updted all the packages to fit in the project.Before it was 5 version and now I updated the packages to 3.1.29 version.

--Starting the project now, I tested and everithing is working.
- add-migration AddDefaultIdentityMigration 
--Updated database in the SQl server
--added a new class file to the .Models.
-- added new Item interface and created a interface item called IRepositoy.cs

2002-11-07  1830

Modified Category class to use for CRUD
Created a repository class and modified the code to create the constructors and dependency injection(DI)
Created individual repository for category and all potencial models to add in the future
--CategoryRepository and ICategoryRepository
Modified CategoryRepository and ICategoryRepository Interface
Updated void method to retrieve the first or default category object and passed the id as a generic entity.

2002-11-07  1920

Implemented a stored procedure repositoryand map multiple repositories in a unit of Work
added a new Interface called ISP_call.cs
Installed NugGet package for Dapper.
added new class called SP_Call.cs
added a connection to the database
uptaded the implementation of the ISP_Call interface and added using statement.



2002-11-07  2030

Added a new Interface IUnitOfWork to the IRepository folder
Change the method to public to acess the class

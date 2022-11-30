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
--file name = 202001107214434_AddDefaultidentityMigration.cs
-- Added Category to database
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
--Builded the project and everything is working


2002-11-08  1200
Starting the part 2 of the project...
added a new mvc controller named CategoryController.cs inside Controllers folder.
Modified the code inside CategoryController 
added icons in the category section
added the IAction result to the controller
created a partial view for the edit
created _CreateAndBackToListButton and added asp-action
created _EditAndBackToListButton and added @model razor statement
System.NotImplementedException error, I am having trouble solving this.


2002-11-08  1700
created an Upsert POST action
added API call for HTTPDelete in the CategoryController.cs
implemented HTTPDelete with a delete method in category.js
added delete functionality in category.js with onclick
added delete url function code
I am sill have the error, I will try later how to figure out this


2022-11-14 13000
fixed the error by removing a parenteses in category.js and put letter D in capitalLetter
in Index.cshtml in table id and was instantiated method loadDataTable in category.js file.

               /////////////////////////////////////////////////////////////////////

2022-11-21  1500
Fixed the visual issue where I couldn't see the list of products in the table because it was too bright.
Added CoverTypeRepository class 
Added ICoverTypeRepository interface 
Added CoverType to UnitOfWork and IUnitOfWork
Added migration
updated database 
Added file 20221121213144_AddCoverTypeToDb.cs


2022-11-21  1620
Added Cover Type to NavBar
Add CoverType Controller with Action Methods
Cover Type Index View to use DataTables
Cover Type Upsert View takes care of creating and updating CoverType


2022-11-21  1830
Deleted CoverType is done using the API Call.
Added a new class Product
Added migration add-migration AddProductToDb
Added file "20221122011802_AddProductToDb.cs"
Updated the database
Added the file name 20221122013256_AddValidationToProduct.cs


2022-11-21  2110
Added Product to the Repository
Added IProductRepository Interface
Added ProductRepository Class 
Add Product to UnitOfWork and IUnitofWork
I built and everything is working and I´m ready for next step...


2022-11-22  1320
Added ProductController.cs and ProductVM.cs class
Modified the API call to include the Category and CoverType properites
Added an Index view afor Product
Copied the Index.cshtml code from Views/Category and modified to the Product List header. 
Modified the _Layout.cshtml to add a new link to Product.
Run the application and its working...


2022-11-22  1930
Created an Upsert.cs for Products 
Added a rich textbox to the textarea inside Product
Added a new folder and subfolder in wwwroot 
Configured the Product Upsert Post action method.
I have an error because when I clicked to add the product the page is not loading.
I will try to fix this tomorrow.


2022-11-23  1400
After some revisions in the code I realized that I put an extra "T" in Upsert and that's why it wasn't working,
after correcting that I managed to register the product and everything is working now...

                /////////////////////////////////////////////////////////////////////

Starting part 4 of the assignment...

2022-11-29 13000

Updated database 
Added 3 properties of price in Product.cs
[Range(1, 10000)]                   [Range(1, 10000)]                          [Range(1, 10000)]
public double Price { get; set; }	public double Price50 { get; set; }        public double Price100 { get; set; }
Added migration
Added file 2022112013256_AddNewValidationToProduct.cs

2022-11-29 1530

Added 3 more properties in ProductRepository.cs (objFromDb.Price,objFromDb.Price50 and objFromDb.Price100)
Added 5 more access modifiers in Utility/SD.cs (public const string Proc_CoverType_Create,public const string Proc_CoverType_Get
public const string Proc_CoverType_GetAll,public const string Proc_CoverType_Update,public const string Proc_CoverType_Delete)
Added fields for Upsert.cshtml (<input asp-for="Product.Price" class="form-control" />,<input asp-for="Product.Price50" class="form-control" /> and
<input asp-for="Product.Price100" class="form-control" />)


2022-11-29 2030
Added images in images folder
Added the product
I tested and everything is working... I added the products without error


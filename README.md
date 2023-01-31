# BasicProgramCSharp
Basic Programs of C Sharp
JavaScript program execution reference :
https://www.youtube.com/watch?v=x_2sYpk75Ic 
https://github.com/Suraj-Dal?tab=repositories

For Boiler Plate in Program.cs
https://stackoverflow.com/questions/70327725/net-core-not-showing-in-target-framework-dropdown-for-visual-studio-2022

ER Diagram ::
https://hasura.io/learn/database/microsoft-sql-server/er-modeling/#:~:text=Entity%2DRelationship%20(ER)%20model,of%20the%20overall%20database%20structure.

https://github.com/RahulAid/Object-Oriented-Programs/blob/UC4CommercialDataProcessing/Repository/CommercialDataProcessing.cs
Marketshares problem with json input

link :: https://www.codespeedy.com/replicate-the-google-com-page-design-using-html-and-css/
html ans CSS google page.

Link :: https://www.codespeedy.com/category/javascript/
Link :: https://thispointer.com/create-a-list-of-objects-in-javascript/
For Javascript Code reference

Link :: https://developer.mozilla.org/en-US/docs/Learn/CSS/Building_blocks/Images_media_form_elements
html reference for form

Link :: https://github.com/Asabeneh/30-Days-Of-JavaScript/blob/master/14_Day_Error_handling/14_day_error_handling.md
about javascript error handling

Link :: https://www.freecodecamp.org/news/how-to-use-javascript-collections-map-and-set/
JavaScript map and set material.

Link :: https://www.geeksforgeeks.org/how-to-validate-form-using-regular-expression-in-javascript/
javascript regex validation in forms

Link :: https://www.w3schools.com/css/tryit.asp?filename=trycss3_box-sizing_all
box-sizing: border-box; explanation

Link :: https://icons.getbootstrap.com/#icons
Bootstrap link for icons

Link :: https://www.google.com/search?q=how+to+align+image+in+html&tbm=isch&rlz=1C1CHZL_enIN1001IN1007&hl=en&sa=X&ved=2ahUKEwiO97CDrND4AhVwyXMBHQQYCrYQrNwCKAB6BQgBEKYC&biw=1263&bih=601
How to align images in html

Link :: https://dev.to/__junaidshah/submit-form-details-and-display-them-in-a-table-3kce
To save from data

Link :: https://javascript.info/map-set
Reference for Map in JS

Local storage :
inspect - application - local storage click on link.

to rdirect to part of page use id and href

margin is added ouside div and padding is inside the div, Space btwn the text and border
text-decoration : none to remove line href

To add map in web page:
type address in google/click on maps/then click on share/In Embedded maps we have html iframe tag use it in code/


Review Questions:
1)Exceptions and types
2)List and arraylist
3)what is enum
4)oops
5)linkedlist,stack,Queue

database is a storage system that has a collection of data.

6)Annotations ([TestClass],[TestMmethod])
Data annotations are a way of adding more contextual information to classes or members of a class. There are three main categories of annotations:
Validation Attributes: add validation criteria to data
Display Attributes: specify how the data should be displayed to the user
Modelling Attributes: add information on usage & relationship with other classes(specifies relationship btwn classes)

7)LAMBDA Expressions in C# are used like anonymous functions, with the difference that in Lambda expressions 
you don’t need to specify the type of the value that you input thus making it more flexible to use. 
The ‘=>’ is the lambda operator which is used in all lambda expressions. The Lambda expression is divided 
into two parts, the left side is the input and the right is the expression or statement.

8)TSQL - it is an extension to SQL
https://www.simplilearn.com/tutorials/sql-tutorial/transact-sql
T-SQL provides some unique features to the users.It adds declared variables, transaction control, error and 
exception handling,and row processing to SQL.
T-SQL has a BULK INSERT statement that allows users to import a file into the database table or view in a 
user-specified format.
T-SQL provides various support functions for string processing and data processing.

9)Aggregate Operators: count, sum , min, max

10)Truncate and Delete : https://byjus.com/gate/difference-between-delete-and-truncate/
Delete is used to delete certain rows with a condition.
Truncate is used to remove all the rows of table.
drop is used delete the table, column, database.

11) Alter Column :: 
ALTER TABLE TableName  
ALTER COLUMN ColumnName NewDataType;

The PRIMARY KEY::  constraint uniquely identifies each record in a table. Primary keys must contain 
UNIQUE values, and cannot contain NULL values. A table can have only ONE primary key; and in the 
table, this primary key can consist of single or multiple columns (fields).

FOREIGN KEY :
The FOREIGN KEY constraint is a key used to link two tables together.
A FOREIGN KEY is a field (or collection of fields) in one table that refers to the PRIMARY KEY 
in another table. We can have more than one foreign key in a table, foreign key also accepts null values.

Stored procedure: 
A stored procedure is a prepared SQL code that you can save,so the code can be reused over and over again.

SQLConnection to establish connection btwn database and frontend
yt video for ado.net reference :: (https://www.youtube.com/watch?v=ko-wrVvIu_E)
Joins in SQL : https://www.educba.com/types-of-joins-in-sql/

// code for review to handle the exception using try catch/when smthg goes wrong in try it enters catch block.
[TestMethod()]
        public void CustomException_FirstNameTest_1()
        {
            try
            {
                string expected = "Name is Valid ";
                CustomUserregistration customUserregistration = new CustomUserregistration();
                string result = customUserregistration.CustomException_FirstName("");
                Assert.AreEqual(expected, result);
                //UserRegistration UR8 = new UserRegistration();
                //UR8.PasswordRule4("PassWordRule@4");
                //Assert.AreEqual(true, UR8.PasswordRule4("776g"));

            }
            catch (Exception ex)
            {
                //throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidPasswordRule, "Password Should not be Empty or Null");

                Console.WriteLine(ex.Message);
            }
-----------------------------------------------------------------------------------------------------------------------------------
Hashing :
is a technique of mapping large data into small tables.
hashing is done for indexing and locating items in database.

HashFunction::
takes a group of characters(keys) and maps it into values of certain length.

hash value: represents original string of characters.

Binary Search :
is an algorithm used to search an element from a sorted list.
it follows divide and conquer approach. where the list is divided into two halves and the item is compared with the middle element.

BST:
bst is a tree with search prpties where elements in left sub tree are lesser than the root and elements in right sub tree are larger than the root. 

Regex :
is used for data validation. 
regex or patterns are special characters which is used in searching the data and matching the complex patterns.

unit testing: 
we write unit test to test the small part of code(like methods) to check its functionality.

MS testing :
is a framework used in .net to write tests for its applications.
 
Data structure : is a way that specifies how to organize and manipulate data. two types linear(array, Lists, queue, stack) and non-linear(trees graphs).

Linkedlist:
ll is a data structure. where data is stored in non contiguous location.data is stored in nodes. 
where each node has two fields. 1) data - stores the values. 2) address - stores the reference of next field.
we have four methods to add data. addfirst addlast addBefore addafter
we can do data manipulation.

Stack : LIFO
it is a DS. we have push pop peek methods etc
Queque : FIFO
front and rare pointer
is a DS. enQue deQue peek methods

Exception : is a event or runtime error that prevents the flow of the program and it can be handled.
built in(checked and unchecked) and user defined(custom exception).

Throw :
In c#, the throw is a keyword, and it is useful to throw an exception manually during the execution of the program, and we can handle those thrown exceptions using try-catch blocks based on our requirements. 
The throw keyword will raise only the exceptions that are derived from the Exception base class.

5.What is the purpose of the finally block?
The code in finally block is guaranteed to run, irrespective of whether an error occurs or not. 
Critical portions of code, for example release of file handles or database connections, should be placed 
in the finally block.

-----------Count Method of Emp Payroll ADO.net----------------------------------------------------------------------------------
public int CountOfRows()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =PayrollServiceADO; Integrated Security = True;");
            connection.Open();
            string query = @"Select count(*) from EmployeeDetails;";
            SqlCommand cmd = new SqlCommand(query, connection);
            object res = cmd.ExecuteScalar();
            connection.Close();
            int Count = (int)res;
            return Count;
        }
--------------------------------------------------------------------------------------------------------------------------------
Stored Procedure :
A stored procedure is a prepared SQL code that you can save, so the code can be reused over and over again. So if you have an SQL query that you write 
over and over again, save it as a stored procedure, and then just call it to execute it.

LINQ : is uniform Query Syntax in C# to retrieve data from different sources and formats.

----------------------
json-server --watch emp.json
 use in git bash

public void RetieveProductIDandReview(List<ProductReview> productreviewlist)
        {
            var product = productreviewlist.Where(from productReviews in productreviewlist
                                                  select new { productreviewlist.ProductID, productreviewlist.Review }));
            foreach (var productData in productreviewlist.Where (from productReviews in productreviewlist
                                         select new { productreviewlist.ProductID, productreviewlist.Review } ))
            {
                Console.WriteLine("ProductID:- " + productData.ProductID + "Review:- " + productData.Review);
            }
        }
___________________________________________
uc2

        public void addEmployeeToPayRollWithThread(List<Employee_details2> employeeDetails)
        {
            employeeDetails.ForEach((employeeData) =>
            {
                DateTime StartdateTime = DateTime.Now;

                Console.WriteLine("Employee being added:" + employeeData.FirstName);
                this.addEmployeePayRoll(employeeData);
                Console.WriteLine("Employee Added :" + employeeData.FirstName);

                DateTime StopDataTime = DateTime.Now;
                Console.WriteLine("Duration without Thread: " + (StopDataTime - StartdateTime));

            });
        }
--------------------
in test:
// Calcuate time for multi-threading
            DateTime StartdateTimeThread = DateTime.Now;
            operationWIthThreads.addEmployeeToPayRollWithThread(employeeDetails);
            DateTime StopDataTimeThread = DateTime.Now;
            Console.WriteLine("Duration with Thread: " + (StopDataTimeThread - StartdateTimeThread));
----------------in program.cs

            DateTime StartdateTimeThread = DateTime.Now;
            operationWIthThreads.addEmployeeToPayRollWithThread(employeeDetails2);
            DateTime StopDataTimeThread = DateTime.Now;
            Console.WriteLine("Duration with Thread: " + (StopDataTimeThread - StartdateTimeThread));
---------------------------
            Console.WriteLine("Duration without Thread: " + (StopDataTime - StartdateTime));
            Console.WriteLine("Duration with Thread: " + (StopDataTimeThread - StartdateTimeThread));

------------------------------------------
JSON Server : is a node module that we can use to create a demo REST json webservice in less than a minute.
All you need is a json server for sample data.
 to install json server 
npm install -g json-server
to check version : json-server -v

--------------------------
RESTSharp is a open source HTTP client library

By definition, the PATCH method applies partial modifications to a resource, 
making it a lightweight option to PUT. Both methods are equivalent, but semantically, they are different.
post - to add additional data
put to modify
get - to retrive

Task-parallel:
What is parallel Task in C#?
Task parallelism is the process of running tasks in parallel. Task parallelism divides tasks and allocates
 those tasks to separate threads for processing. It is based on unstructured parallelism. It means the 
parallel work unit may start and finish in places scattered according to the execution of the program.

LINQ 
Language Integrated Query is a Microsoft .NET Framework component that adds native data querying 
capabilities to .NET languages
linq operators : filtering operators, sorting operators, conversion operators, grouping operators, aggregate operators.

Transaction :
Ensures that all operations within the work unit are completed successfully; If the transaction fails then operations
 are rolled back to their previous state. Ensures that the database properly changes states upon a successfully 
committed transaction

PostMan::
Postman is an API(application programming interface) development tool which helps to build, test and modify APIs. 
Postman is an API client that makes it easy for developers to create, share, test and document APIs. 
This is done by allowing users to create and save simple and complex HTTP/s requests, as well as read their responses

API :: is used for data transfer between two applications.

What is REST API :
A REST API is a way for two computer systems to communicate over HTTP in a similar way to web browsers and servers

Threading :
A thread is defined as the execution path of a program.

Multi-threading : enables your application to have more than one execution path at the same time.

Commit and roll back
The COMMIT statement lets a user save any changes or alterations on the current transaction. These changes then remain permanent. The ROLLBACK statement lets a user undo all the alterations and changes that occurred on the current transaction after the last COMMIT.
------------------------------------------------------------------------------------------------------------------
The value attribute is used differently for different input types:

For "button", "reset", and "submit" - it defines the text on the button
For "text", "password", and "hidden" - it defines the initial (default) value of the input field
For "checkbox", "radio", "image" - it defines the value associated with the input (this is also the value that is sent on submit)

qstns to find out??
1)box-sizing and its types
2)box-shadow and how to change its direction? how to get shadow on left?
3) Complete study on background an its properties.
4)min-height
5)resize in css
6)Fav icon

-----------------------------------
Flexbox :
Flexbox is a one-dimensional layout method for arranging items in rows or columns. Items flex (expand) to fill additional space or shrink 
to fit into smaller spaces.

Template literals (Template strings)
Template literals are literals delimited with backtick (`) characters, allowing for multi-line strings, for string interpolation with 
embedded expressions, and for special constructs called tagged templates.

Template literals are sometimes informally called template strings, because they are used most commonly for string interpolation 
(to create strings by doing substitution of placeholders). However, a tagged template literal may not result in a string; it can be
 used with a custom tag function to perform whatever operations you want on the different parts of the template literal.

Client-server architecture
is an architecture of a computer network in which many
clients (remote processes) can request and receive services from a centralized
server (host computer).

In the demo the Client Requests was from the
Browsers and the Node Process while the
Centralized Server was the JSONServer
running in the Local Host or Machine.

The Client Systems are called Front End Systems and are developed using Frameworks like
React JS, Angular JS, etc. all of which are JavaScript Frameworks.
• The Server Systems are called Back End Systems can be developed using Java & Spring or C# &
.NET or JavaScript & NodeJS, Python & Django etc.

Arrow Function :
Arrow functions are a new way to write anonymous function expressions, and are similar to lambda functions in some other programming languages
arrow functions are particularly useful when passing a function as a parameter to a higher-order functions.

JavaScript ::
is a text-based programming language used both on the client-side and server-side that allows you to make web pages interactive. 
Where HTML and CSS are languages that give structure and style to web pages, JavaScript gives web pages interactive elements that engage a user.

Types of errors :

six basic types : eval error, range error, type error, syntax error, reference error, URIerror.

A data structure is a specialized format for organizing, processing, retrieving and storing data. There are several basic and advanced types 
of data structures, all designed to arrange data to suit a specific purpose. Data structures make it easy for users to access and work with the 
data they need in appropriate ways.

var and let difference :
let does not allow to redeclare variables.	
var allows to redeclare variables.

let is block-scoped.	var is function scoped.
let does not allow to redeclare variables.	var allows to redeclare variables.
Hoisting does not occur in let.	Hoisting occurs in var.

Collection ::
A collection is a class, so you must declare an instance of the class before you can add elements to that collection.

Local storage:
The localStorage object stores data with no expiration date.
The data is not deleted when the browser is closed, and are available for future sessions.
Link :: https://blog.logrocket.com/localstorage-javascript-complete-guide/

Session Storage:
The sessionStorage Object which stores data for one session.
(The data is deleted when the browser window is closed)

JSON.parse() is used to convert JSON string to JavaScript object.
JSON.stringify() is used to convert js object to json string.
Link to include bootsrtap ::
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
Link for cards : https://getbootstrap.com/docs/4.3/components/card/

AJAX 
is used to communicate between client and server.

ICOMPARABLE
C# provides an IComparable interface. This interface provides different types of type-specific 
comparison methods which means a value type or a class can implement this interface to sort its 
instances because we cannot sort the instances of a class directly because the compiler does not know on which basis to sort.
--------------------------------------------------------------
Basic Git Commands

https://www.cloudways.com/blog/git-cheat-sheet/?data1=18059204530&data2=&id=290872&gclid=Cj0KCQjwnbmaBhD-ARIsAGTPcfU1YilgTtsZ19VSfvl7U95oQTVFaG6zjIIKoT_QqrrhhI4lD4l3zR0aAszsEALw_wcB

For the below mention steps the Project Name & Repository Name should be same

Step 1: Create 1 Repository in your github
        Select Add ReadMe, & gitignore -> visual studio
Step 2: Create Project in Visual Studio
step 3: Open your project folder where the .sln file is present then open your git bash here
step 4: Now git status - For checking the status of the repository
step 5: git init       - Make your folder/project as git repository
step 6: git remote add origin "github repository link"
step 7: git branch -M main
step 8: git pull origin main
step 8: Go to your visual studio write one welcome message code in your main method & check is it working or not
step 9: git add .
step 10: git commit -m "commit message"
step 11: git push origin main
All the above mention part is before writing your actual code for the use cases
Now the main part is starting which is writing code for the use cases

Ex: Employee Wage Computation Problem
    UC1 - Emplyee Attendance
    UC2 - Calculate Daily Wage
    UC3 - Part time
    UC4 - Switch Case
I am taking the above mention example to write my git commands
step 12: git checkout -b UC1_EmployeeAttendance
step 13: Write your code for use case 1 & test it. If it is working fine then you are ready to go
step 14: Now git add . -> git commit -> git push origin "UC1_EmployeeAttendance"
step 15: git checkout main
step 16: git merge UC1_EmployeeAttendance
step 17: git push origin main
step 18: git checkout -b "UC2_EmpDailyWage"
step 19: Write your code for use case 2 & run it.
step 20: Now git add . -> git commit -> git push origin UC2_EmpDailyWage
step 21: git checkout main
step 22: git merge UC2_EmpDailyWage
step 23: git push origin main
step 24: Repeat steps from step 12 to step 17 for every new case

Stopwatch :: https://www.dotnetperls.com/stopwatch


public static void FileExists()
        {
            String path = "Example.txt";
            if(File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesn't exists");
        }

        public static void ReadAllLines()
        {
            String path = "C:\\Users\\inyadav\\source\\repos\\Day20_FileIO\\Day20_FileIO\\Example.txt";
            String[] lines;
        //C: \Users/inyadav\source\repos\Day20_FileIO\Day20_FileIO
         lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

        }

        public static void ReadAllText()
        {
            String path = "C:\\Users\\inyadav\\source\\repos\\Day20_FileIO\\Day20_FileIO\\Example.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

        }

        public static void FileCopy()
        {
            String path = "C:\\Users\\inyadav\\source\\repos\\Day20_FileIO\\Day20_FileIO\\Example.txt";
            String copypath = "C:\\Users\\inyadav\\source\\repos\\Day20_FileIO\\Day20_FileIO\\ExampleNew.txt";

            File.Copy(path, copypath);

        }

        public static void DeleteFile()
        {
            String path = "C:\\Users\\inyadav\\source\\repos\\Day20_FileIO\\Day20_FileIO\\Example.txt";

            File.Delete(path);

        }

        public static void ReadFromStreamReader()
        {
            String path = "C:\\Users\\inyadav\\source\\repos\\Day20_FileIO\\Day20_FileIO\\Example.txt";

            using (StreamReader sr=File.OpenText(path))
            {
                String s = "";
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
            }

        }

        public static void WriteUsingStreamWriter()
        {
            String path = "C:\\Users\\inyadav\\source\\repos\\Day20_FileIO\\Day20_FileIO\\Example.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hellow World - .Net is awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }

NOTES CFP FILE--------------------------------------------------------------------------------------------------------------------------------------------------------
  

our Meet Link :: https://meet.google.com/wuh-dzkc-utf?pli=1&authuser=1

https://code-maze.com/net-core-web-api-ef-core-code-first/


CFP Meeting link
meet.google.com/kbd-vmhg-wgm

Doubts session : https://meet.google.com/ver-wqec-bbi
class rajashri:: https://meet.google.com/ibg-ivje-nev

Logger :
https://youtu.be/xG8AOAzgcAw
https://www.youtube.com/watch?v=Jjt1GcXj16k

link for Encrypt/Decrypt ::
https://www.youtube.com/watch?v=u-ROJ4KqoN8

Docs to start Web API :
Link : https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio

Get all notes, get all collab, get all label , implement redis for 
redis cache :: https://codewithmukesh.com/blog/redis-caching-in-aspnet-core/

Link for Image API::
https://cloudinary.com/documentation/dotnet_image_and_video_upload

Detailed explanation about Cloudinary ::
https://cloudinary.com/documentation/how_to_integrate_cloudinary

https://levelup.gitconnected.com/upload-and-download-multiple-files-using-net-5-0-web-api-430f95f34237

https://csharp.hotexamples.com/examples/CloudinaryDotNet/Cloudinary/Upload/php-cloudinary-upload-method-examples.html

Link for Image : https://www.youtube.com/watch?v=FcdXA6EYWyM&t=567s
 
Generate Google App password :
https://www.youtube.com/watch?v=uVDq4VOBMNM

Link to enable "" : Less secure app access not showing @gmail (SOLVED)
https://www.youtube.com/watch?v=LiQYJ6tN51A

Check link for Configuring Authentication in startup.cs(found self)
https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/social-without-identity?view=aspnetcore-6.0

Link for encryption and decryption :
https://www.youtube.com/watch?v=u-ROJ4KqoN8

Exception handling in Fundoo project implement in controllers
Link https://code-maze.com/global-error-handling-aspnetcore/


view > Sqlserverobject explorer> sqlserver>opn dropdown>
--------------------------------------------------------------------------------------------------------------------------------------------------------------------
*by applying redix we use cache due to which execution time decreases.
when we are hitting same type of browser request multiple times, the get data from database is time taking process, so here we introduce redix cache so this data 
is stored in redix cache and when we make a request then we get data from this cache which reduces time of execution.

*registering database with code in context class
Day 5:
Enable authorization in startup.cs
reset Password

for authentication by mentor(nith) :: https://codeshare.io/WdJdZ3
___________________________________________________________

Packages to install to make connection with sql server and create table in it.
Microsoft.EntityFrameworkCore.relational,sqlserver,Tools
________________________________________________
For forget part ::
MSMQ.- (Microsoft Messaging Queue)

Implementation of swagger::
Link :: https://www.youtube.com/watch?v=TlytBx3-k-k
https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-6.0

Authentication and authorization.
dwnlod and startup
delegates and events.
Why do we need event in C#?
Events enable a class or object to notify other classes or objects when something of interest occurs. The class that sends (or raises) the
event is called the publisher and the classes that receive (or handle) the event are called subscribers.
msg sending code.

Msmq implementation using delegates and events:

https://www.c-sharpcorner.com/UploadFile/b9e011/introduction-to-msmq/ 
https://www.c-sharpcorner.com/UploadFile/55d2ea/microsoft-message%C2%A0queuemsmq/ 

For study msmq: 
https://dotnetcoretutorials.com/2018/07/29/queues-in-net-core/ 
https://docs.microsoft.com/en-us/previous-versions/windows/desktop/msmq/ms711472(v=vs.85) 

Delegates and Events : 
https://csharpindepth.com/articles/Events 
https://www.akadia.com/services/dotnet_delegates_and_events.html
__________________________________________________________________
Todays Target::

what is Entity Data Model?
Entity Data Model has three approaches.
1)Code First Approach
2)Database First Approach
3)Model First Approach

Entity Framework :: is an ORM (object relational mapping) framework used to map .net objects with the database entities.
Is a tool used to create, access database.

*******************************************************************************************************
what is the CONTROLLER in ASP.net? (https://www.tutorialsteacher.com/webapi/web-api-controller)
A controller contains the flow control logic for an ASP.NET MVC application. A controller determines what response to send back
to a user when a user makes a browser request.

--ApiController includes multiple action methods whose names match with HTTP verbs like Get, Post, Put and Delete.
--About http action methods :: Based on the incoming request URL and HTTP verb (GET/POST/PUT/PATCH/DELETE), 
Web API decides which Web API controller and action method to execute 
e.g. Get() method will handle HTTP GET request, Post() method will handle HTTP POST request, Put() mehtod will 
handle HTTP PUT request and Delete() method will handle HTTP DELETE request for the above Web API.
*****************************************************************************************************************
Code First Approach :: create classes
we create the classes for our domain entities first. Later, 
we will create the database from our code by using migrations.

IIS Express (Internet Information Services) :: (used to to develop and test websites)is a Web Server which
provides a secure platform for hosting websites, services, and applications.

*******************
=>Ways to implement Dependency Injection 

(https://www.c-sharpcorner.com/article/service-lifetime-dependency-injection-asp-net-core/)

AddTransient :: AddTransient() - This method creates a Transient service.
Transient lifetime services are created each time they are requested. This lifetime works best for lightweight, stateless services.

AddScoped() ::
Scoped lifetime services are created once per request.

AddSingleton() ::
Singleton lifetime services are created the first time they are requested (or when ConfigureServices is
run if you specify an instance there) and then every subsequent request will use the same instance.

*********************

Authentication is the process of verifying who someone is,
whereas authorization is the process of verifying what specific applications,files, and data a user has access to.

Authentication :: 
(validates the identity of the client attempting to make a connection by using an authentication protocol.)
How it works::
The login credentials are compared against the originals stored in the website's server. If they match, the user is authenticated and provided access to their account.
Types ::

Authorization ::
The authorization service ensures that the user is authorized to have access to a particular resource. 
Authorization can be done through role-based access control (RBAC) or list-based access control (LBAC).

JSON Web Token (JWT) ::
To authenticate a user, a client application must send a JSON Web Token (JWT) in the authorization header of the HTTP request to your backend API.
JWT consists of three parts: a header, payload, and signature.
The server generates a token that certifies the user identity, and sends it to the client.
----------------------------------------------------------------------------------------------------------------------------------------------------------------
Link :: https://www.youtube.com/watch?v=-B0rZxlrFZE

CRUD operations php XAMP ::

https://codewithawa.com/posts/php-crud-create,-edit,-update-and-delete-posts-with-mysql-database
https://code-maze.com/net-core-web-api-ef-core-code-first/
git repo for source code of the fundo app related :: https://github.com/CodeMazeBlog/.NET-Core-Series/tree/master/Part%202/AccountOwnerServer/AccountOwnerServer
----------------------------------------------------------------------------------------------------------------------------------------------------------------
Link :: https://www.entityframeworktutorial.net/efcore/one-to-many-conventions-entity-framework-core.aspx

Day 1: Topics::

what is an API?-- 
difference between .net and .net core
.Asp .net core web API - project

3 Tier Architecture- (Flow - common -- Repository -- Business -- main Program)
1) Business Layer/logic			
2) Common Layer/Models			
3) Repository Layer/Data 
Dependency Injection in ASp .net core

What is the difference between dot net and dot net core?
Application Models

Net Core does not support desktop application development and it rather focuses on the web, windows mobile, and windows store. 
.Net Framework is used for the development of both desktop and web applications as well as it supports windows forms and WPF applications.

Check the diffrence in AddSingleton, AddScoped, AddTransient

Startup.cs file-configure service vs configure.
The ConfigureServices method includes the IServiceCollection parameter to register services to the DI container.

Link :: https://www.c-sharpcorner.com/interview-question/difference-between-configureservices-and-configure-method-in-startup-class
RESTful HTTP services
Http verbs
PostMan- download
Entity Framework
Code First Approach

Day 2 ::
IIS Express
-----------------------------------------------------------------------------------------------------------------------------------------------------------------
Swagger::
Swagger is a framework for describing your API using a common language that everyone can understand.

Desktop and Web Application ::
Desktop application is a computer program that runs locally on a computer device like a desktop or a laptop whereas 
a web application needs an internet connection or some sort of network to work properly.

3 Tier architecture:
Three layers - Common layer, Business Access layer, Repository layer.

[Presentation Layer (PL)
The Presentation layer is the top-most layer of the 3-tier architecture, and its major role is to display the results 
to the user, or to put it another way, to present the data that we acquire from the business access layer and offer the results to the front-end user.

Business Access Layer (BAL)
The logic layer interacts with the data access layer and the presentation layer to process the activities that lead to 
logical decisions and assessments. This layer's primary job is to process data between other layers.

Data Access Layer (DAL)
The main function of this layer is to access and store the data from the database and the process of the data to business access layer data 
goes to the presentation layer against user request.]

MVC 
stands for Model, View, and Controller. MVC separates an application into three components - Model, View, and Controller. Model: Model 
represents the shape of the data. A class in C# is used to describe a model. Model objects store data retrieved from the database.

Link :: https://www.c-sharpcorner.com/UploadFile/cd3310/using-mvc-Asp-Net-tools-create-simple-login-form/
for login form using MVC.

Link :: https://www.tutorialspoint.com/asp.net_mvc/asp.net_mvc_getting_started.htm
for creating a console app using MVC and creating a controller in it.

Dependency Injection ::
is a design pattern in which an object or function receives other objects or functions that it depends on.

Types of dependency injection (https://en.wikipedia.org/wiki/Dependency_injection)
There are three main ways in which a client can receive injected services:

Constructor injection, where dependencies are provided through a client's class constructor.
Setter injection, where the client exposes a setter method which accepts the dependency.
Interface injection, where the dependency's interface provides an injector method that will inject the dependency into any client passed to it.

In some frameworks, clients do not need to actively accept dependency injection at all. In Java, for example, reflection can make private attributes public 
when testing and inject services directly.

REST API (gets request from client through HTTP protocol and does task as per request)
REST API would use a GET request to retrieve a record, a POST request to create one, a PUT request to update a record, 
and a DELETE request to delete one. All HTTP methods can be used in API calls. A well-designed REST API is similar to a 
website running in a web browser with built-in HTTP functionality.

HTTP verbs - are Request Methods
HTTP defines a set of request methods to indicate the desired action to be performed for a given resource.
These request methods are sometimes referred to as HTTP verbs.(GET,PUT,POST,PATCH,DELETE)

What is configure service? (this method is used to add services)
ConfigureService is an optional method used to configure services that are used by our application where 
as ConfigureMethods defines how the application will respond to each http request.

Note ID
Nullable attribute: the entity that can accept null values.
by placing question mark at the end, it can be made nullable.

Create Notes In Fundoo app
first create table in entity
then add context in context > fundoo
the do migration>go to ....>Add-migration entityname
then update


_______________________________________________________________________________________________________________________________________________________________________
flow of control
common>repolayer>business>fundoo(main)
(add reference of common layer in repository layer) and soo on
________________________________________________________________________
To create a ASP.net core Web API
then select that console app. name,location.
then select .net core 3.1 version for 2022 version of VS.
then create BusinessLayer, CommonLayer, RepositoryLayer by selecting new project and select class library, then 
create Interface and services folders in Business and Repository layer.
create Model folder in common layer.
create Context, Entity folders in Repository Layer
=>Add reference of common layer in Repository layer
=>Add reference of Repository layer in Business layer
=>Add reference of Business layer in Main App
Create a controller folder in Main App, where we write API's.
 

_______________________________________________________________________________
How does IIS work?
Most commonly, IIS is used to host ASP.NET web applications and static websites.
It can also be used as an FTP server, host WCF services, and be extended to host web applications built on other platforms such as PHP.
There are built-in authentication options such as Basic, ASP.NET, and Windows auth

Data Seeding ::
Data seeding allows us to provide initial data during the creation of a database.

Request model : input
Response Model : response

Http response format:
SMD : success(true/false) Message(action msg) Data(response to be given)

IActionResult :: when we expect multiple HTTP status codes in return
IActionResult is an Interface, we can create a custom response as a return, when you use ActionResult you can 
return only predefined ones for returning a View or a resource. With IActionResult we can return a response, or error as well.

The IActionResult return type is appropriate when multiple ActionResult return types are possible in an action. 
The ActionResult types represent various HTTP status codes. Any non-abstract class deriving from ActionResult qualifies as a 
valid return type. Some common return types in this category are BadRequestResult (400), NotFoundResult (404), and OkObjectResult (200).
-----------------------------------------------------------------------------------------------------------------
Encryption/Decryption in Registration and Login ::
public static string Key = "adef@@kfxcbca";

        public static string ConvertToEncrypt(string password)
        {
            if (string.IsNullOrEmpty(password)) return "";
            password += Key;
            var passwordBytes=Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(passwordBytes);
        }
        public static string ConvertToDecrypt(string base64EncodeData)
        {
            if (string.IsNullOrEmpty(base64EncodeData)) return "";
            var base64EncodeBytes=Convert.FromBase64String(base64EncodeData);
            var result = Encoding.UTF8.GetString(base64EncodeBytes);
            result=result.Substring(0, result.Length-Key.Length);
            return result;
        }
---------------------------------------
//trial one
        string key = "1prt56";
        public string Encryptword(string Encryptval)
        {
            byte[] SrctArray;
            byte[] EnctArray = UTF8Encoding.UTF8.GetBytes(Encryptval);
            SrctArray = UTF8Encoding.UTF8.GetBytes(key);
            TripleDESCryptoServiceProvider objt = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider objcrpt = new MD5CryptoServiceProvider();
            SrctArray = objcrpt.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            objcrpt.Clear();
            objt.Key = SrctArray;
            objt.Mode = CipherMode.ECB;
            objt.Padding = PaddingMode.PKCS7;
            ICryptoTransform crptotrns = objt.CreateEncryptor();
            byte[] resArray = crptotrns.TransformFinalBlock(EnctArray, 0, EnctArray.Length);
            objt.Clear();
            return Convert.ToBase64String(resArray, 0, resArray.Length);
        }
        public string Decryptword(string DecryptText)
        {
            byte[] SrctArray;
            byte[] DrctArray = Convert.FromBase64String(DecryptText);
            SrctArray = UTF8Encoding.UTF8.GetBytes(key);
            TripleDESCryptoServiceProvider objt = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider objmdcript = new MD5CryptoServiceProvider();
            SrctArray = objmdcript.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            objmdcript.Clear();
            objt.Key = SrctArray;
            objt.Mode = CipherMode.ECB;
            objt.Padding = PaddingMode.PKCS7;
            ICryptoTransform crptotrns = objt.CreateDecryptor();
            byte[] resArray = crptotrns.TransformFinalBlock(DrctArray, 0, DrctArray.Length);
            objt.Clear();
            return UTF8Encoding.UTF8.GetString(resArray);
        }
----------------------------------------
public string Decrpt(string encodedData)
        {
            try
            {
                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder utf8Decode = encoder.GetDecoder();
                byte[] todecode_byte = Convert.FromBase64String(encodedData);
                int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                char[] decoded_char = new char[charCount];
                utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                string result = new String(decoded_char);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
public string EncryptPass(string password)
        {
            try
            {
                string msg = "";
                byte[] encode = new byte[password.Length];
                encode = Encoding.UTF8.GetBytes(password);
                msg = Convert.ToBase64String(encode);
                return msg;
            }
            catch (Exception)
            {
                throw;
            }
        }

---------------------------------------------------------------------------------------------------------------------------------
DBMS practice Advance::
https://www.sqlservertutorial.net/sql-server-basics/

subqueries, joins, advanced topics
_________________________________________________
cmmds to use stored procedure in ado.net::
SqlCommand cmd = new SqlCommand("SpAddressBook", this.connection);
cmd.CommandType = CommandType.StoredProcedure;
__________________________________________________-

Indexes ::
Indexes are special data structures associated with tables or views that help speed up the query. 
SQL Server provides two types of indexes: clustered index and non-clustered index.

The syntax for creating a clustered index is as follows:

CREATE CLUSTERED INDEX index_name
ON schema_name.table_name (column_list);  

Triggers ::
SQL Server triggers are special stored procedures that are executed automatically in response to the database object, 
database, and server events. SQL Server provides three type of triggers:

Data manipulation language (DML) triggers which are invoked automatically in response to INSERT, UPDATE, and DELETE events against tables.
Data definition language (DDL) triggers which fire in response to CREATE, ALTER, and DROP statements. DDL triggers also fire in response
to some system stored procedures that perform DDL-like operations.
Logon triggers which fire in response to LOGON events

Important topic :: Error handling in stored procedure.
we have naming conventions as follows
sp for stored procedure
tbl for table
IX for indexes
-----------------------------------------------------------------------------------------------------------
Indexes :
(Indexes are used to retrieve data from the database more quickly. 
The users cannot see the indexes, they are just used to speed up searches/queries.)

sp_helpindex tablename - is a built in stored procedure which is used to get all indexes in the table
To drop the index - drop index tablename.indexname

there are two ways to check the indexes in the table 
1)sp_helpindex tablename 
2)check the indexes under table

two main types of indexes: clustered index, non-clustered index
1)clustered Index:
syntax : create clustered index columnname on tablename (columnname asc/desc)
a table can have only one clustered index.
 the primary key acts as the clustered index, and if we dint give automatic increment for primary key and insert data, table inserts the 
records in the ascending order of primary key.
ex:if we insert a record where id=3 first then try to insert a record where id=1
then the record with id=3 will be pushed down and record with id=1 will be in first position.likewise it sorts the records.

2)Non clustered Index : A nonclustered index is an index structure separate from the data stored in a table that reorders one or more selected columns.
syntax : create NonClustered index IX_Columnname on tablename (columnname asc/desc)
A table can have more than one nonclustered index. the data is stored at a place and the indexes are stored at other, the indexes have the pointers that will point
the data.
Ex :: index page in a text book

**Difference between clustered index and non clustered index::
1)Only one clustered index in a table, and more than one nonclustered index
2)Clustered index is faster, than  non clustered index because if we want a 
record where name=sara, then we have look for the row address of that 
then refere the main table for that. so here we need an extra lookup in other table. where in clustered index everything is in one table, 
so no need of extra look up.
3)clustered index determines the storage order of the table as it doesnot require an extra disc space. 
where non clustered index needs extra space as they form a separte table.

Non-clustered Index uses different search methods : Table scan, Indexes Unique scan, Index range scan

Types of Indexes ::
Create Index IndexName on TableName(Column);
Default index is BTREE Index. In the ablove line.

Unique Index :
Composite Index : when we write query based on more than one column 
Function based Index : create Index IndexName on Emp(Upper(Name));
Bitmap Index : when we have columns like Gender(male, female). This index is created where the column dont have wide variety of values.

Important :: 

Index are generelly created on col which are usually used in where clause.
Index for Primary key and Unique constraints are automatically created and droped during table creation and deletion.
Index improve the performance but hamper the insert, update, delete. so donot create index for each column.
-----------------------------------------------------------
User Defined Scalar functions :
Link :: https://www.youtube.com/watch?v=OV5CquR1Svo
the function which takes zero or more parameters(we can have upto 1024 parameters) and returns a value is known as scalar function.
this function may or maynot have parameters but it should return a value.

----------------------------------------
Sub-Queries
https://www.youtube.com/watch?v=nJIEIzF7tDw
Sub-Query is a query which is placed in another Query.
ex:: select * from employee where salary > (select 
 
are 3 types::
scalar subquery - which returns one row one column.
multiple-row subquery - 2 types
-sub query which returns multiple rows and multiple columns

-sub query which returns multiple rows and one columns

--------------------------------------------------
JOINS ::

Join/Inner Join are same this is basic join, used to get the common data of the columns.
Left join :: gets all rows of left table columns.
Right Join :: gets all rows of right table columns.
outer join :: gets all rows of both tables.
self Join :: operated on Single Table. when One record from a table had to match with other record from same table, we use self join.
(https://www.youtube.com/watch?v=RehbnzKHS28)

---------------------------------------------------
/////
import React from "react";
import Scoreboard from "./scoreboard/scoreboard";

const App = () => {
  const [view, setView] = React.useState(true);
  return (
    <>
      {view ? <Scoreboard /> : <></>}
      <button onClick={() => setView(!view)}>SetView </button>
    </>


{
  "bookId": 1,
  "bookName": "A Dangerous place",
  "authorName": "D.P. Moynihan",
  "rating": 4.5,
  "totalRating": 20,
  "discountPrice": 1000,
  "originalPrice": 1200,
  "description": "The book gives the knowledge about how to survive in an Adventures place",
  "bookImage": "string",
  "bookCount": 100
}

Questions ::
Controller?
executeNonQuery, executeScaler, executeReader
what is MSMQ?
MSMQ is essentially a messaging protocol that allows applications running on separate servers/processes to 
communicate in a failsafe manner. A queue is a temporary storage location from which messages can be sent and 
received reliably, as and when conditions permit.

What is IConfiguration.
The IConfiguration is an interface for .Net Core 2.0. 
The IConfiguration interface need to be injected as dependency in the Controller and then later used throughout the Controller. 
The IConfiguration interface is used to read Settings and Connection Strings from AppSettings.json file.

Daily Session Updates:
Date - 19th October 2022

8:30 AM -  DB Programming with Priyanshu
11 AM - Ideation with Vijaylakshmi/Nandhagopal/Suraj
3 PM to 5 PM taken Dot Net doubt session with Rajashri/Apara.

Status codes
200 - okrequest has been accepted by client;
300 - client must take some more action in order to complete the request,
400- bad request

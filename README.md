# Getting Started with TDD Using XUnit


This example was set up using the following documentation. 
https://xunit.github.io/docs/getting-started-dotnet-core.html

###Requirements
* Visual Studio 2015
* .NET Core SDK

# Intro to TDD (Test Driven Development) Create a simple app that helps you setup, and configure a few tests to run within

###Bangazon Prime is a customer reward feature of a fictional company called Bangazon Inc.
It provides many benefits such as free shipping on many products, daily specials, black friday specials, free streaming of many movies. 

##What You Will Learn.
Tests enable you be confident that new code or refactoring does not break existing code. Writing tests prior to writing new code will help you discover how to implement the requirements. In addition your code will be testable from the onset rather than testable code being an after thought. You will learn to create failing tests based on requirements, better known as acceptance criteria. Your tests should document how your code is supposed to behave according to your acceptance criteria.  In TDD, tests are written PRIOR to implementation code. You will learn to run and refactor tests. You will learn that creating tests can not only be beneficial for new code but also of great value for ensuring bugs are fixed and tests are implemented around the bug fix. You will find that code changes may break existing tests, that is not a bad thing, it indicates the test needs to modified based on code changes.  Another benefit of tests is their role in continuous integration where tests are ran prior to being pushed to source control or even deployed to test or production environments. 

Prior to working on existing code you should pull the latest code then run the tests. All tests should pass. Create new tests for new functionality or bug fixes. Make sure all existing tests still pass and all new tests pass. 
##Myths About Test Driven Development (TDD)
   * TDD is just about testing
   * TDD slows down development
   * TDD means creating lots of interfaces
   * TDD guarantees you to catch all the potential errors in a system
   * TDD guarantees you to design your system well

https://en.wikipedia.org/wiki/Test-driven_development
http://bitbybitblog.com/introduction-to-test-driven-development/


###MAIN TDD STEPS (Red to Green Tests):
   1. Write the test prior to writing code.
   2. Run all tests and see if the new test fails
   3. Write the code to satisfy the test
   4. Run tests, refactor and fix until the test passes
   5. Refactor, clean up refine, make sure you are meeting acceptance criteria
   6. Repeat 


####Steps: 
* Create a new Visual .net core class library, name it BangazonCustomerServiceTests
* Go to the project.json file and delete the contents and replace with the following code: 
```
{
    "version": "1.0.0-*",
    "testRunner": "xunit",
    "dependencies": {
        "xunit": "2.2.0-beta2-build3300",
        "dotnet-test-xunit": "2.2.0-preview2-build1029"
    },
    "frameworks": {
        "netcoreapp1.0": {
            "dependencies": {
                "Microsoft.NETCore.App": {
                    "type": "platform",
                    "version": "1.0.0"
                }
            }
        }
    }
}
```
* Restore your packages
* Build the app to make sure there are no errors.
* Rename the file "Class1.cs" to "UserTests.cs"
* Add a first test. 
```
         [Fact]
        public void TestOfTestSystem()
        {
            //Lets make sure our test framework is working properly
            bool isTestFrameworkWorking = true;
            Assert.True(isTestFrameworkWorking);
        }
```
* The purpose of this test is to see if your test framework is working and you can view test results.
* Run the test. Go to the menu, choose test / windows /test explorer. 
* You should see the test explorer window on the left hand side of your Visual Studio screen.
* At this point you should see one test, "TestOfTestSystem". The icon for it will be blue which indicates that he
test has never been ran.
* Select the test and choose "Run selected test". 
* The test will run and the icon for the test should be green not red. If red, check the code for the test and see if there is anything wrong.


![alt text](https://github.com/dtinsley333/CustomerServiceTests/blob/master/TestRunner.png "Run a first test")

* We have determined that our app will need a user. We are going to create a tests for our user though our system does not yet have code to handle users.  Create the following test in the class file called "User.Tests". 
```
  [Fact]
        public void CanCreateUser()
        {
            User user = new User
            {
                UserId = 123,
                FirstName = "Bob",
                LastName = "Smith",
                StartDate=DateTime.Parse("1/1/2016"),
                EndDate=null,
            };

            Assert.NotNull(user);
        }
```
* You will see errors and this is by design. You are writing code that verifies that you can create a user. Now you need to implement code that will make the test pass. This is the essence of Test Driven Development. 
![alt text](https://github.com/dtinsley333/CustomerServiceTests/blob/master/NonCompilingUserTest.png "Test fails prior to implementing code.")

* Our test project will test various classes in a console app. Tests can also test other types of projects. Right click on your solution and create a new console app. Name the app CustomerService
* Add a new class file to the Customer Service Console app. Name the file "User.cs" and add the following code:
```
namespace CustomerService
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
```
* Right click on your test projects and "Add Reference". Select the Customer Service console app as your reference. 
* Rebuild your project. Then run the tests again. Both tests should pass. 
![alt text](https://github.com/dtinsley333/CustomerServiceTests/blob/master/twoPassedTests.png "Run a first test")



####Assignment:
 1. Create a test to make sure movies that are not eligible for streaming are indeed not eligible.
 2. Create tests for allowing sellers to create products that are Bangazon Prime.
 3. Add test to test that a product of the type holiday movie is eligible for streaming by Bangazon Prime customers from October to   January. User must also have a Bangazon Prime Membership.
 4. Create a test that tests that users with Bangazon Prime are offered Bangazon Prime at a discount on Black Friday.
 5. Create a test that returns a list containing products featured in "Deal of the Day". All products must be Bangazon Prime eligible. list containing products featured in "Deal of the Day". All products must be Bangazon Prime eligible. 
   







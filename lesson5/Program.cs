// Objects and Classes
using System;

// namespace lesson5
// {
//     public class Student
//     {
//         string firstName;
//         string lastName;
//         string courseFocus;

//         // Default constructor
//         public Student()
//         {
//             firstName = "";
//             lastName = "";
//             courseFocus = "";
//         }

//         // Parameterized constructor - constructor overloading
//         public Student(string first, string last, string focus)
//         {
//             firstName = first;
//             lastName = last;
//             courseFocus = focus;

//             Console.WriteLine(firstName + " " + lastName + " is studying to be a " + courseFocus + " Master!");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Student student1 = new Student();
//             Student student2 = new Student("Jason", "Walker", "C#");
//         }
//     }
// }
// Good Practice
// It's good practice to set sensible default values for the variables. Doing this, you won't unintentionally use a variable with a null value, which can cause unforeseen problems. Update the Student constructor to set the course focus, first name, and last name to an empty string. Also remove the print statement, as shown below:
// ...

// public class Student
// {
//     string courseFocus;
//     string firstName;
//     string lastName;

//     // constructor
//     public Student()
//     {
//         firstName = "";
//         lastName = "";
//         courseFocus = "";
//     }
// }

// ...

// Classes
// using System;

// namespace myApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             {
//                 string firstName = "Andrew";
//                 string lastName = "Coder";
//                 string courseFocus = "C#";
//                 Console.WriteLine(firstName + " " + lastName + " is studying " + courseFocus);
//             }
//             {
//                 string firstName = "Anders";
//                 string lastName = "Hejlsberg";
//                 string courseFocus = "C#";
//                 Console.WriteLine(firstName + " " + lastName + " is studying " + courseFocus);
//             }
//         }

//     }
// }

// Constructor Overloading
// You are making progress! Currently, you have an object named student1 within the Main method, which has no name and no course focus yet, as shown below:
// using System;

// namespace lesson5
// {
//     public class Student
//     {
//         string firstName;
//         string lastName;
//         string courseFocus;

//         public Student()
//         {
//             firstName = "";
//             lastName = "";
//             courseFocus = "";
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Student student1 = new Student();
//         }
//     }
// }


// Matching Variables and Parameters
// What happens if the names of the constructor parameters and the class variables are the same? Well, C# wouldn't know to which variable you're referring. So, how do you fix this if you want to use the same variable names? The answer is to use the this keyword. By using this. prepended to the variable name, you can tell C# that you are referring to the class variable rather than the parameter variable. Below is how this would look if the parameters had the same name as the class variables:

// Do not change your code! This is just an example.
//...
// public class Student
// {
//     string courseFocus;
//     string firstName;
//     string lastName;

//     // Default constructor
//     public Student()
//     {
//         firstName = "";
//         lastName = "";
//         courseFocus = "";
//     }

//     // Constructor params w/same name as class properties
//     public Student(string firstName, string lastName, string courseFocus)
//     {
//         // use "this." to distinguish between the class properties
//         // and the constructor parameters
//         this.firstName = firstName;
//         this.lastName = lastName;
//         this.courseFocus = courseFocus;
//     }
// }
//...


// Properties
// Properties allow classes to expose getting and setting values in a public way. While this happens, the implementation of the code is hidden. A property includes fields. Typically, these fields are meant to be private or protected in scope to restrict access to them. Properties are meant to be public, and they typically correspond to a protected member variable (field) or a calculated value. Using properties, you can control access to the underlying, protected fields. Properties have accessors that read, write, and compute values. You can access a property using the same syntax as accessing a field. You can use getters to get values and setters to set values. These are called accessors.


// Accessors
// When creating a property within a class, a property's accessor contains the executable statements that help in getting (reading or computing) or setting (writing) the value. The accessor declarations can include a get accessor, a set accessor, or both.
namespace myApp
{
    class Student
    {
        string firstName;
        string lastName;
        string courseFocus;

        // Declare a FirstName property of type string
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        // Declare a LastName property of type string
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        // Declare a CourseFocus property of type string
        public string CourseFocus
        {
            get
            {
                return courseFocus;
            }
            set
            {
                courseFocus = value;
            }
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " has the Course Focus of " + courseFocus;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            // First lesson 
            // Student s = new Student();
            // s.CourseFocus = "C#";
            // s.FirstName = "John";
            // s.LastName = "Slaw";
            // Console.WriteLine("Student info: {0}", s);

            // try my self
            // Walkthrough
            // You now have a functional Student class! You can read and update the variables for each student. Try to use this class to do some fun things. Below is a walkthrough that will show you how to create new students based on the code you have previously written. Nice work!

            // Try It!
            // Try to accomplish the following before reading the walkthrough. If you get stuck, the walkthrough will help! Create three student objects using the default constructor. Then, use the setter methods to set the names and course focus for all three students. Feel free to create your own student names and focuses. Finally, use the getter methods to print out all of the information for each student.

            // instantiate three student objects
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            // set the information for student 1
            student1.FirstName = "Jason";
            student1.LastName = "Walker";
            student1.CourseFocus = "C#, JS, SQL";

            // set the information for student 2
            student2.FirstName = "Jason";
            student2.LastName = "Walker";
            student2.CourseFocus = "React, JS, SQL";

            // set the information for student 3
            student3.FirstName = "Jason";
            student3.LastName = "Walker";
            student3.CourseFocus = "NodeJS, Vanilla JS, SQL";

            // print information for each student
            Console.WriteLine(student1.FirstName + " " + student1.LastName + " " + "is studying to be a good developer using " + student1.CourseFocus);

            Console.WriteLine(student2.FirstName + " " + student2.LastName + " " + "is studying to be a good developer using " + student2.CourseFocus);

            Console.WriteLine(student3.FirstName + " " + student3.LastName + " " + "is studying to be a good developer using " + student3.CourseFocus);


        }

    }
}
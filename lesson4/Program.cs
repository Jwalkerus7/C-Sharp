// Access-Specifier Return-Type Method-Name(Parameter-List)
// {
//     Method Body
// }


// Defining Methods and Method example
// using System;

// namespace lesson4
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//             Welcome();
//             HeyYall();
//         }

//         public static void Welcome()
//         {
//             Console.WriteLine("Welcome to Earth!");
//         }

//         public static void HeyYall()
//         {
//             Console.WriteLine("SUP!");
//         }
//     }
// }


// Parameters
// using System;

// namespace lesson4
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             GreetPerson("Emilia");
//             GreetPerson("Thomas");
//             GreetPerson("Gail");
//             GreetPerson("Abraham");
//         }

//         public static void GreetPerson(string personName)
//         {
//             Console.WriteLine("Hello " + personName);
//         }
//     }
// }

// Returning Different Types
// Method of Type Bool
// using System;

// namespace lesson4
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine(IsEven(2));
//         }

//         public static bool IsEven(int number)
//         {

//             bool result;

//             // if the number is even, set variable to true
//             if(number % 2 == 0)
//             {
//                 result = true;
//             }
//             // otherwise, set variable to false
//             else
//             {
//                 result = false;
//             }

//             // return the variable
//             return result;
//         }
//     }
// }


// Method of Type Int
// using System;

// namespace lesson4
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int num1 = 16;
//             int num2 = 30;

//             // store the returned value of the "add" method
//             int sum = Add(num1, num2);
//             Console.WriteLine(sum);
//         }

//         // add method returns an integer
//         public static int Add(int number1, int number2)
//         {
//             return(number1 + number2);
//         }
//     }
// }


// Methods Activity
// In the StudentCode class, add a public static method named GreetMe:

// It should have one string parameter named name.
// It should return a string value. That value should be "Hello, " plus the value of the name parameter.
// For instance, if the name were Adam, the result would be "Hello, Adam".
// using System;
// namespace Exercise {
//     public class StudentCode {
//         public static string GreetMe(string name) {
//             return "Hello, " + name;
//         }
//     }
// }


// In the StudentCode class, add a public method named GetAverage:
// It should have one parameter named numbers that is an array of doubles.
// It should return a double, whose value will be the average of all of the values in the numbers array.
// TIP! Never divide by zero! For this exercise, return the value 0.0 if a division by zero will occur.
// using System;
// namespace Exercise {
//     public class StudentCode {
//         public double GetAverage(double[] numbers) {
//             if(numbers.Length == 0) {
//                 return 0.0;
//             }
//             double sum = 0;
//             for(int idx = 0; idx < numbers.Length; idx++) {
//                 sum += numbers[idx];
//             }
//             return sum / numbers.Length;
//         }
//     }
// }
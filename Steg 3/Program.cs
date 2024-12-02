// static void Square()
// {
//     while (1 == 1)
//     {
//         Console.Clear();
//         Console.WriteLine("write a number:");
//         int number = 0;
//         string pnum = Console.ReadLine();
//         bool success = int.TryParse(pnum, out number);

//         if (success == false)
//         {
//             Console.WriteLine("write a number plz.");
//             Console.ReadLine();
//         }
//         else
//         {
//             int x = number * number;
//             Console.WriteLine($"your number squared is {x}");
//             Console.ReadLine();
//         }
//     }
// }

// Square();

// static void Multi()
// {
//     while (1 == 1)
//     {
//         Console.Clear();
//         Console.WriteLine("write an integer between 1 and 100:");
//         int number1 = 0;
//         string num1 = Console.ReadLine();
//         bool success1 = int.TryParse(num1, out number1);
//         if (success1 == false)
//         {
//             Console.WriteLine("write a number plz.");
//             Console.ReadKey();
//         }
//         else if (number1 > 100 || number1 < 1)
//         {
//             Console.WriteLine("error. try again.");
//             Console.ReadKey();
//         }
//         else
//         {
//             Console.Clear();
//             Console.WriteLine("write another integer between 1 and 100:");
//             int number2 = 0;
//             while (number2 == 0)
//             {
//                 string num2 = Console.ReadLine();
//                 bool success2 = int.TryParse(num2, out number2);
//                 if (success1 == false)
//                 {
//                     Console.WriteLine("write a number plz.");
//                     Console.ReadKey();
//                     number2 = 0;
//                 }
//                 else if (number1 > 100 || number1 < 1)
//                 {
//                     Console.WriteLine("error. try again.");
//                     Console.ReadKey();
//                     number2 = 0;
//                 }
//                 else
//                 {
//                     Console.Clear();
//                     int x = number1 * number2;
//                     Console.WriteLine($"Your two numbers multiplied with eachother gives the product {x}.");
//                     Console.ReadKey();
//                 }
//             }
//         }

//     }
// }

// Multi();

// static void RightTriangleArea()
// {
//     while (1 == 1)
//     {
//         Console.Clear();
//         Console.WriteLine("write a number between 0 and 100 that will be the hieght of your triangel in meters:");
//         float number1 = 0;
//         string num1 = Console.ReadLine();
//         bool success1 = float.TryParse(num1, out number1);
//         if (success1 == false)
//         {
//             Console.WriteLine("write a number plz.");
//             Console.ReadKey();
//         }
//         else if (number1 > 100 || number1 < 1)
//         {
//             Console.WriteLine("error. try again.");
//             Console.ReadKey();
//         }
//         else
//         {
//             Console.Clear();
//             Console.WriteLine("write another  number between 0 and 100 for the width of the base for the triangel in meters:");
//             float number2 = 0;
//             while (number2 == 0)
//             {
//                 string num2 = Console.ReadLine();
//                 bool success2 = float.TryParse(num2, out number2);
//                 if (success1 == false)
//                 {
//                     Console.WriteLine("write a number plz.");
//                     Console.ReadKey();
//                     number2 = 0;
//                 }
//                 else if (number1 > 100 || number1 < 1)
//                 {
//                     Console.WriteLine("error. try again.");
//                     Console.ReadKey();
//                     number2 = 0;
//                 }
//                 else
//                 {
//                     Console.Clear();
//                     float x = number1 * number2;
//                     float s = x/2;
//                     Console.WriteLine($"the area of the tringel is {s} m^3.");
//                     Console.ReadKey();
//                 }
//             }
//         }

//     }
// }

// RightTriangleArea();

static float Square(float a)
{
    float result = a*a;
    return result;
}
Console.WriteLine("Write a number under 100");
string num = Console.ReadLine();
float number = 0;
bool success = float.TryParse(num, out number);
float produkt = Square(number);
Console.WriteLine($"{produkt}");
Console.ReadLine();


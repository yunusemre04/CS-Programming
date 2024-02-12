// using System.Security.Cryptography;

// var coursname = "C# programming language with .NET";

//         Console.WriteLine(coursname.Length);
//         Console.WriteLine(coursname.ToLower());
//         Console.WriteLine(coursname.StartsWith('.'));
//         Console.WriteLine(coursname.Split(" ") [0]);
//         Console.WriteLine(coursname.IndexOf("C#"));
//         Console.WriteLine(coursname.Contains("C"));
//         Console.WriteLine(coursname.Replace("language","lessons"));

//        var dt=DateTime.Now;
//        Console.WriteLine(dt);
//        var dt2=new DateTime(2000,7,30);
//        var age=dt-dt2;
//        Console.WriteLine(age.TotalDays);
//        Console.WriteLine(age.TotalNanoseconds);

//              ********************************NEW  PROGRAM**********************************

// string [] students= new string[3];
// int [] grades= new int[3];

// for(int i=0; i < 3;i++){
//    Console.Write($"please enter {i+1}. student name : ");
//    string? temp= Console.ReadLine();
//    students[i]=temp;
// }

// for(int i=0; i < 3;i++){
//    Console.Write($"please enter {i+1}. student grade : ");
//    grades[i]= Convert.ToInt32(Console.ReadLine());
// }

// for (int i=0;i<3;i++){
//   Console.WriteLine($"The grade of {students[i]} is {grades[i]}");
// }

// float total=0;

// foreach (var item in grades)
// {   
//     total+=item;
// }

// float average= total/grades.Length;
// Console.WriteLine(average);
// Console.WriteLine(students.Length);


//              ********************************NEW  PROGRAM**********************************

// string [] students= new string[3];
// decimal [,] grades= new decimal[3,2];

// for (int i = 0; i < 3; i++)
// {
//    Console.Write($"Please enter the {i+1}. student name : ");
//    students[i]=Console.ReadLine();
// }

// for (int i = 0; i < 3; i++)
// {
//    for (int j = 0; j < 2; j++)
//    {
//       Console.Write($"please enter the {j+1}. grade of {students[i]} : ");
//       grades[i,j]=Convert.ToDecimal(Console.ReadLine());
//    }
// }

// for (int i = 0; i < 3; i++)
// {
//    for (int j = 0; j < 2; j++)
//    {
//       Console.WriteLine($"{j+1}. grade of {students[i]} = {grades[i,j]}");
//    }
// }
// All of projects made by Yunus Emre Acar

//              ********************************NEW  PROGRAM**********************************

//int? a=null;
// int? a=50;
// int b=20;
// var result=(a ?? 0)+b;
// Console.WriteLine(result);
// Console.Write("enter a number : ");
// decimal c=decimal.Parse(Console.ReadLine());
// Console.WriteLine(c+a-b);

//              ********************************NEW  PROGRAM**********************************

// Console.Write("Enter the age information : ");
// int age=int.Parse(Console.ReadLine());
// string status= age>=18 ? "vote usable" : "vote not usable";
// Console.WriteLine(status);

// Console.Write("Enter the a number : ");
// decimal number=decimal.Parse(Console.ReadLine());
// string number_status= number<0 ? "the number is negative" : number==0 ?  "number is zero": "the number is positive";
// Console.WriteLine(number_status);

// Console.Write("Enter the a number : ");
// int number2=int.Parse(Console.ReadLine());
// string controle= number2 %2==0 ? "number an even number": "number an odd number";
// Console.WriteLine(controle);

//  var rand= new Random();
//  int number3= rand.Next(0,600);
//  Console.WriteLine(number3);

//              ********************************NEW  PROGRAM**********************************

// Console.WriteLine("Please select an operation one of sum , subtraction , multiplication, divide");
// string? operation =Console.ReadLine();
// Console.WriteLine("Please enter two number");
// decimal a=decimal.Parse(Console.ReadLine());
// decimal b=decimal.Parse(Console.ReadLine());
// if(operation=="sum"){
//     Console.WriteLine(a+b);
// }

// else if(operation=="subtraction"){
//     Console.WriteLine(a-b);
// }

// else if(operation=="multiplication"){
//     Console.WriteLine(a*b);
// }

// else if(operation=="divide"){
//     Console.WriteLine(a/b);
// }
// else{
//     Console.WriteLine("You entered a not allowed command");
// }

//              ********************************NEW  PROGRAM**********************************

// var number= new Random();
//  int a= number.Next(1,13);
// switch(a){
//     case 12:
//     case 1:
//     case 2:
//     Console.WriteLine("Winter");
//     Console.WriteLine(a);
//     break;
//     case 3:
//     case 4:
//     case 5:
//     Console.WriteLine("Spring");
//     Console.WriteLine(a);
//     break;
//     case 6:
//     case 7:
//     case 8:
//     Console.WriteLine("Summer");
//     Console.WriteLine(a);
//     break;
//     case 9:
//     case 10:
//     case 11:
//     Console.WriteLine("Autumn");
//     Console.WriteLine(a);
//     break;
// }
//              ********************************NEW  PROGRAM**********************************

// using System.Collections;

// namespace ConsoleApp5{
//     class Program{
//         public static void Main(string [] args){
//             ArrayList list=new ArrayList() {5,8,"name","85","52.2",96.1};
//             list.Add(-5);
//             string [] names={"kerem","emrah","john"};
//             list.AddRange(names);
//             list.Insert(3,-6);
//             Console.WriteLine(list[3]);

//             foreach (var item in list)
//             {
//                 Console.WriteLine(item);
//             }

 
//         }
//     }
// }

//              ********************************NEW  PROGRAM**********************************

// namespace ConsoleApp5{
//     class Program{

//         public static void Main(){
//         List<string> list= new List<string>{"element1","element2","element3"};
//         List<Product>product= new List<Product>();
//         list.Add("25");
//         product.Add(new Product(){name="samsung",price=850});
//         product.Add(new Product(){name="iphone",price=1000});
//         foreach (var item in product)
//         {
//             Console.WriteLine(item.name);
//         }

//         }
//     }
//     class Product{
//         public string? name { get; set; }
//         public int price { get; set; }
//     }
// }

//              ********************************NEW  PROGRAM**********************************

// namespace ConsoleApp5{
//     class Program{
//            public static void Main(){
//             Dictionary<int,string> cities=new Dictionary<int, string>();

//             cities.Add(54,"sakarya");
//             cities.Add(34,"istanbul");
//             cities.Add(45,"manisa");
           
//            foreach (var item in cities)
//            {
//             Console.WriteLine(item.Key+" "+item.Value);
//            }
//            }
//     }
// }

//              ********************************NEW  PROGRAM**********************************

// namespace ConsoleApp5{
//     class Program{
//         public static void Main(string [] args){
//           try{
//                Console.Write("enter 1st number : ");
//                int number1=int.Parse(Console.ReadLine());
//                Console.Write("enter 2nd number : ");
//                int number2=int.Parse(Console.ReadLine());
//                Console.WriteLine(number1/number2);
//           }
//           catch(FormatException){
//                 Console.WriteLine("You wrote something that not correctly format ");
//           }
//           catch(DivideByZeroException){
//                 Console.WriteLine("A number can't divide zero");
//           }
//           catch(Exception ex){
//             Console.WriteLine("Are you sure you wrote it in the correct format");
//             Console.WriteLine(ex.Message);
//           }
//         }
//     }
// }


//              ********************************NEW  PROGRAM**********************************

// namespace ConsoleApp5
// {
//     class Program{
//         public static void Main(){
//            try{ 
//             Console.Write("Enter a password : ");
//             string? password=Console.ReadLine();
//             password_controle(password);
//             Console.WriteLine("Password is usable");
//            }
//            catch(Exception e){
//             Console.WriteLine(e.Message);
//            }
//         }
        
//             public static void password_controle(string password){
                
//                     if(!password.Any(char.IsDigit)){
//                          throw new Exception ("The password must be contain a number");
//                     }
//                     if(6>password.Length|| 10<password.Length){
//                          throw new Exception ("Password must be beetween 6 and 10");
//                     }
                
            
//         }
//     }
// }
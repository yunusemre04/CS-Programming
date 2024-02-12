//              ********************************NEW  PROGRAM**********************************
// int sum=0;
// for (int i = 1; i <= 100; i++)
// {
//    sum += i;
// }
// Console.WriteLine(sum);
// int[] array={1,3,4,34,41,56,89,42};
// for (int i = 0; i < 8; i++)
// {
//     if (array[i]%3==0)
//     {    
//         Console.Write($"{array[i]} ");
//     }
// }

//              ********************************NEW  PROGRAM**********************************

// using System.Globalization;

// var rand = new Random();
// int number = rand.Next(1,100);
// int guess=0;
// int score = 100;
// int trying=1;
// while(guess!=number){
//   Console.Write("Please enter a number for find a right number : ");
//   guess=int.Parse(Console.ReadLine());
//   if(guess==number){
//     break;
//   }
//   else{
//     score-=10;
//   }
//   if(guess>number){
//     Console.WriteLine("Enter a smaller number");
//   }
//   else{
//     Console.WriteLine("enter a bigger number");
//   }
//   trying++;
// }
// Console.WriteLine($"You were try {trying} times your point is {score}");

//              ********************************NEW  PROGRAM**********************************

// int [] numbers={65,85,21,69,25};
// int sum=0;
// foreach (var item in numbers)
// {
//     sum+=item;
// }
// Console.WriteLine(sum);

//              ********************************NEW  PROGRAM**********************************

// StreamReader sr=File.OpenText("trying.txt");

// for (var i=""; (i=sr.ReadLine()) != null ; )
// {
//     Console.WriteLine(i);
// }

// string r=File.ReadAllText("trying.txt");
// Console.WriteLine(r);


// string [] result=File.ReadAllLines("trying.txt");
// foreach (var item in result)
// {
//     Console.WriteLine(item);
// }

// using (StreamWriter sw = File.CreateText("trying2.txt")){
// sw.WriteLine("Every tale has a hero");
// }

// using (StreamWriter sw = File.AppendText("trying2.txt")){
// sw.WriteLine("But might not end of the tale well");
// }

// using (StreamWriter sw = File.AppendText("trying2.txt")){
// sw.WriteLine("Even so he will everything for become a good end");
// }
// File.WriteAllText("trying2.txt","...\nhello world");

//              ********************************NEW  PROGRAM**********************************

// Directory.CreateDirectory("temp");
// Directory.CreateDirectory("temp/folder1");
// Directory.CreateDirectory("temp/folder2");

// if(Directory.Exists("temp/folder2")){
//     Directory.Delete("temp/folder2");
// }
// else{
//     Console.WriteLine("The location does not contains any folder");
// }
// string path = @"C:\temp";
// Directory.CreateDirectory(path);
// string new_path=@"C:\Users\Yunus Emre\Desktop\dersler\c#\ConsoleApp3\img";
// string last_path=@"C:\Users\Yunus Emre\Desktop\dersler\c#\ConsoleApp3\image\";
// // string [] folders= Directory.GetDirectories(new_path,"*",SearchOption.AllDirectories);
// // foreach (var folder in folders)
// // {
// //     Console.WriteLine(folder);
// // }

// string [] files=Directory.GetFiles(new_path,"*",SearchOption.AllDirectories);
// foreach (var file in files)
// {
//     Console.WriteLine(file);
//     Console.WriteLine(Path.GetExtension(file));
//     Console.WriteLine(Path.GetFileNameWithoutExtension(file));
//     Console.WriteLine(Path.GetFileName(file));

////     string name=Path.GetRandomFileName()+Path.GetExtension(file); 
////     File.Copy(file,$"{last_path}{name}");
//     var info= new FileInfo(file);
//     Console.WriteLine($"{Path.GetFileName(file)} : {info.Length}");
//     File.Copy(file,$"{last_path} {Path.GetFileName(file)}");
    
// }
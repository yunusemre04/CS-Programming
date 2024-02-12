//              ********************************NEW  PROGRAM**********************************

// namespace ConsoleApp4{
//     class Program{
//         static void Main(string [] args){
//             Student student1=new Student();
//             Student student2= new Student();
//             Student student3= new Student();
//             int i=1;
//             Student [] students= {student1,student2,student3};
//             foreach (var student in students)
//             {
//              Console.WriteLine($"Enter {i}th student name");
//              student.name=Console.ReadLine();
//              Console.WriteLine($"Enter {i}th student lastname");
//              student.lastname=Console.ReadLine();
//              Console.WriteLine($"Enter {i}th student department");
//              student.department=Console.ReadLine();
//              Console.WriteLine($"Enter {i}th student age");
//              student.age=int.Parse(Console.ReadLine());
//              i++;
//             }
            
//             foreach (var student in students)
//             {
//              Console.WriteLine(student.WriteInfo());
//             }
//         }
//     }

//     class Student{
//         public string? name { get; set; }
//         public string? lastname{ get; set; }
//         public string? department { get; set; }
//         public int age{get; set;}
//         int i=0;
//         public string WriteInfo(){
//             i++;
//             return $"{i}th student : {this.name} {this.lastname} {this.department} {this.age}";
//         }
//     }
    
// }

//              ********************************NEW  PROGRAM**********************************

// namespace ConsoleApp4{
   
//    class Program{
//         static void Main(string[] args){
//         Ask question1= new Ask() {
//            question="Which one is most popular programming language?",
//            Options= new string [4] {"C#","Pyhton","Java","C++"},
//            Answer = "C#"
//         };
//         Ask question2= new Ask(){
//             question="Which one is not a programming language?",
//             Options=new string [4]{"Java","Pyhton","Html","C++"},
//             Answer="Html"
            
//         };
//         Ask question3= new Ask(){
//             question="Which one is not a web programming language?",
//             Options=new string [4]{"Django","Pyhton","ASP.net","Spring"},
//             Answer="Phyton"
//         };
//         int i=0;
//         Ask [] questions= {question1,question2,question3};
//         foreach (var question in questions)
//         {
//             Console.WriteLine(question.question);
//             foreach (var option in question.Options)
//             {
//                 Console.WriteLine(option);
//             }
            
//             Console.WriteLine("\n");
//             Console.Write("Your answer : ");
//             string? answer=Console.ReadLine();
//             if(answer.ToLower()==question.Answer.ToLower()){
//                 Console.WriteLine("Your answer is true");
//                 i++;
//             }
//             else{
//                 Console.WriteLine("Your answer is not correct");
//             }
//         }
//         Console.WriteLine($"You guessed {i} questions correctly out of 3 question");
//    }
//    }
   
//     class Ask{
//         public string question { get; set; }
//         public string [] Options {get; set;}
//         public string Answer { get; set; }

//     }
// }
// *******************************Same Program with Constructor*******************************

// namespace ConsoleApp4{
   
//    class Program{
//         static void Main(string[] args){
//         Ask question1= new Ask("Which one is most popular programming language?",new string [4] {"C#","Pyhton","Java","C++"},"C#");
//         Ask question2= new Ask("Which one is not a programming language?",new string [4]{"Java","Pyhton","Html","C++"},"Html");
//         Ask question3= new Ask("Which one is not a web programming language?",new string [4]{"Django","Pyhton","ASP.net","Spring"},"Pyhton");
//         int i=0;
//         Ask [] questions= {question1,question2,question3};
//         foreach (var question in questions)
//         {
//             Console.WriteLine(question.getquestion());
//             foreach (var option in question.Options)
//             {
//                 Console.WriteLine(option);
//             }
            
//             Console.WriteLine("\n");
//             Console.Write("Your answer : ");
//             string? answer=Console.ReadLine();
//             if(answer.ToLower()==question.Answer.ToLower()){
//                 Console.WriteLine("Your answer is true");
//                 i++;
//             }
//             else{
//                 Console.WriteLine("Your answer is not correct");
//             }
//         }
//         Console.WriteLine($"You guessed {i} questions correctly out of 3 question");
//    }
//    }
   
//     class Ask{
//         public Ask(){
            
//         }
//         public Ask(string question){
//             this.question=question;
//         }
//         public Ask(string question,string[] Options,string Answer){
//             this.question=question;
//             this.Options=Options;
//             this.Answer=Answer;
//         }
//         private string question;
//         public string getquestion(){
//           return question;
//         }
//         public void setquestion(string value){
//              this.question=value;
//         }
//         public string [] Options {get; set;}
//         public string Answer { get; set; }
//     }
// }

//              ********************************NEW  PROGRAM**********************************

// namespace ConsoleApp4{
//     class Program{
//         public static void Main(string [] args){
//             string example="YOU MUST KEEP GOİNG";
//             Console.WriteLine(Helper.turn_to_lower(example));
//         }
//     }
//     class Helper{
        
//         public static string turn_to_lower(string turn){
//             return  turn.ToLower();
//         }
//     }
// }

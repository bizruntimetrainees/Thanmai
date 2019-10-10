
using System; 
namespace enum_month 
{ 
  
enum month 
{ 
  
    jan, 
    feb, 
    mar, 
    apr, 
    may 
  
}
class Program { 
      
    static void Main(string[] args) 
    { 
          
        Console.WriteLine("The value of jan in month " + 
                          "enum is " + (int)month.jan); 
        Console.WriteLine("The value of feb in month " + 
                          "enum is " + (int)month.feb); 
        Console.WriteLine("The value of mar in month " + 
                          "enum is " + (int)month.mar); 
        Console.WriteLine("The value of apr in month " + 
                          "enum is " + (int)month.apr); 
        Console.WriteLine("The value of may in month " + 
                          "enum is " + (int)month.may); 
    } 
} 
} 
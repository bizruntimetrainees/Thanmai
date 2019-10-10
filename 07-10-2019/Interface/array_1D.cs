using System; 
namespace array_1d { 
      
class Dimenstion { 
      
    // Main Method 
    public static void Main() 
    { 
          
        string[] weekDays; 
  
        weekDays = new string[] {"Sun", "Mon", "Tue", "Wed",  
                                       "Thu", "Fri", "Sat"}; 
  
        foreach(string day in weekDays) 
            Console.Write(day + " "); 
    } 
} 
} 
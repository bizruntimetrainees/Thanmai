
namespace array{ 
	
class Array { 
	
	
	public static void Main() 
	{ 
		
		int[] intArray; 

		intArray = new int[5]; 
		intArray[0] = 10; 
		intArray[1] = 20; 
		intArray[2] = 30; 
		intArray[3] = 40; 
		intArray[4] = 50; 

		// using for loop 
		Console.Write("For loop :"); 
		for (int i = 0; i < intArray.Length; i++) 
			Console.Write(" " + intArray[i]); 

		Console.WriteLine(""); 
		Console.Write("For-each loop :"); 
		
		// using for-each loop 
		foreach(int i in intArray) 
			Console.Write(" " + i); 

		Console.WriteLine(""); 
		Console.Write("while loop :"); 
		
		// using while loop 
		int j = 0; 
		while (j < intArray.Length) { 
			Console.Write(" " + intArray[j]); 
			j++; 
		} 

		Console.WriteLine(""); 
		Console.Write("Do-while loop :"); 
		
		// using do-while loop 
		int k = 0; 
		do
		{ 
			Console.Write(" " + intArray[k]); 
			k++; 
		} while (k < intArray.Length); 
	} 
} 
} 

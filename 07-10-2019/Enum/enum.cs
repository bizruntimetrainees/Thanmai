using System; 

	
class Perimeter { 
	
	public enum shapes 
	{ 
		circle, 
		square 
	} 

	public void peri(int val, shapes s1) 
	{ 
		
		if (s1 == 0) 
		{ 
			
			Console.WriteLine("Circumference of the circle is " + 
												2 * 3.14 * val); 
		} 
		
		else
		{ 

			Console.WriteLine("Perimeter of the square is " + 
													4 * val); 
		} 
	} 
} 

class Program { 
	
	static void Main(string[] args) 
	{ 

		Perimeter a1 = new Perimeter(); 
		a1.peri(3, Perimeter.shapes.circle); 
		a1.peri(4, Perimeter.shapes.square); 

	} 
} 


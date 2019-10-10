
using System; 

interface I1 { 

	void printMethod(); 
} 

interface I2 { 

	void printMethod(); 
} 

class C : I1, I2 { 

	void I1.printMethod() 
	{ 
		Console.WriteLine("I1 printMethod"); 
	} 

	void I2.printMethod() 
	{ 
		Console.WriteLine("I2 printMethod"); 
	} 
} 

class Interface_exp{ 

	static void Main(string[] args) 
	{ 
		I1 i1 = new C(); 
		I2 i2 = new C(); 

		i1.printMethod(); 

		i2.printMethod(); 
	} 
} 

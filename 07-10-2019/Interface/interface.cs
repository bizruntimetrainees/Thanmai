
using System; 


interface Vehicle { 
	
	// all are the abstract methods. 
	void changeGear(int a); 
	void speedUp(int a); 
	void applyBrakes(int a); 
} 

class Bicycle : Vehicle{ 
	
	int speed; 
	int gear; 
	
	
	public void changeGear(int newGear) 
	{ 
		
		gear = newGear; 
	} 
	
	
	public void speedUp(int increment) 
	{ 
		
		speed = speed + increment; 
	} 
	

	public void applyBrakes(int decrement) 
	{ 
		
		speed = speed - decrement; 
	} 
	
	public void printStates() 
	{ 
		Console.WriteLine("speed: " + speed + 
						" gear: " + gear); 
	} 
} 


class Bike : Vehicle { 
	
	int speed; 
	int gear; 
	
	public void changeGear(int newGear) 
	{ 
		
		gear = newGear; 
	} 
	
	public void speedUp(int increment) 
	{ 
		
		speed = speed + increment; 
	} 
	
	public void applyBrakes(int decrement){ 
		
		speed = speed - decrement; 
	} 
	
	public void printStates() 
	{ 
		Console.WriteLine("speed: " + speed + 
						" gear: " + gear); 
	} 
	
} 

class Interface{ 
	
	public static void Main(String []args) 
	{ 
	
		Bicycle bicycle = new Bicycle(); 
		bicycle.changeGear(2); 
		bicycle.speedUp(3); 
		bicycle.applyBrakes(1); 
		
		Console.WriteLine("Bicycle present state :"); 
		bicycle.printStates(); 
		
		Bike bike = new Bike(); 
		bike.changeGear(1); 
		bike.speedUp(4); 
		bike.applyBrakes(3); 
		
		Console.WriteLine("Bike present state :"); 
		bike.printStates(); 
	} 
} 

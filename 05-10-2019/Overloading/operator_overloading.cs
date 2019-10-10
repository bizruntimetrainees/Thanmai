class Length
{
	int feet,inch;
	
	public Length()
	{
	}
	
	public Length(int feet,int inch)
	{
		this.feet = feet;
		this.inch = inch;
	}
	public static Length operator +(Length l1,Length l2)
	{
		Length l3 = new Length();
		l3.feet=l1.feet + l2.feet;
		l3.inch=l1.inch + l2.inch;
		l3.inch=l1.inch + l2.inch;
		
		if(l3.inch >= 12)
		{
			l3.feet++;
			l3.inch -= 12;
			
		}	
		return l3;
		

		
	}
	
	string GetLength()
	{
		return String.Format("Length: {0}' {1}\"",feet,inch);
	}
	
	public staic void Main()
	{
		Length len1 = new Length(2,3);
		Length len2 = new Length(5,8);
		Length len3 = l1+l2;
		
		Console.WriteLine(len1.GetLength());
		Console.WriteLine(len2.GetLength());
		Console.WriteLine("Total"+len3.GetLength());

	}
	
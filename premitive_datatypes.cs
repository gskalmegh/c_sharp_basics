using System;

class Demo
{
 static void Main(string[] args)
	{
		int a;
		float b;
		double d;
		char c;
		string s;
		bool bol;

	   Console.WriteLine("Enter integer a: ");
	   a=Int32.Parse(Console.ReadLine());
	
	   Console.WriteLine("Enter float b: ");
	   b=float.Parse(Console.ReadLine());
	   
	   Console.WriteLine("Enter double d: ");
	   d=double.Parse(Console.ReadLine());
	   

	   
	   Console.WriteLine("Enter char c: ");
	   c=char.Parse(Console.ReadLine());
	   
	   
	   Console.WriteLine("Enter String s: ");
	   s=Console.ReadLine();

	 Console.WriteLine("Enter boolean bol: ");
	 bol=bool.Parse(Console.ReadLine());
	   
		Console.WriteLine("\n===================================");
	   Console.WriteLine("a="+a);
	   Console.WriteLine("b="+b);
	  Console.WriteLine("d="+d);
		Console.WriteLine("c="+c);
		Console.WriteLine("string s="+s);
		Console.WriteLine("bool bol="+bol);
a=(Int32)d;

		String result=""+a+" "+b+" "+c+" "+d;
		Console.WriteLine(result);


	}

}
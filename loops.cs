using System;

class DemoLoop
{
static void Main(string[] args)
{

int a=45;
int b=63;

//while loop
	while(a%b!=0)
	{
		int r=a%b;
		a=b;
		b=r;
	}
Console.WriteLine("gcd="+b);

//do while loop
int count=0;

	do
	{
		Console.WriteLine("count: "+count);

	}while(count>0);



//for loop

for(int i=-10;i<count;i++)
Console.WriteLine("i: "+i);



}

}
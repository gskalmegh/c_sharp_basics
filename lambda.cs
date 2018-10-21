  
using System;  
using System.Collections.Generic;  
using System.Linq;
using System.Collections;



delegate int Sum(int x, int y);
delegate bool IsEven(int x);

delegate bool IsName(string s);
  
public static class demo  
{  
   public static void Main()  
   {  
          
	Sum sum=(x,y)=> x+y+1;
	IsEven iseven=(x)=>x%2==0;
	
	Console.WriteLine("sum 1 2: "+sum(1,2));
	Console.WriteLine("is even 4: "+iseven(4));

//find all ony 'Ram' in following list

	ArrayList al=new ArrayList();
	al.Add("Ram");	al.Add("shyam");	al.Add("Ram");	al.Add("Ganesh");

	
	



        }  
    }  
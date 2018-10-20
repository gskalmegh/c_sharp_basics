using System;
using System.Collections;
using System.Collections.Generic;
class UtilityClasses
{


static void Main(String[] args)
{
//stack

	Stack s = new Stack();
        s.Push("ghs"); s.Push(123); s.Push(244);
        Console.WriteLine("pop: " + s.Pop());
        Console.WriteLine("stack count is: " + s.Count);
       
//Queue
	Queue q=new Queue();
	q.Enqueue('a'); q.Enqueue('b');
	Console.WriteLine("dequeue: "+q.Dequeue()) ;
	
	foreach(object i in q)
		Console.WriteLine(i);
//ArrayList

	ArrayList al=new ArrayList();
	al.Add(4); al.Add(3); al.Add(5);
	al.Sort();
	foreach(object i in al)
		Console.WriteLine(i);
//hashmap

	Dictionary<int, string> dict = new Dictionary<int, string>();
        dict[1] = "ghanshyam";
        dict[2] = "kalmegh";
        Console.WriteLine("dict[1] " + dict[1]);

//hashset
        HashSet <string> hs= new HashSet<string>();
        hs.Add("a");hs.Add("b");hs.Add("a");
        foreach (object i in hs)
            Console.WriteLine(i);


}




}
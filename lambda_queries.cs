using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
	public int roll{get;set;}
	public String name{get;set;}
}

class Demo
{
	static void Main(String[] args)
	{

	List<Student> students=new List<Student>();

	students.Add(new Student{roll=1,name="ram"});
	students.Add(new Student{roll=2,name="Akbar"});
	students.Add(new Student{roll=3,name="Birbal"});
	students.Add(new Student{roll=4,name="Shyam"});

	//print only names of students

	var names=students.Select(x=>x.name);

		foreach(var name in names)
			Console.WriteLine(name);

	//sort students data by name
	
	var s=students.OrderBy(x => x.name);
	foreach(var i in s)
			Console.WriteLine(" "+i.roll+" "+i.name);





	}


}
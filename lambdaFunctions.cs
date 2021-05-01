using System;
					
public class Program
{
	public static void Main()
	{
		//Ways to write a function in functional style
		Func<int, string> func1 = (x) => string.Format("string = {0}", x);
		Func<int,string> func2 = (x) => {
											return string.Format("string = {0}", x);
										}; 
		Console.WriteLine(func1(2));
		Console.WriteLine(func2(2));
	}
}

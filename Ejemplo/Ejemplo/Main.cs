using System;

namespace Ejemplo
{
	class MainClass
	{

		public int suma(){
			int a = 10;
			int b = 30;
			return a+b;
		}

		public static void Main (string[] args)
		{
			MainClass clase = new MainClass();
			int x = clase.suma();
			Console.WriteLine (x);
		}
	}
}

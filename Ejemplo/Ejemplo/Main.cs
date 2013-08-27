using System;

namespace Ejemplo
{
	class MainClass
	{

		public int suma(int a, int b){
			return a+b;
		}

		public static void Main (string[] args)
		{
			MainClass clase = new MainClass();
			int x = clase.suma(11, 55);
			Console.WriteLine (x);
		}
	}
}

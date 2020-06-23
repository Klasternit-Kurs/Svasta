using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svasta
{
	class Program
	{
		//FizzBuzz
		//Korisnik unese broj
		//Krecemo od 1, idemo do broja koji je korisnik naveo
		//Ako je broj deljiv sa 3, stampamo fizz
		//Ako je broj deljiv sa 5, stampamo buzz
		//ako je broj deljiv sa oba, stampamo fizzBuzz
		static void Main(string[] args)
		{
			Console.Write("Unesite broj: ");
			int dokle = int.Parse(Console.ReadLine());


			//Logicko i, AND, &&
			//
			//  A     B         A AND B
			//-------------------------
			//  f  |  f    |      f 
			//  t  |  f    |      f
			//  f  |   t   |      f
			//  t  |   t   |       t

			if (dokle >= 1 && dokle <= 10)
			{
				Console.WriteLine("Izmedju 1 i 10 jeste :) ");
			}

			//Logicko ili, OR, ||
			//
			//  A     B         A OR B
			//-------------------------
			//  f  |  f    |      f 
			//  t  |  f    |      t
			//  f  |   t   |      t
			//  t  |   t   |      t

			if (dokle < 1 || dokle > 10)
			{
				Console.WriteLine("Broj van opsega 1 do 10");
			}

			//Console.ReadKey();

			for(int brojac = 1; brojac <= dokle; brojac++)
			{
				if (brojac % 3 == 0 && brojac % 5 == 0)
				{
					Console.WriteLine($"{brojac} - FizzBuzz");
				} else if (brojac % 5 == 0)
				{
					Console.WriteLine($"{brojac} - Buzz");
				} else if (brojac % 3 == 0)
				{
					Console.WriteLine($"{brojac} - Fizz");
				} else
				{
					Console.WriteLine(brojac);
				}
			}
			Console.ReadKey();
		}
	}
}

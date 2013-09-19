/*
 * Created by SharpDevelop.
 * User: Aula1
 * Date: 19/09/2013
 * Time: 05:28 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica3
{
	class persona
	{
		public static void Main(string[] args)
		{
		    public string nombre;
			public int edad;
			public string email;
		
			Persona p=new Persona();
			
			Console.WriteLine("Dame tu nombre:");
			p.nombre = Console.ReadLine();
			Console.WriteLine("Dame la edad:");
			p.edad = int.Parse(Console.ReadLine());
			Console.WriteLine("Cual es tu email:");
			p.email = Console.ReadLine();
			Console.Clear();
			
			Console.WriteLine("nombre"+p.nombre);
			Console.WriteLine("edad"+p.edad);
			Console.WriteLine("email"+p.email);
			
			Console.ReadKey(true);
		}
	}
}
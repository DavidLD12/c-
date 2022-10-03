/* Crear un triangulo */

using System;

class Triangulo
{
	static void Main()
	{
		int ancho;
		
		do
		{
			Console.WriteLine("Escribe el numero de la altura");
			ancho = Convert.ToInt32(Console.ReadLine());
			
			if ( ancho % 2 == 0) {
				Console.WriteLine("El numero no es impar");
			}

		}
		while ( ancho % 2 == 0 );
		
		int espac;
		int aster = ancho;
		
		for ( int i = ancho ; i >= 1 ; i-- ) {
			espac = (ancho - aster)/2;
			for ( int j = espac ; j >= 1 ; j-- ) {
				Console.Write(" ");
			}
			for ( int j = aster ; j >= 1 ; j--) {
				Console.Write("*");
			}
			aster-=2;
			Console.WriteLine();
		}
	}
}
		

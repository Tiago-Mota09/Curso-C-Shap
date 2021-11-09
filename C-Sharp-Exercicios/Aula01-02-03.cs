//====================================================
//			Padrão C# Puro
//====================================================
// Using System;

// class Program //Aula01
// 	{
// 		static void Main(string[] args){
// 		Console.WriteLine("Olá Mundo!");		
// 	}
// }
//====================================================
//			Padrão .NET
//====================================================
Using System;

namespace Aula02 //padrão .NET
class Program
	{
		static void Main(string[] args){
			Console.WriteLine("Olá Mundo!");
			if (args.GetLength(0)>0){
				Console.Write(args.GetValue(0));
			}
		}
	}
}
//====================================================
//			Variáveis
//====================================================
// using System;

// class aula03{
// 	static void Main(){
// 		byte n1 = 10;      //0 e 255
// 		int num = 0;       //tipo primitivo
// 		char letra = 'c';  //tipo primitivo
// 		float valor = 5.3f //tipo primitivo
// 		string nome = "Tiago"   //tipo referência

// 		var aux = nome;

// 		Console.WriteLine("Valor da variável: " + aux);
// 	}
// }

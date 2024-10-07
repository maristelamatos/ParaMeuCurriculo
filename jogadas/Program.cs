
		Console.WriteLine(" digita jogos voce deseja "); // é usada para imprimir uma linha de texto no console
       int jogadas = int.Parse(Console.ReadLine()); // definir uma função que retorna um inteiro em C# em uma única linha
       	Console.WriteLine(" quantas dezenas voce deseja");// é usada para imprimir uma linha de texto no console
       int dezenas = int.Parse(Console.ReadLine());//definir uma função que retorna um inteiro em C# em uma única linha
       for (int n = 1; n <= jogadas; n ++)//Essa função ImprimirNumeros recebe um inteiro
	
		{
			Console.WriteLine($"\nJogo {n}: ");// é usada para imprimir uma linha de texto no console
			for (int contador = 1;contador <= dezenas;contador ++)// Essa função ImprimirNumeros recebe um inteiro
			{
				Random na = new Random();//pode criar uma função que instancie um novo objeto usando a palavra-chave
				int valores = na.Next(1,60);//definir uma função que retorna um inteiro em C# em uma única linha
				if (contador == dezenas)//verifica se o numero e impar ou par
				{
					Console.Write($"{valores}");//é usada para imprimir uma linha de texto no console
				}
				else//Essa função VerificarNumero recebe um número inteiro e retorna uma string indicando se o número é "Positivo", "Negativo" ou "Zero
				{
				Console.Write($"{valores}-");//é usada para imprimir uma linha de texto no console
				}
			}
          }
	   

        


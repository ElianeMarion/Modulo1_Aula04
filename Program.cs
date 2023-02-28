namespace Aula04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			string opcao;
			do
			{
				//Console.WriteLine("Hello, World!");
				//Tabuada x 1 - 10
				int num, tab;
				Console.WriteLine("Digite um número para exibir a tabuada");
				num = Convert.ToInt32(Console.ReadLine());

				int i = 1; //inicialização =1
				/*while (i <= 10)
				{
					tab = num * i;
					Console.WriteLine(i + " x " + num + " = " + tab);
					i++; //i = i + 2;
				}
				
				//laço contador = variáveis inteiras
				for (i = 10; i >= 1; i--) //inicialização ; condição ;  incremento
				{
					tab = num * i;
					Console.WriteLine(num + " x " + i + " = " + tab);

				}

				/*	do
					{
						tab = num * i;
						Console.WriteLine(i + " x " + num + " = " + tab);
						i++; //i = i + 2;
					} while (i <= 10);


				Console.WriteLine("Digite (s|S|sim) um para exibir outra tabuada ou (n) para sair");
				opcao = Console.ReadLine();


			} while (opcao == "s" || opcao == "S" || opcao == "sim");
			*/
			//Calculo do fatorial
			int fat = 1; // 
			Console.WriteLine("Digite um número para calcular o fatorial: ");
			int num = Convert.ToInt32(Console.ReadLine());
			//inicialização
			int i = 1; // i = num
			while (i <= num) //while(i >= 1)
			{
				fat = i * fat;
				i++; //incremento i-- decremento
			}
			Console.WriteLine(num + "! = " + fat);

			int n1, n2, soma = 0;
			Console.WriteLine("Digite o primeiro número");
			n1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite o segundo número");
			n2 = Convert.ToInt32(Console.ReadLine());

			if (n1 > n2)
			{
				int aux = n1;
				n1 = n2;
				n2 = aux;
			}

			for (i = n1; i <= n2; i++) {
				soma = soma + i; //soma += i;
			}
			Console.WriteLine("Soma: " + soma);
			int contaPar = 0;
			//qtde de pares
			do
			{
				if (n1 % 2 == 0)
					contaPar++;
				n1++;
			} while (n1 <= n2);
			Console.WriteLine("Quantidade de pares: " + contaPar);

			int nota1, nota2, nota3, media;
			Console.WriteLine("Digite a primeira nota");
			nota1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite a segundo nota");
			nota2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite a terceira nota");
			nota3 = Convert.ToInt32(Console.ReadLine());
			media = (nota1 + nota2+ nota3)/3;
			Console.WriteLine("media = ", media);

			soma = 0;
			int nota;
			for(i=1; i<=3; i++)
			{
				Console.WriteLine("Digite a "+ i + " nota");
				nota = Convert.ToInt32(Console.ReadLine());
				soma += nota;
			}
			media = soma / 3;
			Console.WriteLine("media = ", media);
		}
	}
}
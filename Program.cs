using System;
using System.Collections.Generic;

public class Opcoes{
	 public static void Main()
		{
			Console.WriteLine("Digite 1 para PA:\nDigite 2 para PG:\n");
			int opcao = Convert.ToInt32(Console.ReadLine());
			if(opcao==1){
				Console.WriteLine("Digite o primeiro número:\n");
				int a = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Digite a quantidade de termo:\n");
				int n = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Digite a razão:\n");
				int r = Convert.ToInt32(Console.ReadLine());
				int res = Opcoes.PA(a,n,r);
				String s = String.Format("O {0}º termo é {1}.",n,res);
				Console.WriteLine(s);
			}
			else{
				Console.WriteLine("Digite o primeiro número:\n");
				int a1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Digite o primeiro o n-ésimo:\n");
				int an = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Digite o primeiro n-ésimo :\n");
				int r = Convert.ToInt32(Console.ReadLine());
				int res = Opcoes.PG(a1,an,r);
				String s = String.Format("O {0}º termo é {1}.",an,res);
				Console.WriteLine(s);
			}
		}
	static int PA(int a,int n,int r)
        {
            int res = a + (n-1)*r;
			return res;
        }
	static int PG(int a,int n,int q)
		{
			int x = Convert.ToInt32(Math.Pow(q, n));
			int res = a*(x-1)/(q-1);
			return res;
		}
}
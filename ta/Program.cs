/*
 * Created by SharpDevelop.
 * User: safil
 * Date: 9/22/2019
 * Time: 6:38 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ta
{
	class Program
	{

		public static void Main(string[] args)
		{
			int n=Convert.ToInt32(Console.ReadLine());
			
			int[,] pascal=new int[n,n];
			pascal[0,0]=1;
			for (int i=1;i<n;i++)
			{
				for (int j=0;j<=i;j++)
				{
					
					if ((j==0) || (j==i)) { pascal[i,j]=1; continue; }
					else 
						pascal[i,j]=pascal[i-1,j-1]+pascal[i-1,j];
					
				}
			
				
			}
			
			for (int i=0;i<n;i++)
			{
			//	Console.Write("|");
				for (int j=0;j<=n;j++) Console.Write("--");
				Console.WriteLine("");
				//Console.Write("Row N`"+(i+1)+"|");
				            
				for (int j=-1;j<i;j++)
				{
					
					Console.Write( "|{0}|",pascal[i,j+1]);
				}
				Console.WriteLine("");
			}
			
			Console.ReadKey(true);
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Enumerable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//利用Enumerable.Range() 建立一個序列, 值介於 [1, 10]
			//請利用迴圈列出每一個項目值,確認無誤

			
			int[] items=Enumerable.Range(1, 10).ToArray();
			foreach(int i in items)
			{
				Console.WriteLine(i);
			}

			//用Enumerable.Range() 建立一個序列, 值介於 [10, 15]
			//請利用迴圈列出每一個項目值,確認無誤

			int[] items2 = Enumerable.Range(10, 6).ToArray();
			foreach (int i in items2)
			{
				Console.WriteLine(i);
			}
		}
	}
}

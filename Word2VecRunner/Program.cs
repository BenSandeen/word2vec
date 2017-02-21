using System;
using Word2Vec;

namespace Word2VecRunner
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			var builder = Word2Vec.Net.Word2VecBuilder.Create();
		}
	}
}

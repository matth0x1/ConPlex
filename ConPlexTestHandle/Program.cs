using System;
using ConPlex;

namespace ConPlexTestHandle
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("ConPlex TestHandle");
			Console.Write ("\n" + new string ('_', Console.BufferWidth));


			ConPlex.ConPlex.Consoles ["Debug 1"].Write ("Hollow World.");
			ConPlex.ConPlex.Consoles ["Debug 2"].Write ("Hollow World.");
			ConPlex.ConPlex.Consoles ["Debug 3"].Write ("Hollow World.");
			ConPlex.ConPlex.Consoles ["Debug 1"].Write ("Hollow World.");
			ConPlex.ConPlex.Consoles ["Debug 3"].Write ("Hollow World.");

			Console.ReadLine();
		}
	}
}

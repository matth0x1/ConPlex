using System;
using System.Collections.Generic;

namespace ConPlex
{
	public static class ConPlex
	{
		public static ConPlexConsoleCollection Consoles = new ConPlexConsoleCollection ();
	}

	public class ConPlexConsoleCollection
	{
		private readonly object ConsolesLocker = new object();
		private Dictionary<string, ConPlexConsole> Consoles = new Dictionary<string, ConPlexConsole>(StringComparer.OrdinalIgnoreCase);

		public ConPlexConsole this [string consoleName]
		{
			get
			{
				ConPlexConsole console;

				if(!Consoles.TryGetValue (consoleName, out console))
					lock (ConsolesLocker) 
						if (!Consoles.TryGetValue (consoleName, out console))
						{
							console = new ConPlexConsole (consoleName);
							Consoles.Add(consoleName, console);
						}

				return console;
			}
		}
	}

	public class ConPlexConsole
	{
		public ConPlexConsole (string name)
		{
			Name = name;
		}

		public string Name {
			get;
			private set;
		}

		public void Write(string value )
		{
			Console.WriteLine (Name + ": " + value);
		}
	}
}


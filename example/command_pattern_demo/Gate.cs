using System;

namespace command_pattern_demo
{
	public class Gate
	{

		private bool open = false;

		public void Open()
		{
			Console.Out.WriteLine ("Openning Gate ...");
			Console.Out.WriteLine ("Gate Openned!");
			Console.Out.WriteLine ("===================");
			this.open = true;
		}

		public void Close()
		{
			Console.Out.WriteLine ("Closing Gate ...");
			Console.Out.WriteLine ("Gate Closed!");
			Console.Out.WriteLine ("===================");
			this.open = false;
		}

		public bool IsClosed()
		{
			return !this.open;
		}
	}
}


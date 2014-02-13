using System;

namespace command_pattern_demo
{
	public class OpenGate: IOperation
	{
		private Gate gate;

		public OpenGate (Gate gate)
		{
			this.gate = gate;
		}

		public void Execute ()
		{
			Console.Out.WriteLine ("Trying open gate ...");
			if (gate.IsClosed())
				this.gate.Open ();
			else
				Console.Out.WriteLine ("Gate Already Opened!");
		}
	}
}


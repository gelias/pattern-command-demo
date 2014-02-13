using System;

namespace command_pattern_demo
{
	public class CloseGate:IOperation
	{
		private Gate gate;
		public CloseGate (Gate gate)
		{
			this.gate = gate;
		}

		public void Execute()
		{
			Console.Out.WriteLine ("Trying close gate ...");
			if (!gate.IsClosed ())
				gate.Close ();
			else
				Console.Out.WriteLine ("Gate already closed!");
		}
	}
}


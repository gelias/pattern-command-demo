using System;
using System.Collections.Generic;

namespace command_pattern_demo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//FirstWay();
			//SecondWay ();
			ThirdWay ();

		}

		private static void ThirdWay()
		{
			Gate gate = new Gate ();
			EletronicGate eletronicGate = new EletronicGate (gate);
			eletronicGate.Up ();
			eletronicGate.Down ();
			eletronicGate.Down ();
		}

		private static void SecondWay()
		{
			Gate gate = new Gate ();

			// Concrete Operations
			OpenGate open = new OpenGate (gate);
			CloseGate close = new CloseGate (gate);
			CloseGate alreadyClosed = new CloseGate (gate);

			// Invoker
			EletronicGate eletronicGate = new EletronicGate ();
			eletronicGate.DoOperation (open);
			eletronicGate.DoOperation (close);
			eletronicGate.DoOperation (alreadyClosed);
		}

		private static void FirstWay ()
		{
			Gate gate = new Gate ();

			// Concrete Operations

			OpenGate open = new OpenGate (gate);
			CloseGate close = new CloseGate (gate);
			CloseGate alreadyClosed = new CloseGate (gate);

			IList<IOperation> operations = new List<IOperation> ();
			operations.Add (open);
			operations.Add (close);
			operations.Add (alreadyClosed);

			// Invoker
			EletronicGate eletronicGate = new EletronicGate (operations);
			eletronicGate.BulkOperations ();
		}
	}
}

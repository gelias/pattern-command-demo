using System;
using System.Collections.Generic;

namespace command_pattern_demo
{
	public class EletronicGate
	{
		private ICollection<IOperation> operations;
		private Gate gate;

		public EletronicGate() { }

		public EletronicGate(Gate gate) 
		{
			this.gate = gate;
		}

		public EletronicGate (IList<IOperation> operations)
		{
			this.operations = operations;
		}

		#region Bulk
		public void BulkOperations()
		{
			foreach (IOperation operation in operations) 
			{
				DoOperation (operation);
			}
		}
		#endregion

		#region Unity
		public void DoOperation(IOperation operation)
		{
			operation.Execute ();
		}
		#endregion

		#region Abstract operation
		public void Up()
		{
			new OpenGate (gate).Execute ();
		}

		public void Down()
		{
			new CloseGate (gate).Execute ();
		}
		#endregion
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.Sheepo.Data
{
	public class Split
	{
		public Split(SplitTypes type, int data)
		{
			Type = type;
			Data = data;
		}

		public SplitTypes Type { get; set; }
		public int Data { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdz.cAlgo.GridTrap.Schemas
{
	internal class GridTrapLine
	{
		public GridTrapLine() : base()
		{
			ID = Guid.NewGuid();
		}
		internal Guid ID { get; private set; }
		internal double Price { get; set; }
		internal int Index { get; set; }
		internal Guid TransactionID { get; set; }
	}
}

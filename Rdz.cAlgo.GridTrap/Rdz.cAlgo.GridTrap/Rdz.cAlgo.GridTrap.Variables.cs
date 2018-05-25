using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cAlgo.API;
using cAlgo.API.Indicators;
using cAlgo.API.Internals;
using cAlgo.Indicators;
using Rdz.cAlgo.Library;

namespace Rdz.cAlgo.GridTrap
{
	public partial class GridTrapRobot
	{
		private List<Schemas.GridTrapTransaction> __Transactions = null;
		internal List<Schemas.GridTrapTransaction> Transactions
		{
			get
			{
				if (__Transactions == null) { __Transactions = new List<Schemas.GridTrapTransaction>(); }
				return __Transactions;
			}
		}

		private List<Schemas.GridTrapLine> __Lines = null;
		internal List<Schemas.GridTrapLine> Lines
		{
			get
			{
				if (__Lines == null) { __Lines = new List<Schemas.GridTrapLine>(); }
				return __Lines;
			}
		}
	}
}

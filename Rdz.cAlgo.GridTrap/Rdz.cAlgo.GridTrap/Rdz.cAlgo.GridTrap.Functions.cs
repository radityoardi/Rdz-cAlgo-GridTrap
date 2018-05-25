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
		bool IsActive
		{
			get
			{
				return (Positions.Count == 0 && PendingOrders.Count == 0); //to set IsActive whenever there's no trading made
																		   //this criteria can be changed in future.
			}
		}

		void Initialize()
		{

		}
	}
}

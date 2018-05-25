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
		[Parameter("Gap from Price (Points)", DefaultValue = 20)]
		public int GapPointsFromPrice { get; set; }
		[Parameter("Interval (Points)", DefaultValue = 50)]
		public int IntervalPointsEach { get; set; }
	}
}

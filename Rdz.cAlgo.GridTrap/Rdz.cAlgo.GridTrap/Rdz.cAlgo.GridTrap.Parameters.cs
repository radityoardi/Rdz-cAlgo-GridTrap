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
		[Parameter(DefaultValue = 0.0)]
		public double Parameter { get; set; }
	}
}

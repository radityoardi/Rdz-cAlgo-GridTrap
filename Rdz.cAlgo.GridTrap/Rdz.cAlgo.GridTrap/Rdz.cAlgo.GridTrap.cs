using System;
using System.Linq;
using cAlgo.API;
using cAlgo.API.Indicators;
using cAlgo.API.Internals;
using cAlgo.Indicators;
using Rdz.cAlgo.Library;

namespace Rdz.cAlgo.GridTrap
{
    [Robot(TimeZone = TimeZones.UTC, AccessRights = AccessRights.FullAccess)]
    public partial class GridTrapRobot : RdzRobot
    {

        protected override void OnStart()
        {
            // Put your initialization logic here
        }

        protected override void OnTick()
        {
			Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
			// Put your core logic here
			Print("Date time now is: {0} ({1})", DateTime.Now.ToString("dd MMM yyyy HH:mm:ss"), version.ToString());
        }

        protected override void OnStop()
        {
            // Put your deinitialization logic here
        }
    }
}

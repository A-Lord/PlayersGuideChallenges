using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersGuideChallenges.The_Old_Robot
{
    public class OnCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            robot.IsPowered = true; 
        }
    }
}

using PearlCalculatorLib.PearlCalculationLib.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlCalculatorLib.PearlCalculationLib.Entity
{
    public class PearlEntity1205 : PearlEntity
    {
        public override void Tick()
        {
            Position += Motion;
            Motion *= 0.99F;
            Motion.Y -= 0.03;
        }
    }
}

using PearlCalculatorLib.PearlCalculationLib.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlCalculatorLib.PearlCalculationLib.Entity
{
    public class PearlEntity1212 : PearlEntity
    {
        public override void Tick()
        {
            Motion.Y -= 0.03;
            Motion *= 0.99F;
            Position += Motion;
        }
    }
}

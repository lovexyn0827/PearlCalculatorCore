﻿using PearlCalculatorLib.PearlCalculationLib.MathLib;
using PearlCalculatorLib.PearlCalculationLib.World;
using PearlCalculatorLib.PearlCalculationLib.AABB;

namespace RTPearlCalculatorLib.Blocks
{
    public class PistonBaseBlock : Block
    {
        public static readonly Space3D BlockSize = new Space3D(1, 0.75, 1);

        public override Space3D Size => BlockSize;

        public PistonBaseBlock(Space3D pos) : base(pos)
        {

        }
    }
}

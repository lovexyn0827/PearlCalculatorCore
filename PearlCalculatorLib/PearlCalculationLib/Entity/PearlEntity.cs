using PearlCalculatorLib.PearlCalculationLib.World;
using System;

namespace PearlCalculatorLib.PearlCalculationLib.Entity
{
    [Serializable]
    public abstract class PearlEntity : Entity, IDeepCloneable<PearlEntity>
    {
        public override Space3D Size => new Space3D(0.25 , 0.25 , 0.25);
        
        public PearlEntity(Space3D momemtum , Space3D position)
        {
            Motion = momemtum;
            Position = position;
        }

        public PearlEntity(PearlEntity pearl) : this(pearl.Motion , pearl.Position) { }

        public PearlEntity()
        {

        }

        public static PearlEntity instantatePearl(BehaviorVersion ver)
        {
            switch (ver)
            {
                case BehaviorVersion.LEGACY:
                    return new LegacyPearlEntity();
                case BehaviorVersion.POST_1205:
                    return new PearlEntity1205();
                case BehaviorVersion.POST_1212:
                    return new PearlEntity1212();
                default:
                    throw new ArgumentException();
            }
        }

        public static PearlEntity instantatePearl(BehaviorVersion ver, Space3D motion, Space3D pos)
        {
            PearlEntity pearl = instantatePearl(ver);
            pearl.Motion = motion;
            pearl.Position = pos;
            return pearl;
        }

        public static PearlEntity instantatePearl(BehaviorVersion ver, PearlEntity src)
        {
            PearlEntity pearl = instantatePearl(ver);
            pearl.Motion = src.Motion;
            pearl.Position = src.Position;
            return pearl;
        }

        public PearlEntity DeepClone()
        {
            PearlEntity pearl;
            if (this is PearlEntity1205)
            {
                pearl = new PearlEntity1205();
            } else if (this is PearlEntity1212)
            {
                pearl = new PearlEntity1212();
            } else
            {
                pearl = new LegacyPearlEntity();
            }

            pearl.Motion = Motion;
            pearl.Position = Position;
            return pearl;
        }

        object IDeepCloneable.DeepClone() => DeepClone();

        public enum BehaviorVersion
        {
            LEGACY, 
            POST_1205, 
            POST_1212
        }
    }
}

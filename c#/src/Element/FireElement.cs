using System;

namespace Lncodes.DesignPattern.Bridge
{
    public sealed class FireElement : Element
    {
        protected override Type WeekElementType { get; } = typeof(WaterElement);
    }
}

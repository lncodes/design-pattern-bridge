using System;

namespace Lncodes.DesignPattern.Bridge
{
    public sealed class WaterElement : Element
    {
        protected override Type WeekElementType { get; } = typeof(WindElement);
    }
}

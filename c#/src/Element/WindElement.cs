using System;

namespace Lncodes.DesignPattern.Bridge
{
    public sealed class WindElement : Element
    {
        protected override Type WeekElementType { get; } = typeof(FireElement);
    }
}

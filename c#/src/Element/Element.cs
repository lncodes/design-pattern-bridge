using System;

namespace Lncodes.DesignPattern.Bridge
{
    public abstract class Element
    {
        protected abstract Type WeekElementType { get; }

        public bool IsWeekElement(Element element)  =>
            WeekElementType.Equals(element.GetType());
    }
}
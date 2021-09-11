namespace Lncodes.DesignPattern.Bridge
{
    public abstract class Enemy
    {
        public Element Element { get; }

        public abstract uint Health { get; protected set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="element"></param>
        protected Enemy(Element element) =>
            Element = element;

        /// <summary>
        /// Method to take damage
        /// </summary>
        /// <param name="element"></param>
        /// <param name="damage"></param>
        public abstract void TakeDamage(Element element, uint damage);
    }
}

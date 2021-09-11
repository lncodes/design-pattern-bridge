namespace Lncodes.DesignPattern.Bridge
{
    public sealed class OrcEnemy : Enemy
    {
        public override uint Health { get; protected set; } = 100;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="element"></param>
        public OrcEnemy(Element element) : base(element) { }

        /// <inheritdoc cref="Enemy.TakeDamage(Element, uint)"/>
        public override void TakeDamage(Element element, uint damage)
        {
            if (Element.IsWeekElement(element))
                Health -= damage + 3;
            else
                Health -= damage;
        }
    }
}
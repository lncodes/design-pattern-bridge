namespace Lncodes.DesignPattern.Bridge
{
    public sealed class GoblinEnemy : Enemy
    {
        public override uint Health { get; protected set; } = 50;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="element"></param>
        public GoblinEnemy(Element element) : base(element) { }

        /// <inheritdoc cref="Enemy.TakeDamage(Element, uint)"/>
        public override void TakeDamage(Element element, uint damage)
        {
            if (Element.IsWeekElement(element))
                Health -= damage + 10;
            else
                Health -= damage;
        }
    }
}
namespace Lncodes.DesignPattern.Bridge
{
    public sealed class SlimeEnemy : Enemy
    {
        public override uint Health { get; protected set; } = 30;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="element"></param>
        public SlimeEnemy(Element element) : base(element) { }

        /// <inheritdoc cref="Enemy.TakeDamage(Element, uint)"/>
        public override void TakeDamage(Element element, uint damage)
        {
            if (Element.IsWeekElement(element))
                Health -= damage + 5;
            else
                Health -= damage;
        }
    }
}
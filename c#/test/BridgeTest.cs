using Xunit;

namespace Lncodes.DesignPattern.Bridge.Test
{
    public sealed class BridgeTest
    {
        [Theory]
        [ClassData(typeof(BridgeTheoryData))]
        public void Enemy_Health_ShouldEqual(Enemy instance, Element attackElement, uint damage, uint expected)
        {
            var enemy = instance;

            enemy.TakeDamage(attackElement, damage);
            var actual = enemy.Health;

            Assert.Equal(expected, actual);
        }
    }
}
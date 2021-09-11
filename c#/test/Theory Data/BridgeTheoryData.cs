using Xunit;

namespace Lncodes.DesignPattern.Bridge.Test
{
    public sealed class BridgeTheoryData : TheoryData<Enemy, Element, uint, uint>
    {
        public BridgeTheoryData()
        {
            Add(new OrcEnemy(new FireElement()), new WaterElement(), 10, 87);
            Add(new SlimeEnemy(new WindElement()), new FireElement(), 20, 5);
            Add(new GoblinEnemy(new WaterElement()), new WindElement(), 30, 10);
        }
    }
}

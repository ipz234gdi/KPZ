using CHero;

namespace CMage
{
    public class Mage : Hero
    {
        public override string GetDescription()
        {
            return "Mage";
        }

        public override int GetPower()
        {
            return 30;
        }

        public override int GetHP()
        {
            return 75;
        }

        public override int GetArmor()
        {
            return 10;
        }
    }
}
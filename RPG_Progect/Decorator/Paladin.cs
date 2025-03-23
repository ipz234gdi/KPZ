using CHero;

namespace CPaladin
{
    public class Paladin : Hero
    {
        public override string GetDescription()
        {
            return "Paladin";
        }

        public override int GetPower()
        {
            return 20;
        }

        public override int GetHP()
        {
            return 90;
        }

        public override int GetArmor()
        {
            return 20;
        }
    }
}
using CHero;

namespace CWarrior
{
    public class Warrior : Hero
    {
        public override string GetDescription()
        {
            return "Warrior";
        }

        public override int GetPower()
        {
            return 10;
        }

        public override int GetHP()
        {
            return 100;
        }

        public override int GetArmor()
        {
            return 40;
        }
    }
}
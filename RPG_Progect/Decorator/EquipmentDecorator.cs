using CHero;

namespace CEquipmentDecorator
{
    public abstract class EquipmentDecorator : Hero
    {
        protected Hero _hero;

        public EquipmentDecorator(Hero hero)
        {
            _hero = hero;
        }

        public override string GetDescription()
        {
            return _hero.GetDescription();
        }

        public override int GetPower()
        {
            return _hero.GetPower();
        }

        public override int GetHP()
        {
            return _hero.GetHP();
        }

        public override int GetArmor()
        {
            return _hero.GetArmor();
        }
    }
}

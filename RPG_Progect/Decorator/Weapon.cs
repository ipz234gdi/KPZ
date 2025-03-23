using CEquipmentDecorator;
using CHero;

namespace CWeapon
{
    public class Weapon : EquipmentDecorator
    {
        public Weapon(Hero hero) : base(hero)
        {
        }

        public override string GetDescription()
        {
            return _hero.GetDescription() + " + Weapon";
        }

        public override int GetPower()
        {
            return _hero.GetPower() + 40;
        }
    }
}
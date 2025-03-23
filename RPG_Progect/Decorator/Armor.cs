using CEquipmentDecorator;
using CHero;

namespace CArmor
{
    public class Armor : EquipmentDecorator
    {
        public Armor(Hero hero) : base(hero)
        {
        }

        public override string GetDescription()
        {
            return _hero.GetDescription() + " + Armor";
        }

        public override int GetArmor()
        {
            return _hero.GetArmor() + 20;
        }
    }
}
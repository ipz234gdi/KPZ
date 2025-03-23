using CEquipmentDecorator;
using CHero;

namespace CArtifact
{
    public class Artifact : EquipmentDecorator
    {
        public Artifact(Hero hero) : base(hero)
        {
        }

        public override string GetDescription()
        {
            return _hero.GetDescription() + " + Artifact";
        }

        public override int GetPower()
        {
            return _hero.GetPower() + 20;
        }

        public override int GetHP()
        {
            return _hero.GetHP() + 10;
        }
    }
}
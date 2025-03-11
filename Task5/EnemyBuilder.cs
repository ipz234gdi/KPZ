public class EnemyBuilder : ICharacterBuilder
{
    private readonly Character _character = new();

    public ICharacterBuilder SetName(string name)
    {
        _character.Name = name;
        return this;
    }

    public ICharacterBuilder SetHeight(int height)
    {
        _character.Height = height;
        return this;
    }

    public ICharacterBuilder SetBodyType(string bodyType)
    {
        _character.BodyType = bodyType;
        return this;
    }

    public ICharacterBuilder SetHairColor(string hairColor)
    {
        _character.HairColor = hairColor;
        return this;
    }

    public ICharacterBuilder SetEyeColor(string eyeColor)
    {
        _character.EyeColor = eyeColor;
        return this;
    }

    public ICharacterBuilder SetClothes(string clothes)
    {
        _character.Clothes = clothes;
        return this;
    }

    public ICharacterBuilder AddInventoryItem(string item)
    {
        _character.Inventory.Add(item);
        return this;
    }

    public ICharacterBuilder AddSpecialAction(string action)
    {
        _character.SpecialActions.Add(action);
        return this;
    }

    public Character Build() => _character;
}
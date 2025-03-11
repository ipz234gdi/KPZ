public interface ICharacterBuilder
{
    ICharacterBuilder SetName(string name);
    ICharacterBuilder SetHeight(int height);
    ICharacterBuilder SetBodyType(string bodyType);
    ICharacterBuilder SetHairColor(string hairColor);
    ICharacterBuilder SetEyeColor(string eyeColor);
    ICharacterBuilder SetClothes(string clothes);
    ICharacterBuilder AddInventoryItem(string item);
    ICharacterBuilder AddSpecialAction(string action);
    Character Build();
}
public class CharacterDirector
{
    public Character CreateHero(ICharacterBuilder builder)
    {
        return builder
            .SetName("Алиса")
            .SetHeight(170)
            .SetBodyType("Струнка")
            .SetHairColor("Біляве")
            .SetEyeColor("Блакитні")
            .SetClothes("Лицарські обладунки")
            .AddInventoryItem("Меч")
            .AddInventoryItem("Щит")
            .AddSpecialAction("Захист королівства")
            .Build();
    }

    public Character CreateEnemy(ICharacterBuilder builder)
    {
        return builder
            .SetName("Путен")
            .SetHeight(190)
            .SetBodyType("Хилявий")
            .SetHairColor("Лисий")
            .SetEyeColor("Червоні")
            .SetClothes("Костюм")
            .AddInventoryItem("Красна кнопка")
            .AddSpecialAction("Знищення світу")
            .Build();
    }
}
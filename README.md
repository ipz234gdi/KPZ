# Warehouse Management System

## Програмні принципи у реалізації

### DRY (Don't Repeat Yourself)
**Опис:** Принцип DRY забезпечує, щоб кожен фрагмент інформації мав єдине, авторитетне представлення у системі.

**Приклад:** 
Методи форматування грошей та генерації звітів винесені в окремі функції у класах `Money` та `Warehouse`.

```csharp
public override string ToString() => $"{Whole}.{Cents:D2}";
```

[Money.cs](./Task1/Money.cs#L10-L15)

```csharp
public void GenerateReport()
{
    Console.WriteLine("Inventory Report:");
    foreach (var (product, quantity) in products)
    {
        Console.WriteLine($"{product.Name} - {quantity} pcs - {product.Price}");
    }
}
```

[Warehouse.cs](./Task1/Warehouse.cs#L20-L30)

### KISS (Keep It Simple, Stupid)
**Опис:** Програма повинна бути якомога простішою для розуміння та модифікації.

**Приклад:** 
Метод `ReducePrice()` має мінімум параметрів і просту логіку для зниження ціни товару.

```csharp
public virtual void ReducePrice(Money amount)
{
    int totalCents = Price.Whole * 100 + Price.Cents;
    int amountCents = amount.Whole * 100 + amount.Cents;
    
    totalCents -= amountCents;
    Price.Whole = totalCents / 100;
    Price.Cents = totalCents % 100;
}
```

[Product.cs](./Task1/Product.cs#L10-L25)

### SOLID
#### S - Single Responsibility Principle
**Опис:** Кожен клас має одну відповідальність.

**Приклад:** 
Клас `Product` відповідає тільки за дані продукту, а клас `Warehouse` за збереження товарів.

[Product.cs](./Task1/Product.cs#L5-L20)

#### O - Open/Closed Principle
**Опис:** Програмні сутності мають бути відкриті для розширення, але закриті для модифікації.

**Приклад:** 
Методи знижки ціни у класі `Product` можуть бути перевизначені в дочірніх класах.

```csharp
public virtual void ReducePrice(Money amount)
```

[Product.cs](./Task1/Product.cs#L30-L40)

#### L - Liskov Substitution Principle
**Опис:** Об'єкти базового класу повинні бути замінені об'єктами його підкласів без порушення функціональності.

**Приклад:** 
Усі товари реалізовані через клас `Product` і можуть бути додані до складу однаково.

[Warehouse.cs](./Task1/Warehouse.cs#L10-L15)

#### I - Interface Segregation Principle
**Опис:** Клієнти не повинні залежати від інтерфейсів, які вони не використовують.

**Приклад:** 
Окремий інтерфейс для звітності.

[IReportable.cs](./Task1/IReportable.cs#L5-L15)

#### D - Dependency Inversion Principle
**Опис:** Залежності повинні бути абстрактними, а не конкретними.

**Приклад:** 
Клас `Reporting` працює через інтерфейс для складу.

[Reporting.cs](./Task1/Reporting.cs#L20-L30)

### YAGNI (You Ain't Gonna Need It)
**Опис:** Не варто реалізовувати функціонал, який може не знадобитися.

**Приклад:** 
У системі немає складної логіки категоризації товарів, поки це не буде необхідно.

### Composition Over Inheritance
**Опис:** Краще використовувати композицію, ніж успадкування.

**Приклад:** 
Клас `Warehouse` містить об'єкти класу `Product` замість успадкування.

```csharp
private List<(Product, int)> products = new List<(Product, int)>();
```

[Warehouse.cs](./Task1/Warehouse.cs#L5-L15)

### Program to Interfaces not Implementations
**Опис:** Клас повинен працювати з інтерфейсами, а не з конкретними реалізаціями.

**Приклад:** 
Інтерфейс для генерації звітності.

[IReportable.cs](./Task1/IReportable.cs#L5-L15)

### Fail Fast
**Опис:** Система повинна якомога раніше сигналізувати про помилки.

**Приклад:** 
Перевірка на нульову кількість товарів при їхньому додаванні.

```csharp
if (quantity <= 0) throw new ArgumentException("Quantity must be greater than zero.");
```

[Warehouse.cs](./Task1/Warehouse.cs#L15-L20)

---

## UML Diagram
Діаграма класів додана у файл [UML_diagram.pdf](./Task1/UML_diagram.pdf).

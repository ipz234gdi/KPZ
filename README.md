# 🧠 Лабораторна робота №3 — Структурні шаблони проектування (C#)

## 🎯 Мета:
Ознайомитись із реалізацією структурних шаблонів проектування мовою C#.  
У лабораторній реалізовано 6 основних структурних патернів:

- Адаптер
- Декоратор
- Міст
- Проксі
- Компонувальник
- Легковаговик

---

## 📁 Завдання

---

### ✅ [1. Адаптер](RPG_Progect/Adapter/)
**Патерн:** Adapter  
**Мета:** Узгодити інтерфейси логера і файлового запису

#### Класи:
- `Logger` — логування в консоль (кольори)
- `FileWriter` — запис у файл
- `FileLoggerAdapter` — адаптер для `FileWriter`, реалізує інтерфейс `Logger`

---

### ✅ [2. Декоратор](RPG_Progect/Decorator/)
**Патерн:** Decorator  
**Мета:** Додавати інвентар героям у RPG грі без зміни їх коду

#### Класи:
- `Hero` (абстрактний)
- `Warrior`, `Mage`, `Paladin` — герої
- `EquipmentDecorator` — базовий декоратор
- `Armor`, `Weapon`, `Artifact` — конкретні декоратори

---

### ✅ [3. Міст](RPG_Progect/Bridge/)
**Патерн:** Bridge  
**Мета:** Відокремити фігури від способу рендерингу

#### Класи:
- `Shape` (абстрактний)
- `Circle`, `Square`, `Triangle`
- `IRenderer` — інтерфейс рендерингу
- `RasterRenderer`, `VectorRenderer` — реалізації

---

### ✅ [4. Проксі](RPG_Progect/Proxy/)
**Патерн:** Proxy  
**Мета:** Додати логування і захист до файлового читача

#### Класи:
- `SmartTextReader` — читає файл в `char[][]`
- `SmartTextChecker` — проксі з логами
- `SmartTextReaderLocker` — проксі з блокуванням доступу по RegEx

---

### ✅ [5. Компонувальник (LightHTML)](RPG_Progect/Composite/)
**Патерн:** Composite  
**Мета:** Побудова HTML-подібної структури як дерева об'єктів

#### Класи:
- `LightNode` (абстрактний)
- `LightTextNode` — текст
- `LightElementNode` — HTML тег
- Методи `InnerHTML()`, `OuterHTML()` для виводу

---

### ✅ [6. Легковаговик (Flyweight)](RPG_Progect/Flyweight/)
**Патерн:** Flyweight  
**Мета:** Оптимізація використання памʼяті при побудові HTML дерева

#### Класи:
- `FlyweightFactory` — кешування тегів
- `BookToHTMLConverter` — перетворює текст книги у HTML
- Використовується патерн Flyweight для `LightElementNode`

---

## 🛠 Запуск

```bash
dotnet run

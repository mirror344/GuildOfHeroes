# GuildOfHeroes

Автор: Дудаков Иван\
Дата выполнения: 24.10.2026

## Практическая 2

### Вопросы

1. Метод экземпляра - это действие, которое выполняет объект класса.\
   `TakeDamage()`
2. Значение передается в круглых скобках и присваивается параметру.\
   `yaroslav.TakeDamage(25);`
3. `void` это объявление метода, который ничего не возвращает.\
   `public void TakeDamage(int damage)`
4. `return;` завершает выполнение метода, не возвращая значение, а `return Health > 0` возвращает значение типа bool.\

```csharp
if (damage <= 0) {
            return;
        }
        Health -= damage;
        if (Health < 0) {
            Health = 0;
        }
```

5. `bool` возвращает true/false. Ответ `IsAlive()` сохраняется в переменную.\
   `bool yaroslavAlive = yaroslav.IsAlive();`
6. `GetInfo()` формирует информацию о герое, а `Console.WriteLine()` в Program.cs выводит значение.\
   `Console.WriteLine(artem.GetInfo())`
7. Потому что метод работает с одним конкретным экземпляром класса.\
   `yaroslav.GainExperience(25);`
8. Можно изменить значение `Health` на любое.\
   `yaroslav.Health = -5000;`

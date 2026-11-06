Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);

Hero probe = new Hero("   Проверка   ", 120);
Console.WriteLine($"Начало: [{probe.Name}] {probe.Health}/{probe.MaxHealth}");

probe.TakeDamage(20);
probe.Heal(5);
Console.WriteLine($"Обычные действия: {probe.Health}");

probe.Heal(2147483647);
Console.WriteLine($"Большое лечение: {probe.Health}");

probe.TakeDamage(2147483647);
Console.WriteLine($"Большой урон: {probe.Health}; жив: {probe.IsAlive()}");

probe.Heal(20);
probe.Heal(0);
probe.Heal(-10);
probe.TakeDamage(0);
probe.TakeDamage(-10);
Console.WriteLine($"После восстановления и неверных вызовов: {probe.Health}");

probe.GainExperience(40);
probe.GainExperience(0);
probe.GainExperience(-10);
probe.GainExperience(2147483647);
Console.WriteLine($"Опыт: {probe.Experience}; уровень: {probe.Level}");

Console.WriteLine($"Основной Александр: {alexander.Health}/{alexander.MaxHealth}");






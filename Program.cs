// Probe.Run();

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

Guild guild = new Guild("Гильдия героев");
guild.Heroes.Add(yaroslav);
guild.Heroes.Add(anastasia);
guild.Heroes.Add(artem);
guild.Heroes.Add(alexander);
guild.Heroes.Add(sergey);

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.Heroes.Count}");

if (guild.Heroes.Count > 0) {
    Console.WriteLine($"Первый: {guild.Heroes[0].Name}");
    Console.WriteLine($"Последний: {guild.Heroes[guild.Heroes.Count - 1].Name}");
}

Console.WriteLine();
foreach (Hero hero in guild.Heroes) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

int strongCount = 0;
foreach (Hero hero in guild.Heroes) {
    if (hero.Health >= 120) {
        strongCount++;
    }
}
Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {strongCount}");


if (guild.Heroes.Count > 0) {
    Hero strongest = guild.Heroes[0];
    foreach (Hero hero in guild.Heroes) {
        if (hero.Health > strongest.Health) {
            strongest = hero;
        }
    }
    Console.WriteLine($"Самый здоровый: {strongest.Name}({strongest.Health})");
}

Console.WriteLine();

if (guild.Heroes.Count > 0) {
    int sumhp = 0;
    foreach (Hero hero in guild.Heroes) {
        sumhp += hero.Health;
    }

    int avghp = sumhp / guild.Heroes.Count;

    int hero_avghp_count = 0;
    foreach (Hero hero in guild.Heroes) {
        if (hero.Health > avghp) {
            hero_avghp_count++;
        }
    }

    Console.WriteLine($"Количество со здоровьем выше среднего: {hero_avghp_count}");
}

using Ucu.Poo.RoleplayGame;

SpellsBook book = new SpellsBook();
book.Spells = new List<ISpell>() { new Spell("Bola de fuego", 50,0) };

Wizard gandalf = new Wizard("Gandalf");
gandalf.Staff = new Staff();
gandalf.SpellsBook = book;

Dwarf gimli = new Dwarf("Gimli");
gimli.Axe = new Axe();
gimli.Helmet = new Helmet();
gimli.Shield = new Shield();

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

gimli.ReceiveAttack(gandalf);

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

gimli.Cure();

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");


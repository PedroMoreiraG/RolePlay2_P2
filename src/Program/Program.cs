using Ucu.Poo.RoleplayGame;

Wizard gandalf = new Wizard("Gandalf");
Staff staff = new Staff();
SpellsBook spellsBook = new SpellsBook();
Spell bolaDeFuego = new Spell("Bola de fuego",20);
spellsBook.AddSpell(bolaDeFuego);
gandalf.AddItem(staff);
gandalf.AddItem(spellsBook);


Dwarf gimli = new Dwarf("Gimli");
Axe hacha = new Axe();
Helmet casco = new Helmet();
Shield escudo = new Shield();
gimli.AddItem(hacha);
gimli.AddItem(casco);
gimli.AddItem(escudo);

Console.WriteLine($"Gimli has hp: {gimli.Health}");
Console.WriteLine($"Gandalf attacks Gimli with attack value: {gandalf.AttackValue}");

gimli.ReceiveAttack(gandalf);

Console.WriteLine($"Gimli has hp: {gimli.Health}");

gimli.Cure();

Console.WriteLine($"Gimli has hp: {gimli.Health}");
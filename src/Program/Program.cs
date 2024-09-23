using Ucu.Poo.RoleplayGame;

Wizard gandalf = new Wizard("Gandalf"); // Personaje Mago
Staff staff = new Staff(); // Creamos baculo
SpellsBook spellsBook = new SpellsBook(); // Creamos libro de hechizos
Spell bolaDeFuego = new Spell("Bola de fuego",20,20); // Creamos item de hechizo, con su ataque y defensa
spellsBook.AddSpell(bolaDeFuego); //Agregamos item bolaDeFuego al libro
gandalf.AddItem(staff); // Le damos item al mago
gandalf.AddItem(spellsBook); // Le damos los hechizos del libro al mago
Console.WriteLine("La defensa es: " + gandalf.DefenseValue); // Imprime la defensa del mago
//Repetimos lo anterior pero con el personaje Dwarf, y los items Axe, Helmet y Shield

Dwarf gimli = new Dwarf("Gimli");
Axe hacha = new Axe();
Helmet casco = new Helmet();
Shield escudo = new Shield();
gimli.AddItem(hacha);
gimli.AddItem(casco);
gimli.AddItem(escudo);

Console.WriteLine($"Gimli has hp: {gimli.Health}");
Console.WriteLine($"Gandalf attacks Gimli with attack value: {gandalf.AttackValue}");
//Dwarf recibe ataque del mago
gimli.ReceiveAttack(gandalf);

Console.WriteLine($"Gimli has hp: {gimli.Health}");

gimli.Cure();
//Se cura al Dwarf
Console.WriteLine($"Gimli has hp: {gimli.Health}");
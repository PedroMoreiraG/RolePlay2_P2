namespace Ucu.Poo.RoleplayGame;
using System;
using System.Collections.Generic;


public class Wizard:IMagicalCharacters
{
    private int health;
    private List<IItem> Items= new List<IItem>();
    private List<IMagicalItem> MagicalItems= new List<IMagicalItem>();
    
    public Wizard(string name)
    {
        string Name = name;
    }
    
    public string Name
    {
        get { return this.Name; }
    }
    
    public int Health
    {
        get{ return this.Health; }
        set{ this.Health=value; }
    }


    public int AttackValue
    {   
        get
        {
            int attack=0;
            foreach(IAtackItems item in Items)
            {
                attack+=item.AttackValue;
            }
            foreach(IMagicalItem item in MagicalItems)
            {
                attack+=item.AttackValue;
            }
            return attack;
        }
    }
    
    
    public int DefenseValue
    {   
        get
        {
            foreach(IDefenseItems item in Items)
            {
                this.DefenseValue+=item.DefenseValue;
            }
            foreach(IMagicalItem item in MagicalItems)
            {
                this.DefenseValue+=item.DefenseValue;
            }
            return this.DefenseValue;
        }
        set{ this.DefenseValue=value;}
    }
    
    
    public void AddItem(IItem item)
    {
        this.Items.Add(item);
    }
    
    
    public void RemoveItem(IItem item)
    {
        this.Items.Remove(item);

    }
    
    
    public void AddItem(IMagicalItem item)
    {
        this.MagicalItems.Add(item);

    }
    
    
    public void RemoveItem(IMagicalItem item)
    {
        this.MagicalItems.Remove(item);

    }
    
    
    public void Cure()
    {
        this.Health=100;
    }
    
    
    public void ReceiveAttack(ICharacters attacker)
    {
        if(attacker.AttackValue> this.DefenseValue)
        {
            this.Health-= attacker.AttackValue-this.DefenseValue;
            Console.WriteLine($"El ataque ha vencido las defensas de {this.Name}.\nVida restante: {this.Health}");
        }
        else{
            this.DefenseValue-=attacker.AttackValue;
            Console.WriteLine($"Los escudos de {this.Name} resistieron el ataque.\nEscudo restante: {this.DefenseValue}");

        }
    }
}

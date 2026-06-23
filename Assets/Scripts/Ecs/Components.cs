using System.Collections.Generic;
using TinyECS;

public class PlayerComp : IComponent 
{
    public int hp;
    public List<Card> hand = new();
}

public class DeckComp : IComponent 
{
    public List<Card> deck = new();
}

public class EnemyComp : IComponent
{ 
    public List<Enemy> enemy = new();
}

public class Enemy 
{
    public int hp;
    public List<Card> hands = new();
}

public class Card
{
    public string id;
    public Card(string id)
    {
        this.id = id;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public string title;
    public string description;
    public int hp;
    public int attack;
    public int mana;

    private CardNames cardName;
    private Description cardDescription;

    public Card()
    {       
        cardName = (CardNames)Random.Range(0, 6);
        cardDescription = (Description)Random.Range(0, 2);
        title = cardName.ToString();
        description = cardDescription.ToString();
        hp = GetValue();
        attack = GetValue();
        mana = GetValue();
    }

    private int GetValue()
    {
        return Random.Range(1, 11);
    }

    public enum CardNames
    {
        Elf,
        Human,
        Demon,
        Dragon,
        Creature,
        Earth,
    }
    public enum Description
    {
        Kind,
        Strong,
        PowerFul
    }
}

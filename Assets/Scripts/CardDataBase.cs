using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList= new List<Card>(6);
    private int id = 1;
    
    private void Awake()
    {
        foreach(Card card in cardList)
        {
            CardNames name = (CardNames)Random.Range(0, 6);
            Description description = (Description)Random.Range(0, 3);
            cardList.Add(new Card());
            id++;
        }
    }

    private int GetValue()
    {
        return Random.Range(1, 11);
    }
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



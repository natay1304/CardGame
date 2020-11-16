using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCreator : MonoBehaviour
{
    public CardView card;
    public List<CardView> cards = new List<CardView>();

    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            cards.Add(GameObject.Instantiate(card, transform));
        }
    }
}

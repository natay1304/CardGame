using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCreator : MonoBehaviour
{
    public CardView card;

    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            GameObject.Instantiate(card, transform);
        }
    }

    void Update()
    {
        
    }
}

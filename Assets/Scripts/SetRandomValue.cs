using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetRandomValue : MonoBehaviour
{
    public Button button;
    public CardView cardView;

    private int newValue;
    private CardProperty property;

    private void Start()
    {
        button.onClick.AddListener(Handler);
    }

    private void Handler()
    {
        newValue = UnityEngine.Random.Range(1, 11);
        property = (CardProperty)UnityEngine.Random.Range(0, 3);
        Debug.Log("value b" + newValue);
        Debug.Log("property b" + property.ToString());
        cardView.ChangeValue(property, newValue);
    }
}

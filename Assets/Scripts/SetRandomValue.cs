using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetRandomValue : MonoBehaviour
{
    public Button button;
    public CardCreator cardCreator;
    public Text randomProperty;
    public Text randomValue;

    private int _newValue;
    private CardProperty _property;

    private void Start()
    {
        button.onClick.AddListener(Handler);       
    }

    private void Handler()
    {
        _newValue = UnityEngine.Random.Range(1, 11);
        _property = (CardProperty)UnityEngine.Random.Range(0, 3);
        StartCoroutine(SetValueToCard(cardCreator.cards, _property, _newValue));
        randomProperty.text = "Random property is " + _property.ToString();
        randomValue.text = "Random value = " + _newValue.ToString();
    }

    private IEnumerator SetValueToCard(List<CardView> cards, CardProperty property, int value)
    {
        foreach (var cardView in cardCreator.cards)
        {
            Debug.Log($"{property}: {value}", cardView);

            cardView.ChangeValue(property, _newValue);
            yield return new WaitForSeconds(4f);
        }       
    }
}

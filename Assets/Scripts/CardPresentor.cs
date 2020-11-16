using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardPresentor
{
    private CardView _cardView;
    private Card _card;

    public CardPresentor(CardView cardView)
    {
        _cardView = cardView;
        _card = new Card();
        cardView.attack.text = _card.attack.ToString();
        cardView.hp.text = _card.hp.ToString();
        cardView.mana.text = _card.mana.ToString();
        cardView.title.text = _card.title;
        cardView.description.text = "This character is " + _card.description;

        _cardView.OnPropertyChanged += PropertyChangedHandler;
    }

    private void PropertyChangedHandler(CardProperty property, int value)
    {
        Debug.Log("value " + value);
        Debug.Log("property " + property.ToString());
        switch (property)
        {
            case CardProperty.Attack:
                _card.attack = value;
                break;
            case CardProperty.HP:
                _card.hp = value;
                break;
            case CardProperty.Mana:
                _card.mana = value;
                break;
            default:
                break;
        }
    }
}

using System;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public event Action<CardProperty, int> OnPropertyChanged;
    public Text attack;
    public Text hp;
    public Text mana;
    public Text title;
    public Text description;

    private CardPresentor _presentor;

    void Start()
    {
        _presentor = new CardPresentor(this);
    }

    public void ChangeValue(CardProperty property, int value)
    {
        OnPropertyChanged?.Invoke(property, value);
    }    
}

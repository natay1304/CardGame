using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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
        StartCoroutine(CountValue(property, value));
    }

    private IEnumerator CountValue(CardProperty property, int value)
    {
        Text text = FindTextField(property);
        int startValue = Int32.Parse(text.text);
        int sign = Math.Sign(value - startValue);
        int delta = Mathf.Abs(value - startValue);

        for (int i = startValue; i != value; i += sign)
        {
            text.text = i.ToString();
            yield return new WaitForSeconds(4f/delta);
        }

        text.text = value.ToString();
    }

    private Text FindTextField(CardProperty property)
    {
        switch (property)
        {
            case CardProperty.Attack:
                return attack;
            case CardProperty.HP:
                return hp;
            case CardProperty.Mana:
                return mana;               
            default:
                return null;
        }
    }
}

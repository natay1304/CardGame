using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class TouchControl : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{

    private LayoutGroup _element;
    private RectTransform _card;
    private Vector2 _startPoint;
    private Vector2 _delta;

    private void Start()
    {
        _card = GetComponent<RectTransform>();
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {   
                   
    }

    public void OnDrag(PointerEventData eventData)
    {        
        _card.transform.position += (Vector3)eventData.delta / Screen.height * 1000;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        var drag = GetDrag(eventData);
        if (drag.magnitude < Screen.width/10)
            _card.transform.position = _startPoint;
    }

    private static Vector2 GetDrag(PointerEventData eventData)
    {
        return eventData.position - eventData.pressPosition;
    }
}

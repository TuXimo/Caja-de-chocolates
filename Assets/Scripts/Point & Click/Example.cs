using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Example : MonoBehaviour, IPointerExitHandler
{
    [SerializeField] private UnityEvent evento;

    private void OnMouseDown()
    {
        evento.Invoke();
    }

    public void Hablar()
    {
        print("Hola wachos cómo están?");
    }

    private bool mouseOver = true;
    private void OnMouseOver()
    {
        if (mouseOver)
        {
            mouseOver = false;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!mouseOver)
        {
            mouseOver = true;
        }
    }
}
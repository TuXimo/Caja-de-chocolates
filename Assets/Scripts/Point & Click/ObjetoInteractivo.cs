using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class ObjetoInteractivo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool inRange;

    private Animator objectAnimator;

    [SerializeField] private Texture2D pointerHand;

    private void Awake()
    {
        objectAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()       
    {
        objectAnimator.SetBool("inRange", inRange);
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        if (inRange)
            Cursor.SetCursor(pointerHand,Vector2.zero,CursorMode.Auto);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (inRange)
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    private IEnumerator IDestroyGameObject()
    {   
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }

    public void StartCoroutineDestroyGameObject()
    {
        if(inRange)
            StartCoroutine(IDestroyGameObject());
    }
}

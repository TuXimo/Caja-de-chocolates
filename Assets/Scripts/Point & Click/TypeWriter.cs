using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour
{
    [SerializeField] [Min(0.001f)]private float delay = 0.05f;
    [SerializeField] [TextArea(3,10)] private string fullText;
    private string currentText = " ";

    public bool isCanvas = false;
    public UnityEvent unityEvent;

    private void Start()
    {
        StartCoroutine(ShowTextCoroutine());
    }


    private IEnumerator ShowTextCoroutine()
    {
        for (int i = 0; i < fullText.Length+1; i++)
        {
            currentText = fullText.Substring(0, i);
            GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay); 
        }

        if (isCanvas)
        {
            unityEvent.Invoke();
        }
    }

    public void AumentarVelocidad()
    {
        delay = 0;
    }
}

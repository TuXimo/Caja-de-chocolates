using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{

    [SerializeField] private GameObject[] escenas;
    [SerializeField] private GameObject cabeza;
    

    private static int count = 1;

    public void AumentarContador()
    {
        count++;
    }

    
    void Update()
    {
        if (count >= 5)
        {
            cabeza.SetActive(true);
        }
        
        switch (count)
        {
            case 1:
                escenas[0].SetActive(true);
                break;
            case 2:
                escenas[1].SetActive(true);
                break;
            case 3:
                escenas[2].SetActive(true);
                break;
            case 4:
                escenas[3].SetActive(true);
                break;
        }   
    }
}

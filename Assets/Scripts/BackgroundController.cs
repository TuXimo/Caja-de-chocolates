using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{

    [SerializeField] private GameObject[] escenas;

    public int count = 1;

    
    void Update()
    {
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

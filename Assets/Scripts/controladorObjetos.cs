using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorObjetos : MonoBehaviour
{

    public GameObject objeto1;
    public GameObject objeto2;
    public GameObject objeto3;
    public GameObject objeto4;
    public GameObject objeto5;

    private bool esObjetoFinal;

    // Start is called before the first frame update
    void Start()
    {
        objeto1.SetActive(true);
        objeto2.SetActive(true);
        objeto3.SetActive(true);
        objeto4.SetActive(true);
        esObjetoFinal = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!objeto1.activeSelf && !objeto2.activeSelf && !objeto3.activeSelf && !objeto4.activeSelf && !objeto5.activeSelf){
            esObjetoFinal=true;
        }

        if(esObjetoFinal){
            esObjetoFinal=false;
            objeto5.SetActive(true);
        }

    }

}

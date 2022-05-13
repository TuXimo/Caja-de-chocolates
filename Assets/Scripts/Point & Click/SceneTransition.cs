using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] private Animator transitionAnimator; 
    //Funciona
    
    public void StartLevel()
    {
        transitionAnimator.SetTrigger("End");
        StartCoroutine("ChangeBool");
    }

    private IEnumerator ChangeBool()
    {
        yield return new WaitForSeconds(2);
        transitionAnimator.SetBool("change",true);
    }
}

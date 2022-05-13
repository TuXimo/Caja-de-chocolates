using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] private Animator transitionAnimator; 
    [SerializeField] private float transitionTime = 1;

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevelCoroutine());
    }

    private IEnumerator LoadLevelCoroutine()
    {
        transitionAnimator.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);
    }
}

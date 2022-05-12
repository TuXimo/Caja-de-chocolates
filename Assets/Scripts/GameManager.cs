using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Texture2D mouse;

    [SerializeField] private GameObject player;
    private static GameManager instance;

    void Awake()
    {
        SpawnPlayer();
        if (GameManager.instance == null)
        {
            GameManager.instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CargarEscenaEjemplo(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    
    private void SpawnPlayer()
    {
        Instantiate(player, new Vector3(0.46f, -3.04f, 1), player.transform.rotation);
    }
}
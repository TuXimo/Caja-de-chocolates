using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Vector2 target;
    private Vector3 direction;
    private float distance;
    
    
    [SerializeField] private float speed = 4;
    [SerializeField] private Sprite[] sprites;
    private SpriteRenderer playerSR;
    private Animator playerAnimator;

    [SerializeField] private bool isCreepy, isMoving;
    
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        playerSR = GetComponent<SpriteRenderer>();
        playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        Movement();
        Animations();
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        target = transform.position;
        isMoving = false;
    }

    private void Movement()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            target = new Vector2(mousePos.x, mousePos.y);
            isMoving = true;
        }
        
        //Logica moviento
        
        transform.position = Vector2.MoveTowards(transform.position, target,Time.deltaTime * speed);
        direction =new Vector3(target.x,target.y,transform.position.z)-transform.position;
        distance = Vector2.Distance(transform.position, target);
        if (distance <= 0.1f)
            isMoving = false;

    }

    private void Animations()
    {
        playerAnimator.SetFloat("Horizontal",direction.x);
        playerAnimator.SetFloat("Vertical",direction.y);
        playerAnimator.SetBool("isCreepy",isCreepy);
        playerAnimator.SetBool("isMoving",isMoving);
    }


    public GameObject collider;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Objeto"))
        {
            col.GetComponent<ObjetoInteractivo>().UnityEvent.Invoke();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    private Vector2 target;
    [SerializeField] private float speed = 4;
    [SerializeField] private Sprite[] sprites;
    private SpriteRenderer playerSR;
    private Animator playerAnimator;

    [SerializeField] private bool isCreepy;
    private static bool setCreepyPlayer = false;
    
    private void Awake()
    {
        isCreepy = setCreepyPlayer;
        playerSR = GetComponent<SpriteRenderer>();
        playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        setCreepyPlayer = isCreepy;
        Movement();
        Animations();
        RayCasting();
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        target = transform.position;
    }

    private void Movement()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            target = new Vector2(mousePos.x, mousePos.y);
        }
        
        transform.position = Vector2.MoveTowards(transform.position, target,Time.deltaTime * speed);
    }

    private void Animations()
    {
        playerAnimator.SetFloat("Horizontal",target.x);
        playerAnimator.SetFloat("Vertical",target.y);
        playerAnimator.SetBool("isCreepy",setCreepyPlayer);
        //print(target);
    }

    private void RayCasting()
    {
        Debug.DrawRay(transform.position,transform.right,Color.green);
    }
}

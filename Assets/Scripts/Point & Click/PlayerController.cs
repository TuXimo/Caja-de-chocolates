using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    private Vector2 target;
    [SerializeField] private float speed;

    private void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            target = new Vector2(mousePos.x, mousePos.y);
        }
        
        transform.position = Vector2.MoveTowards(transform.position, target,Time.deltaTime * speed);
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        target = transform.position;
    }
}

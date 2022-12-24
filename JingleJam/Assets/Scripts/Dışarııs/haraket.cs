using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haraket : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;
    public GameObject gorev;

    Vector2 movement;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (gorev.activeSelf == true)
            {
                if (Input.GetKeyDown(KeyCode.Tab))
                {
                    gorev.SetActive(false);
                }
                    
                
                
            }
            else if (gorev.activeSelf == false)
            {
                if (Input.GetKeyDown(KeyCode.Tab))
                {
                    gorev.SetActive(true);
                }
                
            }
            
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}

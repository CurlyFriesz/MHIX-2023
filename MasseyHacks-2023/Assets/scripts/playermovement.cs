using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;

    float direction;

    public Rigidbody2D rb;
    public Animator animator;
    public Transform player;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.mousePosition.x > Screen.width/2)
        {
            direction = 1;
        }
        else
        {
            direction = -1;
        }

        animator.SetFloat("Horizontal", direction);
        animator.SetFloat("speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }
}

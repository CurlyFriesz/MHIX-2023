using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField]
    int maxHealth = 25;
    int currentHeatlh;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        currentHeatlh = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHeatlh -= damage;

        anim.SetTrigger("hurt");

        if(currentHeatlh < 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("enemy died");


        anim.SetBool("isDead", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        gameObject.GetComponent<AIDestinationSetter>().enabled = false;
    }
}

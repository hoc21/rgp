using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smile : MonoBehaviour
{
    Animator animator;
    bool isAlive = true;
    public float Health
    {
        set
        {
            if(value<health)
            {
                animator.SetTrigger("hit");
            }
            health = value;
            print(value);
            
            if(health<=0)
            {
                animator.SetBool("isAlive",false);
            }
        }
        get
        {
            return health;
        }
    }
    public float health = 3f;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isAlive",isAlive);
    }

    void OneHit(float damage)
    {
        Health -= damage;
    }
}

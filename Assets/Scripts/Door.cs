using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    BoxCollider2D boxCollider2D;
    Animator animator;
    public bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        isOpen = true;
    }

   private void OnTriggerEnter2D(Collider2D other) 
   {
    if(other.gameObject.CompareTag("Player") && isOpen)
        {
            boxCollider2D.enabled = false;
            animator.SetBool("OpenDoor",true);
            isOpen = true;
            Debug.Log("a");
        }
   }
   private void OnTriggerExit2D(Collider2D other)
   {
        if(other.gameObject.CompareTag("Player") && isOpen)
        {
            //boxCollider2D.enabled = true;
            animator.SetBool("OpenDoor",false);
            isOpen= true;
            
        }
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isWalking",true); 
    }
    void Update()
    {
        
           
   
    }
    void OnCollisionEnter(Collision col){
    if(col.collider.tag =="Player"){
        animator.SetBool("isWalking",false);
        animator.SetBool("isAttacking",true);
    }
    }
    void OnCollisionExit(Collision col){
    if(col.collider.tag =="Player"){
        animator.SetBool("isWalking",false);
        animator.SetBool("isAttacking",true);
    }
    }
}

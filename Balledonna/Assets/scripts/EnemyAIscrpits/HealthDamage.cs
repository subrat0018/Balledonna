using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthDamage : MonoBehaviour
{
   [SerializeField] Slider slider;
   [SerializeField] particles explosion;
   private float currHealth;
   private float maxhealth;
    void Start()
    {
         maxhealth = 100f;
        currHealth = maxhealth;
    }

    void OnCollisionEnter(Collision col){
        if(col.collider.tag == "bullet"){
            dealdamage();
        }
         if(currHealth <= 0){
               explosion.Play();
            Destroy(this.gameObject);
        }
       
    }
    void dealdamage(){
        currHealth -= 40;
        slider.value = currHealth;
    }
   
}


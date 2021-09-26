using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
     [SerializeField] Slider slider;
  // [SerializeField] particles explosion;
   private float currHealth;
   private float maxhealth;
    void Start()
    {
         maxhealth = 100f;
        currHealth = maxhealth;
    }
    public void takeDamage(){
      dealdamage();
        if(currHealth<=0f){
          //   explosion.Play();
            Die();
        }
    }
    void Die(){
        Destroy(gameObject);
    }
     void dealdamage(){
        currHealth -= 34f;
        // explosion.Play();
        slider.value = currHealth;
    }
}

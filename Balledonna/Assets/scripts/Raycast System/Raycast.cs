using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
   public Camera cam;
  public ParticleSystem muzzleflash;
     [SerializeField] particles explosion;
    void Update()
    {
     if (Input.GetButtonDown("Fire1")){
         shoot();
     }   
    }
    void shoot(){
       muzzleflash.Play();
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position,cam.transform.forward,out hit)){
        Target enemy = hit.transform.GetComponent<Target>();
        if(enemy != null){
            enemy.takeDamage();
            explosion.Play();
        }
        }
    }
}

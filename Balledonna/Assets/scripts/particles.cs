using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles : MonoBehaviour
{
    [SerializeField] ParticleSystem[] particle;
    public void Play()
    {
        
        foreach(ParticleSystem p in particle){
            p.Play();
        }
        //particle[0].Play();
       // particle[1].Play();
       // particle[2].Play();
        
    }
}

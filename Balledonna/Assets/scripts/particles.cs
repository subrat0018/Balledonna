using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem[] particle;



    // Update is called once per frame
    public void Play()
    {
        particle[0].Play();
        particle[1].Play();
        particle[2].Play();
    }
}

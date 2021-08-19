using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{  [SerializeField]float DestroyAfterTime; 
float InstatntiationTime=0;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,DestroyAfterTime);
    }

    // Update is called once per frame
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{  [SerializeField]float DestroyAfterTime; 
[SerializeField]GameObject explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,DestroyAfterTime);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col){
        if(col.collider.tag =="enemy"){
            Destroy(col.collider.gameObject);
        }
        Instantiate(explosionPrefab,transform.position,Quaternion.identity);
        Destroy(this.gameObject);
    }
}

using UnityEngine;

public class GunController : MonoBehaviour
{public Rigidbody rb;
 public GameObject BulletPrefab;
 public float offsetUnitFromFront;
public float Force=100f;
public float BulletThrowingForce;
    void Update()
    {
    if (Input.GetButtonDown("Fire1"))
      {
            Debug.Log("ok");
            GameObject bullet=Instantiate(BulletPrefab,transform.position+(transform.forward*offsetUnitFromFront), Quaternion.Euler(transform.eulerAngles-(90*Vector3.up)));
           bullet.GetComponent<Rigidbody>().AddForce(transform.forward*BulletThrowingForce);}        
        
          // changes done
      
    }
}

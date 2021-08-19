using UnityEngine;

public class GunMovement : MonoBehaviour
{public Rigidbody rb;
 public GameObject BulletPrefab;
 public float offsetUnitFromFront;
public float Force=10f;
public float BulletThrowingForce;
    void Update()
    { if(Input.GetKey(KeyCode.D))
        {rb.AddForce(Force*Time.deltaTime,0,0,ForceMode.VelocityChange);}
      if(Input.GetKey(KeyCode.A))
        {rb.AddForce(-Force*Time.deltaTime,0,0,ForceMode.VelocityChange);}
      if(Input.GetKey(KeyCode.W))
        {rb.AddForce(0,0,Force*Time.deltaTime,ForceMode.VelocityChange);}
      if(Input.GetKey(KeyCode.S))
        {rb.AddForce(0,0,-Force*Time.deltaTime,ForceMode.VelocityChange);}
      if(Input.GetMouseButton(0))
        {rb.AddForce(0,Force*Time.deltaTime,0,ForceMode.VelocityChange);}
      if(Input.GetMouseButton(1))
        {rb.AddForce(0,-Force*Time.deltaTime,0,ForceMode.VelocityChange);}
      if(Input.GetKeyDown(KeyCode.Space))
      {
      GameObject bullet=Instantiate(BulletPrefab,transform.position+(transform.forward*offsetUnitFromFront), Quaternion.Euler(transform.eulerAngles-(90*Vector3.up)));
      bullet.GetComponent<Rigidbody>().AddForce(transform.forward*BulletThrowingForce);}        
        
          // changes done
      
    }
}

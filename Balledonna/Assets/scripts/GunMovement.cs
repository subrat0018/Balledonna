using UnityEngine;

public class GunMovement : MonoBehaviour
{public Rigidbody rb;
public float Force=10f;
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
        
        
          
      
    }
}

using UnityEngine;

public class followGun : MonoBehaviour
{public Transform gun;
public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
      transform.position=gun.position+offset;  
    }
}

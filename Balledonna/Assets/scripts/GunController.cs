using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float offsetUnitFromFront;
    [SerializeField] Transform bulletPosition;
    public float Force=80f;
    Vector3 offsetforward = 2* Vector3.forward;
    public float BulletThrowingForce;
    void Update()
    {
    if (Input.GetButtonDown("Fire1"))
      {
          
            GameObject bullet=Instantiate(BulletPrefab,bulletPosition.transform.position, bulletPosition.transform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(bulletPosition.transform.forward*BulletThrowingForce);
                  
      }
      
    }
}

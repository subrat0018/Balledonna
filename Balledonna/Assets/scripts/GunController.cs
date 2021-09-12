using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float offsetUnitFromFront;
    [SerializeField] Transform bulletPosition;
    public float Force=80f;
    public float BulletThrowingForce;
    void Update()
    {
    if (Input.GetButtonDown("Fire1"))
      {
           
            GameObject bullet=Instantiate(BulletPrefab,bulletPosition.transform.position, bulletPosition.transform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(bulletPosition.transform.forward*BulletThrowingForce);}        
        
        
      
    }
}

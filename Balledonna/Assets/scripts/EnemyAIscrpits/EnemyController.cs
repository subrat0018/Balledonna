using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.AI;
public class EnemyController : MonoBehaviour
{
    public float lookradius = 12f;
    Transform target;
   
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target  = PlayerManager.instance.player.transform;      
    }

    // Update is called once per frame
    void Update()
    {
        float distance =Vector3.Distance(target.position,transform.position);
        if(distance <= lookradius){

            agent.SetDestination(target.position);
        }
    }
    void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,lookradius);
    }
}

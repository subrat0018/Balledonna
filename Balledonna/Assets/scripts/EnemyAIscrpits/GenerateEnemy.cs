using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
  public GameObject TheEnemy;
  public int xPos;
  public int zPos;
  public int enemyCount=0;
    void Start()
    {
        StartCoroutine(enemyDrop());
    }
IEnumerator enemyDrop(){
    while(enemyCount < 40){
        xPos =Random.Range(4,27);
        zPos = Random.Range(-28,25);
        Instantiate(TheEnemy,new Vector3(xPos,1,zPos),Quaternion.identity);
        yield return new WaitForSeconds(3f);
        enemyCount+=1;
    }
    while(enemyCount >=40 && enemyCount<=80){
         xPos =Random.Range(4,27);
        zPos = Random.Range(-28,25);
        Instantiate(TheEnemy,new Vector3(xPos,1,zPos),Quaternion.identity);
        yield return new WaitForSeconds(1f);
        enemyCount+=1;
    }
}
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHP : MonoBehaviour
{
    [SerializeField] Slider Playerhealth;
     private int maxmhealth;
     private int hp;
    public GameController gameControl;
    public PlayControl playerControl;
    public GenerateEnemy enemyGeneration;
  // public GunController gunControl;
    void Start()
    {
        maxmhealth = 100;
        hp = maxmhealth;
    }
    void OnCollisionEnter(Collision col){
        if(col.collider.tag == "enemy"){
            takedamage();
        }
         if(hp<=0){
            // Time.timeScale = 0;
            playerControl.enabled = false;
            enemyGeneration.enabled = false;
           // gunControl.enabled = false;
            gameControl.GameOver();
        }
    }
    void takedamage(){
        hp -= 14;
     FindObjectOfType<AudioManager>().Play("takedamage");
        Playerhealth.value = hp;
    }
}

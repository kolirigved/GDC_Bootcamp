using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public GameObject Shield;
    public bool poweractive;
    void Start(){
        Shield.SetActive(false);
        poweractive=false;
    }
    private void OnTriggerEnter2D(Collider2D collison){
        if(collison.CompareTag("Player")){
            Destroy(gameObject);
            invis();
        }
    }
    public void invis(){
        Shield.SetActive(true);
        poweractive=true;
    }
}

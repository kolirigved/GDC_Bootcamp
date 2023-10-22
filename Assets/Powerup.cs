using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public GameObject Shield;
    public bool poweractive=false;
    void Start(){
        Shield.SetActive(false);
        poweractive=false;
    }
    
    private void OnTriggerEnter2D(Collider2D collison){
        if(collison.CompareTag("Player")){
            Destroy(gameObject);
            ActivateShield();
        }
    }
    public void ActivateShield(){
        Shield.SetActive(true);
        poweractive=true;
    }

    public void DeactivateShield(){
        Shield.SetActive(false);
        poweractive=false;
    }

    public bool isActivated(){
        return poweractive;
    }
}

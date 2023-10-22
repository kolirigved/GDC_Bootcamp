using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public GameObject Shield;
    public bool poweractive=false;
    public float PowerUpDuration = 1.0f;
    private float ActivationTime;
    void Start(){
        Shield.SetActive(false);
        poweractive=false;
    }
    void Update(){
        if (isActivated() && Time.time - ActivationTime >= PowerUpDuration)
        {
            DeactivateShield();
        }

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
        ActivationTime = Time.time;
    }
    public void DeactivateShield(){
        Shield.SetActive(false);
        poweractive=false;
    }

    public bool isActivated(){
        return poweractive;
    }
}

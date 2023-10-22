using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death_Trap : MonoBehaviour
{
   public Powerup powerup;
   private void OnCollisionEnter2D(Collision2D collision){
      if(collision.gameObject.CompareTag("Player")&&powerup.poweractive==false){
         Destroy(collision.gameObject);
         Restart();
      }
   }

   public void Restart(){
      int sceneIndex = SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(sceneIndex);
      
   }
}

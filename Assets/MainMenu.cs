using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public GameObject instructionsPanel;
  private void Start(){
    instructionsPanel.SetActive(false);
  }
  private void Update(){
    if(Input.GetKey(KeyCode.I)){
      instructionsPanel.SetActive(false);
    }
  }
  public void ShowInstructions(){
    instructionsPanel.SetActive(true);
  }
  public void StartGame(){
    SceneManager.LoadScene(1);
  }
  public void Exit(){
    Application.Quit();
    Debug.Log("Quit");
  }
  public void HideInstructions(){
    instructionsPanel.SetActive(false);
  }
}

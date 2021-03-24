using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

  public void StartExperience()
  {

    SceneManager.LoadScene("SecondFloor");

  }

  public void ExitExperience()
  {
      
    SceneManager.LoadScene("MainMenu");

  }


}
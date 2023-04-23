using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameoverController : MonoBehaviour
{
   public Button buttonRestart;

    private void Awake() 
    {
      buttonRestart.onClick.AddListener(Restartlevel);
    }
   
    public void PlayerDied()
    {
        gameObject.SetActive(true);

    }

//Restart After Death
public void Restartlevel()
{
  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
  Debug.Log("Level restarted");
}


}

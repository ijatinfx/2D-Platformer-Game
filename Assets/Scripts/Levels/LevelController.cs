using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelController : MonoBehaviour
{


  
  private void OnTriggerEnter2D(Collider2D collision)
   {
    if (collision.gameObject.GetComponent<PlayerController>() != null)

   { 
      Debug.Log ("Level finished by the Player");
     LevelManager.Instance.SetLevelStatus(SceneManager.GetActiveScene().name, LevelStatus.Completed);
    }

   }

}
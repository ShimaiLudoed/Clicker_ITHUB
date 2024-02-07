using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
  public void PlayGame(string Game)
    {
        SceneManager.LoadScene(Game);
    }
        
}

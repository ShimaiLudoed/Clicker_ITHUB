using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
  public void PlayGame(string Start_location)
    {
        SceneManager.LoadScene(Start_location);
    }
    public void WoodTp(string Wood_location)
    {
        SceneManager.LoadScene(Wood_location);
    }
        
}

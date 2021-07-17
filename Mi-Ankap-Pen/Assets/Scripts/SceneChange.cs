using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
   
    public void startGame()
    {
        SceneManager.LoadScene("UserScene");
    }

}

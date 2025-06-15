using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void StartButtonClick()
    {
        SceneManager.LoadScene("Notes");
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void NextLevelll()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void NextLevelPoz()
    {
        SceneManager.LoadSceneAsync(4);
    }

    public void NextLevel2()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void NextLevel6()
    {
        SceneManager.LoadSceneAsync(6);
    }


}

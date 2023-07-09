using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Made by <see href="https://github.com/milanatran" langword="milanatran" />
/// </summary>
public class SceneChanger : MonoBehaviour
{
    public static void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public int GetCurrentSceneID()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
}
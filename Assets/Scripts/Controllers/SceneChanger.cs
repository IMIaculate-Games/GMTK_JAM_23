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

    public int GetCurrentSceneID()
    {
        //TODO implement
        return 0;
    }
}
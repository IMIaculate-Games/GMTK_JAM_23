using UnityEngine;

public class MainMenu : MonoBehaviour
{

    /// <summary>
    /// Quits the application or editor.
    /// </summary>
    public void Quit()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
        Application.Quit();
    }

    /// <summary>
    /// Toggles a given menu on or off.
    /// </summary>
    /// <param name="menu">The menu to toggle.</param>
    public void ToggleSubMenu(GameObject menu)
    {
        menu.SetActive(!menu.activeInHierarchy);
    }
}
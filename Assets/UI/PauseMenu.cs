using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

/// <summary>
/// Made by <see href="https://github.com/boTimPact" langword="boTimPact" />
/// </summary>
public class PauseMenu : MonoBehaviour
{
    #region Serialized Fields

    [SerializeField] private GameObject pauseMenu, resumeButton;

    #endregion Serialized Fields

    #region Game Mechanics / Methods

    private void PauseGame()
    {
        GameData.isPaused = true;
        pauseMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(resumeButton);
        Time.timeScale = 0;
    }
        
    public void ResumeGame()
    {
        GameData.isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void GoToMenu()
    {
        Time.timeScale = 1;
        SceneChanger.ChangeScene(0);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
            Application.Quit();
    }
            
    #endregion Game Mechanics / Methods
}

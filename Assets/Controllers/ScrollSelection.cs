using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Made by <see href="https://github.com/boTimPact" langword="boTimPact" />
/// </summary>
public class ScrollSelection : MonoBehaviour
{

    #region Serialized Fields

    [SerializeField] private GameObject content;
    [SerializeField] private ScrollRect scrollRect;
    [SerializeField] private EventSystem eventSystem;

    #endregion Serialized Fields

    #region Fields

    private const int ROWCOUNT = 3;

    #endregion Fields

    #region Game Mechanics / Methods

    private void FocusOnselected()
    {
        int childCount = content.transform.childCount;
        int gameIndex = GetGameIndex(childCount);
        //Debug.Log("Game Index: " + gameIndex);
        int rownumber = gameIndex / ROWCOUNT;
        //Debug.Log("Row number: " + rownumber);
        float scrollPosition = (float) rownumber / (float) (childCount/ROWCOUNT);
        //Debug.Log("Scroll position: " + scrollPosition);
        scrollRect.verticalNormalizedPosition = 1 - scrollPosition;
    }

    private int GetGameIndex(int childCount)
    {
        for (int i = 0; i < childCount; i++)
        {
            Transform child = content.transform.GetChild(i);
            if (child.GameObject().Equals(eventSystem.currentSelectedGameObject))
            {
                return i;
            }
        }

        return -1;
    }

    #endregion Game Mechanics / Methods

    #region Overarching Methods / Helpers

    private void OnEnable()
    {
        MainMenuGame.SelectionChanged += SelectionChanged;
    }

    private void SelectionChanged()
    {
        //Debug.Log("Selection changed");
        FocusOnselected();
    }
            
    private void OnDisable()
    {
        MainMenuGame.SelectionChanged -= SelectionChanged;
    }

    #endregion Overarching Methods / Helpers
}

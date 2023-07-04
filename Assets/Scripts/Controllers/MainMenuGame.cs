using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

    public class MainMenuGame : MonoBehaviour, ISelectHandler
    {
        #region Serialized Fields

            [SerializeField] private Settings settings;
            [SerializeField] private Image preview;
            [SerializeField] private TMP_Text title;

        #endregion Serialized Fields

        #region Fields

        public static event Action SelectionChanged;

        #endregion Fields

        #region Game Mechanics / Methods

        public void OnSelect(BaseEventData eventData)
        {
            //Debug.Log("new Selection");
            SelectionChanged?.Invoke();
        }

        #endregion Game Mechanics / Methods
    }
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Overlay : MonoBehaviour
{
    [SerializeField] private TMP_Text enemyCoin, coinCounter;
    [SerializeField] private Slider enemyHealth, healthBar;

    private void Update()
    {
        enemyCoin.text = GameData.enemyGold.ToString();
        coinCounter.text = GameData.gold.ToString();
        enemyHealth.value = GameData.enemyLives;
        healthBar.value = GameData.live;
    }
}

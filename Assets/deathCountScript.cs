using UnityEngine;
using TMPro;

public class deathCountScript : MonoBehaviour
{
    public TextMeshProUGUI deathCountText;
    public int deathCount;
    private static bool isVisible = true;

    void Awake()
    {
        if (deathCountText == null) // Makes sure code is valid before running
        {
            deathCountText = GetComponent<TextMeshProUGUI>();
        }
    }

    void Update()
    {
        if (deathCountText == null)
        {
            return;
        }

        deathCountText.enabled = isVisible;
        if (isVisible)
        {
            UpdateDeathCountUI(PlayerRespawn.deathCount);
        }
    }

    public static void HideDeathCount()
    {
        isVisible = false; //hides the text
    }
    public static void ShowDeathCount()
    {
        isVisible = true; //shows the text
    }

    void UpdateDeathCountUI(int deathCount)
    {
        deathCountText.text = "Deaths: " + deathCount.ToString();
        // Updates death count text
    }
}


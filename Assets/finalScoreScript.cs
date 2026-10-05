using UnityEngine;
using TMPro;

public class finalScoreScript : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;

    // Update is called once per frame
    void Update()
    {
        finalScore();
    }
    public void finalScore()
    {
        int finalScore = PlayerRespawn.deathCount;
        // Final score is equal to the death count
        GetComponent<TextMeshProUGUI>().text = "Final Score: " + finalScore;
        // Displays the final score on the screen
        finalScoreText.text = "Final Score: " + finalScore;
    }
}

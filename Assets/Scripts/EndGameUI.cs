using UnityEngine;
using TMPro;

public class EndGameUI : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;

    void Start()
    {
        // Lấy điểm đã lưu từ PlayerPrefs ra hiển thị
        int score = PlayerPrefs.GetInt("FinalScore", 0);

        if (finalScoreText != null)
        {
            finalScoreText.text = "Final Score: " + score;
        }
    }
}
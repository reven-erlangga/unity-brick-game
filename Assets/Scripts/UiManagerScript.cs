using UnityEngine;
using UnityEngine.UI;

public class UiManagerScript : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    int score = 0;

    public void IncrementScore() {
        score++;

        scoreText.text = score.ToString();
    }

    public void DecrementScore() {
        score--;

        scoreText.text = score.ToString();
    }
}

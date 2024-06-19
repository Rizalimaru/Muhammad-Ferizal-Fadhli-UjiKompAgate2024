using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;


    private int score;

    private void Awake()
    {

       Instance = this;
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
    }


    public int GetScore()
    {
        return score;
    }

    public void ResetScore()
    {
        score = 0;
    }
}

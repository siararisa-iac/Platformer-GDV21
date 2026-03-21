using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : Singleton<ScoreManager>
{
    [SerializeField]
    private int gameOverSceneIndex = 2;

    public int CurrentScore { get; private set; }

    public void AddScore(int scorePoints)
    {
        CurrentScore += scorePoints;
    }

    public void ResetScore()
    {
        CurrentScore = 0;
    }
}
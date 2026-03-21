using UnityEngine;

// Handles the game flow
public class GameManager : Singleton<GameManager>
{  
    public void StartGame()
    {
        ScoreManager.Instance.ResetScore();

    }

    public void PauseGame()
    {

    }

    public void ResumeGame()
    {

    }

    public void SetEndGameStatus(bool isWin)
    {

    }
}

using UnityEngine;

// Handles the game flow
public class GameManager : Singleton<GameManager>
{
    // We declare that GameEventDelegate can store a function that is a void
    public delegate void GameEventDelegate();

    // We instantiate a "container" for any function that is a void
    public GameEventDelegate OnGameStarted;
    public event GameEventDelegate OnGamePaused;

    // We declared a new delegate type GameEndedEventDelegate and it accepts
    // a function that is a void AND has a paremeter that is a boolean
    public delegate void GameEndedEventDelegate(bool isWin);

    public event GameEndedEventDelegate OnGameEnded;


    private void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        ScoreManager.Instance.ResetScore();
        OnGameStarted?.Invoke();

        // ?. is a shortcut for:
        //if(OnGameStarted != null)
        //{
        //    OnGameStarted.Invoke();
        //}
    }

    public void PauseGame()
    {
        Debug.Log("Pause Game is called");
    }

    public void ResumeGame()
    {

    }

    public void SetEndGameStatus(bool isWin)
    {
        OnGameEnded?.Invoke(isWin);
    }
}

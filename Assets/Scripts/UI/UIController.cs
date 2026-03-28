using System;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private BalanceView balanceView;

    [SerializeField]
    private GameOverView gameOverView;

    private void Start()
    {
        GameManager.Instance.OnGameStarted += HandleGameStart;
        GameManager.Instance.OnGameEnded += HandleGameOver;

        gameOverView.TryAgainButton.onClick.AddListener(OnTryAgainClicked);
        CurrencyManager.Instance.OnCurrencyUpdated += HandleCurrencyUpdated;

        HandleGameStart();
    }

    private void HandleCurrencyUpdated(CurrencyType type, int balance)
    {
        balanceView.GetCurrencyUI(type).TextAmountView.SetAmount(balance);
    }

    private void OnDestroy()
    {
        // For safety purposes, unsubscribe to the event
        if(GameManager.Instance != null)
        {
            GameManager.Instance.OnGameStarted -= HandleGameStart;
            GameManager.Instance.OnGameEnded -= HandleGameOver;
        }
    }

    private void OnTryAgainClicked()
    {
        GameManager.Instance.StartGame();
    }

    private void HandleGameStart()
    {
        gameOverView.gameObject.SetActive(false);
    }

    private void HandleGameOver(bool isWin)
    {
        gameOverView.gameObject.SetActive(true);
        if (isWin)
        {
            gameOverView.SetGameOverMessage("You Win!");
        }
        else
        {
            gameOverView.SetGameOverMessage("Game Over!");
        }
    }
}

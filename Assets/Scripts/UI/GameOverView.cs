using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverView : MonoBehaviour
{
    // Make this a get only property
    public Button TryAgainButton => tryAgainButton;
    /*
    public Button TryAgainButton
    {
        get
        {
            return tryAgainButton;
        }
    }
    */

    [SerializeField]
    private Button tryAgainButton;

    [SerializeField]
    private TextMeshProUGUI gameOverText;

    public void SetGameOverMessage(string message)
    {
        gameOverText.text = message;
    }
}

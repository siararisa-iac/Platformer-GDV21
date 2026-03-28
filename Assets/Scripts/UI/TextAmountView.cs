using TMPro;
using UnityEngine;

public class TextAmountView : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;

    public void SetAmount(int newValue)
    {
        text.text = newValue.ToString();
    }
}

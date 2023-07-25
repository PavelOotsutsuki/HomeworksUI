using UnityEngine;
using TMPro;

public class ButtonTextChanger : MonoBehaviour
{
    [SerializeField] TMP_Text _text;

    public void SetText(string message)
    {
        _text.text = message;
    }
}

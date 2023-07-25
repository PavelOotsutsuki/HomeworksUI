using UnityEngine;
using UnityEngine.UI;

public class ButtonColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;

    private Button[] _buttons;
    private Color _defaultColor;

    private void Start()
    {
        _buttons = GetComponentsInChildren<Button>();

        foreach (Button childButton in _buttons)
        {
            if (childButton.TryGetComponent<Image>(out Image childButtonImage))
            {
                _defaultColor = childButtonImage.color;
                break;
            }
        }
    }

    public void SetColor (Button button)
    {
        if (button.TryGetComponent<Image>(out Image image))
        {
            foreach (Button childButton in _buttons)
            {
                if (childButton.TryGetComponent<Image>(out Image childButtonImage))
                {
                    childButtonImage.color = _defaultColor;
                }
            }

            image.color = _color;
        }
    }
}

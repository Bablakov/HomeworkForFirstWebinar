using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonWithExternalAction : MonoBehaviour
{
    private Button _button;

    public void Initialize(UnityAction actionExitPanel)
    {
        GetComponent();
        AddMethodInEventClick(actionExitPanel);
    }

    protected virtual void GetComponent()
    {
        _button = GetComponent<Button>();
    }

    protected void AddMethodInEventClick(UnityAction action)
    {
        _button.onClick.AddListener(action);
    }
}
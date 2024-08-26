using System;
using Task4.Controllers;
using Task4.Enums;
using UnityEngine;

public class StartPanel : MonoBehaviour
{
    [SerializeField] private ButtonWithExternalAction _buttonStartAllBurst;
    [SerializeField] private ButtonWithExternalAction _buttonStartOneColor;

    public event Action<TypeStart> StartedGame;

    public void Initialize(GameController gameController)
    {
        _buttonStartAllBurst.Initialize(StartAllBurst);
        _buttonStartOneColor.Initialize(StartOneColor);
    }

    private void StartAllBurst()
    {
        StartedGame?.Invoke(TypeStart.AllBurst);
        Disable();
    }

    private void StartOneColor()
    {
        StartedGame?.Invoke(TypeStart.OneColorBurst);
        Disable();
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
}
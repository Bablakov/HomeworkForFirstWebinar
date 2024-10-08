﻿using General.Input;
using System;
using Task4.Balls;
using Task4.Interfaces;
using UnityEngine;

namespace Task4.Players
{
    [RequireComponent(typeof(CharacterController))]
    public class Player : MonoBehaviour, IBallBurster
    {
        public event Action<Ball> BurstedBall;

        [SerializeField, Range(0, 10)] private float _speed;

        private GameInput _gameInput;
        private CharacterController _characterController;
        private bool _isEnabled;

        private void Update()
        {
            if (_isEnabled && _gameInput.CanMovement)
                _characterController.Move(_gameInput.GetDirectionMovememt() * _speed * Time.deltaTime);
        }

        public void Initialize(GameInput gameInput)
        {
            _gameInput = gameInput;

            _characterController = GetComponent<CharacterController>();
        }

        public void ReactBallBurster(Ball ball)
        {
            BurstedBall?.Invoke(ball);
        }

        public void Enable()
        {
            _isEnabled = true;
        }

        public void Disable()
        {
            _isEnabled = false;
        }
    }
}
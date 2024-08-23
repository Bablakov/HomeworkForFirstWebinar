using System;
using Task4.Balls;
using Task4.Interfaces;
using UnityEngine;

namespace Task4.Players
{
    public class Player : MonoBehaviour, IBallBurster
    {
        public event Action<Ball> BurstedBall;

        public void ReactBallBurster(Ball ball)
        {
            BurstedBall?.Invoke(ball);
        }
    }
}
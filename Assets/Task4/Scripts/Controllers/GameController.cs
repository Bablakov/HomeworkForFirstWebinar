using System.Collections.Generic;
using Task4.Players;
using Task4.Balls;
using Task4.Enums;
using UnityEngine;
using Task4.Interfaces;
using Task4.VictoryDeterminant;
using General.Input;
using Assets.Task4.Scripts.Interfaces;
using System.Collections;

namespace Task4.Controllers
{
    public class GameController : MonoBehaviour, IGameStarter
    {
        [SerializeField] private List<Ball> _balls;
        [SerializeField] private Player _player;
        [SerializeField] private StartPanel _startPanel;

        private IVictoryDeterminant _victoryDeterminant;

        private void Awake()
        {
            PlayerInitialize();

            _startPanel.Initialize(this);
        }

        public void GameStart<IVictoryDeterminant>()
        {
            /*switch(IVictoryDeterminant)
                
            _victoryDeterminant = new IVictoryDeterminant(_balls, _player);*/
        }

        public void StartGameWithDestroyAllBall()
        {
            Subscribe();
        }

        public void StartGameWithDestroyAllBallOneColor()
        {
            _victoryDeterminant = new OneColorVictory(_balls, _player);
            Subscribe();
        }

        private void Subscribe()
        {
            _victoryDeterminant.WonGame += OnWonGame;
            _victoryDeterminant.LostGame += OnLostGame;
        }

        private void Unsubscribe()
        {
            _victoryDeterminant.WonGame -= OnWonGame;
            _victoryDeterminant.LostGame -= OnLostGame;
        }

        private void OnWonGame()
        {
            Debug.Log("Победа!!!");
        }

        private void OnLostGame()
        {
            Debug.Log("Поражение (((");
        }

        private void PlayerInitialize()
        {
            GameInput gameInput = new GameInput();
            _player.Initialize(gameInput);
        }
    }
}
using System.Collections.Generic;
using Task4.Players;
using Task4.Balls;
using UnityEngine;
using Task4.Interfaces;
using Task4.VictoryDeterminant;

namespace Task4.Controllers
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private List<Ball> _balls;
        [SerializeField] private Player _player;

        private IVictoryDeterminant _victoryDeterminant;

        private void Awake()
        {
            _victoryDeterminant = new OneColorVictory(_balls, _player);
        }

        private void OnEnable()
        {
            Subscribe();
        }

        private void OnDisable()
        {
            Unsubscribe();
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
        
    }
}
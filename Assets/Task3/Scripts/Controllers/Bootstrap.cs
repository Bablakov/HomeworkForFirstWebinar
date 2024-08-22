using UnityEngine;
using Task3.Iteraction;
using Task3.Traders;

namespace Task3.Controllers
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Trader _reputationTraderIteraction;
        [SerializeField] private Trader _moneyTraderIteraction;
        [SerializeField] private Trader _ageTraderIteraction;

        private void Awake()
        {
            _reputationTraderIteraction.Initialize(new ReputationInteraction());
            _moneyTraderIteraction.Initialize(new MoneyInteraction());
            _ageTraderIteraction.Initialize(new AgeInteraction());
        }
    }
}
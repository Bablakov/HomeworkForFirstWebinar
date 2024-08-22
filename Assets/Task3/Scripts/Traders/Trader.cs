using UnityEngine;
using Task3.Interfaces;

namespace Task3.Traders
{
    public abstract class Trader : MonoBehaviour
    {
        private ITraderIteraction _traderIteraction;

        public void Initialize(ITraderIteraction traderIteraction)
        {
            _traderIteraction = traderIteraction;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out ITradable tradable))
            {
                if (_traderIteraction.DeterminePossibilityInteraction(tradable))
                    Trade();
            }
        }

        protected abstract void Trade();
    }
}
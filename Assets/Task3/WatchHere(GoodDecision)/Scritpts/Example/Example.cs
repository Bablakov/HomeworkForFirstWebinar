using Task3.TraderInteracts;
using Task3.Traders;
using UnityEngine;

namespace Task3.Example
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Trader _trader;

        private void Awake()
        {
            Debug.Log("Теперь я торгую фруктами");
            _trader.SetTraderInteract(new FruitTrader());
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("Теперь я торгую фруктами");
                _trader.SetTraderInteract(new FruitTrader());
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("Теперь я не торгую");
                _trader.SetTraderInteract(new NotSaillingTrader());
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Теперь я торгую бронёй");
                _trader.SetTraderInteract(new ArmorTrader());
            }
        }
    }
}
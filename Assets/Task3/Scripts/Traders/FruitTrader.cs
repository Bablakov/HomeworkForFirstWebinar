using UnityEngine;

namespace Task3.Traders
{
    public class FruitTrader : Trader
    {
        protected override void Trade()
        {
            Debug.Log("Я могу предложить тебе огромный ассортимент фруктов");
        }
    }
}
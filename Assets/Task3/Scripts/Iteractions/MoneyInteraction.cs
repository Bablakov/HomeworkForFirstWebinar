using UnityEngine;
using Task3.Interfaces;

namespace Task3.Iteraction
{
    public class MoneyInteraction : ITraderIteraction
    {
        public bool DeterminePossibilityInteraction(ITradable tradable)
        {
            if (tradable.Money <= 10)
            {
                Debug.Log("Прости, но у тебя слишком мало денег, чтобы купить что-то");
                return false;
            }
            else
            {
                Debug.Log("У тебя достаточно денег, добро пожаловать");
                return true;
            }
        }
    }
}
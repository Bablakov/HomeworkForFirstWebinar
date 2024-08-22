using UnityEngine;
using Task3.Interfaces;

namespace Task3.Iteraction
{
    internal class AgeInteraction : ITraderIteraction
    {
        public bool DeterminePossibilityInteraction(ITradable tradable)
        {
            if (tradable.Age < 18)
            {
                Debug.Log("Прости, но ты слишком мал");
                return false;
            }
            else
            {
                Debug.Log("У тебя достаточный возвраст, для торговли со мной");
                return true;
            }
        }
    }
}
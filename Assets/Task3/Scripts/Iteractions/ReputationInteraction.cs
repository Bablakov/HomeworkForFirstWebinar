using UnityEngine;
using Task3.Interfaces;

namespace Task3.Iteraction
{
    public class ReputationInteraction : ITraderIteraction
    {
        public bool DeterminePossibilityInteraction(ITradable tradable)
        {
            if(tradable.Reputation <= 15)
            {
                Debug.Log("Прости, но у тебя слишком низкая репутация");
                return false;
            }
            else
            {
                Debug.Log("У тебя хорошая репутация, с тобой можно иметь дело");
                return true;
            }
        }
    }
}
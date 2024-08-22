using UnityEngine;
using Task3.Interfaces;

namespace Task3.Player
{
    public class Player : MonoBehaviour, ITradable
    {
        [field: SerializeField, Range(0, 100)] public int Money { get; private set; }
        [field: SerializeField, Range(0, 100)] public int Reputation { get; private set; }
        [field: SerializeField, Range(0, 100)] public int Age { get; private set; }
    }
}
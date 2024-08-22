using UnityEngine;

namespace Task2
{
    public class Bullet : MonoBehaviour
    {
        private float _speed = 5f;

        private void Update()
        {
            transform.position += transform.forward * _speed * Time.deltaTime;
        }
    }
}
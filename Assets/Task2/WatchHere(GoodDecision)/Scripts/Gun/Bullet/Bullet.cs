using UnityEngine;

namespace Task2.Guns
{
    public class Bullet : MonoBehaviour
    {
        private float _speed = 5f;
        private float _timeLife = 3f;

        public void Initialize()
        {
            Destroy(gameObject, _timeLife);
        }

        private void Update()
        {
            transform.position += transform.forward * _speed * Time.deltaTime;
        }
    }
}
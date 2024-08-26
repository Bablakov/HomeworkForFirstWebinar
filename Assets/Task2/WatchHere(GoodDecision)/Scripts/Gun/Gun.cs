using UnityEngine;

namespace Task2.Guns
{
    public abstract class Gun : MonoBehaviour
    {
        [SerializeField] private Bullet _bullet;
        [SerializeField] private Transform _spawnPointBullet;

        public abstract void Shoot();

        protected void SpawnBullet()
        {
            Instantiate(_bullet, _spawnPointBullet.position, _spawnPointBullet.rotation).Initialize();
        }

        protected void SpawnBullet(Vector3 rangePosition, Quaternion rangeRotation)
        {
            Instantiate(_bullet, rangePosition, rangeRotation).Initialize();
        }
    }
}
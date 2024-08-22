using UnityEngine;

namespace Task2
{
    public interface IGunShooter
    {
        void Shoot(Transform spawnPointBullet, Bullet bullet);
    }
}
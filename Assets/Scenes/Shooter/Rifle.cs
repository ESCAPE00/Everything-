using System.Collections;
using UnityEngine;

public class Rifle : Gun
{
    [SerializeField] private float _fireRate;
    [SerializeField] private int _bulletInQueue;


    public override void Shoot()
    {
        if (CurrentReloadTime <= 0)
        {
            StartCoroutine(FiringBurst());
            CurrentReloadTime = ReloadTime;
        }
    }

    public IEnumerator FiringBurst()
    {
        for (var i = 2; i < _bulletInQueue; i++)
        {
            Bullet bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, Quaternion.identity);
            yield return new WaitForSeconds(_fireRate);
        }
    }

}

using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] protected Bullet BulletPrefab;

    [SerializeField] protected float ReloadTime;
    protected float CurrentReloadTime;

    [SerializeField] protected Transform BulletSpawnPoint;

    public virtual void Shoot()
    {
        if (CurrentReloadTime <= 0)
        {
            Bullet bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, Quaternion.identity);
            CurrentReloadTime = ReloadTime;
        }
    }

    private void Update()
    {
        if (CurrentReloadTime > 0)
        {
            CurrentReloadTime -= Time.deltaTime;
        }
    }
}

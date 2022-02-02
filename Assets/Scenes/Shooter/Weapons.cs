using UnityEngine;

public class Weapons : MonoBehaviour
{
    [SerializeField] private Gun _gun;
    public float Speed { get; private set; }

    public void Switch(Gun gun)
    {
        _gun = gun;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        _gun.Shoot();
    }
}

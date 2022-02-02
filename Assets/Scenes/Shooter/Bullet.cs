using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;

    public Rigidbody body;

    

    private void Start()
    {
        body.AddForce(Vector3.forward * _speed * Time.deltaTime);
    }
}

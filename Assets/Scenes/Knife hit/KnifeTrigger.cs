using UnityEngine;

public class KnifeTrigger : MonoBehaviour
{
    private Rigidbody _rigidbody;

    [SerializeField] private bool _knifeAttachedToWood;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Wood"))
        {
            _rigidbody.velocity = Vector3.zero;
            transform.parent = collision.transform;
        }

        if (collision.CompareTag("Knife"))
        {
            if(collision.gameObject.GetComponent<KnifeTrigger>()._knifeAttachedToWood == true)
            {
                _rigidbody.velocity = Vector3.zero;
                _rigidbody.useGravity = true;
                Debug.LogError("You are lose");
            }
        }
    }
}

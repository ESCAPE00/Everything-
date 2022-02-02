using UnityEngine;

public class KnifeHit : MonoBehaviour
{

    [SerializeField] private float _hitForce;
    [SerializeField] private GameObject _knifePrefab;
    private GameObject _knife;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        _knife = Instantiate(_knifePrefab, transform);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _knife.transform.parent = null;
            _knife.GetComponent<Rigidbody>().AddForce(Vector3.up * _hitForce, ForceMode.Impulse);
            _knife = Instantiate(_knifePrefab, transform);
        }
    }
}

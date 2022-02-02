using UnityEngine;

public class WoodRotate : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(0f, _speed, 0f);
    }
}

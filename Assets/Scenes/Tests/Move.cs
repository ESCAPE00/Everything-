using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;

    [SerializeField] private float _speed;
    [SerializeField] private float _jumpHeight;
    private float _horizontal;
    private float _vertical;

    private float _gravity = -9.81f;
    private Vector3 _velocity;

    [SerializeField] private Transform _checkGround;
    [SerializeField] private LayerMask _groundMask;
    [SerializeField] private float _checkDistance;
    private bool _isGround;


    private void Update()
    {
        Movement();
        Gravity();
        GroundCheck();
        Jump();
    }

    private void Movement()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * _horizontal + transform.forward * _vertical;

        _characterController.Move(movement * _speed * Time.deltaTime);
    }

    private void Gravity()
    {
        _velocity.y += _gravity * Time.deltaTime;
        _characterController.Move(_velocity * Time.deltaTime);
    }


    private void GroundCheck()
    {
        _isGround = Physics.CheckSphere(_checkGround.position, _checkDistance, _groundMask);

        if (_isGround && _velocity.y < 0)
        {
            _velocity.y = -2;
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _velocity.y = Mathf.Sqrt(-2 * _jumpHeight * Time.deltaTime);
        }
    }

}

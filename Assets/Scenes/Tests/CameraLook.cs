using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [SerializeField] private float _sensitivity;
    [SerializeField] private Transform _playerBody;

    private float _mouseX;
    private float _mouseY;

    private float _xRotation = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        MouseLook();
    }

    private void MouseLook()
    {
        _mouseX = Input.GetAxis("Mouse X") * _sensitivity * Time.deltaTime;
        _mouseY = Input.GetAxis("Mouse Y") * _sensitivity * Time.deltaTime;

        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
        _xRotation -= _mouseY;

        transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        _playerBody.Rotate(Vector3.up * _mouseX);
    }
}

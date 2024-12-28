using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private float _sensitivity = 2f;
    private float _maxYAngle = 80.0f;
    private float _rotationX = 0.0f;
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");


        transform.parent.Rotate(Vector3.up * mouseX * _sensitivity);


        _rotationX -= mouseY * _sensitivity;
        _rotationX = Mathf.Clamp(_rotationX, -_maxYAngle, _maxYAngle);
        transform.localRotation = Quaternion.Euler(_rotationX, 0.0f, 0.0f);
    }
    
}
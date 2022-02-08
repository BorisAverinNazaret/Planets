using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float sensitivity;

    [SerializeField] private Transform _camera;

    private float _rotationX;

    private void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        transform.Translate(move * speed * Time.deltaTime);

        transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);

        _rotationX -= Input.GetAxis("Mouse Y") * sensitivity;
        _rotationX = Mathf.Clamp(_rotationX, -80, 80);
        _camera.localEulerAngles = new Vector3(_rotationX, 0, 0);
    }
}
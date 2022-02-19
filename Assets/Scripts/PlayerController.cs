using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public float speed_forsag = 1f;
    public float sensitivity = 0f;
    public float sensitivityRotate = 0f;


    [SerializeField] private Transform _camera;

    private float _rotationX=1f;

    private void FixedUpdate()
    {
        if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
        {
            //          if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) speed_forsag = 3; else speed_forsag = 1;
            if (Input.GetKey("0")) speed_forsag = 0;
            if (Input.GetKey("1")) speed_forsag = 1;
            if (Input.GetKey("2")) speed_forsag = 4;
            if (Input.GetKey("3")) speed_forsag = 50;

            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
            transform.Translate(move * speed * speed_forsag * Time.deltaTime);
            transform.Rotate(Input.GetAxis("Mouse Y") * sensitivityRotate, Input.GetAxis("Mouse X") * sensitivityRotate, 0);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey("a"))
            {
            //    Debug.Log("sfgsdg");
            //     _rotationX -= Input.GetKey("y")  * sensitivity;
            //     _rotationX = Mathf.Clamp(_rotationX, -80, 80);
            //    _camera.localEulerAngles = new Vector3(_rotationX * sensitivity, 0, 0);
                _camera.localEulerAngles = new Vector3(0, 0, _rotationX * sensitivity);
            }
        }
    }

}
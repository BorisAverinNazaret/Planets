using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public float sensitivity = 2f;
    public float sensitivityRotateMouse = 4f;

    public float RotationSpeed = 50f;
    public float dumpAmt = 2f;

    [SerializeField] private Transform _camera;

    //  private float _rotationX=1f;


    private void FixedUpdate()
    {
        if (Input.GetKey("0")) speed = 0f;
        if (Input.GetKey("1")) speed = 1f; 
        if (Input.GetKey("4")) speed = 25.5f;
        if (Input.GetKey("5")) speed = 50f;

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            if (Input.GetKey("w") && Input.GetKey(KeyCode.LeftShift))
                transform.Rotate((Vector3.forward * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);
            if (Input.GetKey("s") && Input.GetKey(KeyCode.LeftShift))
                transform.Rotate((Vector3.back * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);
            if (Input.GetKey("a") && Input.GetKey(KeyCode.LeftShift))
                transform.Rotate((Vector3.left * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);
            if (Input.GetKey("d") && Input.GetKey(KeyCode.LeftShift))
                transform.Rotate((Vector3.right * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        transform.Translate((move * speed) * (Time.deltaTime * sensitivity));

        transform.Rotate(Input.GetAxis("Mouse Y") * sensitivityRotateMouse, Input.GetAxis("Mouse X") * sensitivityRotateMouse, 0);



        if (Input.GetKey("a") && 1==2)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                // _rotationX -= Input.GetKey("y")  * sensitivity;
                // _rotationX = Mathf.Clamp(_rotationX, -80, 80);
                // _camera.localEulerAngles = new Vector3(_rotationX * sensitivity, 0, 0);
                // _camera.localEulerAngles = new Vector3(0, 0, _rotationX * sensitivity);
            }
        }
    }

}
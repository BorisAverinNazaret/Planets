using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0f;
    public float sensitivity = 0f;
    public float sensitivityRotate = 0f;


    [SerializeField] private Transform _camera;

    private float _rotationX=1f;

    public float RotationSpeed = 30f;
    public float dumpAmt = 2f;


    private void FixedUpdate()
    {

        if (Input.GetKey("0")) speed = 0;
        if (Input.GetKey("1")) speed = 1;
        if (Input.GetKey("2")) speed = 4;
        if (Input.GetKey("3")) speed = 30;



        if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
        {
            //          if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) speed_forsag = 3; else speed_forsag = 1;
         

            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
            transform.Translate(move * speed * Time.deltaTime);

            transform.Rotate(Input.GetAxis("Mouse Y") * sensitivityRotate, Input.GetAxis("Mouse X") * sensitivityRotate, 0);
        }


        if (Input.GetKey("w") && Input.GetKey(KeyCode.LeftShift))
            transform.Rotate((Vector3.forward * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);
        if (Input.GetKey("s") && Input.GetKey(KeyCode.LeftShift))
            transform.Rotate((Vector3.back * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);
        if (Input.GetKey("a") && Input.GetKey(KeyCode.LeftShift))
            transform.Rotate((Vector3.left * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);
        if (Input.GetKey("d") && Input.GetKey(KeyCode.LeftShift))
            transform.Rotate((Vector3.right * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);



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
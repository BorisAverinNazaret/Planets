using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public float sensitivity = 2f;
    public float sensitivityRotateMouse = 4f;

    public float RotationSpeed = 50f;
    public float dumpAmt = 2f;

    [SerializeField] private Transform spaceship;
    //    [SerializeField] private Transform _camera;

    //  private float _rotationX=1f;
    private float ad_LR=0f, ws_FB=0f;


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {

            if (Input.GetKey("a") && Input.GetKey(KeyCode.LeftShift))
                transform.Rotate((Vector3.forward * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);
            if (Input.GetKey("d") && Input.GetKey(KeyCode.LeftShift))
                transform.Rotate((Vector3.back * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);
        }
        else 
        {
            if (Input.GetKey("0")) speed = 0f;
            if (Input.GetKey("1")) speed = 1f;
            if (Input.GetKey("2")) speed = 25f;
            if (Input.GetKey("3")) speed = 50f;
            if (Input.GetKey("4")) speed = 100f;
            if (Input.GetKey("5")) speed = 1000f;
            Debug.Log(ad_LR);
            if (Input.GetKey("a")) ad_LR = ad_LR == 1f ? 0f : -1f; 
     //       ComputeBuffer.
            if (Input.GetKey("d")) ad_LR = ad_LR == -1f ? 0f : 1f;
            if (Input.GetKey("w")) ws_FB = 1f;
            if (Input.GetKey("s")) ws_FB = -1f;
        }

        //     Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        //        transform.Translate((move * speed) * (Time.deltaTime * sensitivity));
        transform.Translate((new Vector3(ad_LR, 0f, ws_FB) * speed) * (Time.deltaTime * sensitivity));


        transform.Rotate(Input.GetAxis("Mouse Y") * sensitivityRotateMouse, Input.GetAxis("Mouse X") * sensitivityRotateMouse, 0);


    }

}
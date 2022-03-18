
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public float sensitivity = 2f;
    public float sensitivityRotateMouse = 4f;

    public float RotationSpeed = 50f;
    public float dumpAmt = 2f;

    [SerializeField] private Transform spaceship;

    private Camera camSkybox, camMain, camBack;

    //  private float _rotationX=1f;
    private float ad_LR=0f, ws_FB=0f;


    private void FixedUpdate()
    {


        if (Input.GetKeyDown(KeyCode.F))
        {
            camMain.enabled = !camMain.enabled;
            camBack.enabled = !camBack.enabled;
        }


        if (Input.GetKey("q"))
            transform.Rotate((Vector3.forward * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);
        if (Input.GetKey("e")) 
            transform.Rotate((Vector3.back * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);


        if (Input.GetKeyDown("`")) speed = 0f;
        if (Input.GetKeyDown("0")) speed = 0f;
        if (Input.GetKeyDown("1")) speed = 1f;
        if (Input.GetKeyDown("2")) speed = 5f;
        if (Input.GetKeyDown("3")) speed = 25f;
        if (Input.GetKeyDown("4")) speed = 125f;
        if (Input.GetKeyDown("5")) speed = 1000f;



        if (Input.GetKeyDown("a")) ad_LR = ad_LR == 0f ? -1f : 0f;
        if (Input.GetKeyDown("d")) ad_LR = ad_LR == 0f ?  1f : 0f;


        if (Input.GetKeyDown("w")) ws_FB = 1f;
        if (Input.GetKeyDown("s")) ws_FB = -1f;
      

        //     Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        //        transform.Translate((move * speed) * (Time.deltaTime * sensitivity));
        transform.Translate((new Vector3(ad_LR, 0f, ws_FB) * speed) * (Time.deltaTime * sensitivity));


        transform.Rotate(Input.GetAxis("Mouse Y") * sensitivityRotateMouse, Input.GetAxis("Mouse X") * sensitivityRotateMouse, 0);


    }

}

//  if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
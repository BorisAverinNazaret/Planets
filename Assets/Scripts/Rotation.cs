using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation({ float RotationSpeed; float dumpAmt; }) : MonoBehaviour
{
    public float RotationSpeed = 3f;
    public float dumpAmt = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate((Vector3.right * RotationSpeed) * (Time.deltaTime * dumpAmt),Space.Self);
    }
}

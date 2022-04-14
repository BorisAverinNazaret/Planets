using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraController : MonoBehaviour
{
    /*
    1. Вид из рубки с корабля
    2. Свободный вид с  корабля
    3. Вид назад
    3.1  Установка новых камер образованных из свободного вида

    */

    private Camera camSkybox, camMain, camBack;


    //  Вращение камерой
    public float sensitivityRotateMouse = 4f;

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            camMain.enabled = !camMain.enabled;
            camBack.enabled = !camBack.enabled;
        }

        // Направление, выбор мышом      Debug.Log("rr");
        transform.Rotate(Input.GetAxis("Mouse Y") * sensitivityRotateMouse, Input.GetAxis("Mouse X") * sensitivityRotateMouse, 0);
    }
}

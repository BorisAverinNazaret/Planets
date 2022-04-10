﻿using System;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public float sensitivity = 2f;
    public float sensitivityRotateMouse = 4f;

    public float RotationSpeed = 0f;
    public float dumpAmt = 2f;

    [SerializeField] private Transform spaceship;

    private Camera camSkybox, camMain, camBack;

    //  private float _rotationX=1f;
    private float ad_LR=0f, ws_FB=0f;


    private void Update()
    {
        if(RotationSpeed != 0f)
            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("e"))

                transform.Rotate((Vector3.back * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);
        transform.Rotate((Input.GetKey("e") ? Vector3.forward : Vector3.back * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);

    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            camMain.enabled = !camMain.enabled;
            camBack.enabled = !camBack.enabled;
        }

        // передне-задний тормоз
        if (Input.GetKeyDown("`")) speed = 0f;
        if (Input.GetKeyDown("0")) speed = 0f;
 //       Debug.Log("rr");

        // Перевороты
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey("q") || Input.GetKey("e"))) 
            {
            Debug.Log("----------");
            Debug.Log(RotationSpeed);
            if (Input.GetKey("q")) RotationSpeed = Math.Abs(RotationSpeed + 20f);
            if (Input.GetKey("e")) RotationSpeed = Math.Abs(RotationSpeed - 20f);
            Debug.Log(RotationSpeed);
        };
      //  transform.Rotate((Input.GetKey("e") ? Vector3.forward : Vector3.back * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);



        // if (Input.GetKey("e")) transform.Rotate((Vector3.back * RotationSpeed) * (Time.deltaTime * dumpAmt), Space.Self);




        // выбор направления вращения
        if (Input.GetKeyDown("a")) ad_LR = ad_LR == 0f ? -1f : 0f;
        if (Input.GetKeyDown("d")) ad_LR = ad_LR == 0f ? 1f : 0f;











        if (Input.GetKeyDown("w")) ws_FB = ws_FB == 0f ? -1f : 0f;
        if (Input.GetKeyDown("s")) ws_FB = ws_FB == 0f ?  1f : 0f;


        //     Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        //        transform.Translate((move * speed) * (Time.deltaTime * sensitivity));
        transform.Translate((new Vector3(ad_LR, 0f, ws_FB) * speed) * (Time.deltaTime * sensitivity));

        // Направление, выбор мышом
        transform.Rotate(Input.GetAxis("Mouse Y") * sensitivityRotateMouse, Input.GetAxis("Mouse X") * sensitivityRotateMouse, 0);


    }
}

//  if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))

/*
using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
//Переменные ***************************************************
  public float horizontalSpeed = 2.0F;
     public float verticalSpeed = 2.0F;
  public float speed = 1f;  
  private Transform myTransform;
//**************************************************************
   
  void Start(){
   myTransform = transform; // оптимизация
   Screen.showCursor = false; //убрать курсор
  }
   
     void Update() {     
         float h = horizontalSpeed * Input.GetAxis("Mouse X");
         float v = verticalSpeed * Input.GetAxis("Mouse Y");
    
         myTransform.Rotate(v, h, 0);

   }
     }

------------------------------------------------------------------
а вот самого корабля
------------------------------------------------------------------

using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {
  //пременные***************************************
  public Transform target;//цель
  public int moveSpeed; //скорость перемещения
  public int rotationSpeed; //скорость поворота
  public float rot = 1.0f;
   
  private Transform myTransform ;//временная переменная для хранения ссылки
                    //на свойство transform (это оптимизация)
  //************************************************
  void Awake (){
        //ссылаемся на свойство transform для того чтобы сократить время
        //обращения к нему в скрипте
        myTransform = transform;
  }

  // начальная инициализация
  void Start () {
        //ищем обьект по тегу Player
        GameObject go = GameObject.FindGameObjectWithTag("aim");
        //и делаем его целью
        target = go.transform;    
  }
   
  // Update is called once per frame
  void Update () {
   //чертим вспомогательную линию от нас к игроку
   Debug.DrawLine(target.position, myTransform.position,
                      Color.yellow);
   //поворачивемся в сторону игрока
   myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
                       Quaternion.LookRotation(target.position - myTransform.position),
                       rotationSpeed * Time.deltaTime);
   //усли позволяет дистанция двигаемся к игроку
   if(moveSpeed >0){
   //двигаемся к цели
   myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;  
    
   rot = -5*Input.GetAxis("Mouse X");
   myTransform.Rotate(0,0,rot);
   }
  }
}
*/
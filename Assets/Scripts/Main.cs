using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Spaceship;
using UnityEditor;

public class Main : MonoBehaviour
{
    //    Звук
    //    public GameObject audio_object;
    //    private AudioSource[] my_audio;
    //    my_audio = audio_object.GetComponents<AudioSource>();
    //    GetComponent<AudioSource>().Play();


    //   public AudioClip myClip;
    //   void Start()
    //   {
    //   audio.PlayOneShot(myClip);




    public int samplerate = 44100;
    public float frequency = 440;


    public const float ae  = 149597870.691f; //149597870.691f;
    public       float aeg = 10000f;





    public static GameObject CENTRE;

    public static Camera camSkybox, camMain, camBack;

    void Start()
    {
        //  Объект визуализации центра
        CENTRE = ObjectFactory.CreatePrimitive(PrimitiveType.Sphere);
        CENTRE.name = "CENTRE";
        CENTRE.transform.position = Vector3.zero ;
        CENTRE.transform.localScale = new Vector3(0.06f, 0.06f, 0.06f);
        Renderer rend = CENTRE.GetComponent<Renderer>();
        rend.material.color = Color.yellow; 
        // mainTexture = Resources.Load("Red") as Texture;



        //     CENTRE.AddComponent<AudioSource>();
   

        /*
                //    Create(string name, int lengthSamples, int channels, int frequency, bool stream);
                AudioClip myClip = AudioClip.Create("flight", 500000, 1, 44100, false);
                AudioSource aud = CENTRE.GetComponent<AudioSource>();
                aud.volume /= 2;
                aud.loop    = true;

                aud.clip    = myClip;
                aud.Play();

        */

        Spaceship.Generation();

        Renderer rend = CENTRE.GetComponent<Renderer>();
        rend.material.color = Color.red;
        // mainTexture = Resources.Load("Red") as Texture;



        camMain = GetComponent<Camera>();
        camMain = Camera.main;
        //  camSkybox.farClipPlane = 100000f;



        camSkybox = GetComponent<Camera>();




        camBack = GetComponent<Camera>();



        /*
                CameraSkybox.name = "CameraSkybox";
                CameraSkybox.transform.localEulerAngles = new Vector3(0f, 0f, 60f);
                //   CameraSkybox.targetDisplay. = target;

        */


        camMain.transform.parent = spaceship.transform;
        camMain.transform.localPosition = new Vector3(spaceship.transform.position.x, spaceship.transform.position.y+3f, spaceship.transform.position.z-5f);










        // временно
        aeg = 10000; // 149 597 870.691f;

        // Наклонение к плоскости Млечного Пути    60,19°

        Planet.Generation("P000",    700f, 0f, 0f, 0f);          //  R 696000,7 км
        Planet.Generation("P100",  2.439f, 0f, 0f, aeg * 0.387f);//  R   2439,7 км  L 0,386ае     m 0,055274 земной v 47,36 км/с  накл-ние 3,38°  относительно солн. экватора
        Planet.Generation("P200",  6.051f, 0f, 0f, aeg * 0.723f);//  R   6051,8 km  L 0,72333199  m 0,815    земной v 35,02 км/с  накл-ние 3,86°
        Planet.Generation("P300",  6.365f, 0f, 0f, aeg);         //  R   6365,0 km  L 1,00000261  m 1        земной v 29,79 км/с  накл-ние 7,155°
        Planet.Generation("P400",  3.385f, 0f, 0f, aeg * 1.524f);//  R   3385,0 km  L 1,5235      m 0,107    земной v 24,13 км/с  накл-ние 5,65°
        Planet.Generation("P500", 69.911f, 0f, 0f, aeg * 5.203f);//  R  69911,0 km  L 5,2042665   m 317,8    земной v 13,07 км/с  накл-ние 6,09°  Наклон оси 3,13°
        Planet.Generation("P600", 60.1f,   0f, 0f, aeg * 9.539f);
        Planet.Generation("P700",  5.35f,  0f, 0f, aeg * 19.19f);
        Planet.Generation("P800",  5.9f,   0f, 0f, aeg * 30.06f);

        
    }
    private void FixedUpdate() 
    {

    }
}

/*
GameObject.CreatePrimitive.

Sphere Capsule Cylinder Cube Plane Quad
Selection.activeGameObject = ObjectFactory.CreatePrimitive(PrimitiveType.Cube);


public GameObject hand;
hand = GameObject.Find("Hand");





*/

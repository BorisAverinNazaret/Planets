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


    public const float ae  = 149597870.691f;
    public const float aeg = 1000f;

    public static GameObject CENTRE;

    public static Spaceship sp;

    void Start()
    {

        CENTRE = ObjectFactory.CreatePrimitive(PrimitiveType.Cube);
        CENTRE.name = "CENTRE";
        CENTRE.transform.position = Vector3.zero ;
        CENTRE.transform.localScale = new Vector3(6f, 4f, 9f);
        CENTRE.AddComponent<AudioSource>();
    //    CENTRE.AddComponent<Renderer>();

        Renderer rend = CENTRE.GetComponent<Renderer>();
        rend.material.color = Color.red; // mainTexture = Resources.Load("Red") as Texture;




        //    Create(string name, int lengthSamples, int channels, int frequency, bool stream);
        AudioClip myClip = AudioClip.Create("Track 09", 500000, 1, 44100, false);
        AudioSource aud = CENTRE.GetComponent<AudioSource>();
        aud.volume /= 2;
        aud.loop    = true;

        aud.clip    = myClip;
        aud.Play();





        Spaceship.Generation();


        Camera.main.transform.parent = spaceship.transform;
//      Camera.main.transform.localPosition = Vector3.zero;
        Camera.main.transform.localPosition = new Vector3(spaceship.transform.position.x, spaceship.transform.position.y+3f, spaceship.transform.position.z-5f);





        Camera.main.farClipPlane = 1000000f;

        // 0.387   57894
        Planet.Generation("P000",   700f, 0f, 0f, 0f);
        Planet.Generation("P100",     30f,  0f, 0f, aeg * 0.387f);
        Planet.Generation("P200",     60f,  0f, 0f, aeg * 0.723f);
        Planet.Generation("P300",     65f,  0f, 0f, aeg);
        Planet.Generation("P400",     30f,  0f, 0f, aeg * 1.524f);
        Planet.Generation("P500",  100.8f,  0f, 0f, aeg * 5.203f);
        Planet.Generation("P500",   90.1f,  0f, 0f, aeg * 9.539f);
        Planet.Generation("P500",  50.35f,  0f, 0f, aeg * 19.19f);
        Planet.Generation("P500",   50.9f,  0f, 0f, aeg * 30.06f);

        
    }
    private void FixedUpdate() 
    {

    }
}

/*
GameObject.CreatePrimitive.

Sphere Capsule Cylinder Cube Plane Quad

CreateSystemPlanets

Selection.activeGameObject = ObjectFactory.CreatePrimitive(PrimitiveType.Cube);


public GameObject hand;
hand = GameObject.Find("Hand");

        // This returns the GameObject named Hand.
        // Hand must not have a parent in the Hierarchy view.
        hand = GameObject.Find("/Hand");




*/

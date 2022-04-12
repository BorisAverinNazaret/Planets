using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



public class Planet 

{
    public GameObject planet;

    [SerializeField] public string fname; /* {get{return fname;} set{fname = value;}}*/

    public Planet(string name, float radius, Vector3 _Vector3)
    {

        planet = ObjectFactory.CreatePrimitive(PrimitiveType.Sphere);

        planet.transform.position = _Vector3;
        planet.name = name;
        planet.transform.localScale = new Vector3(radius, radius, radius);

        planet.AddComponent<Rigidbody>();
        planet.GetComponent<Rigidbody>().isKinematic = true;
        planet.GetComponent<Rigidbody>().detectCollisions = true;

        planet.GetComponent<SphereCollider>().radius = radius + 20;
        planet.GetComponent<SphereCollider>().isTrigger = true;

        planet.GetComponent<Renderer>().material.color = Color.red;


    }




}



/*

Debug.Log($"Модуль вектора: {transform.position.magnitude}, квадрат модуля {transform.position.sqrMagnitude}, напровление вектора {transform.position.normalized}");
Debug.DrawRay(Vector3.zero, Vector3.up, Color.black);


public static void SetSuundplanet(GameObject objName, string soundName)
    {
        
        //    Create(string name, int lengthSamples, int channels, int frequency, bool stream);
    AudioSource aud =  planet.GetComponent<AudioSource>();
    AudioClip myClip =  AudioClip.Create("Track 09", 500000, 1, 44100, false);
    aud.volume /= 2;
    aud.loop = true;

    aud.clip = myClip;
    aud.Play();
        
    }
*/




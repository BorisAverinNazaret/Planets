using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



public class Planet : MonoBehaviour

{
    public GameObject planet;

    [SerializeField] public string name; /* {get{return name;} set{name = value;}}*/

    public Planet(string nameL, float radius, float x, float y, float z)
    {

        planet = ObjectFactory.CreatePrimitive(PrimitiveType.Sphere);

        planet.transform.position = new Vector3(x, y, z);
        planet.name = nameL;
        planet.transform.localScale = new Vector3(radius, radius, radius);

        planet.AddComponent<Rigidbody>();
        planet.GetComponent<Rigidbody>().isKinematic = true;
        planet.GetComponent<Rigidbody>().detectCollisions = true;

        planet.GetComponent<SphereCollider>().radius = radius + 20;
        planet.GetComponent<SphereCollider>().isTrigger = true;

        planet.GetComponent<Renderer>().material.color = Color.red;
    }


        public static void SetSuundplanet(GameObject objName, string soundName)
    {
        /*
         //    Create(string name, int lengthSamples, int channels, int frequency, bool stream);
        AudioSource aud =  planet.GetComponent<AudioSource>();
        AudioClip myClip =  AudioClip.Create("Track 09", 500000, 1, 44100, false);
        aud.volume /= 2;
        aud.loop = true;

        aud.clip = myClip;
        aud.Play();
        */
    }

}



/*

 Debug.Log($"Модуль вектора: {transform.position.magnitude}, квадрат модуля {transform.position.sqrMagnitude}, напровление вектора {transform.position.normalized}");

        Debug.DrawRay(Vector3.zero, Vector3.up, Color.black);




*/

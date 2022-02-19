using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;




public class Planet : MonoBehaviour
{
    public static GameObject planet; 
    public static float x,y,z;

    public void GalaxyCenter(float x, float y, float z) { }
    public void SystemCenter(object parent, float x, float y, float z) { }



    public static void Generation(string name, float radius, float x, float y, float z)
    {
     //   hand.transform.position = Vector3.zero;


        planet = ObjectFactory.CreatePrimitive(PrimitiveType.Sphere);
    
        planet.transform.position = new Vector3(x,y,z);
        planet.name = name;
        planet.transform.localScale = new Vector3(radius, radius, radius) ;
        planet.AddComponent<SphereCollider>();
        planet.GetComponent<SphereCollider>().radius = radius+100;
        planet.GetComponent<SphereCollider>().isTrigger = true;

        planet.AddComponent<Rigidbody>();
        planet.GetComponent<Rigidbody>().isKinematic = true;



        // hand = GameObject.Find("Hand").;


    }


}



/*

 Debug.Log($"Модуль вектора: {transform.position.magnitude}, квадрат модуля {transform.position.sqrMagnitude}, напровление вектора {transform.position.normalized}");

        Debug.DrawRay(Vector3.zero, Vector3.up, Color.black);



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

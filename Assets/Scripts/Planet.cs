using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;




public class Planet : MonoBehaviour
{
    public static GameObject hand;

    public void GalaxyCenter(float x, float y, float z) { }
    public void SystemCenter(object parent, float x, float y, float z) { }



    public static void Generation(string name, float r, float distance)
    {
        hand = Selection.activeGameObject = ObjectFactory.CreatePrimitive(PrimitiveType.Sphere);
     //   hand.transform.position = Vector3(0f, 0f, 0f);
        hand.transform.position=Vector3.zero;
        hand.name = name; 

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

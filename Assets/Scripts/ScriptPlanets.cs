using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

public class ScriptPlanets : MonoBehaviour
{
    public GameObject hand;

    void Start()
    {
        hand = Selection.activeGameObject = ObjectFactory.CreatePrimitive(PrimitiveType.Sphere);
        hand.transform.position = Vector3.zero;
        hand.name = "yyy";

        // hand = GameObject.Find("Hand").;




        ObjectFactory.CreatePrimitive(PrimitiveType.Sphere);
  
    }


    void Update()
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

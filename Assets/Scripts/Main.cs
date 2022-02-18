using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static Planet;

using UnityEditor;

public class Main : MonoBehaviour
{
    public const float ae  = 149597870.691f;
    public const float aeg = 1000f;
    void Start()
    {
        // солнце 695500
        //     
        Planet.Generation("P000", 695f, 0f, 0f, 0f);
        Planet.Generation("P100",           3f,  0f, 0f, aeg * 0.387f);
        Planet.Generation("P200",        6.05f,  0f, 0f, aeg * 0.723f);
        Planet.Generation("P300",       6.371f,  0f, 0f, aeg);
        Planet.Generation("P400",         3.4f,  0f, 0f, aeg * 1.524f);
        Planet.Generation("P500",        70.8f,  0f, 0f, aeg * 5.203f);
        Planet.Generation("P600",        60.1f,  0f, 0f, aeg * 9.539f);
        Planet.Generation("P700",       25.35f,  0f, 0f, aeg * 19.19f);
        Planet.Generation("P800",        24.9f,  0f, 0f, aeg * 30.06f);
        //   Planet.Generation("Z", 10f, new Vector3(5, 0, 5));
        //   Debug.Log((4.87/2)+ (4.87%2));

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

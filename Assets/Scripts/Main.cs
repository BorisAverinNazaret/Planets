using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Main : MonoBehaviour
{
    public const float ae  = 149597870.691f;
    public const float aeg = 1000f;


    public static GameObject spaceship;

    void Start()
    {

        Spaceship.Generation();



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

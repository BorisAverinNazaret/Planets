﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static Planet;

using UnityEditor;

public class Main : MonoBehaviour
{
    void Start()
    {
            




        Planet.Generation("Centre", 0f, 0f);
        Planet.Generation("Sun", 10f, 20f);
    }


    void FixedUpdate()
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
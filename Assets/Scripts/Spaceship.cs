using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Spaceship : MonoBehaviour 
{
    public static GameObject spaceship;

    public void Spaceship()






    {
        // Sphere Capsule Cylinder Cube Plane Quad
        spaceship = ObjectFactory.CreatePrimitive(PrimitiveType.Cube);
        spaceship.name                  = "spaceship";
        spaceship.transform.localScale  = new Vector3(0.009f, 0.004f, 0.006f);

        spaceship.transform.position    = Vector3.zero;
        spaceship.transform.position = new Vector3(0, 0, -1000);
        spaceship.transform.Rotate(new Vector3(0,45,0));

        Renderer rendSpaceship = spaceship.GetComponent<Renderer>();
        rendSpaceship.material.color = Color.red;
        // mainTexture = Resources.Load("Red") as Texture;
 
        spaceship.AddComponent<Rigidbody>();
        spaceship.GetComponent<Rigidbody>().isKinematic = true;
        spaceship.GetComponent<BoxCollider>().size = new Vector3(0.009f, 0.004f, 0.006f);
        spaceship.GetComponent<BoxCollider>().isTrigger = true;
        spaceship.AddComponent<PlayerController>();
    }










}

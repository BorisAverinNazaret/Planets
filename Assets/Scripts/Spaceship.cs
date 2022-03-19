using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Spaceship : MonoBehaviour
{

    public static GameObject spaceship;


    public static void Generation()
    {
        // Sphere Capsule Cylinder Cube Plane Quad
        spaceship = ObjectFactory.CreatePrimitive(PrimitiveType.Cube);
        spaceship.name                  = "spaceship";
        spaceship.transform.localScale  = new Vector3(0.006f, 0.004f, 0.009f);

        spaceship.transform.position    = Vector3.zero;
        spaceship.transform.position = new Vector3(-1000, 0, 0);
        spaceship.transform.Rotate(new Vector3(0,90,0) * Time.deltaTime);

        Renderer rendSpaceship = spaceship.GetComponent<Renderer>();
        rendSpaceship.material.color = Color.red;
        // mainTexture = Resources.Load("Red") as Texture;
 
        spaceship.AddComponent<Rigidbody>();
        spaceship.GetComponent<Rigidbody>().isKinematic = true;
        spaceship.GetComponent<BoxCollider>().size = new Vector3(0.006f, 0.004f, 0.009f);
        spaceship.GetComponent<BoxCollider>().isTrigger = true;
        spaceship.AddComponent<PlayerController>();


    }

    /*
       camMain.transform.parent = spaceship.transform;
        camMain.transform.localPosition = new Vector3(spaceship.transform.position.x, spaceship.transform.position.y+3f, spaceship.transform.position.z-5f);

*/






}

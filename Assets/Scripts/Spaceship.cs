using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Spaceship : MonoBehaviour
{

    public static GameObject spaceship;

    public static void Generation()
    {
        spaceship = ObjectFactory.CreatePrimitive(PrimitiveType.Cube);
     
        spaceship.transform.position = new Vector3(3000, 0, 2000);
        spaceship.name = "spaceship";
        spaceship.transform.localScale = new Vector3(90, 20, 60);
        spaceship.AddComponent<BoxCollider>();
        spaceship.GetComponent<BoxCollider>().size = new Vector3(90, 20, 60);
        spaceship.GetComponent<BoxCollider>().isTrigger = true;

        spaceship.AddComponent<Rigidbody>();
        spaceship.GetComponent<Rigidbody>().isKinematic = true;

        .transform.parent = spaceship.transform;

    }


}

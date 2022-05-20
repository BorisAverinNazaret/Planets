using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class spaceship // : MonoBehaviour 
{

    //write this in your class
    //public GameObject myGameObject;

    //write this in your function:
    //var instance = myGameObject.GetComponent<ApiPost>();


    //public static GameObject Spaceship;

    public spaceship()
    {
        // Sphere Capsule Cylinder Cube Plane Quad


        GameObject Spaceship = new GameObject();



        Spaceship = ObjectFactory.CreatePrimitive(PrimitiveType.Cube);

        Spaceship.AddComponent<MonoBehaviour>();
        Spaceship.GetComponent<MonoBehaviour>();

        Spaceship.name                  = "Spaceship";
        Spaceship.transform.localScale  = new Vector3(0.009f, 0.004f, 0.006f);

        Spaceship.transform.position    = Vector3.zero;
        Spaceship.transform.position = new Vector3(0, 0, -1000);
        Spaceship.transform.Rotate(new Vector3(0,45,0));

        Renderer rendSpaceship = Spaceship.GetComponent<Renderer>();
        rendSpaceship.material.color = Color.red;
        // mainTexture = Resources.Load("Red") as Texture;
 
        Spaceship.AddComponent<Rigidbody>();
        Spaceship.GetComponent<Rigidbody>().isKinematic = true;
        Spaceship.GetComponent<BoxCollider>().size = new Vector3(0.009f, 0.004f, 0.006f);
        Spaceship.GetComponent<BoxCollider>().isTrigger = true;
        Spaceship.AddComponent<PlayerController>();
    }


   // Автоматическое удаление объекта 
   // ~spaceship() {Debug.Log("Ded spaceship");}








}

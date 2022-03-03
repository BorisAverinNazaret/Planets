using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Spaceship : MonoBehaviour
{

    public static GameObject spaceship;
  //  private Transform _camera;
  //  private Camera CameraMain;

    public static void Generation()
    {
        spaceship                       = ObjectFactory.CreatePrimitive(PrimitiveType.Cube);
        spaceship.name                  = "spaceship";
        spaceship.transform.localScale  = new Vector3(6f, 4f, 9f);

        spaceship.transform.position    = Vector3.zero;
        // spaceship.transform.position    = new Vector3(3000, 0, -2000);
        // spaceship.transform.Rotate(new Vector3(0,180,0) * Time.deltaTime);

        spaceship.AddComponent<Rigidbody>();
        spaceship.GetComponent<Rigidbody>().isKinematic = true;
        
        spaceship.GetComponent<BoxCollider>().size = new Vector3(6f, 4f, 9f);
        spaceship.GetComponent<BoxCollider>().isTrigger = true;

        spaceship.AddComponent<PlayerController>();
      //  spaceship.GetComponent<PlayerController>()._camera = spaceship.;


    }


}

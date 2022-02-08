
using System.Collections;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speed;
    public float rotateSpeedY;

    private int _direction;


    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            _direction = Random.Range(-1, 2);
        }
    }

    private void Update()
    {
        transform.Rotate(0, _direction * rotateSpeedY * Time.deltaTime, speed * Time.deltaTime);
    }
}
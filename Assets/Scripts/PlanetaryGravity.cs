using UnityEngine;

public class PlanetaryGravity : MonoBehaviour
{
    public float gravityForce;
    [SerializeField] private Transform _planet;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 gravity = (transform.position - _planet.position);
        transform.rotation = Quaternion.FromToRotation(transform.up, gravity) * transform.rotation;
        _rigidbody.AddForce(gravity * gravityForce * Time.deltaTime);
    }
}
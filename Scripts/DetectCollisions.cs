using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public float Radius = 10;
    public float Power = 10;
    public void OnCollisionEnter(Collision collision)
    {
        Vector3 ExplosionPosition = transform.position;
        if(collision.gameObject.CompareTag("Hazard"))
        {
            Collider[] BarrelColliders = Physics.OverlapSphere(ExplosionPosition, Radius);
            foreach (Collider Hit in BarrelColliders)
            {
                Rigidbody RigidB = Hit.GetComponent<Rigidbody>();
                if (RigidB != null)
                {
                    RigidB.AddExplosionForce(Power, ExplosionPosition, Radius, 3.0f, ForceMode.Impulse);
                }
            }
        }
        Destroy(this.gameObject);
    }
}

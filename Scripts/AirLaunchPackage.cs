using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirLaunchPackage : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rb;
    public void Initialize(Vector3 Velocity)
    {
        _rb.AddForce(Velocity, ForceMode.Impulse);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    private Rigidbody _boxBody;
    [SerializeField]
    private float _forceSpeed;
    [SerializeField]
    private float _torqueSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _boxBody = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _boxBody.AddRelativeForce(0f, _forceSpeed, _forceSpeed, ForceMode.Force);
        _boxBody.AddTorque(transform.right * _torqueSpeed, ForceMode.Force);
    }
}

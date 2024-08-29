using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    [SerializeField]
    private List<WheelCollider> _wheelColliders;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void VisualTransformChange(WheelCollider wheelCOL)
    {
        Transform Visual = wheelCOL.transform.GetChild(0);
        Vector3 Position;
        Quaternion Rotation;

        wheelCOL.GetWorldPose(out Position, out Rotation);
        Visual.transform.position = Position;
        Visual.transform.rotation = Rotation;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (WheelCollider collider in _wheelColliders)
        {
            VisualTransformChange(collider);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField]
    private int _customForce = 0;
    private ConstantForce _conForce;
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            CreateNewForce();
        }
    }

    void CreateNewForce()
    {
        _conForce = GetComponent<ConstantForce>();
        if(_conForce != null)
        {
            _conForce.force = new Vector3(0, _customForce, 0);
        }
    }
}

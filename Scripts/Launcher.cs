using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField]
    private AirLaunchPackage _box;
    [SerializeField]
    private float _power = 10f;
    [SerializeField]
    private LabComplete _labCheck;
    [SerializeField]
    private SimulatedPhysics _simPhys;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void Update()
    {
        _simPhys.ProjectorySim(_box, transform.position, transform.forward * _power);

       if (Input.GetKeyDown(KeyCode.Space))
        {
               var SpawnedBox = Instantiate(_box, transform.position, transform.rotation);
               SpawnedBox.transform.parent = SpawnedBox.transform.root;
               SpawnedBox.Initialize(transform.forward * _power);
               _labCheck.isCriteriaMet = true; 
        } 
    }
}

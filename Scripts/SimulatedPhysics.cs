using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SimulatedPhysics : MonoBehaviour
{
    private Scene _SimScene;
    private PhysicsScene _physScene;
    [SerializeField]
    private Transform _labParent;
    
    // Start is called before the first frame update
    void Start()
    {
        _labParent.transform.parent = gameObject.transform.parent.root;

        AddPhysicsScene();
    }

    private void AddPhysicsScene() 
    {
        _SimScene = SceneManager.CreateScene("SimulatedPhysics", new CreateSceneParameters(LocalPhysicsMode.Physics3D));
        _physScene = _SimScene.GetPhysicsScene();

        foreach(Transform obstacle in _labParent)
        {
            if (obstacle.CompareTag("Obstacle"))
            {
                var SimObstacle = Instantiate(obstacle.gameObject, obstacle.position, obstacle.rotation);
                if(obstacle.GetComponent<Renderer>() != null) 
                {
                    obstacle.GetComponent<Renderer>().enabled = false;
                }

                SceneManager.MoveGameObjectToScene(SimObstacle, _SimScene);
            }
        }
    }
    public void ProjectorySim(AirLaunchPackage prefab, Vector3 pos, Vector3 velocity)
    {
        var SimObj = Instantiate(prefab, pos, Quaternion.identity);
      //  SimObj.GetComponent<Renderer>().enabled = false;
        SceneManager.MoveGameObjectToScene(SimObj.gameObject, _SimScene);
        SimObj.Initialize(transform.forward * 5);
    }
}

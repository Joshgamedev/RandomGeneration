using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{

    public float raycastDistance = 100f;
    public GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        positionRaycast();

    }

        void positionRaycast()

        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDistance))
            {
            Quaternion spawnRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
            GameObject clone = Instantiate(objectToSpawn, hit.point, spawnRotation);
            }

            Debug.Log(" I did smth");
        }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner: MonoBehaviour


{

    public float Radius = 1;
    public float numberOfObjects = 0;
    public float objectsspawned = 0;
    public GameObject obstacle;

    

    // Start is called before the first frame update

void Start()                    
{
             StartCoroutine(SpawnMyShiz());

             GameObject Obstacle = Instantiate (obstacle, transform);
}

void Update()
{
        CheckSpawned();
}

IEnumerator SpawnMyShiz()
{
        Vector3 randomPos = Random.insideUnitCircle * Radius;
        Instantiate (obstacle, randomPos, Quaternion.identity);
        objectsspawned ++;
             //Wait Time
             yield return new WaitForSeconds(1f);
             //Go Again
             StartCoroutine(SpawnMyShiz());

}

void CheckSpawned()
{
        if(objectsspawned == numberOfObjects)
        {
        Debug.Log("Max reached");
        //StopCoroutine(SpawnMyShiz());
        StopAllCoroutines();
        }
}
private void OnDrawGizmos() 
{
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, Radius);
}

}
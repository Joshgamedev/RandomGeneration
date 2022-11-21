using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Generator : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject[] objectPrefabs;
    

    public List<GameObject> SpawnPoints = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoints"); 

        for(int i = 0; i < spawnPoints.Length; i++){
			SpawnPoints.Add (spawnPoints[i]);
		}
        for (int i = 0; i < SpawnPoints.Count; i++){
            SpawnPoints.RemoveAt(Random.Range(0, SpawnPoints.Count - 1));
        }
        StartCoroutine (GenerateAllFancy());

                 
                    //Debug works here//
    } 

            IEnumerator GenerateAllFancy() {
        for(int i = 0; i < SpawnPoints.Count; i++){
            if (i == 0){
                GameObject FirstItem = Instantiate(objectPrefabs[Random.Range(0,objectPrefabs.Length)], SpawnPoints[i].transform);
                FirstItem.GetComponent<Renderer>().material.color = new Color (1f, 0.5f, 0f);
                yield return new WaitForSeconds(0.5f);

                // Debug.Log doesnt work here//
            } 
            
            else if ( i == SpawnPoints.Count-1) {
                GameObject LastItem = Instantiate(objectPrefabs[Random.Range(0,objectPrefabs.Length)], SpawnPoints[i].transform);
                LastItem.GetComponent<Renderer>().material.color = new Color (1f, 0.5f, 0f);
                yield return new WaitForSeconds(0.5f);
            } 
            else {
                Instantiate(objectPrefabs[Random.Range(0,objectPrefabs.Length)], SpawnPoints[i].transform);
                yield return new WaitForSeconds(0.5f);

                    
                
                //Debug.Log doesnt work here//
            }
		}

    }

    void Update()
    {
            if (Input.GetKeyDown(KeyCode.F)){
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(scene.name);
        }
         // This works.
    }
}

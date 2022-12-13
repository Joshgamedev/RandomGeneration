using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World_Generate : MonoBehaviour
{
    public GameObject Room;
    public GameObject SpawnPoints;


    public GameObject spawner;

    public GameObject SpawnPoint;
    public int gridX;
    public int gridY;
    public float generateTime;

   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WorldSpawn());
 Debug.Log ("GameObject SpawnPoints has fired"); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(scene.name);
        }
    }


/*     float JoshRandomNumber = Random.Range (0f,1f); //will generate a decimal

    if (JoshRandomNumber <= 0.30f) {

    } */
    

  
     
    IEnumerator WorldSpawn()
    {
        for(int i = 0; i < gridX; i++)
        {
            for(int j = 0; j < gridY; j++)
            {
                GameObject room = Instantiate(Room, spawner.transform);
                room.transform.parent = null;
                spawner.transform.position = new Vector3(transform.position.x, 0, transform.position.z + 1000);
                yield return new WaitForSeconds(generateTime);
            }

            spawner.transform.position = new Vector3(transform.position.x + 1000, transform.position.y, 0);
        }

       
    }
}

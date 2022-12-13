using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RobsPlayground : MonoBehaviour
{

    public GameObject floor;
    public GameObject coin;
    public GameObject wall;

    public GameObject Obstacle; 
    public GameObject player;

    public GameObject Roof;


    public Material materials;
    private Material wallcolor;

    public GameObject spawner;

    public float Radius = 1;

    private float floorSizeX, floorSizeZ;

    public int floorSizeMin, floorSizeMax, roomHeight;

    // Start is called before the first frame update
    void Start()
    {
        // coin spawn //

        /*for (int i = 0; i < numCoins; i++)
        {
            GameObject Coin = Instantiate(coin, transform);
            
        }
        */

        //Coin Spawner
        GameObject Spawner = Instantiate(spawner, transform);
        //Make the floor
        GameObject roomFloor = Instantiate (floor, transform);

        //Determine floor size
        floorSizeX = Random.Range (floorSizeMin, floorSizeMax);
        floorSizeZ = Random.Range (floorSizeMin, floorSizeMax);

        roomFloor.transform.localScale = new Vector3 (floorSizeX, 1, floorSizeZ);
        roomFloor.transform.position = new Vector3 (roomFloor.transform.position.x, roomFloor.transform.position.y - roomHeight/2, roomFloor.transform.position.z);


        //Set the wall paremters

        Color newColor = new Color (Random.Range (0, 1f), Random.Range (0, 1f), Random.Range (0, 1f), 1.0f);
        materials.SetColor ("_Color", newColor);
        wallcolor = materials;
    

        //make the walls
        GameObject roomWallL = Instantiate (wall, transform);
        roomWallL.transform.position = new Vector3 (roomWallL.transform.position.x - (floorSizeX/2) * 10f, roomWallL.transform.position.y, roomWallL.transform.position.z);
        roomWallL.transform.localScale = new Vector3 (roomWallL.transform.localScale.x, roomHeight, floorSizeZ * 10f);
        roomWallL.GetComponent<MeshRenderer>().material = wallcolor;


        GameObject roomWallR = Instantiate (wall, transform);
        roomWallR.transform.position = new Vector3 (roomWallR.transform.position.x + (floorSizeX/2) * 10f, roomWallR.transform.position.y, roomWallR.transform.position.z);
        roomWallR.transform.localScale = new Vector3 (roomWallR.transform.localScale.x, roomHeight, floorSizeZ * 10f);
        roomWallR.GetComponent<MeshRenderer>().material = wallcolor;

        GameObject roomWallT = Instantiate (wall, transform);
        roomWallT.transform.position = new Vector3 (roomWallT.transform.position.x, roomWallT.transform.position.y, roomWallT.transform.position.z + (floorSizeZ/2) * 10f);
        roomWallT.transform.localScale = new Vector3 (floorSizeX * 10f, roomHeight, roomWallT.transform.transform.localScale.z);
        roomWallT.GetComponent<MeshRenderer>().material = wallcolor;

        GameObject roomWallB = Instantiate (wall, transform);
        roomWallB.transform.position = new Vector3 (roomWallB.transform.position.x, roomWallB.transform.position.y, roomWallB.transform.position.z - (floorSizeZ/2) * 10f);
        roomWallB.transform.localScale = new Vector3 (floorSizeX * 10f, roomHeight, roomWallB.transform.transform.localScale.z);
        roomWallB.GetComponent<MeshRenderer>().material = wallcolor;

        

        // Make the roof

        GameObject roomRoof = Instantiate (Roof, transform);

        roomRoof.transform.localScale = new Vector3 (floorSizeX, 1, floorSizeZ);
        roomRoof.transform.position = new Vector3 (roomRoof.transform.position.x, roomRoof.transform.position.y + roomHeight/2, roomRoof.transform.position.z);
          

                // spawn Obstacle

                
            
            if (Input.GetKeyDown(KeyCode.Space))

            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range( -10, 11), 5, Random.Range( -10, 11));
                Instantiate (coin,randomSpawnPosition, Quaternion.identity);
            }

        // spawn player

        GameObject Player = Instantiate(player, transform);

        


    }

    // Update is called once per frame

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }
            /*if(Input.GetKeyDown(KeyCode.Space)) SpawnObjectAtRandom();    
    }
            void SpawnObjectAtRandom() 
            {
             Vector3 randomPos = Random.insideUnitCircle * Radius;
             Instantiate (coin, randomPos, Quaternion.identity);
            }
            
             private void OnDrawGizmos() {
                
                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(this.transform.position, Radius);
                
            }*/

        }
        
    }
    

              

   


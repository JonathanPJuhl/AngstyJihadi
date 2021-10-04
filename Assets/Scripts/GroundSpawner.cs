using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTileSystem;
    public GameObject edge;
    public GameObject metalBox;
    public GameObject woodenBox;
    public int mapSize;
    public int boxFrequency;
    Vector3 SpawnPoint;

  //Make method for setting sizes in UI

    private void Start()
    {
        SpawnPlane(5, 10);
    }

    public void SpawnPlane(float mapSize, int boxFrequency)
    {
        SpawnPoint.x = (mapSize * 5);
        SpawnPoint.y = 0;
        SpawnPoint.z = (-mapSize * 5);
        
        groundTileSystem.transform.localScale = new Vector3(mapSize, 1f, mapSize);
        GameObject temp = Instantiate(groundTileSystem, SpawnPoint, Quaternion.identity);

        SpawnEdges(mapSize, new Vector3(1,2, mapSize * mapSize * 2), new Vector3(-0.5f, 0.5f, -mapSize * mapSize));
        SpawnEdges(mapSize, new Vector3(mapSize * mapSize * 2, 2, 1), new Vector3(mapSize * mapSize, 0.5f, -mapSize * mapSize *2 + 0.5f));
        SpawnEdges(mapSize, new Vector3(mapSize * mapSize * 2, 2 , 1), new Vector3(mapSize * mapSize, 0.5f, 0.5f));
        SpawnEdges(mapSize, new Vector3(1, 2 , mapSize * mapSize * 2), new Vector3(mapSize * mapSize * 2 -0.5f, 0.5f, -mapSize * mapSize));
        SpawnHardBoxes(mapSize, 2, 4);
        SpawnWoodenBoxes(2,5);
    }

    public void SpawnEdges(float mapSize, Vector3 scale, Vector3 position)
    {
        GameObject obstacleToSpawn = edge;
        
        GameObject temp = Instantiate(obstacleToSpawn, transform);
        temp.transform.localScale = scale;
        temp.transform.position = position;
    }
    public void SpawnHardBoxes(float mapSize, int low, int high)
    {
        GameObject obstacleToSpawn = metalBox;

        int toughness;
       
        for (float z = -1.5f; z >= -mapSize * mapSize * 2; z += -toughness)
        {  
             toughness = Random.Range(low, high);
          
            for (float x = 1.5f; x <= mapSize * mapSize * 2; x += toughness)
            {
                toughness = Random.Range(low, high);

                Vector3 position;
                position.x = x;
                position.z = z;
                position.y = 0.5f;

                GameObject temp = Instantiate(obstacleToSpawn, transform);
                temp.transform.position = position;
            }
        }
    }

    public void SpawnWoodenBoxes(int low, int high)
    {
        GameObject obstacleToSpawn = woodenBox;
        int toughness;

        for (float z = -2.5f; z > -mapSize * mapSize * 2; z -= toughness)
        {
            toughness = Random.Range(low, high);

            for (float x = 2.5f; x < mapSize * mapSize * 2; x += toughness)
            {
                toughness = Random.Range(low, high);
                Vector3 position;
                position.x = x;
                position.z = z;
                position.y = 0.5f;

                GameObject temp = Instantiate(obstacleToSpawn, transform);

                temp.transform.position = position;
            }
        }

    }
}

using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTileSystem;
    public GameObject metalBox;
    public int mapSize;
    public int boxFrequency;
    Vector3 SpawnPoint;

  //Make method for setting sizes in UI

    private void Start()
    {
        SpawnPlane(5, 50);
        SpawnHardBoxes(5);
    }

    public void SpawnPlane(float mapSize, int boxFrequency)
    {
        SpawnPoint.x = (mapSize * 5);
        SpawnPoint.y = 0;
        SpawnPoint.z = (-mapSize * 5);
        
        groundTileSystem.transform.localScale = new Vector3(mapSize, 1f, mapSize);
        GameObject temp = Instantiate(groundTileSystem, SpawnPoint, Quaternion.identity);
        
    }

    public void SpawnHardBoxes(float mapSize)
    {
        GameObject obstacleToSpawn = metalBox;
        
        for (float z = -1.5f; z > -mapSize * mapSize * 2; z += -2)
        {   
            for (float x = 1.5f; x < mapSize * mapSize * 2; x += 2)
            {
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

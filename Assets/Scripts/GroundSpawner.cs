using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTileSystem;
    public GameObject metalBox;
    public int mapSize;
    public int boxFrequency;
    Vector3 SpawnPoint;

  //Make method for setting saizes in UI

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
        Debug.Log(SpawnPoint.ToString());
        
        groundTileSystem.transform.localScale = new Vector3(mapSize, 1f, mapSize);
        Debug.Log(groundTileSystem.transform.localScale.ToString());
        GameObject temp = Instantiate(groundTileSystem, SpawnPoint, Quaternion.identity);
        
    }

    public void SpawnHardBoxes(float mapSize)
    {
        GameObject obstacleToSpawn = metalBox;
        Debug.Log( -1.5 < (float)(-mapSize * mapSize));
        
        for (float z = -1.5f; z > -mapSize * mapSize * 2; z += -2)
        {   
            Debug.Log("HEY1");
        
            for (float x = 1.5f; x < mapSize * mapSize * 2; x += 2)
            {Debug.Log("HEY2");
                Vector3 position;
                position.x = x;
                position.z = z;
                position.y = 0.5f;

                GameObject temp = Instantiate(obstacleToSpawn, transform);

                temp.transform.position = position;
            }
        }
        //GameObject obstacleToSpawn = metalBox;

        //float z = -1.5f;
        //int counter = 0;

        //for (float x = 1.5f; x < mapSize*mapSize; x += 2)
        //{
        //    if (x >= mapSize*10 - 1.5)
        //    {
        //        x = 1.5f;
        //        z = -1.5f;
        //    }
        //    Vector3 position;
        //    position.x = x;
        //    position.z = z;
        //    position.y = 0f;

        //    GameObject temp = Instantiate(obstacleToSpawn, transform);

        //    temp.transform.position = position;

        //    z -= 2;

        //    counter++;
        //}
    }

    public void FF()
    {
        GameObject obstacleToSpawn = metalBox;

        int counter = 0;

        for(float z = 1.5f; z < mapSize*mapSize; z += -2) {

        for (float x = 1.5f; x < mapSize * mapSize; x += 2)
        {
            if (x >= mapSize * 10 - 1.5)
            {
                x = 1.5f;
                z = -1.5f;
            }
            Vector3 position;
            position.x = x;
            position.z = z;
            position.y = 0f;

            GameObject temp = Instantiate(obstacleToSpawn, transform);

            temp.transform.position = position;

            counter++;
            }
        }
    }
}

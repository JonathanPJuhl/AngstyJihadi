using UnityEngine;

public class GroundTile : MonoBehaviour
{


    GroundSpawner groundSpawn;
    [SerializeField] GameObject MetalBox;


    // Start is called before the first frame update
    void Start()
    {
        groundSpawn = GameObject.FindObjectOfType<GroundSpawner>();

    }

    public void SpawnHardBoxes(float mapSize)
    {
        GameObject obstacleToSpawn = MetalBox;

        float z = -1.5f;
        int counter = 0;
        for (float x = 1.5f; counter < mapSize; x+=2)
        {
            if (x >= mapSize-1.5)
            {
                x = 1.5f;
                z = -1.5f;
            }
            Vector3 position;
            position.x = x;
            position.z = z;
            position.y = 0f;
            //Instantiate(obstacleToSpawn, position, Quaternion.identity, transform);
            GameObject temp = Instantiate(obstacleToSpawn, transform);
            temp.transform.position = position;
            z -= 2;
            counter++;
        }
        // Instantiate(obstacleToSpawn, spawnpoint.position, Quaternion.identity, transform);
    }


    //public void SpawnCoins()
    //{
    //    int amountOfCoins = 10;
    //    for (int i = 0; i < amountOfCoins; i++)
    //    {
    //        GameObject temp = Instantiate(coinPrefab, transform);
    //        temp.transform.position = CoinSpawnPoint(GetComponent<Collider>());
    //    }
    //}
    //Vector3 CoinSpawnPoint(Collider collider)
    //{
    //    Vector3 point = new Vector3(
    //        Random.Range(collider.bounds.min.x, collider.bounds.max.x),
    //        Random.Range(collider.bounds.min.y, collider.bounds.max.y),
    //        Random.Range(collider.bounds.min.z, collider.bounds.max.z)
    //        );
    //    if (point != collider.ClosestPoint(point))
    //    {
    //        point = CoinSpawnPoint(collider);
    //    }
    //    point.y = 1;
    //    return point;
    //}
}

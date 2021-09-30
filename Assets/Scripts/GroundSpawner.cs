using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTileSystem;
    public int mapSize;
    public int boxFrequency;
    Vector3 SpawnPoint;

    private void Update()
    {
        SpawnPlane(mapSize, boxFrequency);
    }

    public void SpawnPlane(int mapSize, int boxFrequency)
    {
        SpawnPoint.x = (mapSize / 2);
        SpawnPoint.y = 0;
        SpawnPoint.x = (-mapSize / 2);
        GameObject temp = Instantiate(groundTileSystem, SpawnPoint, Quaternion.identity);

        temp.GetComponent<GroundTile>().SpawnHardBoxes(50);


        //if (spawnItems)
        //{
        //    temp.GetComponent<GroundTile>().SpawnObstacle();
        //    temp.GetComponent<GroundTile>().SpawnCoins();
        //}
    }

}

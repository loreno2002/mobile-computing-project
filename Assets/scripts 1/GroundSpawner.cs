
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    // Start is called before the first frame update
    void SpawnTile()
    {
        GameObject temp= Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

    }

    // Update is called once per frame
    private void Start()
    {
        SpawnTile();
        SpawnTile();
        SpawnTile();
        SpawnTile();

        SpawnTile();

    }
}

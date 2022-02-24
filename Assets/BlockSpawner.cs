using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public Transform[] spawns;
    public GameObject blockPrefab;
    public float spawnTime = 2f;
    public float timeBetweenWaves = 2f;

    // Start is called before the first frame update
    void SpawnBlocks()
    {
        int missingSpawn = Random.Range(0, spawns.Length);

        for(int i = 0; i < spawns.Length; i++) {
            if(missingSpawn != i) {
                Instantiate(blockPrefab, spawns[i].position, Quaternion.identity);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime) {
            SpawnBlocks();
            spawnTime = Time.time + timeBetweenWaves;
        }
    }
}

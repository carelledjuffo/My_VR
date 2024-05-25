using System.Collections;
using UnityEngine;

public class MoleManager : MonoBehaviour
{
    public GameObject molePrefab; // The mole prefab
    public int moleCount = 5; // The number of moles
    public float spawnRadius = 10; // The radius within which the moles can spawn

    private GameObject[] moles; // The array of moles

    void Start()
    {
        // Initialize the moles array
        moles = new GameObject[moleCount];

        // Spawn the moles
        for (int i = 0; i < moleCount; i++)
        {
            SpawnMole(i);
        }
    }

    public void RespawnMole(GameObject mole)
    {
        // Find the index of the mole in the moles array
        int index = System.Array.IndexOf(moles, mole);

        // Start the respawn coroutine
        StartCoroutine(RespawnAfterDelay(index, 5));
    }

    private void SpawnMole(int index)
    {
        // Generate a random position within the spawn radius
        Vector3 position = Random.insideUnitSphere * spawnRadius;
        position.y = 0; // Keep the mole on the ground

        // Instantiate the mole at the random position
        moles[index] = Instantiate(molePrefab, position, Quaternion.identity);
    }

    private IEnumerator RespawnAfterDelay(int index, float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Destroy the old mole
        Destroy(moles[index]);

        // Spawn a new mole
        SpawnMole(index);
    }
}
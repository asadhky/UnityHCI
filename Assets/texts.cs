using UnityEngine;

public class DeleteAndRespawn : MonoBehaviour
{
    public float destroyDelay = 3f;
    public float respawnDelay = 10f;

    void Start()
    {
        Invoke("DestroyAndRespawn", destroyDelay);
    }

    void DestroyAndRespawn()
    {
        // Destroy the GameObject after the destroy delay
        Destroy(gameObject);
        
        // Invoke the Respawn method after the respawn delay
        Invoke("Respawn", respawnDelay);
    }

    void Respawn()
    {
        // Instantiate a new instance of the GameObject after the respawn delay
        Instantiate(gameObject, Vector3.zero, Quaternion.identity);
    }
}

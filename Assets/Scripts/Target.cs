using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject hitParticlesPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Cible touchée !");

            Instantiate(
                hitParticlesPrefab,
                transform.position,
                Quaternion.identity
            );

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
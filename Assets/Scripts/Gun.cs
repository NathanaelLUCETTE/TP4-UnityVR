using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header("Gun")]
    public Transform firePoint;

    [Header("Bullet")]
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;

    public void Fire()
    {
        // Crée une balle au niveau du FirePoint
        GameObject bullet = Instantiate(
            bulletPrefab,
            firePoint.position,
            firePoint.rotation
        );

        // Récupère le Rigidbody de la balle
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        // Propulse la balle vers l'avant
        rb.AddForce(
            firePoint.forward * bulletSpeed,
            ForceMode.Impulse
        );

        // Détruit la balle après 5 secondes
        Destroy(bullet, 5f);
    }
}
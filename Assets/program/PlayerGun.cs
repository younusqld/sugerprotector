using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float rotationSpeed = 100f;

    void Update()
    {
        // Rotate gun with A/D or arrow keys
        float h = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward, -h * rotationSpeed * Time.deltaTime);

        // Clamp rotation between -90 and +90 degrees
        float z = transform.eulerAngles.z;
        if (z > 180) z -= 360;
        z = Mathf.Clamp(z, -90f, 90f);
        transform.eulerAngles = new Vector3(0, 0, z);

        // Shoot with Spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}

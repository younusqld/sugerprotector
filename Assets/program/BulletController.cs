using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1;

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime, Space.Self);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Ant ant = other.GetComponent<Ant>();
        if (ant != null)
        {
            ant.TakeDamage(damage);
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Destroy(gameObject, 3f);
    }
}

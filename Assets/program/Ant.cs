using UnityEngine;

public class Ant : MonoBehaviour
{
    public int health = 3;       // 3 hits to die
    public float speed = 2f;

    void Update()
    {
        // move downwards
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        void OnTriggerEnter2D(Collider2D collision)
        {
            // If ant touches the base → disappear
            if (collision.CompareTag("Base"))
            {
                Destroy(gameObject);
            }
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}

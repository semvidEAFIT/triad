using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public float health = 100;
    public Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    public float GetHeath()
    {
        return health;
    }

    public void SetDamage(float damage)
    {
        health = health - damage;
        renderer.material.color = Color.white + Color.red * (health / 100f);
        if (health <= 0)
            Destroy(gameObject);
    }
}

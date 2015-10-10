using UnityEngine;

namespace Triad.Warriors
{
    public class Health : MonoBehaviour
    {

        public float health = 100;
        public new Renderer renderer;

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
            renderer.material.color = renderer.material.color + Color.red * (health / 100f);
            if (health <= 0)
                Destroy(gameObject);
        }
    }
}
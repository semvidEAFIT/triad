using System.Collections;
using UnityEngine;

namespace Triad.Warriors
{
    public class Health : MonoBehaviour
    {

        public float health = 100;
        public new Renderer renderer;
        private bool isInvincible;
        public float timeInvincible = 2f;


        private void Awake()
        {
            renderer = GetComponent<Renderer>();
            isInvincible = false;
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

        public void onHit(float damage) {
            if (health > 0 && !isInvincible)
            {
                health = health - damage;
                if (health <= 0)
                    Destroy(gameObject);
                isInvincible = true;
                StartCoroutine(BlinkCharacter());
                StartCoroutine(StopBlinking());
            }
        }

        public IEnumerator BlinkCharacter()
        {
            while (isInvincible)
            {
                renderer.enabled = false;
                yield return new WaitForSeconds(.1f);
                renderer.enabled = true;
                yield return new WaitForSeconds(.1f);
            }
        }

        IEnumerator StopBlinking()
        {
            yield return new WaitForSeconds(timeInvincible);
            isInvincible = false;
            renderer.enabled = true;
        }
    }
}
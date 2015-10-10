using UnityEngine;
using System.Collections;
using System;

namespace Triad.Warriors.Skills
{
    public class SwordAttack : MonoBehaviour, ISkill
    {
        public Collider col;
        public float swingTime = 1f;
        public int damage;

        public void Cast()
        {
            if (!col.enabled)
            {
                col.enabled = true;
                StartCoroutine(TurnOffCollider());
            }
        }

        private IEnumerator TurnOffCollider()
        {
            yield return new WaitForSeconds(swingTime);
            col.enabled = false;
        }

        private void OnTriggerEnter(Collider c)
        {
            if (c.CompareTag("Enemy"))
                c.GetComponent<Health>().SetDamage(damage);
        }
    }
}
using UnityEngine;
using System.Collections;
using System;

public class SwordAttack : MonoBehaviour, ISkill
{
    public Collider col;
    public float swingTime = 4f;

    public void Cast()
    {
        col.enabled = true;
        StartCoroutine(TurnOffCollider());
    }

    private IEnumerator TurnOffCollider()
    {
        yield return new WaitForSeconds(swingTime);
        col.enabled = false;
    }
}
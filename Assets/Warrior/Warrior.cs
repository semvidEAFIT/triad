using System;
using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

[RequireComponent(typeof(CharacterController))]
public class Warrior : MonoBehaviour
{
    [SerializeField] private CharacterController charControl;
    [SerializeField] private SkillCaster caster;

    public void Move(Vector3 motion)
    {
        charControl.SimpleMove(motion);
    }

    public void Aim(Vector3 direction)
    {
        transform.LookAt(transform.position + direction);
    }

    public void Attack()
    {
        caster.Attack();
    }
}

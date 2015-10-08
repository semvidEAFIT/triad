using UnityEngine;
using System.Collections;

public class SkillCaster : MonoBehaviour
{
    [SerializeField]
    private SwordAttack skill;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private string attackTrigger;

    public void Attack()
    {
        skill.Cast();
        animator.SetTrigger(attackTrigger);
    }
}
using UnityEngine;
using System.Collections;

public class SkillCaster : MonoBehaviour
{
    [SerializeField]
    private SwordAttack skill;

    public void Attack()
    {
        skill.Cast();
    }
}
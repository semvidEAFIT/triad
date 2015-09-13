using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class Triad : MonoBehaviour, IInputListener
{
    [SerializeField]
    private Warrior[] warriors;

    [SerializeField]
    private Structure structure;

    public float speed;

    private void Start()
    {
        InputController.Instance.Listeners.Add(this);
    }

    public void Attack(EAttack[] attack)
    {
        //TODO: Implement Skill Casting 
    }

    public void Motion(Vector2 motion)
    {
        Vector3 v = new Vector3(motion.x, 0, motion.y);
        structure.Move(v * speed, warriors);
    }

    public void Aim(Vector2 direction)
    {
        Vector3 v = new Vector3(direction.x, 0, direction.y);
        structure.Aim(v, warriors);
    }
}

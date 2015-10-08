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

    public Warrior[] Warriors
    {
        get { return warriors; }
    }

    private void Start()
    {
        InputController.Instance.Listeners.Add(this);
    }

    public void Attack(EAttack[] attack)
    {
        foreach (EAttack a in attack)
        {
            warriors[(int)a].Attack();
        }
    }

    public void Motion(Vector2 direction)
    {
        Vector3 v = new Vector3(direction.x, 0, direction.y);
        structure.Move(v);
    }

    public void Aim(Vector2 direction)
    {
        Vector3 v = new Vector3(direction.x, 0, direction.y);
        structure.Aim(v);
    }
}

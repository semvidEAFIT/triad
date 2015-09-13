using UnityEngine;
using System.Collections;

public interface IInputListener
{
    void Motion(Vector2 motion);
    void Attack(EAttack[] attack);
    void Aim(Vector2 direction);
}

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public abstract class Structure : MonoBehaviour
{
    [SerializeField]
    protected CharacterController charController;

    public abstract void Move(Vector3 motion, Warrior[] warriors);
    public abstract void Aim(Vector3 direction, Warrior[] warriors);
}

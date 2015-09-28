using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public abstract class Structure : MonoBehaviour
{
    [SerializeField]
    protected CharacterController charController;
    public Triad triad;

    public abstract void Move(Vector3 direction);
    public abstract void Aim(Vector3 direction);
}

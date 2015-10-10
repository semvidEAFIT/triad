using UnityEngine;
using System.Collections;

namespace Triad.Warriors.Movement
{
    [RequireComponent(typeof(CharacterController))]
    public abstract class Structure : MonoBehaviour
    {
        [SerializeField]
        protected CharacterController charController;
        public Motion[] motors;

        public abstract void Move(Vector3 direction);
        public abstract void Aim(Vector3 direction);
    }
}
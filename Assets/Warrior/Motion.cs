using UnityEngine;
using Triad.Warriors.Skills;

namespace Triad.Warriors
{
    [RequireComponent(typeof(CharacterController))]
    public class Motion : MonoBehaviour
    {
        [SerializeField]
        private CharacterController charControl;
        [SerializeField]
        private Animator animator;
        [SerializeField]
        private string speedTrigger;

        public void Move(Vector3 motion)
        {
            charControl.SimpleMove(motion);
            animator.SetFloat(speedTrigger, motion.sqrMagnitude);
        }

        public void Aim(Vector3 direction)
        {
            transform.LookAt(transform.position + direction);
        }
    }
}
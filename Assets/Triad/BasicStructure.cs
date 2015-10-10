using UnityEngine;
using System;


namespace Triad.Warriors.Movement
{
    public class BasicStructure : Structure
    {
        public float distance = 4f;
        public float speed = 8f;
        public float rootSpeed = 10;

        public override void Move(Vector3 direction)
        {
            charController.SimpleMove(direction * rootSpeed);
        }

        public override void Aim(Vector3 direction)
        {
            transform.LookAt(transform.position + direction);
            foreach (Motion w in motors)
            {
                w.Aim(direction);
            }
        }

        void Update()
        {
            Vector3 direction = transform.forward;
            foreach (Motion w in motors)
            {
                Vector3 shouldBe = transform.position + direction * distance;
                Vector3 motion = (shouldBe - w.transform.position) * speed;
                w.Move(motion);
                direction = Quaternion.AngleAxis(120, Vector3.up) * direction;
            }
        }
    }
}

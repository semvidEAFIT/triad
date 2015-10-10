using UnityEngine;
using System.Collections;
using System;
using Triad.Controls;
using Triad.Warriors.Movement;
using Triad.Warriors.Skills;

namespace Triad.Warriors
{
    [Serializable]
    public class Triad : MonoBehaviour, IInputListener
    {
        [SerializeField]
        private Structure structure;
        [SerializeField]
        private SkillCaster[] attacks;

        private void Start()
        {
            InputController.Instance.Listeners.Add(this);
        }

        public void Attack(EAttack[] attack)
        {
            foreach (EAttack a in attack)
            {
                attacks[(int)a].Attack();
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
}
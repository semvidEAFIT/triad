using UnityEngine;
using System.Collections;

namespace Triad.Controls
{
    public interface IInputListener
    {
        void Motion(Vector2 direction);
        void Attack(EAttack[] attack);
        void Aim(Vector2 direction);
    }
}
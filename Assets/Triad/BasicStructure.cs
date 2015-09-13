using UnityEngine;
using System;

public class BasicStructure : Structure {
    public override void Move(Vector3 motion, Warrior[] warriors)
    {
        charController.SimpleMove(motion);
        foreach (Warrior w in warriors)
        {
            w.Move(motion);
        }
    }

    public override void Aim(Vector3 direction, Warrior[] warriors)
    {
        foreach (Warrior w in warriors)
        {
            w.Aim(direction);
        }
    }
}

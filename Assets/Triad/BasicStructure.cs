using UnityEngine;
using System;

public class BasicStructure : Structure
{

    public float distance = 1.5f;
    public float speed = 1.0f;

    public override void Move(Vector3 direction)
    {
        charController.SimpleMove(direction * speed);
    }

    public override void Aim(Vector3 direction)
    {
        transform.LookAt(transform.position + direction);
        foreach (Warrior w in triad.Warriors)
        {
            w.Aim(direction);
            //direction = Quaternion.AngleAxis(120, Vector3.up) * direction;
        }
    }

    void Update()
    {
        Vector3 direction = transform.forward;
        foreach (Warrior w in triad.Warriors)
        {
            Vector3 shouldBe = transform.position + direction*distance;
            Vector3 motion = (shouldBe - w.transform.position) * speed;
            w.Move(motion);
            direction = Quaternion.AngleAxis(120, Vector3.up) * direction;
        }
    }
}

using UnityEngine;
using System.Collections;

public class InputLogger : MonoBehaviour, IInputListener {

	// Use this for initialization
	void Start () {
	    InputController.Instance.Listeners.Add(this);
	}

    public void Motion(Vector2 motion)
    {
        Debug.Log("Motion: " + motion);
    }

    public void Attack(EAttack[] attack)
    {
        string attackString = " ";
        foreach (EAttack a in attack)
        {
            attackString = attackString + a + " ";
        }
        attackString = attackString.Substring(0, attackString.Length - 1);

        Debug.Log("Attack: " + attackString);
    }

    public void Aim(Vector2 direction)
    {
        Debug.Log("Aim: " + direction);
    }
}

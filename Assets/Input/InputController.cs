using System;
using UnityEngine;
using System.Collections.Generic;

public class InputController : MonoBehaviour
{
    private static InputController instance;

    private bool gamepad;

    [SerializeField]
    private GameObject squad;

    [SerializeField]
    private float aimSensibility = 0.005f;

    private List<IInputListener> listeners;

    private Vector2 lastAim = Vector2.zero;

    public static InputController Instance
    {
        get { return instance; }
    }

    public List<IInputListener> Listeners
    {
        get { return listeners; }
    }

    private void Awake()
    {
        instance = this;
        listeners = new List<IInputListener>();
    }

    // Use this for initialization
	void Start ()
	{
	    gamepad = Input.GetJoystickNames().Length > 0;
	}
	
	// Update is called once per frame
	void Update () {
	    Vector2 motion = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if(motion.sqrMagnitude > 0) Motion(motion);
        
        List<EAttack> pressed = new List<EAttack>(3);
	    EAttack[] values = (EAttack[])Enum.GetValues(typeof (EAttack));
	    foreach (EAttack a in values)
	    {
	        if (Input.GetButtonDown(a.ToString()))
	        {
                pressed.Add(a);
            }
	    }
        if(pressed.Count > 0) Attack(pressed.ToArray());

        Vector2 aim = new Vector2(Input.GetAxis("AimX"), Input.GetAxis("AimY"));
	    if (!gamepad && squad)
	    {
	        Vector2 distance = Input.mousePosition - GetSquadPosition();
	        aim = distance;
	    }
	    aim = aim.normalized;

	    if (aim.sqrMagnitude > 0 && (aim - lastAim).sqrMagnitude > aimSensibility)
	    {
	        Aim(aim);
	        lastAim = aim;
	    }
	}

    private Vector3 GetSquadPosition()
    {
        return Camera.main.WorldToScreenPoint(squad.transform.position);
    }

    private void Motion(Vector2 motion)
    {
        foreach (IInputListener il in listeners)
        {
            il.Motion(motion);
        }
    }

    private void Attack(EAttack[] attacks)
    {
        foreach (IInputListener il in listeners)
        {
            il.Attack(attacks);
        }
    }

    private void Aim(Vector2 direction)
    {
        foreach (IInputListener il in listeners)
        {
            il.Aim(direction);
        }
    }
}

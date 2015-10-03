using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    private float health = 100; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public float getHeath()
    {
        return health;
    }

    public void setDamage(float damage)
    {
        health = health - damage;
    }

    public void regeneration()
    {
        health = health + (Time.deltaTime * 0.1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
	public Animator controller;

    // Start is called before the first frame update
    void Start()
    {
		controller = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

	void OnTriggerEnter(Collider other)
	{
		controller.SetTrigger("TriggerTrap");
		print("Triggered!");
	}
}

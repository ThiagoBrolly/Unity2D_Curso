using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

	private Transform playerTransf;






	// Use this for initialization
	void Start () {

		playerTransf = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Player" && other.isTrigger != true && playerTransf.transform.position.x > transform.position.x){
			other.GetComponent<Hero>().Damage(1);  // Acessa funçoes de outra classe. "Classe Hero"
			other.GetComponent<Hero>().KnockbackRight();
		}
	}
}

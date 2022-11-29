using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public float speed;
    public GameObject effect;

	void Update () {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) { //enemy objects collide with player and gets destroyed
            other.GetComponent<Player>().health--; //health decrease.
            other.GetComponent<Player>().camAnim.SetTrigger("shake"); //camera shake animation.
            Instantiate(effect, transform.position, Quaternion.identity); //spawning enemies.
            Destroy(gameObject);
        }   
    }
}

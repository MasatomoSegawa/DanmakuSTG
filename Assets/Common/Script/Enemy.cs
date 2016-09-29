using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Bullet bullet;

	public float bulletSpeed;

	public float shootDuration;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.A)) {
			StartCoroutine (Shoot());
		}

	}

	IEnumerator Shoot() {

		for (var i = 0; i < 10; i++) {

			Bullet tmpBullet = Instantiate (bullet) as Bullet;
			tmpBullet.transform.position = this.gameObject.transform.position;

			Vector3 moveVector = Player.Instance.transform.position - this.gameObject.transform.position;
			moveVector = moveVector.normalized;

			tmpBullet.myRigidbody2D.velocity = moveVector * bulletSpeed;

			yield return new WaitForSeconds (shootDuration);
		}
			
	}

}

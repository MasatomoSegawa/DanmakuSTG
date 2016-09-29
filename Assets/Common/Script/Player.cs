using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Transform myTransform;

	[Range(0.0f, 0.1f)]
	public float moveSpeed = 0.05f;

	void Start() {
		this.myTransform = this.gameObject.transform;
	}

	// Update is called once per frame
	void Update () {

		float horizontalAxis = Input.GetAxis ("Horizontal");
		float verticalAxis = Input.GetAxis ("Vertical");

		if (Mathf.Abs(horizontalAxis) > 0.0f || Mathf.Abs(verticalAxis) > 0.0f) {
			Move (new Vector2(horizontalAxis, verticalAxis));
		}

	}

	/// <summary>
	/// 移動
	/// </summary>
	void Move(Vector3 moveVector) {
		Vector3 prePosition = this.gameObject.transform.position + moveVector * moveSpeed;

		myTransform.position = prePosition;

	}
}

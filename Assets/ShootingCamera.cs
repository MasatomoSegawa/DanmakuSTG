﻿using UnityEngine;
using System.Collections;

public class ShootingCamera : Singleton<ShootingCamera> {

	private Camera _mainCamera;

	void Start () {
		// カメラオブジェクトを取得します
		_mainCamera = this.GetComponent<Camera> ();
	}

	public Vector3 getScreenTopLeft() {
		// 画面の左上を取得
		Vector3 topLeft = _mainCamera.ScreenToWorldPoint (Vector3.zero);
		// 上下反転させる
		topLeft.Scale(new Vector3(1f, -1f, 1f));
		return topLeft;
	}

	public Vector3 getScreenBottomRight() {
		// 画面の右下を取得
		Vector3 bottomRight = _mainCamera.ScreenToWorldPoint (new Vector3(Screen.width, Screen.height, 0.0f));
		// 上下反転させる
		bottomRight.Scale(new Vector3(1f, -1f, 1f));
		return bottomRight;
	}
		
}

using UnityEngine;
using System.Collections;

public class ShootingCamera : Singleton<ShootingCamera> {

	/// <summary>
	/// 左上と左下からのoffset
	/// </summary>
	public float cameraOffset = 0.1f;

	private Camera _mainCamera;

	void Start () {
		// カメラオブジェクトを取得します
		_mainCamera = this.GetComponent<Camera> ();
	}

	/// <summary>
	/// 画面の左上を返す.
	/// </summary>
	/// <returns>The screen top left.</returns>
	public Vector3 getScreenTopLeft() {
		// 画面の左上を取得
		Vector3 topLeft = _mainCamera.ScreenToWorldPoint (Vector3.zero) + new Vector3(cameraOffset, cameraOffset);
		// 上下反転させる
		topLeft.Scale(new Vector3(1f, -1f, 1f));
		return topLeft;
	}

	/// <summary>
	/// 画面の右下を返す.
	/// </summary>
	/// <returns>The screen bottom right.</returns>
	public Vector3 getScreenBottomRight() {
		// 画面の右下を取得
		Vector3 bottomRight = _mainCamera.ScreenToWorldPoint (new Vector3(Screen.width, Screen.height, 0.0f)) + new Vector3(-cameraOffset, -cameraOffset);
		// 上下反転させる
		bottomRight.Scale(new Vector3(1f, -1f, 1f));
		return bottomRight;
	}
		
}

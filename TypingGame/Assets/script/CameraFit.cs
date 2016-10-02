using UnityEngine;
using System.Collections;

public class CameraFit : MonoBehaviour {
	private Camera cam;
	private float height = 1280.0f;
	private float width = 720.0f;

	private float pixelPerUnit = 16.0f;

	// Use this for initialization
	void Start () {
		// カメラコンポーネントを取得します
		cam = GetComponent<Camera> ();


		// カメラのorthographicSizeを設定
		cam.orthographicSize = height / 2f / pixelPerUnit;
		
		// 縦幅の倍率
		float bgScale = height / Screen.height;
		// viewport rectの幅
		float camWidth = width / (Screen.width * bgScale);
		// viewportRectを設定
		cam.rect = new Rect ((1f - camWidth) / 2f, 0f, camWidth, 1f);

	}
	
	// Update is called once per frame
	void Update () {
		// カメラのorthographicSizeを設定
		cam.orthographicSize = height / 2f / pixelPerUnit;
		
		// 縦幅の倍率
		float bgScale = height / Screen.height;
		// viewport rectの幅
		float camWidth = width / (Screen.width * bgScale);
		// viewportRectを設定
		cam.rect = new Rect ((1f - camWidth) / 2f, 0f, camWidth, 1f);
	}
}

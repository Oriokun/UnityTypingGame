using UnityEngine;
using System.Collections;

public class QuestionText : MonoBehaviour {
	//画面上に表示されるテキスト数
	const int texts = 5;
	public GameObject prefabtext;
	GameObject[] qtexts = new GameObject[texts];
	// Use this for initialization
	void Start () {
		Debug.Log ("テキストセッティング");


		for (int i=0; i<texts; i++) {
			qtexts[i] = Instantiate(prefabtext) as GameObject;

		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

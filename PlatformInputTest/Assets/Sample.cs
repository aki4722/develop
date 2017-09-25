using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput; //←追加

public class Sample : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		// 水平方向への入力( -1.0 ～ 1.0 )
		Debug.Log( "Horizontal : " + CrossPlatformInputManager.GetAxisRaw( "Horizontal" ) );
		// 垂直方向への入力( -1.0 ～ 1.0 )
		Debug.Log( "Vertical : " + CrossPlatformInputManager.GetAxisRaw( "Vertical" ) );

	}
}

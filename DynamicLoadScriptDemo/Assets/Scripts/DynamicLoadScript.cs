using UnityEngine;
using System.Collections;

public class DynamicLoadScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		TextAsset text = Resources.Load ("UnityScriptLib") as TextAsset;
		System.Reflection.Assembly ass = System.Reflection.Assembly.Load (text.bytes);
		System.Type script = ass.GetType ("UnityScriptLib.Script");

		gameObject.AddComponent(script);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

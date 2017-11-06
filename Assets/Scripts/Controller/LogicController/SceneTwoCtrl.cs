using UnityEngine;
using System.Collections;

public class SceneTwoCtrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (GUILayout.Button("Jump to Scene_One", GUILayout.Width(200f), GUILayout.Height(50f)))
        {
            LuaManager.Instance.DoFile("GameStart");
            Util.CallMethod("GameStart", "OpenScene_One");
        }
    }
}

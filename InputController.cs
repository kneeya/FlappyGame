using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
	private KeyCode flapKey = KeyCode.Space;

	private bool hasStartedFlapping = false;

	private bool IsFlapKeyPressed() {
        #if UNITY_IOS || UNITY_ANDROID
			return GetTouchInput();
		#else
			return GetDesktopInput();
		#endif
	}

	private bool GetTouchInput() {
		return Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began;
	}

	private bool GetDesktopInput() {
		return Input.GetKeyDown(flapKey);
	}

	//Start is called before the first frame update
	void Start()
	{

	}
	// Update is called once per frame
	void Update()
	{
		if (IsFlapKeyPressed()) {
			if (!hasStartedFlapping) {
				
			}
		}
	}

}
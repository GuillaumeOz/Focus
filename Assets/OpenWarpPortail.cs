using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWarpPortail : MonoBehaviour
{
	public GameObject WarpPortailObject;
	public GameObject gameDoneCanvas;
	private bool gameDone;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	IEnumerator displayGameDoneMessage() {
		yield return new WaitForSeconds(6);
        gameDoneCanvas.SetActive(true);
        yield return new WaitForSeconds(7);
        gameDoneCanvas.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
		if (Gamekit3D.GameCommands.SendOnTriggerEnterMainIslandFishing.isMainIslandRiverClean == true
		&& Gamekit3D.GameCommands.SimpleTranslator.done == true && !gameDone) {
			WarpPortailObject.SetActive(true);
			gameDone = true;
			StartCoroutine(displayGameDoneMessage());
		}
	}
}

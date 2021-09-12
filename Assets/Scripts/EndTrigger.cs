using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
	public GameReset gameReset;

    void OnTriggerEnter ()
	{
		gameReset.CompleteLevel();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CharacterController
{
	protected override void IAmStart()
	{
		myCharType = CharacterType.Player;
		GameManager.CharacterStart(myCharType, gameObject);
	}
}

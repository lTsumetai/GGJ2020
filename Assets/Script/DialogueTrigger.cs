using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour {

	public Conversation convers;

	public void TriggerDialogue ()
	{
		FindObjectOfType<DialogueManager>().StartDialogue(convers);
	
	}

	
}

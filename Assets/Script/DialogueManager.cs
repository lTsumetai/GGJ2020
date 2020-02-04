using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public Text nameText;
	public Text dialogueText;
	//public Animator animator;
	public GameObject buttonAnswerShow;
    //public int q1,q2,q3;
	private Queue<string> sentences;
	public Button[] buttonAnswers;
    //public GameObject continue;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
        buttonAnswerShow.gameObject.SetActive(false);
	}

	public void StartDialogue (Conversation convers)
	{
		//animator.SetBool("IsOpen", true);

		nameText.text = convers.sentences[0];
	

		sentences.Clear();

		foreach (string sentence in convers.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence ()
	{
        Debug.Log("test");
		if (sentences.Count == 1)
		{
			buttonAnswerShow.gameObject.SetActive(true);
		}
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence (string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{
		//animator.SetBool("IsOpen", false);
        buttonAnswerShow.gameObject.SetActive(false);

	}
}

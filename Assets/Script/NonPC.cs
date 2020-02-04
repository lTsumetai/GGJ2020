using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NonPC : MonoBehaviour
{
    //public GameObject Choices;
    public GameObject panel;
    public Slider Dbar;
    public int Dpoint;
    public Dialogue dialogue;
    public DialogueManager dialogueManager;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D target)
    {
        //Debug.Log("OnCollisionEnter2D" + target.gameObject.name);
        if (target.gameObject.CompareTag("Player"))
        {
            Debug.Log("we Did it");
            panel.SetActive(true);
            //Choices.SetActive(true);
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue.convers[0]);
            FindObjectOfType<DialogueTrigger>().TriggerDialogue();
            //Dpoint++;
            //Dbar.value = Dpoint;

        }
    }
    private void OnTriggerExit2D(Collider2D target)
    {
        if(target.gameObject.CompareTag("Player"))
        {

            Debug.Log("Out");
            panel.SetActive(false);
            //Choices.SetActive(false);
        }

    }

}

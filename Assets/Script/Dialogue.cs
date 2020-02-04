using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Doption
{
	[TextArea(3, 10)]
    public string optiontext;
    public int optionvalue;
}

[System.Serializable]
public class Conversation
{
	[TextArea(3, 10)]
	public string[] sentences;
	public Doption[] answers;
}

[System.Serializable]
public class Dialogue {

	public string name;
	public Conversation[] convers;	

}

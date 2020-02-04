using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurePoint : MonoBehaviour
{
    public Button yourButton;
    public int cure; //cure kan positif,sedangkan adatombol yang negatif,cure kan gk mungkin negatif, tulisancure bisa diganti jadi effect atau nilai, yang pasti sesuatu yang general
    public Slider slider;
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        slider.value += cure;
    }

    /*private void Button()
    {
        if (Input.GetMouseButtonDown(0))
        {
            btn.gameObject.SendMessage("TakeCure", poin);
        }
    }*/

}

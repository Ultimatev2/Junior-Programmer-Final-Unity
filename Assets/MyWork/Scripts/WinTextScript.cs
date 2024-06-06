using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class WinTextScript : MonoBehaviour  //INHERITANCE
{
    [SerializeField] private TMP_Text winner;

    [SerializeField] private Button start;
    private void Awake()
    {
        if(MenuUIHandler.Instance.win)
        {
            winner.gameObject.SetActive(true);  //INHERITANCE
            start.gameObject.SetActive(false);  //INHERITANCE
        }
    }
}

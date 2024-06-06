using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour  //INHERITANCE
{
    public static MenuUIHandler Instance;
    public bool win;

    [SerializeField] private TMP_Text winText;
    private void Awake()
    {
        // start of new code
        if (Instance)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartNew()  //ENCAPSULATION
    {
        SceneManager.LoadScene(1);
    }

    public void Winner()
    {
        win = true;
        SceneManager.LoadScene(0);
    }
}

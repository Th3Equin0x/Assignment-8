using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Canvas prompt;

    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DisplayPrompt()
    {
        prompt.gameObject.SetActive(true);
        StartCoroutine("HideDisplay");
    }

    IEnumerator HideDisplay()
    {
        yield return new WaitForSeconds(5);
        prompt.gameObject.SetActive(false);
        yield return null;
    }
}

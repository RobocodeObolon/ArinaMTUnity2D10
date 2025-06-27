using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinChecker : MonoBehaviour
{
    private GameObject winPanel;
    // Start is called before the first frame update
    void Start()
    {
        winPanel = GameObject.Find("Win");
        winPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(FindAnyObjectByType<Wind>() == null)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

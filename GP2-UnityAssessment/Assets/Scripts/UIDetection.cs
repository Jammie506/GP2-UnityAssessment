using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDetection : MonoBehaviour
{
    public Text Detection;

    public HybridController HC;
    public HybridController HC1;
    public HybridController HC2;
    public HybridController HC3;
    public HybridController HC4;

    void Start()
    {
        Detection = GetComponent<Text>();
    }
    
    void Update()
    {
        if(HC.isVisible == true)
        {
            Detection.text = "Visible";
        }
        else if(HC1.isVisible == true)
        {
            Detection.text = "Visible";
        }
        else if (HC2.isVisible == true)
        {
            Detection.text = "Visible";
        }
        else if (HC3.isVisible == true)
        {
            Detection.text = "Visible";
        }
        else if (HC4.isVisible == true)
        {
            Detection.text = "Visible";
        }
        else
        {
            Detection.text = "Hidden";
        }
    }
}

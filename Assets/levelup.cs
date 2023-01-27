using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelup : MonoBehaviour
{
    public Text t;
    public int Score = 0;
    
    
    [ContextMenu("test fx")] 
    public void addlevel()
    {
        Score ++;
        t.text = Score.ToString();
    }
}

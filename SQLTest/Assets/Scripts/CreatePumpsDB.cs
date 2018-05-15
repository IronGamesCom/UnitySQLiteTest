using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class CreatePumpsDB : MonoBehaviour
{

    public Text DebugText;
    [HideInInspector]
    public DataService ds;
    // Use this for initialization
    void Start()
    {
        StartSync();
    }

    public void StartSync()
    {
        ds = new DataService("PumpsDatabase.db");
        ds.CreatePumpsDB();
        DebugText.text = "";
        var pumps = ds.GetPumps();
        foreach (var item in pumps)
        {
            Debug.Log(item.ToString());
            ToConsole(item.ToString());
        }
        
    }

    private void ToConsole(string msg)
    {
        DebugText.text += System.Environment.NewLine + msg;
        Debug.Log(msg);
    }
   

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AddNewPump : MonoBehaviour {
    public InputField Model;
    public InputField Serial;
    public InputField MadeIn;
    public CreatePumpsDB DB;
	
	
    public void  AddNewPumpButton()
    {
        if (Model.text != "" && MadeIn.text != "" && long.Parse(Serial.text)!=0)
        {
            DB.ds.CreatePump(Model.text, long.Parse(Serial.text), MadeIn.text);
            DB.StartSync();
        }

    }
}

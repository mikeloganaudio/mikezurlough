using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]

public class Ww_MaterialSwitch : MonoBehaviour
{
    public string SwitchGroup = "Material";
    public string Switch = "Metal";
    public string ExitSwitch = "Grass";
    public GameObject Character;
    public bool Debug_Enabled;

    private void OnTriggerEnter(Collider other)
    {
        if (Debug_Enabled) { Debug.Log(Switch + "switch set"); }
        AkSoundEngine.RegisterGameObj(Character);
        AkSoundEngine.SetSwitch(SwitchGroup, Switch, Character);
    }


    private void OnTriggerExit(Collider other)
    {
        if (Debug_Enabled) { Debug.Log(ExitSwitch + "switch set"); }
        AkSoundEngine.SetSwitch(SwitchGroup, ExitSwitch, Character);
    }

}

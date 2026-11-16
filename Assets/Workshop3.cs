using UnityEngine;
using FMODUnity;
using FMOD.Studio;


public class Workshop3 : MonoBehaviour
{
    
    public EventInstance eventInst;
    public EventReference eventRef;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eventInst = RuntimeManager.CreateInstance(eventRef);
        eventInst.start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

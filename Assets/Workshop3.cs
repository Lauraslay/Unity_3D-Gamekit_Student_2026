using UnityEngine;
using FMODUnity;
using FMOD.Studio;
using STOP_MODE = FMOD.Studio.STOP_MODE;


public class Workshop3 : MonoBehaviour
{

    public float timer = 5f;
    
    public EventInstance eventInst;
    public EventReference eventRef;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eventInst = RuntimeManager.CreateInstance(eventRef);
        eventInst.start();
        
        eventInst.getPlaybackState(out PLAYBACK_STATE state);
        Debug.Log(state);
        
        //PLAYBACK_STATE.STOPPED
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            //eventInst.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            //eventInst.setParameterByName("Parameter", 1);
        }
        
        if (timer <= -3f && timer >= -9f)
        {
            eventInst.setParameterByName("Progression", 0);
        }
        
        if (timer <= -10f)
        {
            eventInst.setParameterByName("Progression", 2);
            //eventInst.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
        
        
        
    }
}

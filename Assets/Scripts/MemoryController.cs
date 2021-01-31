using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoryController : MonoBehaviour
{
    public Slider volume; // 0 to 1
    public Slider pitch; // -3 to 3
    public Slider priority; // High 0 Low 256
    public Slider blend; // 0 to 1
    public Slider pan; // -1 to 1

    public GameObject consolePlace;

    [HideInInspector]
    public Canvas console;

    private AudioSource sfx;

    public void Awake() 
    { 
        sfx = GetComponentInChildren<AudioSource>();
        console = GetComponentInChildren<Canvas>();
    }
    public void Start()
    {
        volume.onValueChanged.AddListener(delegate { OnVolumeChange(); });
        pitch.onValueChanged.AddListener(delegate { OnPitchChange(); });
        priority.onValueChanged.AddListener(delegate { OnPriorityChange(); });
        blend.onValueChanged.AddListener(delegate { OnBlendChange(); });
        pan.onValueChanged.AddListener(delegate { OnPanChange(); });
    }
    private void OnVolumeChange() { sfx.volume = volume.value; }
    private void OnPitchChange() { sfx.pitch = Numbers.MapRangeF(pitch.value, 0f, 1f, -3f, 3f); }
    private void OnPriorityChange() { sfx.priority = Numbers.MapRangeI(priority.value, 0f, 1f, 0, 256); }
    private void OnBlendChange() { sfx.spatialBlend = blend.value; }
    private void OnPanChange() { sfx.panStereo = Numbers.MapRangeF(pan.value, 0f, 1f, -1f, 1f); }
}

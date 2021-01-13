using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventHandler : MonoBehaviour
{

    private bool soundActiveStatus;
    private int countOfButtons;
    private Dictionary<GameObject, int> buttonsClickedCounter;
    private AudioSource audioSource;

    void Start()
    {
        soundActiveStatus = false;
        countOfButtons = 0;
        buttonsClickedCounter = new Dictionary<GameObject, int>();
    }


    public void updateAudioSourceContent(AudioSource _content)
    {
        this.audioSource = _content;
    }

    public bool getAudioSourceContentPlayingStatus()
    {
        return this.audioSource.isPlaying;
    }

    public int updateButtonsClickedCounter(GameObject _button, int _count = 0)
    {
        if (_count < 0) return 0;
        if (buttonsClickedCounter.ContainsKey(_button))
        {
            buttonsClickedCounter[_button] += _count;
        }
        else buttonsClickedCounter.Add(_button, _count);
        return 1;
    }

    public Dictionary<GameObject, int> getButtonsClickedCounter()
    {
        return buttonsClickedCounter;
    }

    public int updateCountOfButtons(int _count = 0)
    {
        if (_count < 0) return 0;
        countOfButtons += _count;
        return countOfButtons;
    }

    public int getCountOfButtons()
    {
        return countOfButtons;
    }

    public bool updateSoundActiveStatus(bool _active_status)
    {
        soundActiveStatus = _active_status;
        return soundActiveStatus;
    }

    public bool getSoundActiveStatus(){
        return soundActiveStatus;
    }
}

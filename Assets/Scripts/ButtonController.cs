using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private int id;

    public Image buttonImage;
    public AudioSource audioSource;
    public EventHandler eventHandler;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnButtonClick);
        this.eventHandler.updateAudioSourceContent(this.audioSource);
    }

    public void OnButtonClick()
    {
        Debug.Log("Button click " + id);
        if (!this.eventHandler.getSoundActiveStatus())
        {
            this.eventHandler.updateSoundActiveStatus(true);
            StartCoroutine(playAudio());
        }
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public int getId()
    {
        return id;
    }

    public void setImage(Sprite sprite)
    {
        buttonImage.sprite = sprite;
    }

    public void setAudioClip(AudioClip clip) 
    {
        this.audioSource.clip = clip;
    }

    IEnumerator playAudio()
    {
        this.audioSource.Play();
        yield return new WaitForSeconds(this.audioSource.clip.length);
        this.eventHandler.updateSoundActiveStatus(false);

    }
}

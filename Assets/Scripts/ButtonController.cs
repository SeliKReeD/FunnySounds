using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

    private int id;

    public Image buttonImage;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        Debug.Log("Button click " + id);
        playAudio();
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
        audioSource.clip = clip;
    }

    public void playAudio()
    {
        audioSource.Play();
    }
}

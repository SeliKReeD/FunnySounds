using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{
    public Transform buttonPanel;
    public GameObject buttonPrefab;
    public int buttonCount;
    public int columns;

    public GridLayoutGroup gridLayoutGroup;

    //-------------------
    public EventHandler eventHandler;
    //-------------------

    public ButtonScriptableObject buttonScriptableObject;
    // Start is called before the first frame update
    void Start()
    {
        float width = this.GetComponent<RectTransform>().rect.width;
        Debug.Log(width);
        gridLayoutGroup.cellSize = new Vector2(width/columns, width/columns);
        List<ButtonObject> buttonObjects = buttonScriptableObject.buttons;

        for (int i = 0; i < buttonObjects.Count; i++)
        {
            GameObject newButton = (GameObject) Instantiate(buttonPrefab);

            eventHandler.updateButtonsClickedCounter(newButton);
            eventHandler.updateSoundActiveStatus(false);
            //Adding 1 to count of buttons
            eventHandler.updateCountOfButtons(1);

            newButton.GetComponent<ButtonController>().eventHandler = eventHandler;
            newButton.GetComponent<ButtonController>().setId(i);
            newButton.GetComponent<ButtonController>().setImage(buttonObjects[i].sprite);
            newButton.transform.SetParent(buttonPanel, false);
            newButton.GetComponent<ButtonController>().setAudioClip(buttonObjects[i].clip);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

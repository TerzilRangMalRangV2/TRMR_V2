using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HM_Title_Manager : MonoBehaviour
{
    public GameObject title_UI;
    public GameObject char_Choice_UI;

    public Image image;
    public GameObject gameStart_Btn;
    
    bool titleOff = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.touchCount);

        if (Input.touchCount > 0 && titleOff == false)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                titleOff = true;
                char_Choice_UI.SetActive(true);
                title_UI.SetActive(false);
            }
        }
    }

    public void GameStart_Btn()
    {
        StartCoroutine(FadeOut());
        gameStart_Btn.SetActive(false);
    }

    IEnumerator FadeOut()
    {
        float fadeCount = 0;
        while(fadeCount < 1.0f)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.01f);
            image.color = new Color(0, 0, 0, fadeCount);
        }

        yield return new WaitForSeconds(1.0f); 
        SceneManager.LoadScene(1);
    }
}

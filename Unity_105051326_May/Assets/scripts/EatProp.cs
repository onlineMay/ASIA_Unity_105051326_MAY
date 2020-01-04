using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EatProp : MonoBehaviour
{
    [Header("道具數量介面")]
    public Text textCount;
    [Header("提示畫面")]
    public GameObject objTip;

    public int propCount;
    public int propTotal=10;

    public bool finish;

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "道具")
        {
            Destroy(collision.gameObject);

            propCount++;
            textCount.text = "道具："+propCount +"/10";

            if(propCount==propTotal)
            {
                finish = true;
                objTip.SetActive(true);
            }
        }
    }
    private void Update()
    {
        GmaeOver();
    }

    private void GmaeOver()
    {
        if(finish)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }

            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}


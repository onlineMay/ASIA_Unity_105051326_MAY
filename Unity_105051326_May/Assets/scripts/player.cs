
using UnityEngine;

public class player : MonoBehaviour
{
    #region 欄位區域
    public string parRun = "跑步開關";

    public int countNeed = 10;
    public int countCurrent;
    #endregion

    public Animator ani;
    #region 方法區域
    private void Run()
    {
        print("水平"+Input.GetAxis("Horizontal"));//Horizontal A左-1、D右1、沒按0
        print("垂直"+Input.GetAxis("Vertical"));  //Vertical   S下-1、W上1、沒按0

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        ani.SetBool("跑步開關", h != 0 || v != 0);
    }
    private void EatProp()
    {

    }
    private void Pass()
    {

    }
    #endregion

    private void Update()
    {
        Run();
    }

}

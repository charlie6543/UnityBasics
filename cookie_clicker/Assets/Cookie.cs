using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cookie : MonoBehaviour
{
    private TextMeshProUGUI text;
    private int cookieCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponentInChildren<TextMeshProUGUI>();
    }

    public void ClickCookie()
    {
        string msg = "";
        cookieCount++;
        msg += cookieCount;
        text.text = msg;
    }

    public int getCount(){
        return cookieCount;
    }

    public bool subtractCount(int toSubtract){
        if(toSubtract < 0) return false;
        if(cookieCount >= toSubtract){
            cookieCount -= toSubtract;
            string msg = "" + cookieCount;
            text.text = msg;
            return true;
        }
        else return false;
    }
}

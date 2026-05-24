using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Purchase: MonoBehaviour
{
    public GameObject Purchase;
   public  void Purchaes()
    {
        Purchase.SetActive(true);
        Invoke("Close", 3.5f);
    }
     public void Close()
    {
        Purchase.SetActive(false);


    }
}

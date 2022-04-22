using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color[] colors;
    public Renderer[] mats;

    public void Red(){
        for (int i=0; i<mats.Length; i++){
            mats[i].material.color= colors[0];
            Debug.Log("Working");
        }
    }
    public void Black(){
        for (int i=0; i<mats.Length; i++){
            mats[i].material.color= colors[1];
        }
    }
    public void Green(){
        for (int i=0; i<mats.Length; i++){
            mats[i].material.color= colors[2];
        }
    }
    public void Yellow(){
        for (int i=0; i<mats.Length; i++){
            mats[i].material.color= colors[3];
        }
    }
    public void White(){
        for (int i=0; i<mats.Length; i++){
            mats[i].material.color= colors[4];
        }
    }
}

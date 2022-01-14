using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    //public Joystick Joy;
    private Vector3 offset;
    public float min,max;
    private float rotSpeed=.4F;
    public Transform pivot;
    FixedTouchField touch;
  



    
    void Awake()
    {
        offset=pivot.position-transform.position;
        touch=FindObjectOfType<FixedTouchField>();
    }


    // Update is called once per frame
    public void moveCam()
    {
        //float x=Input.GetAxis("Mouse X")*rotSpeed;
        float x=touch.TouchDist.x * rotSpeed;
        //if(manager.scoped==false)
        //{
        //x+=Joy.Horizontal*joyrot+Joystick2.Horizontal*.23F;
        //}
        pivot.Rotate(0,x,0);
        //float y=Input.GetAxis("Mouse Y")*rotSpeed;
        float y=touch.TouchDist.y * rotSpeed;
        //if(manager.scoped==false)
       // {
      //  y+=(Joy.Vertical+Joystick2.Vertical)*joyrot;
        //}
        pivot.Rotate(-y,0,0);
    
        if(pivot.rotation.eulerAngles.x>=max && pivot.rotation.eulerAngles.x<=180F)
        {
            pivot.rotation=Quaternion.Euler(max,pivot.rotation.eulerAngles.y,0);
        }
        if(pivot.rotation.eulerAngles.x>180F && pivot.rotation.eulerAngles.x<=360+min)
        {
           pivot.rotation=Quaternion.Euler(360+min,pivot.rotation.eulerAngles.y,0); 
        }
        pivot.rotation=Quaternion.Euler(pivot.rotation.eulerAngles.x,pivot.rotation.eulerAngles.y,0);

        float a=pivot.eulerAngles.x;
        float b=pivot.eulerAngles.y;
        //if(manager.croach==false)
        //{
        Quaternion axis=Quaternion.Euler(a,b,0);
        transform.position=pivot.position-(axis*offset);
        transform.LookAt(pivot);
    
    }
    
    
    
  
} 

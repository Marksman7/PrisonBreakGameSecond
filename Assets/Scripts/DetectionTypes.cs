using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DectionType
{
    ZBoxFrontD, ZDimanondFrontD, ZDimaondHalfFrontD, ZDimaondThirdFrontD, AreaBoxD, AreaDimaondD, XBoxFrontD, XDimanondFrontD, XDimaondHalfFrontD, XDimaondThirdFrontD
}


public class DetectionTypes : MonoBehaviour
{

    public DectionType DropSelect = new DectionType();
    
    public Transform PlayerTransform;

    public int PlayerWithInDistance = 5;
    protected bool PlaySpotted = false;

    public int StopFollowDistance = 20;

    void Start()
    {
        PlayerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {

    }


    public void StopFollowing()
    {
        if (PlayerTransform.transform.position.z < (this.transform.position.z - StopFollowDistance) ||
            PlayerTransform.transform.position.z > (this.transform.position.z + StopFollowDistance) ||
            PlayerTransform.transform.position.x < (this.transform.position.x - StopFollowDistance) ||
            PlayerTransform.transform.position.x > (this.transform.position.x + StopFollowDistance))
        {
            PlaySpotted = false;
        }

    }


    protected void DetectionStateCheck()
    {
        if (DropSelect == DectionType.ZBoxFrontD)
        {
            ZBoxFront();
        }
        else if (DropSelect == DectionType.ZDimanondFrontD)
        {
            ZDimanondFront();
        }
        else if (DropSelect == DectionType.ZDimaondHalfFrontD)
        {
            ZDimaondHalfFront();
        }
        else if (DropSelect == DectionType.ZDimaondThirdFrontD)
        {
            ZDimaondThirdFront();
        }
        else if (DropSelect == DectionType.AreaBoxD)
        {
            AreaBox();
        }
        else if (DropSelect == DectionType.AreaDimaondD)
        {
            AreaDimaond();
        }
        else if (DropSelect == DectionType.XBoxFrontD)
        {
            XBoxFront();
        }
        else if (DropSelect == DectionType.XDimanondFrontD)
        {
            XDimanondFront();
        }
        else if (DropSelect == DectionType.XDimaondHalfFrontD)
        {
            XDimaondHalfFront();
        }
        else if (DropSelect == DectionType.XDimaondThirdFrontD)
        {
            XDimaondThirdFront();
        }
    }

    void ZBoxFront() //box radius
    {
        if (PlayerTransform.transform.position.z > this.transform.position.z &&
            PlayerTransform.transform.position.z < (this.transform.position.z + (PlayerWithInDistance * 2)) &&
            PlayerTransform.transform.position.x > (this.transform.position.x - PlayerWithInDistance) &&
            PlayerTransform.transform.position.x < (this.transform.position.x + PlayerWithInDistance))
        {
            PlaySpotted = true;
        }
    }


    void ZDimanondFront() // Dimanond Detction Radius
    {
        if (PlayerTransform.transform.position.z > this.transform.position.z &&
            PlayerTransform.transform.position.z < (this.transform.position.z + (PlayerWithInDistance * 2)) &&
            PlayerTransform.transform.position.x > (this.transform.position.x - PlayerWithInDistance) &&
            PlayerTransform.transform.position.x < (this.transform.position.x + PlayerWithInDistance) &&
            ((PlayerTransform.transform.position.z > (this.transform.position.z + (PlayerWithInDistance * 1.5)) && PlayerTransform.transform.position.x > (this.transform.position.x + (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.z > (this.transform.position.z + (PlayerWithInDistance * 1.5)) && PlayerTransform.transform.position.x < (this.transform.position.x - (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.z < (this.transform.position.z + (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.x < (this.transform.position.x - (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.z < (this.transform.position.z + (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.x > (this.transform.position.x + (PlayerWithInDistance * .5))) != true)
            )
        {
            PlaySpotted = true;
        }
    }

    void ZDimaondHalfFront() // Dimanond with one cormer a Half of the size Detction Radius
    {
        if (PlayerTransform.transform.position.z > this.transform.position.z &&
            PlayerTransform.transform.position.z < (this.transform.position.z + (PlayerWithInDistance * 1.5)) &&
            PlayerTransform.transform.position.x > (this.transform.position.x - PlayerWithInDistance) &&
            PlayerTransform.transform.position.x < (this.transform.position.x + PlayerWithInDistance) &&
            ((PlayerTransform.transform.position.z > (this.transform.position.z + (PlayerWithInDistance * 1.25)) && PlayerTransform.transform.position.x > (this.transform.position.x + (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.z > (this.transform.position.z + (PlayerWithInDistance * 1.25)) && PlayerTransform.transform.position.x < (this.transform.position.x - (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.z < (this.transform.position.z + (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.x < (this.transform.position.x - (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.z < (this.transform.position.z + (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.x > (this.transform.position.x + (PlayerWithInDistance * .5))) != true)
            )
        {
            PlaySpotted = true;
        }


    }

    void ZDimaondThirdFront() // Dimanond with one cormer a third of the size Detction Radius
    {
        if (PlayerTransform.transform.position.z > this.transform.position.z &&
            PlayerTransform.transform.position.z < (this.transform.position.z + (PlayerWithInDistance * 1.25)) &&
            PlayerTransform.transform.position.x > (this.transform.position.x - PlayerWithInDistance) &&
            PlayerTransform.transform.position.x < (this.transform.position.x + PlayerWithInDistance) &&
            ((PlayerTransform.transform.position.z > (this.transform.position.z + (PlayerWithInDistance * 1.125)) && PlayerTransform.transform.position.x > (this.transform.position.x + (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.z > (this.transform.position.z + (PlayerWithInDistance * 1.125)) && PlayerTransform.transform.position.x < (this.transform.position.x - (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.z < (this.transform.position.z + (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.x < (this.transform.position.x - (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.z < (this.transform.position.z + (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.x > (this.transform.position.x + (PlayerWithInDistance * .5))) != true)
            )
        {
            PlaySpotted = true;
        }


    }

    void AreaBox() //Box detect that surounds the enmey
    {
        if (PlayerTransform.transform.position.x > this.transform.position.x - PlayerWithInDistance &&
            PlayerTransform.transform.position.x < (this.transform.position.x + PlayerWithInDistance) &&
            PlayerTransform.transform.position.z > (this.transform.position.z - PlayerWithInDistance) &&
            PlayerTransform.transform.position.z < (this.transform.position.z + PlayerWithInDistance))
        {
            PlaySpotted = true;
        }
    }

    void AreaDimaond() //diamond detect that surounds the enmey
    {
        if (PlayerTransform.transform.position.x > this.transform.position.x - PlayerWithInDistance &&
            PlayerTransform.transform.position.x < (this.transform.position.x + PlayerWithInDistance) &&
            PlayerTransform.transform.position.z > (this.transform.position.z - PlayerWithInDistance) &&
            PlayerTransform.transform.position.z < (this.transform.position.z + PlayerWithInDistance) &&
            ((PlayerTransform.transform.position.x > (this.transform.position.x - (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.z > (this.transform.position.z + (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.x > (this.transform.position.x - (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.z < (this.transform.position.z - (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.x < (this.transform.position.x + (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.z < (this.transform.position.z - (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.x < (this.transform.position.x + (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.z > (this.transform.position.z + (PlayerWithInDistance * .5))) != true)
            )
        {
            PlaySpotted = true;
        }
    }


    void XBoxFront() //box radius
    {
        if (PlayerTransform.transform.position.x > this.transform.position.x &&
            PlayerTransform.transform.position.x < (this.transform.position.x + (PlayerWithInDistance * 2)) &&
            PlayerTransform.transform.position.z > (this.transform.position.z - PlayerWithInDistance) &&
            PlayerTransform.transform.position.z < (this.transform.position.z + PlayerWithInDistance))
        {
            PlaySpotted = true;
        }
    }

    void XDimanondFront() // Dimanond Detction Radius
    {
        if (PlayerTransform.transform.position.x > this.transform.position.x &&
           PlayerTransform.transform.position.x < (this.transform.position.x + (PlayerWithInDistance * 2)) &&
           PlayerTransform.transform.position.z > (this.transform.position.z - PlayerWithInDistance) &&
           PlayerTransform.transform.position.z < (this.transform.position.z + PlayerWithInDistance) &&
           ((PlayerTransform.transform.position.x > (this.transform.position.x + (PlayerWithInDistance * 1.5)) && PlayerTransform.transform.position.z > (this.transform.position.z + (PlayerWithInDistance * .5))) != true) &&
           ((PlayerTransform.transform.position.x > (this.transform.position.x + (PlayerWithInDistance * 1.5)) && PlayerTransform.transform.position.z < (this.transform.position.z - (PlayerWithInDistance * .5))) != true) &&
           ((PlayerTransform.transform.position.x < (this.transform.position.x + (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.z < (this.transform.position.z - (PlayerWithInDistance * .5))) != true) &&
           ((PlayerTransform.transform.position.x < (this.transform.position.x + (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.z > (this.transform.position.z + (PlayerWithInDistance * .5))) != true)
           )
        {
            PlaySpotted = true;
        }
    }

    void XDimaondHalfFront() // Dimanond with one cormer a Half of the size Detction Radius
    {
        if (PlayerTransform.transform.position.x > this.transform.position.x &&
            PlayerTransform.transform.position.x < (this.transform.position.x + (PlayerWithInDistance * 1.5)) &&
            PlayerTransform.transform.position.z > (this.transform.position.z - PlayerWithInDistance) &&
            PlayerTransform.transform.position.z < (this.transform.position.z + PlayerWithInDistance) &&
            ((PlayerTransform.transform.position.x > (this.transform.position.x + (PlayerWithInDistance * 1.25)) && PlayerTransform.transform.position.z > (this.transform.position.z + (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.x > (this.transform.position.x + (PlayerWithInDistance * 1.25)) && PlayerTransform.transform.position.z < (this.transform.position.z - (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.x < (this.transform.position.x + (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.z < (this.transform.position.z - (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.x < (this.transform.position.x + (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.z > (this.transform.position.z + (PlayerWithInDistance * .5))) != true)
            )
        {
            PlaySpotted = true;
        }


    }

    void XDimaondThirdFront() // Dimanond with one cormer a third of the size Detction Radius
    {
        if (PlayerTransform.transform.position.x > this.transform.position.x &&
            PlayerTransform.transform.position.x < (this.transform.position.x + (PlayerWithInDistance * 1.25)) &&
            PlayerTransform.transform.position.z > (this.transform.position.z - PlayerWithInDistance) &&
            PlayerTransform.transform.position.z < (this.transform.position.z + PlayerWithInDistance) &&
            ((PlayerTransform.transform.position.x > (this.transform.position.x + (PlayerWithInDistance * 1.125)) && PlayerTransform.transform.position.z > (this.transform.position.z + (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.x > (this.transform.position.x + (PlayerWithInDistance * 1.125)) && PlayerTransform.transform.position.z < (this.transform.position.z - (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.x < (this.transform.position.x + (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.z < (this.transform.position.z - (PlayerWithInDistance * .5))) != true) &&
            ((PlayerTransform.transform.position.x < (this.transform.position.x + (PlayerWithInDistance * .5)) && PlayerTransform.transform.position.z > (this.transform.position.z + (PlayerWithInDistance * .5))) != true)
            )
        {
            PlaySpotted = true;
        }

    }

}
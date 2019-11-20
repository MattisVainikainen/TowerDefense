using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 posOffset;

    private GameObject turret;
   
    private Renderer rend;
    private Color startColor;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color; 
    }

    private void OnMouseDown() 
    {
        if(turret != null)
        {
            Debug.Log("We cant build here! - TODO: DISPLAY ON SCREEN");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild(); 
        turret = Instantiate(turretToBuild, transform.position + posOffset, transform.rotation) as GameObject;
    }
    void OnMouseEnter()
    {
        rend.material.color = hoverColor; 
    }
    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}

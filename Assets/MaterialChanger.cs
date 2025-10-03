using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class MaterialChanger : MonoBehaviour
{
    //Initalize Variables for text, objects renderer, 3 different materials
    public Text shaderTypes;
    public Text shadersOnorOff;
    private Renderer objRenderer;
    public Material lampert;
    public Material ambient;
    public Material specular;

    public Material[] materials = new Material[4];

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Set text for ui
        shaderTypes.text = "Press 1 for Lampert, Press 2 for Ambient, Press 3 for Specular";

        //Get Render from object and assign it to the variable objRender;
        objRenderer = GetComponent<Renderer>();

        objRenderer.materials = materials;

    }
    // Update is called once per frame
    void Update()
    {
        shaderTypes.text = "Press 1 for Lampert, Press 2 for Ambient, Press 3 for Specular";
        objRenderer.materials = materials;

        //Depending on what number the user selects change material
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            materials[0] = lampert;
            materials[1] = null;
            materials[2] = null;

            objRenderer.materials = materials;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            materials[0] = null;
            materials[1] = ambient;
            materials[2] = null;

            objRenderer.materials = materials;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            materials[0] = null;
            materials[1] = null;
            materials[2] = specular;

            objRenderer.materials = materials;
        }
        



    }
}

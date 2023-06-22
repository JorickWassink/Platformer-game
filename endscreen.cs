using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class endscreen : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void endingscreen()
    {
        Application.Quit(); // sluit applicatie doet niks als je in de unity editor zit
    }
}

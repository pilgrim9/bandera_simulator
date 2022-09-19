using UnityEngine;
using UnityEngine.UI;
public class controller : MonoBehaviour
{
    private Cloth _cloth;

    public Slider stiffnessSlider;
    public Slider waverSlider;
    public Slider windSlider;
    
    public float maxStiffness = 1f;
    public float baseStiffness = 80f;
    public float maxWaver = 1f;
    public float maxWind;
    // Start is called before the first frame update
    void Start()
    {
        _cloth = GetComponent<Cloth>();
    }

    // Update is called once per frame
    void Update()
    {
        _cloth.randomAcceleration = new Vector3(waverSlider.value * maxWaver, 0, maxWind*windSlider.value);
        _cloth.externalAcceleration = new Vector3(0, 0, maxStiffness * stiffnessSlider.value + baseStiffness);
    }
}

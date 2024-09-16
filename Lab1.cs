using UnityEngine;

public class VectorVisualizer : MonoBehaviour
{
    public Vector3 vector1;
    public Vector3 vector2;
    public Vector3 vector3;
    public Vector3 vector4;
    public Vector3 vector5;
    public Vector3 vector6;

    void Start()
    {
        // Initialize vectors with values between -20 and 20
        vector1 = new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20));
        vector2 = new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20));
        vector3 = new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20));
        vector4 = new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20));
        vector5 = new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20));
        vector6 = new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20));
    }

    void Update()
    {
        // Draw lines between vectors
        Debug.DrawLine(Vector3.zero, vector1, Color.red);
        Debug.DrawLine(Vector3.zero, vector2, Color.green);
        Debug.DrawLine(Vector3.zero, vector3, Color.blue);
        Debug.DrawLine(Vector3.zero, vector4, Color.yellow);
        Debug.DrawLine(Vector3.zero, vector5, Color.magenta);
        Debug.DrawLine(Vector3.zero, vector6, Color.cyan);
    }
}
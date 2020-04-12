using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Girar : MonoBehaviour
{
    public float vel;
    public float vel2;

    private int dir;
    private int dir2;

    public float distanciaMov = 50;

    private int btn1;
    private int btn2;

    SerialPort puerto = new SerialPort("COM3", 9600);

    // Start is called before the first frame update
    void Start()
    {
        puerto.Open();
        puerto.ReadTimeout = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (puerto.IsOpen)
        {
            try
            {
                mover(puerto.ReadLine());
            }
            catch (System.Exception)
            {

            }
        }

    }

    void mover(string datoArduino)
    {
        string[] datosArray = datoArduino.Split(char.Parse(","));

        if (datosArray.Length == 4)
        {
            btn1 = int.Parse(datosArray[0]);
            btn2 = int.Parse(datosArray[1]);
            dir = int.Parse(datosArray[2]);
            dir2 = int.Parse(datosArray[3]);
            print(btn1 + " " + btn2 + " " + dir + " " + dir2);
        }

        if (btn1 == 1)
        {
            transform.Translate(Vector3.up * distanciaMov, Space.World);
        }

        if (btn2 == 1)
        {
            transform.Translate(Vector3.down * distanciaMov, Space.World);
        }

        if (dir >= 700)
        {
            transform.Rotate(Vector3.back * vel, Space.World);
        }
        if (dir <= 300)
        {
            transform.Rotate(Vector3.forward * vel, Space.World);
        }

        if (dir2 >= 700)
        {
            transform.Translate(Vector3.right * vel2, Space.World);
        }
        if (dir2 <= 300)
        {
            transform.Translate(Vector3.left * vel2, Space.World);
        }
        

    }
}

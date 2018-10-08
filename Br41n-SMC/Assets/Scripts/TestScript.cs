using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.Networking;

public class TestScript : MonoBehaviour {
    int PORT = 1000;
    static UdpClient udp;
    Thread thread;
    static IPEndPoint remoteEP;
    void Start()
    {
        Debug.Log("started");
        remoteEP = new IPEndPoint(IPAddress.Any, PORT);
        udp = new UdpClient(remoteEP);
        //udp = new UdpClient(PORT);
        //udp.Client.ReceiveTimeout = 1;
        thread = new Thread(new ThreadStart(ThreadMethod));
        thread.Start();
    }

    private static void ThreadMethod()
    {
        while (true)
        {
            //IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1000);
            
            byte[] data = udp.Receive(ref remoteEP);
            //Debug.Log("test");
            char[] charData = new char[data.Length];
            
            for (int i = 0;i < data.Length; i++)
            {
                if (data[i] == 0)
                    data[i] = (byte)'.';

                charData[i] = (char)data[i];
                //Debug.Log("b " + data[i] + "s " + (char)data[i]);
            }
            string text = new string(charData);
            
            char[] chars = new char[data.Length / sizeof(char)];
            System.Buffer.BlockCopy(data, 0, chars, 0, data.Length);
            string str = new string(chars);
 
            string finding = "System.Drawing.Bitmap..........";
            int target = text.IndexOf(finding);

            string result = "";
            int start = target + finding.Length;
            while (!text[start].Equals('.'))
            {
                result += text[start];
                start++;
            }
            
            Debug.Log(result);
        }
    }

    void OnApplicationQuit()
    {
        udp.Close();
        Debug.Log("exiting");
        thread.Abort();
    }



}

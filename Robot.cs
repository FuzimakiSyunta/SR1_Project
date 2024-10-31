using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Robot
{
    //フィールド
    protected string name = "";
    protected bool powerStatus = false;

    //電源をON
    public void PowerOn()
    {
        powerStatus = true;
        Console.WriteLine("{0}は、起動した!!",name);
    }
    //電源をOFF
    public void PowerOff()
    {
        powerStatus = false;
        Console.WriteLine("{0}は、停止した..", name);
    }
    
    //名前を取得する
    public string GetName()
    {
        return name;
    }
    //電源ON状態を取得
    public int GetPowerStatus()
    {
        return powerStatus;
    }
}
}

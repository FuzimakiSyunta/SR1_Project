using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Item
{
    public string name;

    public Item(string name)
    {
        this.name = name;
    }

    public string Getname()
    {
        return name;
    }
    public virtual void Use()
    {
        Console.WriteLine("{0}を使った", name);
    }
}

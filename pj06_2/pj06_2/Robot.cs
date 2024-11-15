using System;

public class Robot
{
	//フィールド
	protected string name;


	public Robot(string name)
	{
		this.name = name;
	}

	//nameの値返し
	public string Getname()
	{
		return name;
	}
	//攻撃する
    public void Attack()
    {
        Console.WriteLine("{0}は、攻撃した!", name);
    }
}

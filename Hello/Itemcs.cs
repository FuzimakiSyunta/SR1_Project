using System;

public class Class1
{
    internal class Item
    {
        //フィールド
        protected string name;

        //メソッド
        //コンストラクタ
        public Item(string name)
        {
            this.name = name;
        }

        //使用する
        public virtual void Use()
        {
            Console.WriteLine("{0}を使った", name);
        }
    }
}


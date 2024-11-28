using System;

public class _09_3
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
        public void Use()
        {
            Console.WriteLine("{0}を使った", name);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Player
    {
        //フィールド
        private string name;
        private int level;

        //コンストラクタ
        public Player(string name,int level)
        {
            this.name = name;
            this.level = level;
        }
        //攻撃
        private void Attack()
        {
            Console.WriteLine("攻撃!!");
        }
        //防御
        public void Defence()
        {
            Console.WriteLine("防御した");
        }
        //レベルアップ
        public void LevelUp()
        {
            level++;
        }
        //名前を聞く
        public string GetName()
        {
            return name;
        }
        //レベルを聞く
        public int GetLevel()
        {
            return level;
        }
    }

}

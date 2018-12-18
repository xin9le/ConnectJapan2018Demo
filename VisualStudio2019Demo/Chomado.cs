//--- 並び変えられていない using
//--- 未使用の using
using System.Collections.Generic;
using System.IO;
using System;

namespace VisualStudio2019Demo
{
    //--- アクセシビリティが明示されてない
    class Chomado
    {
        //--- 修飾子の順序が変
        //--- 定義済みの型 string を使っていない
        static private List<String> Messages { get; }

        //--- readonly にできる private フィールド
        private Random random;

        //--- 1 行の関数
        public Chomado()
        {
            //--- this. が付いていない
            random = new Random();
        }

        static Chomado()
        {
            //--- コレクション初期化子を使ってない
            Messages = new List<string>();
            Messages.Add("ちょまど(*ﾟ▽ﾟ* っ)З");
            Messages.Add("┌（┌ *ﾟ▽ﾟ*）┐ チョマドォ...");
            Messages.Add("プログラミング ₍₍⁽⁽(ી(*ﾟ▽ﾟ*)ʃ)₎₎⁾⁾ 楽しい！");

            Messages.Add("じんぐる(*ﾟ▽ﾟ* っ)З");
            Messages.Add("┌（┌ *ﾟ▽ﾟ*）┐ じんぐるぅ...");
        }

        //--- 括弧が右にある
        public void Tweet() {
            /*
            var ちょま語 = new List<string>();
            foreach (var x in Messages)
            {
                if (!x.Contains("じんぐる"))
                    ちょま語.Add(x);
            }
            */

            for (var _ = 0; _ < 10; _++)
            {
                //--- 不要なキャスト
                var index = (int)this.random.Next(0, Messages.Count);

                //--- 未使用の変数
                var j = 0;

                Console.WriteLine(Messages[index]);
            }
        }
    }
}

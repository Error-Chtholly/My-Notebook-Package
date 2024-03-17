using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Shown(object sender, EventArgs e)
        {
            Random random = new Random();　　//Public a class of Random.
            int figure = random.Next(1, 18); //Get the figure which use in the condition in random zone of 1 to 13.
            if (figure == 1) //Conditions,set the richtextbox's text.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n时光荏苒，愿你有一天能与重要的人重逢。\n——by Error";
            }
            if (figure == 2) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n重逢的时候，希望你的梦不再支离破碎。\n——by Error";
            }
            if (figure == 3) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n聚拢，成形，捻转，回绕，时而返回，暂歇，再联结。这就是时间。\n——by Error";
            }
            if (figure == 4) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n有时回忆越美好，就越可能遭到回忆的反噬。但我认为，一个人没有回忆，反而是更悲哀的。\n——by Error";
            }
            if (figure == 5) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n两人的思念，抱紧这无法逆转的时间，飞向天际。\n——by Error";
            }
            if (figure == 6) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n数不清的和你一起的日子，回过头来你看，烟火如此的多彩。\n——by Error";
            }
            if (figure == 7) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n祈愿这一瞬间，永远也不要忘记，在远处绽放盛开着的，星空璀璨的烟花。\n——by Error";
            }
            if (figure == 8) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n所谓谎言，只要你愿意相信它是真的，它对你来说就是真的。\n——by Error";
            }
            if (figure == 9) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n因为悲伤，所以一直微笑。\n——by Error";
            }
            if (figure == 10) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n能创造回忆的，就只有现在了，只有瞬间的此时此刻。\n——by Error";
            }
            if (figure == 11) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n如果自己的寿命从一开始就已经是定数的话，换做我，我想我会在有限的时间内，尽全力的活着。\n——by Error";
            }
            if (figure == 12) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n时光终有一天会将我们分开，比起以不好的回忆来结束，保留着美好的回忆不是更好吗？\n——by Error";
            }
            if (figure == 13) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n命运之环，轮回反复，思绪终将合而为一。\n——by Error";
            }
            if (figure == 14) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n明明是再次相逢，却要说初次见面。\n——by Error";
            }
            if (figure == 15) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\nMake this world a better place.\n——by Error";
            }
            if (figure == 16) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n看来这世界，似乎还想要驯服我。那就如你所愿吧，我会美丽地挣扎到底。\n——by Error";
            }
            if (figure == 17) //Conditions.
            {
                richTextBox1.Text = "欢迎使用My Notebook 1.2.6！更多详情请见帮助！\n\n\n\n我们是时间旅行者，追逐时光的攀岩者，厌倦了与时间的躲猫猫。\n——by Error";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); //Close this form.
        }
    }
}

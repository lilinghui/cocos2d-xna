using cocos2d;

namespace tests
{
    internal class BMFontUnicode : AtlasDemo
    {
        public BMFontUnicode()
        {
            var data = CCFileUtils.GetFileData("fonts/strings.plist");
            PlistDocument doc = PlistDocument.Create(data);
            var strings = doc.Root as PlistDictionary;

            string chinese = strings["chinese1"].AsString;
            string japanese = strings["japanese"].AsString;
            string spanish = strings["spanish"].AsString;

            CCSize s = CCDirector.SharedDirector.WinSize;

            CCLabelBMFont label1 = CCLabelBMFont.Create(spanish, "fonts/arial-unicode-26.fnt", 200, CCTextAlignment.CCTextAlignmentLeft);
            AddChild(label1);
            label1.Position = new CCPoint(s.Width / 2, s.Height / 4 * 3);

            CCLabelBMFont label2 = CCLabelBMFont.Create(chinese, "fonts/arial-unicode-26.fnt");
            AddChild(label2);
            label2.Position = new CCPoint(s.Width / 2, s.Height / 4 * 2);

            CCLabelBMFont label3 = CCLabelBMFont.Create(japanese, "fonts/arial-unicode-26.fnt");
            AddChild(label3);
            label3.Position = new CCPoint(s.Width / 2, s.Height / 4 * 1);
        }

        public override string title()
        {
            return "CCLabelBMFont with Unicode support";
        }

        public override string subtitle()
        {
            return "You should see 3 differnt labels: In Spanish, Chinese and Korean";
        }
    }
}
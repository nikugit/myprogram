using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomeDialogBox
{
    public class MsgBox
    {
        public string title { set; get; }
        public string comment { set; get; }
        public MessageBoxButtons btn { set; get; }
        public MessageBoxIcon icon { set; get; }
        public MessageBoxDefaultButton defBtn { set; get; }
        public bool showHelp { set; get; }
        public string helpFilePath { set; get; }
        public string helpKeyWord { set; get; }

        public MsgBox()
        {
            // 初期値をセット
            this.title = null;
            this.comment = null;
            this.btn = MessageBoxButtons.OK;
            this.icon = MessageBoxIcon.None;
            this.defBtn = MessageBoxDefaultButton.Button1;
            this.showHelp = false;
            this.helpFilePath = null;
            this.helpKeyWord = null;
        }

        public void showMsgBox()
        {
            MessageBox.Show(this.comment, this.title, this.btn, this.icon);
        }
    }
}

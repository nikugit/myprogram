using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SomeDialogBox.Properties;
using System.Configuration;
using System.IO;

namespace SomeDialogBox
{
    public partial class frmMain : Form
    {
        private enum tabKind
        {
            MsgBox = 1,
            OpenFileDialog = 2,
            SaveFileDialog = 3,
            Other = -1
        }

        private Dictionary<string, MessageBoxButtons> _dictMsgBoxBtn = new Dictionary<string, MessageBoxButtons>();
        private Dictionary<string, MessageBoxIcon> _dictMsgBoxIcon = new Dictionary<string, MessageBoxIcon>();
        private Dictionary<string, MessageBoxDefaultButton> _dictMsgBoxDefault = new Dictionary<string, MessageBoxDefaultButton>();

        public frmMain()
        {
            InitializeComponent();
        }       

        private void btnShow_Click(object sender, EventArgs e)
        {
            // アクティブなタブを判別して処理を分岐
            switch (tabDialog.SelectedTab.Name)
            {
                case "tbpMsgBox":

                    // 入力チェック
                    if (inputChkMsgBox() == false)
                    {
                        return;
                    }

                    if (chkHelpBtn.Checked)
                    {
                        // ヘルプファイルのパスチェック
                        if (!Directory.Exists(txtbHelpFilePath.Text))
                        {
                            txtbErrMsg.Text = "ヘルプファイルのパスが見つかりません。";
                            return;
                        }

                        MessageBox.Show(
                            txtbTitle.Text, 
                            txtbContent.Text,
                            this._dictMsgBoxBtn[cmbBtn.SelectedItem.ToString()],
                            this._dictMsgBoxIcon[cmbIcon.SelectedItem.ToString()],
                            this._dictMsgBoxDefault[cmbDefautBtn.SelectedItem.ToString()],
                            0,
                            txtbHelpFilePath.Text,
                            HelpNavigator.KeywordIndex,
                            txtbHelpKeyWord.Text
                            );
                    }
                    else
                    {
                        // パラメータのセット
                        MsgBox lMsgBox = new MsgBox();
                        lMsgBox.title = txtbTitle.Text;
                        lMsgBox.comment = txtbContent.Text;

                        if (cmbBtn.SelectedIndex != -1)
                        {
                            // 選択したボタン種別をセット(未選択の場合はデフォルトのまま)
                            lMsgBox.btn = this._dictMsgBoxBtn[cmbBtn.SelectedItem.ToString()];
                        }

                        if (cmbIcon.SelectedIndex != -1)
                        {
                            // 選択したアイコン種別をセット(未選択の場合はデフォルトのまま)
                            lMsgBox.icon = this._dictMsgBoxIcon[cmbIcon.SelectedItem.ToString()];
                        }

                        if (cmbDefautBtn.SelectedIndex != -1)
                        {
                            // 選択したデフォルトボタンをセット(未選択の場合はデフォルトのまま)
                            lMsgBox.defBtn = this._dictMsgBoxDefault[cmbDefautBtn.SelectedItem.ToString()];
                        }

                        lMsgBox.showMsgBox();
                    }

                    break;

                case "tbpOpenFileDialog":

                    // パラメータのセット
                    OpenFileDialog lOfd = new OpenFileDialog();

                    lOfd.Title = txtbTitleOFD.Text;

                    // フィルタ文字列
                    try
                    {
                        lOfd.Filter = txtbFilterOFD.Text;
                    }
                    catch (ArgumentException)
                    {
                        txtbErrMsg.Text = "フィルタ文字列のフォーマットが不正です。";
                        return;
                    }

                    // ヘルプボタン表示の有無
                    if (chkHelpBtnOFD.Checked)
                    {
                        lOfd.ShowHelp = true; ;
                    }
                    else
                    {
                        lOfd.ShowHelp = false;
                    }

                    // 読み取り専用
                    lOfd.ShowReadOnly = chkReadOnlyOFD.Checked;
                    
                    lOfd.ShowDialog();
                    break;

                case "tbpSaveFileDialog":
                    SaveFileDialog lSfd = new SaveFileDialog();


                    // ヘルプボタン表示の有無
                    lSfd.ShowHelp = chkHelpSFD.Checked;

                    lSfd.ShowDialog();
                    break;

                default:
                    txtbErrMsg.Text = "タブページの選択が不正です。";
                    break;
            }
        }

        private bool inputChkMsgBox()
        {
            if (txtbTitle.Text == "")
            {
                txtbErrMsg.Text = "タイトルが未入力です。";
                return false;
            }

            if (txtbContent.Text == "")
            {
                txtbErrMsg.Text = "メッセージ内容が未入力です。";
                return false;
            }

            if (chkHelpBtn.Checked)
            {
                if (txtbHelpFilePath.Text == "")
                {
                    txtbErrMsg.Text = "ヘルプファイルパスが未入力です。";
                    return false;
                }

                if (!System.IO.Directory.Exists(txtbHelpFilePath.Text))
                {
                    txtbErrMsg.Text = "ヘルプファイルが存在しません。";
                    return false;
                }
            }



            return true;
        }

        

        private void mnVerInfo_Click(object sender, EventArgs e)
        {
            AboutBox abBox = new AboutBox();
            abBox.ShowDialog();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkHelpBtn_CheckedChanged(object sender, EventArgs e)
        {
            txtbEnableChange();
            Properties.Settings.Default.chkHelpBtn = chkHelpBtn.Checked;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtbEnableChange();
            txtbErrMsg.Text = "";

            // メッセージボックスボタンの初期化            
            _dictMsgBoxBtn.Add(Resources.AbortRetryIgnore, MessageBoxButtons.AbortRetryIgnore);
            _dictMsgBoxBtn.Add(Resources.OK, MessageBoxButtons.OK);
            _dictMsgBoxBtn.Add(Resources.OKCancel, MessageBoxButtons.OKCancel);
            _dictMsgBoxBtn.Add(Resources.RetryCancel, MessageBoxButtons.RetryCancel);
            _dictMsgBoxBtn.Add(Resources.YesNo, MessageBoxButtons.YesNo);
            _dictMsgBoxBtn.Add(Resources.YesNoCancel, MessageBoxButtons.YesNoCancel);
            cmbBtn.Items.AddRange(_dictMsgBoxBtn.Keys.ToArray());

            // メッセージボックスアイコンの初期化
            //_dictMsgBoxIcon.Add(Resources.Asterisk, MessageBoxIcon.Asterisk);         // 情報と同じアイコン
            _dictMsgBoxIcon.Add(Resources.Error, MessageBoxIcon.Error);
            //_dictMsgBoxIcon.Add(Resources.Exclamation, MessageBoxIcon.Exclamation);   // 警告と同じアイコン
            //_dictMsgBoxIcon.Add(Resources.Hand, MessageBoxIcon.Hand);                 // エラーと同じアイコン
            _dictMsgBoxIcon.Add(Resources.Information, MessageBoxIcon.Information);
            _dictMsgBoxIcon.Add(Resources.None, MessageBoxIcon.None);
            _dictMsgBoxIcon.Add(Resources.Question, MessageBoxIcon.Question);
            _dictMsgBoxIcon.Add(Resources.Stop, MessageBoxIcon.Stop);
            _dictMsgBoxIcon.Add(Resources.Warning, MessageBoxIcon.Warning);
            cmbIcon.Items.AddRange(_dictMsgBoxIcon.Keys.ToArray());

            // メッセージボックスデフォルトボタンの初期化
            _dictMsgBoxDefault.Add(Resources.DefButton1, MessageBoxDefaultButton.Button1);
            _dictMsgBoxDefault.Add(Resources.DefButton2, MessageBoxDefaultButton.Button2);
            _dictMsgBoxDefault.Add(Resources.DefButton3, MessageBoxDefaultButton.Button3);
            cmbDefautBtn.Items.AddRange(_dictMsgBoxDefault.Keys.ToArray());

            // コンボボックスの初期状態を設定
            //   ボタンの種類コンボボックス
            if (Properties.Settings.Default.cmbBtnIndex <= -1)
            {
                this.cmbBtn.SelectedIndex = 0;
            }
            else
            {
                this.cmbBtn.SelectedIndex = Properties.Settings.Default.cmbBtnIndex;
            }

            // アイコンの種類コンボボックス
            if (Properties.Settings.Default.cmbIconIndex <= -1)
            {
                this.cmbIcon.SelectedIndex = 0;
            }
            else
            {
                this.cmbIcon.SelectedIndex = Properties.Settings.Default.cmbIconIndex;
            }

            // 規定のボタンコンボボックス
            if (Properties.Settings.Default.cmbDefaultBtnIndex <= -1)
            {
                this.cmbDefautBtn.SelectedIndex = 0;
            }
            else
            {
                this.cmbDefautBtn.SelectedIndex = Properties.Settings.Default.cmbDefaultBtnIndex;
            }

            // ヘルプチェックブックス
            if (Properties.Settings.Default.chkHelpBtn)
            {
                this.chkHelpBtn.Checked = true;
            }
            else
            {
                this.chkHelpBtn.Checked = false;
            }

            // ヘルプファイルパス
            if (String.IsNullOrWhiteSpace(Properties.Settings.Default.txtbHelpFilePath))
            {
                this.txtbHelpFilePath.Text = Properties.Settings.Default.txtbHelpFilePath;
            }

            // ヘルプキーワード
            if (String.IsNullOrWhiteSpace(Properties.Settings.Default.txtbHelpKeyWord))
            {
                this.txtbHelpKeyWord.Text = Properties.Settings.Default.txtbHelpKeyWord;
            }


            // OpenFileDialogのタイトル
            if (String.IsNullOrWhiteSpace(Properties.Settings.Default.txtbTitleOFD))
            {
                this.txtbTitleOFD.Text = Properties.Settings.Default.txtbTitleOFD;
            }

            // OpenFileDialogのフィルタ
            if (String.IsNullOrWhiteSpace(Properties.Settings.Default.txtbFilterOFD))
            {
                this.txtbFilterOFD.Text = Properties.Settings.Default.txtbFilterOFD;
            }

            // OpenFileDialogのヘルプチェックボックス
            if (Properties.Settings.Default.chkHelpBtnOFD)
            {
                this.chkHelpBtnOFD.Checked = true;
            }
            else
            {
                this.chkHelpBtnOFD.Checked = false;
            }

            // OpenFileDialogの読み取り専用で開く
            if (Properties.Settings.Default.ckbReadOnlyOFD)
            {
                this.chkReadOnlyOFD.Checked = true;
            }
            else
            {
                this.chkReadOnlyOFD.Checked = false;
            }
        }

        private void txtbEnableChange()
        {
            // ヘルプボックスの活性制御
            if (chkHelpBtn.Checked)
            {
                txtbHelpFilePath.Enabled = true;
                txtbHelpKeyWord.Enabled = true;
            }
            else
            {
                txtbHelpFilePath.Enabled = false;
                txtbHelpKeyWord.Enabled = false;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void cmbBtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 設定値を保存するため、設定ファイルの値を書き換える
            Properties.Settings.Default.cmbBtnIndex = cmbBtn.SelectedIndex;
        }

        private void cmbIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 設定値を保存するため、設定ファイルの値を書き換える
            Properties.Settings.Default.cmbIconIndex = cmbIcon.SelectedIndex;
        }

        private void cmbDefautBtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 設定値を保存するため、設定ファイルの値を書き換える
            Properties.Settings.Default.cmbDefaultBtnIndex = cmbDefautBtn.SelectedIndex;
        }

        private void txtbHelpFilePath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.txtbHelpFilePath = txtbHelpFilePath.Text;
        }

        private void txtbHelpKeyWord_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.txtbHelpKeyWord = txtbHelpKeyWord.Text;
        }        
    }
}

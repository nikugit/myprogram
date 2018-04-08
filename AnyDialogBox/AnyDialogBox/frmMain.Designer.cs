namespace SomeDialogBox
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabDialog = new System.Windows.Forms.TabControl();
            this.tbpMsgBox = new System.Windows.Forms.TabPage();
            this.lblBtn = new System.Windows.Forms.Label();
            this.cmbIcon = new System.Windows.Forms.ComboBox();
            this.chkHelpBtn = new System.Windows.Forms.CheckBox();
            this.grpHelp = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbHelpKeyWord = new System.Windows.Forms.TextBox();
            this.txtbHelpFilePath = new System.Windows.Forms.TextBox();
            this.cmbDefautBtn = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpOpenFileDialog = new System.Windows.Forms.TabPage();
            this.tbpSaveFileDialog = new System.Windows.Forms.TabPage();
            this.btnShow = new System.Windows.Forms.Button();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVerInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.errpTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtbErrMsg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkHelpSFD = new System.Windows.Forms.CheckBox();
            this.cmbBtn = new System.Windows.Forms.ComboBox();
            this.txtbContent = new System.Windows.Forms.TextBox();
            this.txtbTitle = new System.Windows.Forms.TextBox();
            this.chkReadOnlyOFD = new System.Windows.Forms.CheckBox();
            this.txtbFilterOFD = new System.Windows.Forms.TextBox();
            this.chkHelpBtnOFD = new System.Windows.Forms.CheckBox();
            this.txtbTitleOFD = new System.Windows.Forms.TextBox();
            this.txtbFilterSFD = new System.Windows.Forms.TextBox();
            this.txtbTitleSFD = new System.Windows.Forms.TextBox();
            this.tabDialog.SuspendLayout();
            this.tbpMsgBox.SuspendLayout();
            this.grpHelp.SuspendLayout();
            this.tbpOpenFileDialog.SuspendLayout();
            this.tbpSaveFileDialog.SuspendLayout();
            this.mnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDialog
            // 
            this.tabDialog.Controls.Add(this.tbpMsgBox);
            this.tabDialog.Controls.Add(this.tbpOpenFileDialog);
            this.tabDialog.Controls.Add(this.tbpSaveFileDialog);
            this.tabDialog.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabDialog.Location = new System.Drawing.Point(0, 24);
            this.tabDialog.Name = "tabDialog";
            this.tabDialog.SelectedIndex = 0;
            this.tabDialog.Size = new System.Drawing.Size(592, 389);
            this.tabDialog.TabIndex = 0;
            // 
            // tbpMsgBox
            // 
            this.tbpMsgBox.Controls.Add(this.lblBtn);
            this.tbpMsgBox.Controls.Add(this.cmbIcon);
            this.tbpMsgBox.Controls.Add(this.chkHelpBtn);
            this.tbpMsgBox.Controls.Add(this.grpHelp);
            this.tbpMsgBox.Controls.Add(this.cmbDefautBtn);
            this.tbpMsgBox.Controls.Add(this.label4);
            this.tbpMsgBox.Controls.Add(this.label3);
            this.tbpMsgBox.Controls.Add(this.cmbBtn);
            this.tbpMsgBox.Controls.Add(this.label2);
            this.tbpMsgBox.Controls.Add(this.txtbContent);
            this.tbpMsgBox.Controls.Add(this.label1);
            this.tbpMsgBox.Controls.Add(this.txtbTitle);
            this.tbpMsgBox.Location = new System.Drawing.Point(4, 22);
            this.tbpMsgBox.Name = "tbpMsgBox";
            this.tbpMsgBox.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMsgBox.Size = new System.Drawing.Size(584, 363);
            this.tbpMsgBox.TabIndex = 0;
            this.tbpMsgBox.Text = "MsgBox";
            this.tbpMsgBox.UseVisualStyleBackColor = true;
            // 
            // lblBtn
            // 
            this.lblBtn.AutoSize = true;
            this.lblBtn.Location = new System.Drawing.Point(8, 89);
            this.lblBtn.Name = "lblBtn";
            this.lblBtn.Size = new System.Drawing.Size(82, 12);
            this.lblBtn.TabIndex = 11;
            this.lblBtn.Text = "ボタンの種類(&B)";
            // 
            // cmbIcon
            // 
            this.cmbIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIcon.FormattingEnabled = true;
            this.cmbIcon.Location = new System.Drawing.Point(10, 142);
            this.cmbIcon.Name = "cmbIcon";
            this.cmbIcon.Size = new System.Drawing.Size(206, 20);
            this.cmbIcon.TabIndex = 10;
            this.cmbIcon.SelectedIndexChanged += new System.EventHandler(this.cmbIcon_SelectedIndexChanged);
            // 
            // chkHelpBtn
            // 
            this.chkHelpBtn.AutoSize = true;
            this.chkHelpBtn.Location = new System.Drawing.Point(10, 221);
            this.chkHelpBtn.Name = "chkHelpBtn";
            this.chkHelpBtn.Size = new System.Drawing.Size(147, 16);
            this.chkHelpBtn.TabIndex = 8;
            this.chkHelpBtn.Text = "ヘルプボタンを表示する(&S)";
            this.chkHelpBtn.UseVisualStyleBackColor = true;
            this.chkHelpBtn.CheckedChanged += new System.EventHandler(this.chkHelpBtn_CheckedChanged);
            // 
            // grpHelp
            // 
            this.grpHelp.Controls.Add(this.label6);
            this.grpHelp.Controls.Add(this.label5);
            this.grpHelp.Controls.Add(this.txtbHelpKeyWord);
            this.grpHelp.Controls.Add(this.txtbHelpFilePath);
            this.grpHelp.Location = new System.Drawing.Point(10, 243);
            this.grpHelp.Name = "grpHelp";
            this.grpHelp.Size = new System.Drawing.Size(566, 114);
            this.grpHelp.TabIndex = 9;
            this.grpHelp.TabStop = false;
            this.grpHelp.Text = "ヘルプ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "ヘルプキーワード(&K)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "ヘルプファイルのパスと名前(&P)";
            // 
            // txtbHelpKeyWord
            // 
            this.txtbHelpKeyWord.Location = new System.Drawing.Point(6, 67);
            this.txtbHelpKeyWord.Name = "txtbHelpKeyWord";
            this.txtbHelpKeyWord.Size = new System.Drawing.Size(554, 19);
            this.txtbHelpKeyWord.TabIndex = 1;
            this.txtbHelpKeyWord.TextChanged += new System.EventHandler(this.txtbHelpKeyWord_TextChanged);
            // 
            // txtbHelpFilePath
            // 
            this.txtbHelpFilePath.Location = new System.Drawing.Point(8, 30);
            this.txtbHelpFilePath.Name = "txtbHelpFilePath";
            this.txtbHelpFilePath.Size = new System.Drawing.Size(552, 19);
            this.txtbHelpFilePath.TabIndex = 0;
            this.txtbHelpFilePath.TextChanged += new System.EventHandler(this.txtbHelpFilePath_TextChanged);
            // 
            // cmbDefautBtn
            // 
            this.cmbDefautBtn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefautBtn.FormattingEnabled = true;
            this.cmbDefautBtn.Location = new System.Drawing.Point(10, 180);
            this.cmbDefautBtn.Name = "cmbDefautBtn";
            this.cmbDefautBtn.Size = new System.Drawing.Size(206, 20);
            this.cmbDefautBtn.TabIndex = 7;
            this.cmbDefautBtn.SelectedIndexChanged += new System.EventHandler(this.cmbDefautBtn_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "規定のボタン(&D)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "アイコンの種類(&I)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "メッセージ内容(&M)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "タイトル(&T)";
            // 
            // tbpOpenFileDialog
            // 
            this.tbpOpenFileDialog.Controls.Add(this.chkReadOnlyOFD);
            this.tbpOpenFileDialog.Controls.Add(this.label9);
            this.tbpOpenFileDialog.Controls.Add(this.label8);
            this.tbpOpenFileDialog.Controls.Add(this.label7);
            this.tbpOpenFileDialog.Controls.Add(this.txtbFilterOFD);
            this.tbpOpenFileDialog.Controls.Add(this.chkHelpBtnOFD);
            this.tbpOpenFileDialog.Controls.Add(this.txtbTitleOFD);
            this.tbpOpenFileDialog.Location = new System.Drawing.Point(4, 22);
            this.tbpOpenFileDialog.Name = "tbpOpenFileDialog";
            this.tbpOpenFileDialog.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOpenFileDialog.Size = new System.Drawing.Size(584, 363);
            this.tbpOpenFileDialog.TabIndex = 1;
            this.tbpOpenFileDialog.Text = "OpenFileDialog";
            this.tbpOpenFileDialog.UseVisualStyleBackColor = true;
            // 
            // tbpSaveFileDialog
            // 
            this.tbpSaveFileDialog.Controls.Add(this.chkHelpSFD);
            this.tbpSaveFileDialog.Controls.Add(this.txtbFilterSFD);
            this.tbpSaveFileDialog.Controls.Add(this.label11);
            this.tbpSaveFileDialog.Controls.Add(this.label10);
            this.tbpSaveFileDialog.Controls.Add(this.txtbTitleSFD);
            this.tbpSaveFileDialog.Location = new System.Drawing.Point(4, 22);
            this.tbpSaveFileDialog.Name = "tbpSaveFileDialog";
            this.tbpSaveFileDialog.Size = new System.Drawing.Size(584, 363);
            this.tbpSaveFileDialog.TabIndex = 2;
            this.tbpSaveFileDialog.Text = "SaveFileDialog";
            this.tbpSaveFileDialog.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(513, 419);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "表示(&V)";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // mnMain
            // 
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(592, 24);
            this.mnMain.TabIndex = 2;
            this.mnMain.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(109, 22);
            this.mnExit.Text = "終了(&X)";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnVerInfo});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // mnVerInfo
            // 
            this.mnVerInfo.Name = "mnVerInfo";
            this.mnVerInfo.Size = new System.Drawing.Size(155, 22);
            this.mnVerInfo.Text = "バージョン情報(&V)";
            this.mnVerInfo.Click += new System.EventHandler(this.mnVerInfo_Click);
            // 
            // errpTitle
            // 
            this.errpTitle.ContainerControl = this;
            // 
            // txtbErrMsg
            // 
            this.txtbErrMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtbErrMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtbErrMsg.Location = new System.Drawing.Point(0, 448);
            this.txtbErrMsg.Name = "txtbErrMsg";
            this.txtbErrMsg.Size = new System.Drawing.Size(592, 19);
            this.txtbErrMsg.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "タイトル(&T)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "フィルタ(&L)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(287, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "例: \"テキスト ファイル (*.txt)|*.txt|すべてのファイル (*.*)|*.*\"";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "タイトル(&T)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "フィルタ(&L)";
            // 
            // chkHelpSFD
            // 
            this.chkHelpSFD.AutoSize = true;
            this.chkHelpSFD.Checked = global::SomeDialogBox.Properties.Settings.Default.chkHelpSFD;
            this.chkHelpSFD.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SomeDialogBox.Properties.Settings.Default, "chkHelpSFD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkHelpSFD.Location = new System.Drawing.Point(10, 90);
            this.chkHelpSFD.Name = "chkHelpSFD";
            this.chkHelpSFD.Size = new System.Drawing.Size(147, 16);
            this.chkHelpSFD.TabIndex = 4;
            this.chkHelpSFD.Text = "ヘルプボタンを表示する(&S)";
            this.chkHelpSFD.UseVisualStyleBackColor = true;
            // 
            // cmbBtn
            // 
            this.cmbBtn.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::SomeDialogBox.Properties.Settings.Default, "cmbBtnName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbBtn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBtn.FormattingEnabled = true;
            this.cmbBtn.Location = new System.Drawing.Point(10, 104);
            this.cmbBtn.Name = global::SomeDialogBox.Properties.Settings.Default.cmbBtnName;
            this.cmbBtn.Size = new System.Drawing.Size(206, 20);
            this.cmbBtn.TabIndex = 4;
            this.cmbBtn.SelectedIndexChanged += new System.EventHandler(this.cmbBtn_SelectedIndexChanged);
            // 
            // txtbContent
            // 
            this.txtbContent.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SomeDialogBox.Properties.Settings.Default, "txtbComment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbContent.Location = new System.Drawing.Point(10, 65);
            this.txtbContent.Name = "txtbContent";
            this.txtbContent.Size = new System.Drawing.Size(560, 19);
            this.txtbContent.TabIndex = 2;
            this.txtbContent.Text = global::SomeDialogBox.Properties.Settings.Default.txtbComment;
            // 
            // txtbTitle
            // 
            this.txtbTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SomeDialogBox.Properties.Settings.Default, "txtbTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbTitle.Location = new System.Drawing.Point(10, 28);
            this.txtbTitle.Name = "txtbTitle";
            this.txtbTitle.Size = new System.Drawing.Size(560, 19);
            this.txtbTitle.TabIndex = 0;
            this.txtbTitle.Text = global::SomeDialogBox.Properties.Settings.Default.txtbTitle;
            // 
            // chkReadOnlyOFD
            // 
            this.chkReadOnlyOFD.AutoSize = true;
            this.chkReadOnlyOFD.Checked = global::SomeDialogBox.Properties.Settings.Default.chkReadOnlyOFD;
            this.chkReadOnlyOFD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReadOnlyOFD.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SomeDialogBox.Properties.Settings.Default, "chkReadOnlyOFD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkReadOnlyOFD.Location = new System.Drawing.Point(10, 134);
            this.chkReadOnlyOFD.Name = "chkReadOnlyOFD";
            this.chkReadOnlyOFD.Size = new System.Drawing.Size(168, 16);
            this.chkReadOnlyOFD.TabIndex = 7;
            this.chkReadOnlyOFD.Text = "読み取り専用で開くを表示(&R)";
            this.chkReadOnlyOFD.UseVisualStyleBackColor = true;
            // 
            // txtbFilterOFD
            // 
            this.txtbFilterOFD.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SomeDialogBox.Properties.Settings.Default, "txtbFilterOFD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbFilterOFD.Location = new System.Drawing.Point(10, 65);
            this.txtbFilterOFD.Name = "txtbFilterOFD";
            this.txtbFilterOFD.Size = new System.Drawing.Size(566, 19);
            this.txtbFilterOFD.TabIndex = 1;
            this.txtbFilterOFD.Text = global::SomeDialogBox.Properties.Settings.Default.txtbFilterOFD;
            // 
            // chkHelpBtnOFD
            // 
            this.chkHelpBtnOFD.AutoSize = true;
            this.chkHelpBtnOFD.Checked = global::SomeDialogBox.Properties.Settings.Default.chkHelpBtnOFD;
            this.chkHelpBtnOFD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHelpBtnOFD.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SomeDialogBox.Properties.Settings.Default, "chkHelpBtnOFD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkHelpBtnOFD.Location = new System.Drawing.Point(10, 112);
            this.chkHelpBtnOFD.Name = "chkHelpBtnOFD";
            this.chkHelpBtnOFD.Size = new System.Drawing.Size(147, 16);
            this.chkHelpBtnOFD.TabIndex = 2;
            this.chkHelpBtnOFD.Text = "ヘルプボタンを表示する(&S)";
            this.chkHelpBtnOFD.UseVisualStyleBackColor = true;
            // 
            // txtbTitleOFD
            // 
            this.txtbTitleOFD.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SomeDialogBox.Properties.Settings.Default, "txtbTitleOFD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbTitleOFD.Location = new System.Drawing.Point(10, 28);
            this.txtbTitleOFD.Name = "txtbTitleOFD";
            this.txtbTitleOFD.Size = new System.Drawing.Size(566, 19);
            this.txtbTitleOFD.TabIndex = 0;
            this.txtbTitleOFD.Text = global::SomeDialogBox.Properties.Settings.Default.txtbTitleOFD;
            // 
            // txtbFilterSFD
            // 
            this.txtbFilterSFD.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SomeDialogBox.Properties.Settings.Default, "txtbFilterSFD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbFilterSFD.Location = new System.Drawing.Point(10, 65);
            this.txtbFilterSFD.Name = "txtbFilterSFD";
            this.txtbFilterSFD.Size = new System.Drawing.Size(566, 19);
            this.txtbFilterSFD.TabIndex = 3;
            this.txtbFilterSFD.Text = global::SomeDialogBox.Properties.Settings.Default.txtbFilterSFD;
            // 
            // txtbTitleSFD
            // 
            this.txtbTitleSFD.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SomeDialogBox.Properties.Settings.Default, "txtbTitleSFD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbTitleSFD.Location = new System.Drawing.Point(10, 28);
            this.txtbTitleSFD.Name = "txtbTitleSFD";
            this.txtbTitleSFD.Size = new System.Drawing.Size(566, 19);
            this.txtbTitleSFD.TabIndex = 0;
            this.txtbTitleSFD.Text = global::SomeDialogBox.Properties.Settings.Default.txtbTitleSFD;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 467);
            this.Controls.Add(this.txtbErrMsg);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.tabDialog);
            this.Controls.Add(this.mnMain);
            this.MainMenuStrip = this.mnMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "SomeDialogBox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabDialog.ResumeLayout(false);
            this.tbpMsgBox.ResumeLayout(false);
            this.tbpMsgBox.PerformLayout();
            this.grpHelp.ResumeLayout(false);
            this.grpHelp.PerformLayout();
            this.tbpOpenFileDialog.ResumeLayout(false);
            this.tbpOpenFileDialog.PerformLayout();
            this.tbpSaveFileDialog.ResumeLayout(false);
            this.tbpSaveFileDialog.PerformLayout();
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabDialog;
        private System.Windows.Forms.TabPage tbpMsgBox;
        private System.Windows.Forms.TabPage tbpOpenFileDialog;
        private System.Windows.Forms.TabPage tbpSaveFileDialog;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBtn;
        private System.Windows.Forms.CheckBox chkHelpBtn;
        private System.Windows.Forms.GroupBox grpHelp;
        private System.Windows.Forms.ComboBox cmbDefautBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbHelpKeyWord;
        private System.Windows.Forms.TextBox txtbHelpFilePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnVerInfo;
        private System.Windows.Forms.ErrorProvider errpTitle;
        private System.Windows.Forms.TextBox txtbErrMsg;
        private System.Windows.Forms.Label lblBtn;
        private System.Windows.Forms.ComboBox cmbIcon;
        private System.Windows.Forms.CheckBox chkHelpBtnOFD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbTitleOFD;
        private System.Windows.Forms.TextBox txtbFilterOFD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkReadOnlyOFD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbTitleSFD;
        private System.Windows.Forms.TextBox txtbFilterSFD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkHelpSFD;
    }
}


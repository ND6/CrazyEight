namespace CrazyEight
{
    partial class CrazyEight
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrazyEight));
            this.buttonCommit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerBaseTextBox = new System.Windows.Forms.RichTextBox();
            this.playerShopTextBox = new System.Windows.Forms.RichTextBox();
            this.opponentBaseTextBox = new System.Windows.Forms.RichTextBox();
            this.opponentShopTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCommit
            // 
            this.buttonCommit.Location = new System.Drawing.Point(105, 181);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(75, 23);
            this.buttonCommit.TabIndex = 0;
            this.buttonCommit.Text = "计算";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "我方场上：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "我方商店：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "对方场上：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "对方商店：";
            // 
            // playerBaseTextBox
            // 
            this.playerBaseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerBaseTextBox.Location = new System.Drawing.Point(105, 35);
            this.playerBaseTextBox.Name = "playerBaseTextBox";
            this.playerBaseTextBox.Size = new System.Drawing.Size(435, 26);
            this.playerBaseTextBox.TabIndex = 5;
            this.playerBaseTextBox.Text = "";
            // 
            // playerShopTextBox
            // 
            this.playerShopTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerShopTextBox.Location = new System.Drawing.Point(105, 70);
            this.playerShopTextBox.Name = "playerShopTextBox";
            this.playerShopTextBox.Size = new System.Drawing.Size(435, 26);
            this.playerShopTextBox.TabIndex = 6;
            this.playerShopTextBox.Text = "";
            // 
            // opponentBaseTextBox
            // 
            this.opponentBaseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opponentBaseTextBox.Location = new System.Drawing.Point(105, 105);
            this.opponentBaseTextBox.Name = "opponentBaseTextBox";
            this.opponentBaseTextBox.Size = new System.Drawing.Size(435, 26);
            this.opponentBaseTextBox.TabIndex = 7;
            this.opponentBaseTextBox.Text = "";
            // 
            // opponentShopTextBox
            // 
            this.opponentShopTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opponentShopTextBox.Location = new System.Drawing.Point(105, 140);
            this.opponentShopTextBox.Name = "opponentShopTextBox";
            this.opponentShopTextBox.Size = new System.Drawing.Size(435, 26);
            this.opponentShopTextBox.TabIndex = 8;
            this.opponentShopTextBox.Text = "";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(225, 181);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "清除";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(24, 218);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(65, 12);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "计算结果：";
            // 
            // rtbResult
            // 
            this.rtbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbResult.Location = new System.Drawing.Point(105, 218);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(437, 88);
            this.rtbResult.TabIndex = 11;
            this.rtbResult.Text = "";
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(333, 181);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAll.TabIndex = 12;
            this.buttonShowAll.Text = "展示所有解";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "只填攻击力，商店中用空格分开";
            // 
            // CrazyEight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(564, 318);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.opponentShopTextBox);
            this.Controls.Add(this.opponentBaseTextBox);
            this.Controls.Add(this.playerShopTextBox);
            this.Controls.Add(this.playerBaseTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCommit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrazyEight";
            this.Text = "疯狂的八计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCommit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox playerBaseTextBox;
        private System.Windows.Forms.RichTextBox playerShopTextBox;
        private System.Windows.Forms.RichTextBox opponentBaseTextBox;
        private System.Windows.Forms.RichTextBox opponentShopTextBox;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Label label5;
    }
}


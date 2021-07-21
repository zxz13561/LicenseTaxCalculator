
namespace LicenseTaxCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtnAnnual = new System.Windows.Forms.RadioButton();
            this.rbtnPeriod = new System.Windows.Forms.RadioButton();
            this.datePickStart = new System.Windows.Forms.DateTimePicker();
            this.labelRbtn2 = new System.Windows.Forms.Label();
            this.datePickEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxEngine = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSumit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.yearMsg = new System.Windows.Forms.Label();
            this.typeMsg = new System.Windows.Forms.Label();
            this.engineMsg = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelHint01 = new System.Windows.Forms.Label();
            this.labelHint02 = new System.Windows.Forms.Label();
            this.linkToTaxLabel = new System.Windows.Forms.LinkLabel();
            this.btnMsg = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnAnnual
            // 
            this.rbtnAnnual.AutoSize = true;
            this.rbtnAnnual.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.rbtnAnnual.Location = new System.Drawing.Point(224, 199);
            this.rbtnAnnual.Name = "rbtnAnnual";
            this.rbtnAnnual.Size = new System.Drawing.Size(96, 32);
            this.rbtnAnnual.TabIndex = 0;
            this.rbtnAnnual.TabStop = true;
            this.rbtnAnnual.Text = "全年度";
            this.rbtnAnnual.UseVisualStyleBackColor = true;
            this.rbtnAnnual.CheckedChanged += new System.EventHandler(this.rbtnAnnual_CheckedChanged);
            // 
            // rbtnPeriod
            // 
            this.rbtnPeriod.AutoSize = true;
            this.rbtnPeriod.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.rbtnPeriod.Location = new System.Drawing.Point(339, 199);
            this.rbtnPeriod.Name = "rbtnPeriod";
            this.rbtnPeriod.Size = new System.Drawing.Size(96, 32);
            this.rbtnPeriod.TabIndex = 1;
            this.rbtnPeriod.TabStop = true;
            this.rbtnPeriod.Text = "依期間";
            this.rbtnPeriod.UseVisualStyleBackColor = true;
            this.rbtnPeriod.CheckedChanged += new System.EventHandler(this.rbtnPeriod_CheckedChanged);
            // 
            // datePickStart
            // 
            this.datePickStart.CustomFormat = "";
            this.datePickStart.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.datePickStart.Location = new System.Drawing.Point(441, 196);
            this.datePickStart.Name = "datePickStart";
            this.datePickStart.Size = new System.Drawing.Size(187, 35);
            this.datePickStart.TabIndex = 2;
            this.datePickStart.Value = new System.DateTime(2021, 7, 20, 15, 21, 18, 0);
            this.datePickStart.Visible = false;
            this.datePickStart.ValueChanged += new System.EventHandler(this.datePickStart_ValueChanged);
            // 
            // labelRbtn2
            // 
            this.labelRbtn2.AutoSize = true;
            this.labelRbtn2.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.labelRbtn2.Location = new System.Drawing.Point(634, 202);
            this.labelRbtn2.Name = "labelRbtn2";
            this.labelRbtn2.Size = new System.Drawing.Size(34, 28);
            this.labelRbtn2.TabIndex = 3;
            this.labelRbtn2.Text = "至";
            this.labelRbtn2.Visible = false;
            // 
            // datePickEnd
            // 
            this.datePickEnd.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.datePickEnd.Location = new System.Drawing.Point(674, 196);
            this.datePickEnd.Name = "datePickEnd";
            this.datePickEnd.Size = new System.Drawing.Size(187, 35);
            this.datePickEnd.TabIndex = 4;
            this.datePickEnd.Visible = false;
            this.datePickEnd.ValueChanged += new System.EventHandler(this.datePickEnd_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(113, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "使用期間";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(155, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "用途";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbxType
            // 
            this.cbxType.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.cbxType.Location = new System.Drawing.Point(224, 247);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(182, 35);
            this.cbxType.TabIndex = 7;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            this.cbxType.TextChanged += new System.EventHandler(this.cbxType_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(3, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "汽缸CC數 / 馬達馬力";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbxEngine
            // 
            this.cbxEngine.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cbxEngine.FormattingEnabled = true;
            this.cbxEngine.Location = new System.Drawing.Point(224, 302);
            this.cbxEngine.Name = "cbxEngine";
            this.cbxEngine.Size = new System.Drawing.Size(415, 28);
            this.cbxEngine.TabIndex = 9;
            this.cbxEngine.TextChanged += new System.EventHandler(this.cbxEngine_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(113, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "試算結果";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtResult.Location = new System.Drawing.Point(224, 350);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(623, 402);
            this.txtResult.TabIndex = 11;
            // 
            // btnSumit
            // 
            this.btnSumit.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSumit.Location = new System.Drawing.Point(200, 780);
            this.btnSumit.Name = "btnSumit";
            this.btnSumit.Size = new System.Drawing.Size(126, 53);
            this.btnSumit.TabIndex = 12;
            this.btnSumit.Text = "確定送出";
            this.btnSumit.UseVisualStyleBackColor = true;
            this.btnSumit.Click += new System.EventHandler(this.btnSumit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(400, 780);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 53);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "清除重填";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // yearMsg
            // 
            this.yearMsg.AutoSize = true;
            this.yearMsg.BackColor = System.Drawing.Color.Transparent;
            this.yearMsg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearMsg.ForeColor = System.Drawing.Color.Red;
            this.yearMsg.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.yearMsg.Location = new System.Drawing.Point(437, 173);
            this.yearMsg.Name = "yearMsg";
            this.yearMsg.Size = new System.Drawing.Size(153, 20);
            this.yearMsg.TabIndex = 14;
            this.yearMsg.Text = "請選擇正確時間範圍";
            this.yearMsg.Visible = false;
            // 
            // typeMsg
            // 
            this.typeMsg.AutoSize = true;
            this.typeMsg.BackColor = System.Drawing.Color.Transparent;
            this.typeMsg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.typeMsg.ForeColor = System.Drawing.Color.Red;
            this.typeMsg.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.typeMsg.Location = new System.Drawing.Point(412, 255);
            this.typeMsg.Name = "typeMsg";
            this.typeMsg.Size = new System.Drawing.Size(121, 20);
            this.typeMsg.TabIndex = 15;
            this.typeMsg.Text = "請選擇正確車種";
            this.typeMsg.Visible = false;
            // 
            // engineMsg
            // 
            this.engineMsg.AutoSize = true;
            this.engineMsg.BackColor = System.Drawing.Color.Transparent;
            this.engineMsg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.engineMsg.ForeColor = System.Drawing.Color.Red;
            this.engineMsg.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.engineMsg.Location = new System.Drawing.Point(645, 305);
            this.engineMsg.Name = "engineMsg";
            this.engineMsg.Size = new System.Drawing.Size(121, 20);
            this.engineMsg.TabIndex = 16;
            this.engineMsg.Text = "請選擇正確選項";
            this.engineMsg.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitle.Location = new System.Drawing.Point(3, 2);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(555, 61);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "使用牌照稅應納稅額試算";
            // 
            // labelHint01
            // 
            this.labelHint01.AutoSize = true;
            this.labelHint01.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelHint01.ForeColor = System.Drawing.Color.Crimson;
            this.labelHint01.Location = new System.Drawing.Point(23, 73);
            this.labelHint01.Name = "labelHint01";
            this.labelHint01.Size = new System.Drawing.Size(138, 27);
            this.labelHint01.TabIndex = 18;
            this.labelHint01.Text = "貼心小叮嚀：";
            // 
            // labelHint02
            // 
            this.labelHint02.AutoSize = true;
            this.labelHint02.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelHint02.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHint02.Location = new System.Drawing.Point(37, 103);
            this.labelHint02.Name = "labelHint02";
            this.labelHint02.Size = new System.Drawing.Size(853, 27);
            this.labelHint02.TabIndex = 19;
            this.labelHint02.Text = "1. 本表試算之稅額僅供參考之用，不做任何證明，實際應納稅額仍應以稽徵機關核定為準。";
            // 
            // linkToTaxLabel
            // 
            this.linkToTaxLabel.AutoSize = true;
            this.linkToTaxLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkToTaxLabel.Location = new System.Drawing.Point(37, 135);
            this.linkToTaxLabel.Name = "linkToTaxLabel";
            this.linkToTaxLabel.Size = new System.Drawing.Size(433, 27);
            this.linkToTaxLabel.TabIndex = 21;
            this.linkToTaxLabel.TabStop = true;
            this.linkToTaxLabel.Text = "2. 使用牌照稅稅額對照表及電動車應納稅額表";
            this.linkToTaxLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToTaxLabel_LinkClicked);
            // 
            // btnMsg
            // 
            this.btnMsg.AutoSize = true;
            this.btnMsg.BackColor = System.Drawing.Color.Transparent;
            this.btnMsg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMsg.ForeColor = System.Drawing.Color.Red;
            this.btnMsg.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMsg.Location = new System.Drawing.Point(156, 755);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(233, 20);
            this.btnMsg.TabIndex = 22;
            this.btnMsg.Text = "請重新確認輸入資料正確再送出";
            this.btnMsg.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.Location = new System.Drawing.Point(600, 780);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 53);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 850);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMsg);
            this.Controls.Add(this.linkToTaxLabel);
            this.Controls.Add(this.labelHint02);
            this.Controls.Add(this.labelHint01);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.engineMsg);
            this.Controls.Add(this.typeMsg);
            this.Controls.Add(this.yearMsg);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSumit);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxEngine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePickEnd);
            this.Controls.Add(this.labelRbtn2);
            this.Controls.Add(this.datePickStart);
            this.Controls.Add(this.rbtnPeriod);
            this.Controls.Add(this.rbtnAnnual);
            this.Name = "MainForm";
            this.Text = "LicenseTaxCalculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnAnnual;
        private System.Windows.Forms.RadioButton rbtnPeriod;
        private System.Windows.Forms.DateTimePicker datePickStart;
        private System.Windows.Forms.Label labelRbtn2;
        private System.Windows.Forms.DateTimePicker datePickEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxEngine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSumit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label yearMsg;
        private System.Windows.Forms.Label typeMsg;
        private System.Windows.Forms.Label engineMsg;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelHint01;
        private System.Windows.Forms.Label labelHint02;
        private System.Windows.Forms.LinkLabel linkToTaxLabel;
        private System.Windows.Forms.Label btnMsg;
        private System.Windows.Forms.Button btnExit;
    }
}


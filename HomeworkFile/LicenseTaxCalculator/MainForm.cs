using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseTaxCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region FormActions
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void linkToTaxLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://law-out.mof.gov.tw/LawContent.aspx?id=FL006130");
        }

        private void rbtnAnnual_CheckedChanged(object sender, EventArgs e)
        {

            this.datePickStart.Visible = false;
            this.datePickEnd.Visible = false;
            this.labelRbtn2.Visible = false;
        }

        private void rbtnPeriod_CheckedChanged(object sender, EventArgs e)
        {
            this.datePickStart.Visible = true;
            this.datePickEnd.Visible = true;
            this.labelRbtn2.Visible = true;

            // 自動選擇當年度01/01和12/31
            this.datePickStart.Value = new DateTime(DateTime.Today.Year, 1, 1);
            this.datePickEnd.Value = new DateTime(DateTime.Today.Year, 12, 31);
        }

        private void datePickEnd_ValueChanged(object sender, EventArgs e)
        {
            ErrorDetectDate();
        }

        private void datePickStart_ValueChanged(object sender, EventArgs e)
        {
            ErrorDetectDate();
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshEngineCbx();
            this.cbxEngine.SelectedIndex = 0;
            
            // 觸發表示使用者有正確使用選單, Disable Error Message
            errorType = false;
            this.typeMsg.Visible = false;
        }

        private void cbxType_TextChanged(object sender, EventArgs e)
        {
            ErrorDetectType();
        }

        private void cbxEngine_TextChanged(object sender, EventArgs e)
        {
            ErrorDetectEngine();
        }

        private void btnSumit_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = null;
            _MainCalculation_();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // PopMessage
            if (MessageBox.Show("確定離開?", "離開試算表", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Bye~~~~", "關閉中...");
                Application.Exit();
            }
        }

        #endregion

        #region CostomFunctions
        // 宣告全域變數
        decimal taxValue;
        bool errorDate;
        bool errorType;
        bool errorEngine;
        string[] CarTypes = { "機車", "自用小客車", "營業用小客車", "貨車", "大客車" }; // 車種用途對比清單

        /// <summary> 試算程式初始化 </summary>
        private void Init()
        {
            // 參數初始化
            taxValue = 0;
            errorDate = false;
            errorType = false;
            errorEngine = false;

            // 頁面初始化
            this.yearMsg.Visible = false;
            this.typeMsg.Visible = false;
            this.engineMsg.Visible = false;
            this.btnMsg.Visible = false;
            this.txtResult.AutoSize = true;

            // 選項與輸出初始化
            this.rbtnAnnual.Checked = true;
            this.cbxType.SelectedIndex = 0;
            RefreshEngineCbx();
            this.cbxEngine.SelectedIndex = 0;
            this.txtResult.Text = null;
        }

        /// <summary> 選擇用途ComboBox時,刷新引擎/馬力ComboBox items </summary>
        private void RefreshEngineCbx()
        {
            string carType = this.cbxType.Text;

            switch (carType)
            {
                case "機車":
                    this.cbxEngine.Items.Clear();
                    BikeDic("cbx");
                    break;

                case "自用小客車":
                    this.cbxEngine.Items.Clear();
                    CarDic("cbx");
                    break;

                case "營業用小客車":
                    this.cbxEngine.Items.Clear();
                    CarDic("cbx");
                    break;

                case "貨車":
                    this.cbxEngine.Items.Clear();
                    TruckDic("cbx");
                    break;

                case "大客車":
                    this.cbxEngine.Items.Clear();
                    TruckDic("cbx");
                    break;
            }
        }

        /// <summary> 依照選擇的用途以及馬力,將稅金寫入到全域變數taxValue </summary>
        private void TaxByType()
        {
            switch (this.cbxType.Text)
            {
                case "機車":
                    BikeDic("value");
                    break;

                case "自用小客車":
                    CarDic("value", 0);
                    break;

                case "營業用小客車":
                    CarDic("value", 1);
                    break;

                case "大客車":
                    TruckDic("value", 0);
                    break;

                case "貨車":
                    TruckDic("value", 1);
                    break;
            }
        }

        /// <summary> 偵測使用者是否填入日期範圍錯誤 </summary>
        private void ErrorDetectDate()
        {
            // 判斷結束日期是否小於起始日期
            if (this.datePickEnd.Value < this.datePickStart.Value) 
            {
                this.yearMsg.Visible = true; // 顯示錯誤訊息
                errorDate = true; // 紀錄Error
            }
            else
            {
                this.yearMsg.Visible = false;
                errorDate = false;
            }
        }

        /// <summary> 偵測使用者是否填入用途選項錯誤 </summary>
        private void ErrorDetectType()
        {
            // 比對Array資料
            foreach (string _type in CarTypes)
            {
                if (this.cbxType.Text != _type)
                {
                    this.typeMsg.Visible = true; // 顯示錯誤訊息
                    errorType = true; // 紀錄Error
                }
                else
                {
                    errorType = false;
                    this.typeMsg.Visible = false;
                    break;
                }
            }
        }

        /// <summary> 偵測使用者是否填入馬力選項錯誤 </summary>
        private void ErrorDetectEngine()
        {
            // Dictionary資料比對
            foreach (string _item in this.cbxEngine.Items)
            {
                if (this.cbxEngine.Text != _item)
                {
                    this.engineMsg.Visible = true; // 顯示錯誤訊息
                    errorEngine = true; // 紀錄Error
                }
                else
                {
                    errorEngine = false;
                    this.engineMsg.Visible = false;
                    break;
                }
            }
        }

        /// <summary> 判斷是不是閏年並輸出一年有幾天 </summary> 
        /// <param name="_date"> 查詢的日期 </param>
        /// <returns></returns>
        private int ReturnYearDays(DateTime _date)
        {
            if (DateTime.IsLeapYear(_date.Year))
                return 366; 
            else
                return 365;
        }

        /// <summary> 選擇"全年度"按鈕時, 依照輸入資料輸出稅金 </summary>
        private void AnnualMethod()
        {
            // 宣告區域變數
            DateTime YearTimeHead;
            DateTime YearTimeTail;
            int DaysInYear;

            // 寫入日期變數
            YearTimeHead = new DateTime(DateTime.Today.Year, 1, 1);
            YearTimeTail = new DateTime(DateTime.Today.Year, 12, 31);
            DaysInYear = ReturnYearDays(DateTime.Today);

            // 依照條件選擇稅率並寫到全域變數taxValue
            TaxByType();

            // String Array輸出模板
            string[] outputFomat = {
                        $"使用期間 : {YearTimeHead.ToString("yyyy-MM-dd")} ~ {YearTimeTail.ToString("yyyy-MM-dd")}",
                        $"使用天數 : {DaysInYear}",
                        $"汽缸CC數 : {this.cbxEngine.Text}",
                        $"用途 : {this.cbxType.Text}",
                        $"計算公式 : {taxValue} * {DaysInYear} / {DaysInYear} = {taxValue} 元",
                        $"應繳稅額 : 共 {taxValue} 元",
                        $" -----------------------------------"
                    };

            // 輸出Result到TextBox中
            foreach (string _textLine in outputFomat)
            {
                this.txtResult.Text += _textLine + Environment.NewLine;
            }
        }

        /// <summary> 選擇"依期間"按鈕時, 依照輸入資料與給定期間計算稅率後輸出稅金 </summary>
        private void PeriodMethod()
        {
            // 宣告區域變數
            DateTime YearTimeHead;
            DateTime YearTimeTail; 
            int UsedDays;
            int DaysInYear;
            decimal taxRatio;
            decimal taxTotal = 0;

            // 依照條件選擇稅率並寫到全域變數taxValue
            TaxByType();

            // 判斷是否有跨年
            if (this.datePickStart.Value.Year == this.datePickEnd.Value.Year)
            {
                YearTimeHead = this.datePickStart.Value.Date;
                YearTimeTail = this.datePickEnd.Value.Date;

                UsedDays = (YearTimeTail - YearTimeHead).Days + 1;
                DaysInYear = ReturnYearDays(this.datePickStart.Value);

                taxRatio = Math.Truncate((decimal)(taxValue * UsedDays / DaysInYear)); //直接轉型;無條件捨去

                // String Array輸出模板
                string[] outputFomat = {
                        $"使用期間 : {YearTimeHead.ToString("yyyy-MM-dd")} ~ {YearTimeTail.ToString("yyyy-MM-dd")}",
                        $"使用天數 : {UsedDays}",
                        $"汽缸CC數 : {this.cbxEngine.Text}",
                        $"用途 : {this.cbxType.Text}",
                        $"計算公式 : {taxValue} * {UsedDays} / {DaysInYear} = {taxRatio} 元",
                        $"應繳稅額 : 共 {taxRatio} 元",
                        $" -----------------------------------"
                    };

                // 輸出Result到TextBox中
                foreach (string _textLine in outputFomat)
                {
                    this.txtResult.Text += _textLine + Environment.NewLine;
                }
            }
            else
            {
                // 跨年迴圈輸出
                for (int _year = this.datePickStart.Value.Year; _year <= this.datePickEnd.Value.Year; _year++)
                {
                    if (_year == this.datePickStart.Value.Year) // 開始年段
                    {
                        YearTimeHead = this.datePickStart.Value.Date;
                        YearTimeTail = new DateTime(this.datePickStart.Value.Year, 12, 31);
                        UsedDays = (YearTimeTail - YearTimeHead).Days + 1;
                    }
                    else if (_year == this.datePickEnd.Value.Year) // 結束年段
                    {
                        YearTimeHead = new DateTime(this.datePickEnd.Value.Year, 1, 1);
                        YearTimeTail = this.datePickEnd.Value.Date;
                        UsedDays = (YearTimeTail - YearTimeHead).Days + 1;
                    }
                    else // 中間年段
                    {
                        YearTimeHead = new DateTime(_year, 1, 1);
                        YearTimeTail = new DateTime(_year, 12, 31);
                        UsedDays = (YearTimeTail - YearTimeHead).Days + 1;
                    }

                    // 計算稅金
                    DaysInYear = ReturnYearDays(YearTimeHead);
                    taxRatio = Math.Truncate((decimal)(taxValue * UsedDays / DaysInYear)); //強制轉型,無條件捨去

                    // String Array輸出模板
                    string[] outputFomat = {
                        $"使用期間 : {YearTimeHead.ToString("yyyy-MM-dd")} ~ {YearTimeTail.ToString("yyyy-MM-dd")}",
                        $"使用天數 : {UsedDays}",
                        $"汽缸CC數 : {this.cbxEngine.Text}",
                        $"用途 : {this.cbxType.Text}",
                        $"計算公式 : {taxValue} * {UsedDays} / {DaysInYear} = {taxRatio} 元",
                        $"應繳稅額 : 共 {taxRatio} 元",
                        $" -----------------------------------"
                    };

                    // 輸出Result到TextBox中
                    foreach (string _textLine in outputFomat)
                    {
                        this.txtResult.Text += _textLine + Environment.NewLine;
                    }

                    // 加總每一年段稅金
                    taxTotal += taxRatio;
                }

                // 輸出總稅額金額
                this.txtResult.Text += $"全部應繳稅額 : 共 {taxTotal} 元";
            }
        }

        /// <summary> 主要輸出Method </summary>
        private void _MainCalculation_()
        {
            if (errorDate || errorType || errorEngine)
            {
                this.btnMsg.Visible = true;
                this.txtResult.Text = "計算發生錯誤, 請檢查上方選項正確後再重新送出";
            }
            else
            {
                this.btnMsg.Visible = false;
                
                if (rbtnAnnual.Checked) // 依年度
                {
                    AnnualMethod();
                }
                else if (rbtnPeriod.Checked) // 依區間
                {
                    PeriodMethod();
                }
            }
        }
        #endregion

        #region TaxInfoDictionary
        /// <summary> 機車稅率表 </summary>
        /// <param name="_input">輸入字串使用相關功能;
        /// cbx: 輸出key string; value: 取得value</param>
        private void BikeDic(string _input)
        {
            // 建立稅率Dictionary
            Dictionary<string, int> _bikeTax = new Dictionary<string, int>() {
                {"150cc以下 / 20.19HP以下(21.54PS以下)", 0 },
                {"151cc - 250cc / 20.20 - 40.03HP(21.55 - 42.71PS)", 800 },
                {"251cc - 500cc / 40.04 - 50.07HP(42.72 - 53.43PS)", 1620 },
                {"501cc - 600cc / 50.08 - 58.79HP(53.44 - 62.73PS)", 2160 },
                {"1201cc - 1800cc / 58.80 - 114.11HP(62.74 - 121.76PS)", 7120 },
                {"1801cc或以上 / 114.12HP或以上(121.77PS或以上)", 11230 }
            };

            // 出錯偵錯並顯示錯誤訊息
            try
            {
                // 選擇case
                switch (_input)
                {
                    case "cbx": // 輸出Key資料
                        foreach (var items in _bikeTax)
                        {
                            this.cbxEngine.Items.Add(items.Key);
                        }
                        break;

                    case "value": // 輸出稅金
                        foreach (var _key in _bikeTax.Keys)
                        {
                            if (_key == this.cbxEngine.Text)
                            {
                                taxValue = _bikeTax[_key];
                            }
                        }
                        break;
                }
            }
            catch (Exception _ex)
            {
                this.txtResult.Text = "Dictionary 功能出錯，請通知相關工程人員" + Environment.NewLine;
                this.txtResult.Text += _ex.ToString();
            }
        }

        /// <summary> 汽車稅率表 </summary>
        /// <param name="_input"> 輸入字串使用相關功能; cbx: 輸出key string; value: 取得value </param>
        /// <param name="_type"> 輸入數字使用相關功能; 0: 自用; 1: 營業用; 2:無動作</param>
        private void CarDic(string _input, int _type = 2)
        {
            // 建立稅率Dictionary
            Dictionary<string, int[]> _carTax = new Dictionary<string, int[]>() {
                {"500以下 / 38HP以下(38.6PS以下)", new int[2]{ 1620, 900}},
                {"501cc - 600cc / 38.1-56HP(38.7-56.8PS)", new int[2] { 2160, 1260 }},
                {"601cc - 1200cc / 56.1-83HP(56.9-84.2PS)", new int[2] { 4320, 2160 }},
                {"1201cc - 1800cc / 83.1-182HP(84.3-184.7PS)", new int[2] { 7120, 3060 }},
                {"1801cc - 2400cc / 182.1-262HP(184.8-265.9PS)", new int[2] { 11230, 6480 }},
                {"2401cc - 3000cc / 262.1-322HP(266-326.8PS)", new int[2] { 15210, 9900 }},
                {"3001cc - 4200cc / 322.1-414HP(326.9-420.2PS", new int[2] { 28220, 16380 }},
                {"4201cc - 5400cc / 414.1-469HP(420.3-476.0PS)", new int[2] { 46170, 24300 }},
                {"5401cc - 6600cc / 469.1-509HP(476.1-516.6PS)", new int[2] { 69690, 33660 }},
                {"6601cc - 7800cc / 509.1HP以上(516.7PS以上)", new int[2] { 117000, 44460 }},
                {"7801cc 以上", new int[2] { 151200, 56700 }}
            };

            // 出錯偵錯並顯示錯誤訊息
            try
            {
                // 選擇case
                switch (_input)
                {
                    case "cbx":     // 輸出Key
                        foreach (var items in _carTax)
                        {
                            this.cbxEngine.Items.Add(items.Key);
                        }
                        break;

                    case "value":   // 輸出稅金
                        if (_type == 0 || _type == 1)
                        {
                            foreach (var _key in _carTax.Keys)
                            {
                                if (_key == this.cbxEngine.Text)
                                {
                                    taxValue = _carTax[_key][_type];
                                }
                            }
                        }
                        break;
                }
            }
            catch (Exception _ex)
            {
                this.txtResult.Text = "Dictionary 功能出錯，請通知相關工程人員" + Environment.NewLine;
                this.txtResult.Text += _ex.ToString();
            }
        }

        /// <summary> 大車稅率表 </summary>
        /// <param name="_input"> 輸入字串使用相關功能; cbx: 輸出key string; value: 取得value </param>
        /// <param name="_type"> 輸入數字使用相關功能; 0: 大客車; 1: 貨車; 2:無動作</param>
        private void TruckDic(string _input, int _type = 2)
        {
            Dictionary<string, int[]> _truckTax = new Dictionary<string, int[]>() {
                {"500cc 以下", new int[2]{ 0, 900}},
                {"501cc - 600cc", new int[2] { 1080, 1080 }},
                {"601cc - 1200cc", new int[2] { 1800, 1800 }},
                {"1201cc - 1800cc", new int[2] { 2700, 2700 }},
                {"1801cc - 2400cc", new int[2] { 3600, 3600 }},
                {"2401cc - 3000cc / 138HP以下(140.1PS以下)", new int[2] { 4500, 4500 }},
                {"3001cc - 3600cc", new int[2] { 5400, 5400 }},
                {"3601cc - 4200cc / 138.1-200HP(140.2-203.0PS)", new int[2] { 6300, 6300 }},
                {"4201cc - 4800cc", new int[2] { 7200, 7200 }},
                {"4801cc - 5400cc / 200.1-247HP(203.1-250.7PS)", new int[2] { 8100, 8100 }},
                {"5401cc - 6000cc", new int[2] { 9000, 9000 }},
                {"6001cc - 6600cc / 247.1-286HP(250.8-290.3PS)", new int[2] { 9900, 9900 }},
                {"6601cc - 7200cc", new int[2] { 10800, 10800 }},
                {"7201cc - 7800cc / 286.1-336HP(290.4-341.0PS)", new int[2] { 11700, 11700 }},
                {"7801cc - 8400cc", new int[2] { 12600, 12600 }},
                {"8401cc - 9000cc / 336.1-361HP(341.1-366.4PS)", new int[2] { 13500, 13500 }},
                {"9001cc - 9600cc", new int[2] { 14400, 14400 }},
                {"9601cc - 10200cc / 361.1HP以上(366.5PS以上)", new int[2] { 15300, 15300 }},
                {"10201cc 以上", new int[2] { 16200, 16200 }},
            };

            // 出錯偵錯並顯示錯誤訊息
            try
            {
                // 選擇case
                switch (_input)
                {
                    case "cbx":   // 輸出Key
                        foreach (var items in _truckTax)
                        {
                            this.cbxEngine.Items.Add(items.Key);
                        }
                        break;

                    case "value":  // 輸出稅金
                        foreach (var _key in _truckTax.Keys)
                        {
                            if (_key == this.cbxEngine.Text)
                            {
                                taxValue = _truckTax[_key][_type];
                            }
                        }
                        break;
                }
            }
            catch (Exception _ex)
            {
                this.txtResult.Text = "Dictionary 功能出錯，請通知相關工程人員" + Environment.NewLine;
                this.txtResult.Text += _ex.ToString();
            }
        }

        #endregion

    }
}

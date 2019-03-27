namespace Trend_Analyser
{
    partial class Data_Request
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn1mon = new System.Windows.Forms.Button();
            this.btn3mon = new System.Windows.Forms.Button();
            this.btn6mon = new System.Windows.Forms.Button();
            this.btn1yr = new System.Windows.Forms.Button();
            this.btn3yr = new System.Windows.Forms.Button();
            this.btn5yr = new System.Windows.Forms.Button();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlSingleRequest = new System.Windows.Forms.TableLayoutPanel();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnShowChart = new System.Windows.Forms.Button();
            this.btnShowLineChart = new System.Windows.Forms.Button();
            this.btn_support_resistant_predictor_1 = new System.Windows.Forms.Button();
            this.btn_support_resistant_predictor_1_enable_charts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tlRequestMultiple = new System.Windows.Forms.TableLayoutPanel();
            this.txtSymbolAdder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddSymbol = new System.Windows.Forms.Button();
            this.btnRequestAll = new System.Windows.Forms.Button();
            this.symbolsList = new System.Windows.Forms.ListBox();
            this.btnDeleteSymbol = new System.Windows.Forms.Button();
            this.btnClearAllSymbol = new System.Windows.Forms.Button();
            this.fileLister = new System.Windows.Forms.ListBox();
            this.btnRequestMultiple = new System.Windows.Forms.Button();
            this.btnSingleMode = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_support_resistant_predictor_1_review_all = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlSingleRequest.SuspendLayout();
            this.tlRequestMultiple.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Date";
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(78, 3);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(165, 20);
            this.fromDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Recent Data";
            // 
            // btn1mon
            // 
            this.btn1mon.Location = new System.Drawing.Point(3, 3);
            this.btn1mon.Name = "btn1mon";
            this.btn1mon.Size = new System.Drawing.Size(75, 23);
            this.btn1mon.TabIndex = 4;
            this.btn1mon.Text = "1 month";
            this.btn1mon.UseVisualStyleBackColor = true;
            this.btn1mon.Click += new System.EventHandler(this.btn1mon_Click);
            // 
            // btn3mon
            // 
            this.btn3mon.Location = new System.Drawing.Point(84, 3);
            this.btn3mon.Name = "btn3mon";
            this.btn3mon.Size = new System.Drawing.Size(75, 23);
            this.btn3mon.TabIndex = 5;
            this.btn3mon.Text = "3 months";
            this.btn3mon.UseVisualStyleBackColor = true;
            this.btn3mon.Click += new System.EventHandler(this.btn3mon_Click);
            // 
            // btn6mon
            // 
            this.btn6mon.Location = new System.Drawing.Point(165, 3);
            this.btn6mon.Name = "btn6mon";
            this.btn6mon.Size = new System.Drawing.Size(75, 23);
            this.btn6mon.TabIndex = 6;
            this.btn6mon.Text = "6 months";
            this.btn6mon.UseVisualStyleBackColor = true;
            this.btn6mon.Click += new System.EventHandler(this.btn6mon_Click);
            // 
            // btn1yr
            // 
            this.btn1yr.Location = new System.Drawing.Point(3, 32);
            this.btn1yr.Name = "btn1yr";
            this.btn1yr.Size = new System.Drawing.Size(75, 23);
            this.btn1yr.TabIndex = 7;
            this.btn1yr.Text = "1 year";
            this.btn1yr.UseVisualStyleBackColor = true;
            this.btn1yr.Click += new System.EventHandler(this.btn1yr_Click);
            // 
            // btn3yr
            // 
            this.btn3yr.Location = new System.Drawing.Point(84, 32);
            this.btn3yr.Name = "btn3yr";
            this.btn3yr.Size = new System.Drawing.Size(75, 23);
            this.btn3yr.TabIndex = 8;
            this.btn3yr.Text = "3 years";
            this.btn3yr.UseVisualStyleBackColor = true;
            this.btn3yr.Click += new System.EventHandler(this.btn3yr_Click);
            // 
            // btn5yr
            // 
            this.btn5yr.Location = new System.Drawing.Point(165, 32);
            this.btn5yr.Name = "btn5yr";
            this.btn5yr.Size = new System.Drawing.Size(75, 23);
            this.btn5yr.TabIndex = 9;
            this.btn5yr.Text = "5 years";
            this.btn5yr.UseVisualStyleBackColor = true;
            this.btn5yr.Click += new System.EventHandler(this.btn5yr_Click);
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(78, 33);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(165, 20);
            this.toDate.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn1mon);
            this.flowLayoutPanel1.Controls.Add(this.btn3mon);
            this.flowLayoutPanel1.Controls.Add(this.btn6mon);
            this.flowLayoutPanel1.Controls.Add(this.btn1yr);
            this.flowLayoutPanel1.Controls.Add(this.btn3yr);
            this.flowLayoutPanel1.Controls.Add(this.btn5yr);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(246, 65);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.8642F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.1358F));
            this.tableLayoutPanel1.Controls.Add(this.toDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fromDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 61);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tlSingleRequest
            // 
            this.tlSingleRequest.ColumnCount = 2;
            this.tlSingleRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlSingleRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tlSingleRequest.Controls.Add(this.txtSymbol, 1, 0);
            this.tlSingleRequest.Controls.Add(this.label4, 0, 0);
            this.tlSingleRequest.Location = new System.Drawing.Point(12, 163);
            this.tlSingleRequest.Name = "tlSingleRequest";
            this.tlSingleRequest.RowCount = 1;
            this.tlSingleRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlSingleRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlSingleRequest.Size = new System.Drawing.Size(246, 30);
            this.tlSingleRequest.TabIndex = 14;
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(77, 3);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(163, 20);
            this.txtSymbol.TabIndex = 15;
            this.txtSymbol.Text = "SBIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Symbol";
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(12, 199);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(246, 23);
            this.btnRequest.TabIndex = 15;
            this.btnRequest.Text = "&Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(594, 493);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(594, 465);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnShowChart
            // 
            this.btnShowChart.Location = new System.Drawing.Point(264, 465);
            this.btnShowChart.Name = "btnShowChart";
            this.btnShowChart.Size = new System.Drawing.Size(138, 23);
            this.btnShowChart.TabIndex = 19;
            this.btnShowChart.Text = "Show Candlestick Chart";
            this.btnShowChart.UseVisualStyleBackColor = true;
            this.btnShowChart.Click += new System.EventHandler(this.btnShowChart_Click);
            // 
            // btnShowLineChart
            // 
            this.btnShowLineChart.Location = new System.Drawing.Point(264, 493);
            this.btnShowLineChart.Name = "btnShowLineChart";
            this.btnShowLineChart.Size = new System.Drawing.Size(138, 23);
            this.btnShowLineChart.TabIndex = 20;
            this.btnShowLineChart.Text = "Show Line Chart";
            this.btnShowLineChart.UseVisualStyleBackColor = true;
            this.btnShowLineChart.Click += new System.EventHandler(this.btnShowLineChart_Click);
            // 
            // btn_support_resistant_predictor_1
            // 
            this.btn_support_resistant_predictor_1.Location = new System.Drawing.Point(12, 438);
            this.btn_support_resistant_predictor_1.Name = "btn_support_resistant_predictor_1";
            this.btn_support_resistant_predictor_1.Size = new System.Drawing.Size(174, 36);
            this.btn_support_resistant_predictor_1.TabIndex = 21;
            this.btn_support_resistant_predictor_1.Text = "Support and Resistance based Predictor 1";
            this.btn_support_resistant_predictor_1.UseVisualStyleBackColor = true;
            this.btn_support_resistant_predictor_1.Click += new System.EventHandler(this.btn_support_resistant_predictor_1_Click);
            // 
            // btn_support_resistant_predictor_1_enable_charts
            // 
            this.btn_support_resistant_predictor_1_enable_charts.Location = new System.Drawing.Point(12, 480);
            this.btn_support_resistant_predictor_1_enable_charts.Name = "btn_support_resistant_predictor_1_enable_charts";
            this.btn_support_resistant_predictor_1_enable_charts.Size = new System.Drawing.Size(120, 36);
            this.btn_support_resistant_predictor_1_enable_charts.TabIndex = 22;
            this.btn_support_resistant_predictor_1_enable_charts.Text = "Show Segmentation Chart";
            this.btn_support_resistant_predictor_1_enable_charts.UseVisualStyleBackColor = true;
            this.btn_support_resistant_predictor_1_enable_charts.Click += new System.EventHandler(this.btn_support_resistant_predictor_1_enable_charts_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 23;
            this.button1.Text = "Show Regression Chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tlRequestMultiple
            // 
            this.tlRequestMultiple.ColumnCount = 2;
            this.tlRequestMultiple.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlRequestMultiple.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tlRequestMultiple.Controls.Add(this.txtSymbolAdder, 1, 0);
            this.tlRequestMultiple.Controls.Add(this.label5, 0, 0);
            this.tlRequestMultiple.Controls.Add(this.btnAddSymbol, 1, 1);
            this.tlRequestMultiple.Location = new System.Drawing.Point(12, 262);
            this.tlRequestMultiple.Name = "tlRequestMultiple";
            this.tlRequestMultiple.RowCount = 2;
            this.tlRequestMultiple.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlRequestMultiple.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlRequestMultiple.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlRequestMultiple.Size = new System.Drawing.Size(246, 62);
            this.tlRequestMultiple.TabIndex = 24;
            this.tlRequestMultiple.Visible = false;
            // 
            // txtSymbolAdder
            // 
            this.txtSymbolAdder.Location = new System.Drawing.Point(77, 3);
            this.txtSymbolAdder.Name = "txtSymbolAdder";
            this.txtSymbolAdder.Size = new System.Drawing.Size(163, 20);
            this.txtSymbolAdder.TabIndex = 15;
            this.txtSymbolAdder.Text = "SBIN";
            this.txtSymbolAdder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSymbolAdder_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Symbol";
            // 
            // btnAddSymbol
            // 
            this.btnAddSymbol.Location = new System.Drawing.Point(77, 33);
            this.btnAddSymbol.Name = "btnAddSymbol";
            this.btnAddSymbol.Size = new System.Drawing.Size(163, 23);
            this.btnAddSymbol.TabIndex = 28;
            this.btnAddSymbol.Text = "Add To List";
            this.btnAddSymbol.UseVisualStyleBackColor = true;
            this.btnAddSymbol.Click += new System.EventHandler(this.btnAddSymbol_Click);
            // 
            // btnRequestAll
            // 
            this.btnRequestAll.Location = new System.Drawing.Point(12, 330);
            this.btnRequestAll.Name = "btnRequestAll";
            this.btnRequestAll.Size = new System.Drawing.Size(246, 23);
            this.btnRequestAll.TabIndex = 25;
            this.btnRequestAll.Text = "Request All";
            this.btnRequestAll.UseVisualStyleBackColor = true;
            this.btnRequestAll.Visible = false;
            this.btnRequestAll.Click += new System.EventHandler(this.btnRequestAll_Click);
            // 
            // symbolsList
            // 
            this.symbolsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.symbolsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolsList.FormattingEnabled = true;
            this.symbolsList.ItemHeight = 16;
            this.symbolsList.Location = new System.Drawing.Point(264, 233);
            this.symbolsList.Name = "symbolsList";
            this.symbolsList.Size = new System.Drawing.Size(405, 162);
            this.symbolsList.TabIndex = 26;
            this.symbolsList.Visible = false;
            // 
            // btnDeleteSymbol
            // 
            this.btnDeleteSymbol.Location = new System.Drawing.Point(509, 404);
            this.btnDeleteSymbol.Name = "btnDeleteSymbol";
            this.btnDeleteSymbol.Size = new System.Drawing.Size(160, 23);
            this.btnDeleteSymbol.TabIndex = 27;
            this.btnDeleteSymbol.Text = "Delete Selected";
            this.btnDeleteSymbol.UseVisualStyleBackColor = true;
            this.btnDeleteSymbol.Visible = false;
            this.btnDeleteSymbol.Click += new System.EventHandler(this.btnDeleteSymbol_Click);
            // 
            // btnClearAllSymbol
            // 
            this.btnClearAllSymbol.Location = new System.Drawing.Point(509, 433);
            this.btnClearAllSymbol.Name = "btnClearAllSymbol";
            this.btnClearAllSymbol.Size = new System.Drawing.Size(160, 23);
            this.btnClearAllSymbol.TabIndex = 29;
            this.btnClearAllSymbol.Text = "Clear All";
            this.btnClearAllSymbol.UseVisualStyleBackColor = true;
            this.btnClearAllSymbol.Visible = false;
            this.btnClearAllSymbol.Click += new System.EventHandler(this.btnClearAllSymbol_Click);
            // 
            // fileLister
            // 
            this.fileLister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileLister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLister.FormattingEnabled = true;
            this.fileLister.ItemHeight = 16;
            this.fileLister.Location = new System.Drawing.Point(264, 57);
            this.fileLister.Name = "fileLister";
            this.fileLister.Size = new System.Drawing.Size(405, 402);
            this.fileLister.TabIndex = 30;
            // 
            // btnRequestMultiple
            // 
            this.btnRequestMultiple.Location = new System.Drawing.Point(12, 233);
            this.btnRequestMultiple.Name = "btnRequestMultiple";
            this.btnRequestMultiple.Size = new System.Drawing.Size(246, 23);
            this.btnRequestMultiple.TabIndex = 31;
            this.btnRequestMultiple.Text = "Request Multiple";
            this.btnRequestMultiple.UseVisualStyleBackColor = true;
            this.btnRequestMultiple.Click += new System.EventHandler(this.btnRequestMultiple_Click);
            // 
            // btnSingleMode
            // 
            this.btnSingleMode.Location = new System.Drawing.Point(12, 233);
            this.btnSingleMode.Name = "btnSingleMode";
            this.btnSingleMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSingleMode.Size = new System.Drawing.Size(246, 23);
            this.btnSingleMode.TabIndex = 32;
            this.btnSingleMode.Text = "Single Mode";
            this.btnSingleMode.UseVisualStyleBackColor = true;
            this.btnSingleMode.Visible = false;
            this.btnSingleMode.Click += new System.EventHandler(this.btnSingleMode_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_support_resistant_predictor_1_review_all
            // 
            this.btn_support_resistant_predictor_1_review_all.Location = new System.Drawing.Point(192, 438);
            this.btn_support_resistant_predictor_1_review_all.Name = "btn_support_resistant_predictor_1_review_all";
            this.btn_support_resistant_predictor_1_review_all.Size = new System.Drawing.Size(66, 36);
            this.btn_support_resistant_predictor_1_review_all.TabIndex = 34;
            this.btn_support_resistant_predictor_1_review_all.Text = "Review All";
            this.btn_support_resistant_predictor_1_review_all.UseVisualStyleBackColor = true;
            this.btn_support_resistant_predictor_1_review_all.Click += new System.EventHandler(this.btn_support_resistant_predictor_1_review_all_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Search";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(311, 25);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(358, 20);
            this.txtKeyword.TabIndex = 36;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // Data_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 527);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_support_resistant_predictor_1_review_all);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSingleMode);
            this.Controls.Add(this.btnRequestMultiple);
            this.Controls.Add(this.fileLister);
            this.Controls.Add(this.btnClearAllSymbol);
            this.Controls.Add(this.btnDeleteSymbol);
            this.Controls.Add(this.symbolsList);
            this.Controls.Add(this.btnRequestAll);
            this.Controls.Add(this.tlRequestMultiple);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_support_resistant_predictor_1_enable_charts);
            this.Controls.Add(this.btn_support_resistant_predictor_1);
            this.Controls.Add(this.btnShowLineChart);
            this.Controls.Add(this.btnShowChart);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.tlSingleRequest);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Data_Request";
            this.Text = "Data Request";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Data_Request_FormClosed);
            this.Load += new System.EventHandler(this.Data_Request_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlSingleRequest.ResumeLayout(false);
            this.tlSingleRequest.PerformLayout();
            this.tlRequestMultiple.ResumeLayout(false);
            this.tlRequestMultiple.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn1mon;
        private System.Windows.Forms.Button btn3mon;
        private System.Windows.Forms.Button btn6mon;
        private System.Windows.Forms.Button btn1yr;
        private System.Windows.Forms.Button btn3yr;
        private System.Windows.Forms.Button btn5yr;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlSingleRequest;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnShowChart;
        private System.Windows.Forms.Button btnShowLineChart;
        private System.Windows.Forms.Button btn_support_resistant_predictor_1;
        private System.Windows.Forms.Button btn_support_resistant_predictor_1_enable_charts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tlRequestMultiple;
        private System.Windows.Forms.TextBox txtSymbolAdder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRequestAll;
        private System.Windows.Forms.ListBox symbolsList;
        private System.Windows.Forms.Button btnDeleteSymbol;
        private System.Windows.Forms.Button btnAddSymbol;
        private System.Windows.Forms.Button btnClearAllSymbol;
        private System.Windows.Forms.ListBox fileLister;
        private System.Windows.Forms.Button btnRequestMultiple;
        private System.Windows.Forms.Button btnSingleMode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_support_resistant_predictor_1_review_all;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKeyword;
    }
}
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.myBuyingPriceBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.refreshPriceButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.balanceBTCBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.balanceUSDBox = New System.Windows.Forms.TextBox()
        Me.autoTimer = New System.Windows.Forms.Timer(Me.components)
        Me.enableTimerButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timerIntervalBox = New System.Windows.Forms.TextBox()
        Me.buyCoinButton = New System.Windows.Forms.Button()
        Me.sellCoinButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lastRateBox = New System.Windows.Forms.TextBox()
        Me.logBox = New System.Windows.Forms.TextBox()
        Me.nextSellValueBox = New System.Windows.Forms.TextBox()
        Me.netValueBox = New System.Windows.Forms.TextBox()
        Me.percentChangeBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mySellingPriceBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.priorWhatIPayBox = New System.Windows.Forms.TextBox()
        Me.whatIPayPercentChangeBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.autoSellCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.emaSellValueBox = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.smaSellValueBox = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.smaSellTimeBox = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.emaSellTimeBox = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.buyPercentBox = New System.Windows.Forms.TextBox()
        Me.nextBuyValueBox = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.emaBuyValueBox = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.smaBuyValueBox = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.smaBuyTimeBox = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.emaBuyTimeBox = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.sellPercentBox = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.whatIGotBox = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.whatIPaidBox = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.autoBuyCheckBox = New System.Windows.Forms.CheckBox()
        Me.donateButton = New System.Windows.Forms.Button()
        Me.helpButton = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.avgBuyBox = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.avgSellBox = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.avgHourBox = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tickerSell = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tickerBuy = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tickerLast = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tickerVol = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tickerAvg = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tickerLow = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tickerHigh = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tickerTime = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.balanceTimer = New System.Windows.Forms.Timer(Me.components)
        Me.getBalanceTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.openOrdersButton = New System.Windows.Forms.Button()
        Me.withdrawButton = New System.Windows.Forms.Button()
        Me.getBalanceButton = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.saveDataButton = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.balanceCheckBox = New System.Windows.Forms.CheckBox()
        Me.balanceTimerBox = New System.Windows.Forms.TextBox()
        Me.walletAddressBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.smtpPasswordBox = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.smtpPortBox = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.emailAddressBox = New System.Windows.Forms.TextBox()
        Me.smtpServerBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.mtGoxFeeBox = New System.Windows.Forms.TextBox()
        Me.usernameBox = New System.Windows.Forms.TextBox()
        Me.passwordBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.simpleSellBox = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.simpleBuyBox = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.simpleRulesCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'myBuyingPriceBox
        '
        Me.myBuyingPriceBox.Location = New System.Drawing.Point(97, 22)
        Me.myBuyingPriceBox.Name = "myBuyingPriceBox"
        Me.myBuyingPriceBox.Size = New System.Drawing.Size(78, 20)
        Me.myBuyingPriceBox.TabIndex = 8
        Me.myBuyingPriceBox.Text = "0"
        Me.myBuyingPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "What I Pay"
        '
        'refreshPriceButton
        '
        Me.refreshPriceButton.Location = New System.Drawing.Point(607, 131)
        Me.refreshPriceButton.Name = "refreshPriceButton"
        Me.refreshPriceButton.Size = New System.Drawing.Size(111, 23)
        Me.refreshPriceButton.TabIndex = 10
        Me.refreshPriceButton.Text = "Refresh Price"
        Me.refreshPriceButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Balance (BTC)"
        '
        'balanceBTCBox
        '
        Me.balanceBTCBox.Location = New System.Drawing.Point(94, 100)
        Me.balanceBTCBox.Name = "balanceBTCBox"
        Me.balanceBTCBox.Size = New System.Drawing.Size(78, 20)
        Me.balanceBTCBox.TabIndex = 16
        Me.balanceBTCBox.Text = "0"
        Me.balanceBTCBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Balance (USD)"
        '
        'balanceUSDBox
        '
        Me.balanceUSDBox.Location = New System.Drawing.Point(94, 74)
        Me.balanceUSDBox.Name = "balanceUSDBox"
        Me.balanceUSDBox.Size = New System.Drawing.Size(78, 20)
        Me.balanceUSDBox.TabIndex = 18
        Me.balanceUSDBox.Text = "0"
        Me.balanceUSDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'autoTimer
        '
        Me.autoTimer.Interval = 6000
        '
        'enableTimerButton
        '
        Me.enableTimerButton.Location = New System.Drawing.Point(11, 17)
        Me.enableTimerButton.Name = "enableTimerButton"
        Me.enableTimerButton.Size = New System.Drawing.Size(102, 23)
        Me.enableTimerButton.TabIndex = 20
        Me.enableTimerButton.Text = "Enable"
        Me.enableTimerButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Wait Time (Sec)"
        '
        'timerIntervalBox
        '
        Me.timerIntervalBox.Location = New System.Drawing.Point(206, 19)
        Me.timerIntervalBox.Name = "timerIntervalBox"
        Me.timerIntervalBox.Size = New System.Drawing.Size(78, 20)
        Me.timerIntervalBox.TabIndex = 26
        Me.timerIntervalBox.Text = "5"
        Me.timerIntervalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'buyCoinButton
        '
        Me.buyCoinButton.Location = New System.Drawing.Point(97, 280)
        Me.buyCoinButton.Name = "buyCoinButton"
        Me.buyCoinButton.Size = New System.Drawing.Size(78, 23)
        Me.buyCoinButton.TabIndex = 28
        Me.buyCoinButton.Text = "Buy Coins"
        Me.buyCoinButton.UseVisualStyleBackColor = True
        '
        'sellCoinButton
        '
        Me.sellCoinButton.Location = New System.Drawing.Point(97, 280)
        Me.sellCoinButton.Name = "sellCoinButton"
        Me.sellCoinButton.Size = New System.Drawing.Size(78, 23)
        Me.sellCoinButton.TabIndex = 29
        Me.sellCoinButton.Text = "Sell Coins"
        Me.sellCoinButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Last Rate"
        '
        'lastRateBox
        '
        Me.lastRateBox.Location = New System.Drawing.Point(97, 49)
        Me.lastRateBox.Name = "lastRateBox"
        Me.lastRateBox.Size = New System.Drawing.Size(78, 20)
        Me.lastRateBox.TabIndex = 31
        Me.lastRateBox.Text = "0"
        Me.lastRateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'logBox
        '
        Me.logBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.logBox.Location = New System.Drawing.Point(0, 416)
        Me.logBox.Multiline = True
        Me.logBox.Name = "logBox"
        Me.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.logBox.Size = New System.Drawing.Size(978, 208)
        Me.logBox.TabIndex = 33
        '
        'nextSellValueBox
        '
        Me.nextSellValueBox.Location = New System.Drawing.Point(97, 126)
        Me.nextSellValueBox.Name = "nextSellValueBox"
        Me.nextSellValueBox.Size = New System.Drawing.Size(78, 20)
        Me.nextSellValueBox.TabIndex = 34
        Me.nextSellValueBox.Text = "0"
        Me.nextSellValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'netValueBox
        '
        Me.netValueBox.Location = New System.Drawing.Point(94, 126)
        Me.netValueBox.Name = "netValueBox"
        Me.netValueBox.Size = New System.Drawing.Size(78, 20)
        Me.netValueBox.TabIndex = 35
        Me.netValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'percentChangeBox
        '
        Me.percentChangeBox.Location = New System.Drawing.Point(97, 75)
        Me.percentChangeBox.Name = "percentChangeBox"
        Me.percentChangeBox.Size = New System.Drawing.Size(78, 20)
        Me.percentChangeBox.TabIndex = 36
        Me.percentChangeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "What I Get"
        '
        'mySellingPriceBox
        '
        Me.mySellingPriceBox.Location = New System.Drawing.Point(97, 22)
        Me.mySellingPriceBox.Name = "mySellingPriceBox"
        Me.mySellingPriceBox.Size = New System.Drawing.Size(78, 20)
        Me.mySellingPriceBox.TabIndex = 37
        Me.mySellingPriceBox.Text = "0"
        Me.mySellingPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(25, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "% Change"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(25, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Sell $ Value"
        '
        'priorWhatIPayBox
        '
        Me.priorWhatIPayBox.Location = New System.Drawing.Point(97, 49)
        Me.priorWhatIPayBox.Name = "priorWhatIPayBox"
        Me.priorWhatIPayBox.Size = New System.Drawing.Size(78, 20)
        Me.priorWhatIPayBox.TabIndex = 45
        Me.priorWhatIPayBox.Text = "0"
        Me.priorWhatIPayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'whatIPayPercentChangeBox
        '
        Me.whatIPayPercentChangeBox.Location = New System.Drawing.Point(97, 75)
        Me.whatIPayPercentChangeBox.Name = "whatIPayPercentChangeBox"
        Me.whatIPayPercentChangeBox.Size = New System.Drawing.Size(78, 20)
        Me.whatIPayPercentChangeBox.TabIndex = 46
        Me.whatIPayPercentChangeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(10, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Last Rate"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(10, 77)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "% Change"
        '
        'autoSellCheckBox
        '
        Me.autoSellCheckBox.AutoSize = True
        Me.autoSellCheckBox.Checked = True
        Me.autoSellCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.autoSellCheckBox.Location = New System.Drawing.Point(290, 21)
        Me.autoSellCheckBox.Name = "autoSellCheckBox"
        Me.autoSellCheckBox.Size = New System.Drawing.Size(68, 17)
        Me.autoSellCheckBox.TabIndex = 49
        Me.autoSellCheckBox.Text = "Auto Sell"
        Me.autoSellCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.emaSellValueBox)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.smaSellValueBox)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.smaSellTimeBox)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.emaSellTimeBox)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.buyPercentBox)
        Me.GroupBox1.Controls.Add(Me.nextBuyValueBox)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.myBuyingPriceBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.whatIPayPercentChangeBox)
        Me.GroupBox1.Controls.Add(Me.buyCoinButton)
        Me.GroupBox1.Controls.Add(Me.priorWhatIPayBox)
        Me.GroupBox1.Location = New System.Drawing.Point(190, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 317)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buying Data"
        '
        'emaSellValueBox
        '
        Me.emaSellValueBox.Location = New System.Drawing.Point(97, 230)
        Me.emaSellValueBox.Name = "emaSellValueBox"
        Me.emaSellValueBox.Size = New System.Drawing.Size(78, 20)
        Me.emaSellValueBox.TabIndex = 87
        Me.emaSellValueBox.Text = "0"
        Me.emaSellValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(10, 233)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(30, 13)
        Me.Label35.TabIndex = 88
        Me.Label35.Text = "EMA"
        '
        'smaSellValueBox
        '
        Me.smaSellValueBox.Location = New System.Drawing.Point(97, 178)
        Me.smaSellValueBox.Name = "smaSellValueBox"
        Me.smaSellValueBox.Size = New System.Drawing.Size(78, 20)
        Me.smaSellValueBox.TabIndex = 85
        Me.smaSellValueBox.Text = "0"
        Me.smaSellValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(10, 181)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(30, 13)
        Me.Label34.TabIndex = 86
        Me.Label34.Text = "SMA"
        '
        'smaSellTimeBox
        '
        Me.smaSellTimeBox.Location = New System.Drawing.Point(97, 152)
        Me.smaSellTimeBox.Name = "smaSellTimeBox"
        Me.smaSellTimeBox.Size = New System.Drawing.Size(78, 20)
        Me.smaSellTimeBox.TabIndex = 83
        Me.smaSellTimeBox.Text = "10"
        Me.smaSellTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(10, 155)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(48, 13)
        Me.Label33.TabIndex = 84
        Me.Label33.Text = "SMA (M)"
        '
        'emaSellTimeBox
        '
        Me.emaSellTimeBox.Location = New System.Drawing.Point(97, 204)
        Me.emaSellTimeBox.Name = "emaSellTimeBox"
        Me.emaSellTimeBox.Size = New System.Drawing.Size(78, 20)
        Me.emaSellTimeBox.TabIndex = 81
        Me.emaSellTimeBox.Text = "5"
        Me.emaSellTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(10, 207)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(48, 13)
        Me.Label32.TabIndex = 82
        Me.Label32.Text = "EMA (M)"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(10, 103)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(36, 13)
        Me.Label30.TabIndex = 54
        Me.Label30.Text = "Buy %"
        '
        'buyPercentBox
        '
        Me.buyPercentBox.Location = New System.Drawing.Point(97, 100)
        Me.buyPercentBox.Name = "buyPercentBox"
        Me.buyPercentBox.Size = New System.Drawing.Size(78, 20)
        Me.buyPercentBox.TabIndex = 53
        Me.buyPercentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nextBuyValueBox
        '
        Me.nextBuyValueBox.Location = New System.Drawing.Point(97, 126)
        Me.nextBuyValueBox.Name = "nextBuyValueBox"
        Me.nextBuyValueBox.Size = New System.Drawing.Size(78, 20)
        Me.nextBuyValueBox.TabIndex = 51
        Me.nextBuyValueBox.Text = "0"
        Me.nextBuyValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(10, 129)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 13)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "Buy $ Value"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.emaBuyValueBox)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.smaBuyValueBox)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.smaBuyTimeBox)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.emaBuyTimeBox)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.sellPercentBox)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.sellCoinButton)
        Me.GroupBox2.Controls.Add(Me.lastRateBox)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.percentChangeBox)
        Me.GroupBox2.Controls.Add(Me.mySellingPriceBox)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.nextSellValueBox)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(385, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 317)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selling Data"
        '
        'emaBuyValueBox
        '
        Me.emaBuyValueBox.Location = New System.Drawing.Point(97, 230)
        Me.emaBuyValueBox.Name = "emaBuyValueBox"
        Me.emaBuyValueBox.Size = New System.Drawing.Size(78, 20)
        Me.emaBuyValueBox.TabIndex = 95
        Me.emaBuyValueBox.Text = "0"
        Me.emaBuyValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(25, 233)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(30, 13)
        Me.Label37.TabIndex = 96
        Me.Label37.Text = "EMA"
        '
        'smaBuyValueBox
        '
        Me.smaBuyValueBox.Location = New System.Drawing.Point(97, 178)
        Me.smaBuyValueBox.Name = "smaBuyValueBox"
        Me.smaBuyValueBox.Size = New System.Drawing.Size(78, 20)
        Me.smaBuyValueBox.TabIndex = 93
        Me.smaBuyValueBox.Text = "0"
        Me.smaBuyValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(25, 182)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(30, 13)
        Me.Label38.TabIndex = 94
        Me.Label38.Text = "SMA"
        '
        'smaBuyTimeBox
        '
        Me.smaBuyTimeBox.Location = New System.Drawing.Point(97, 152)
        Me.smaBuyTimeBox.Name = "smaBuyTimeBox"
        Me.smaBuyTimeBox.Size = New System.Drawing.Size(78, 20)
        Me.smaBuyTimeBox.TabIndex = 91
        Me.smaBuyTimeBox.Text = "10"
        Me.smaBuyTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(25, 156)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(48, 13)
        Me.Label39.TabIndex = 92
        Me.Label39.Text = "SMA (M)"
        '
        'emaBuyTimeBox
        '
        Me.emaBuyTimeBox.Location = New System.Drawing.Point(97, 204)
        Me.emaBuyTimeBox.Name = "emaBuyTimeBox"
        Me.emaBuyTimeBox.Size = New System.Drawing.Size(78, 20)
        Me.emaBuyTimeBox.TabIndex = 89
        Me.emaBuyTimeBox.Text = "5"
        Me.emaBuyTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(25, 208)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(48, 13)
        Me.Label40.TabIndex = 90
        Me.Label40.Text = "EMA (M)"
        '
        'sellPercentBox
        '
        Me.sellPercentBox.Location = New System.Drawing.Point(97, 100)
        Me.sellPercentBox.Name = "sellPercentBox"
        Me.sellPercentBox.Size = New System.Drawing.Size(78, 20)
        Me.sellPercentBox.TabIndex = 41
        Me.sellPercentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(25, 103)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(35, 13)
        Me.Label31.TabIndex = 42
        Me.Label31.Text = "Sell %"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.whatIGotBox)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.whatIPaidBox)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.netValueBox)
        Me.GroupBox3.Controls.Add(Me.balanceBTCBox)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.balanceUSDBox)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(775, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(187, 168)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "User Data"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Net Value"
        '
        'whatIGotBox
        '
        Me.whatIGotBox.Location = New System.Drawing.Point(94, 48)
        Me.whatIGotBox.Name = "whatIGotBox"
        Me.whatIGotBox.Size = New System.Drawing.Size(78, 20)
        Me.whatIGotBox.TabIndex = 39
        Me.whatIGotBox.Text = "0"
        Me.whatIGotBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 13)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "What I Got"
        '
        'whatIPaidBox
        '
        Me.whatIPaidBox.Location = New System.Drawing.Point(94, 22)
        Me.whatIPaidBox.Name = "whatIPaidBox"
        Me.whatIPaidBox.Size = New System.Drawing.Size(78, 20)
        Me.whatIPaidBox.TabIndex = 36
        Me.whatIPaidBox.Text = "0"
        Me.whatIPaidBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 25)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(63, 13)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "What I Paid"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.autoBuyCheckBox)
        Me.GroupBox4.Controls.Add(Me.timerIntervalBox)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.autoSellCheckBox)
        Me.GroupBox4.Controls.Add(Me.enableTimerButton)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 329)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(935, 47)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Auto Buy / Sell"
        '
        'autoBuyCheckBox
        '
        Me.autoBuyCheckBox.AutoSize = True
        Me.autoBuyCheckBox.Checked = True
        Me.autoBuyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.autoBuyCheckBox.Location = New System.Drawing.Point(361, 21)
        Me.autoBuyCheckBox.Name = "autoBuyCheckBox"
        Me.autoBuyCheckBox.Size = New System.Drawing.Size(69, 17)
        Me.autoBuyCheckBox.TabIndex = 50
        Me.autoBuyCheckBox.Text = "Auto Buy"
        Me.autoBuyCheckBox.UseVisualStyleBackColor = True
        '
        'donateButton
        '
        Me.donateButton.Location = New System.Drawing.Point(725, 285)
        Me.donateButton.Name = "donateButton"
        Me.donateButton.Size = New System.Drawing.Size(111, 23)
        Me.donateButton.TabIndex = 45
        Me.donateButton.Text = "Donate!"
        Me.donateButton.UseVisualStyleBackColor = True
        '
        'helpButton
        '
        Me.helpButton.Location = New System.Drawing.Point(842, 285)
        Me.helpButton.Name = "helpButton"
        Me.helpButton.Size = New System.Drawing.Size(102, 23)
        Me.helpButton.TabIndex = 54
        Me.helpButton.Text = "Help!"
        Me.helpButton.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.avgBuyBox)
        Me.GroupBox5.Controls.Add(Me.Label29)
        Me.GroupBox5.Controls.Add(Me.avgSellBox)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Controls.Add(Me.avgHourBox)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.tickerSell)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.tickerBuy)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.tickerLast)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.tickerVol)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.tickerAvg)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.tickerLow)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.tickerHigh)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.tickerTime)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(169, 317)
        Me.GroupBox5.TabIndex = 55
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ticker Data"
        '
        'avgBuyBox
        '
        Me.avgBuyBox.Location = New System.Drawing.Point(74, 256)
        Me.avgBuyBox.Name = "avgBuyBox"
        Me.avgBuyBox.Size = New System.Drawing.Size(78, 20)
        Me.avgBuyBox.TabIndex = 71
        Me.avgBuyBox.Text = "0"
        Me.avgBuyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(7, 259)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(47, 13)
        Me.Label29.TabIndex = 72
        Me.Label29.Text = "Avg Buy"
        '
        'avgSellBox
        '
        Me.avgSellBox.Location = New System.Drawing.Point(74, 282)
        Me.avgSellBox.Name = "avgSellBox"
        Me.avgSellBox.Size = New System.Drawing.Size(78, 20)
        Me.avgSellBox.TabIndex = 69
        Me.avgSellBox.Text = "0"
        Me.avgSellBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(7, 285)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(46, 13)
        Me.Label28.TabIndex = 70
        Me.Label28.Text = "Avg Sell"
        '
        'avgHourBox
        '
        Me.avgHourBox.Location = New System.Drawing.Point(74, 230)
        Me.avgHourBox.Name = "avgHourBox"
        Me.avgHourBox.Size = New System.Drawing.Size(78, 20)
        Me.avgHourBox.TabIndex = 51
        Me.avgHourBox.Text = "2"
        Me.avgHourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(7, 233)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(43, 13)
        Me.Label27.TabIndex = 52
        Me.Label27.Text = "Avg (H)"
        '
        'tickerSell
        '
        Me.tickerSell.Location = New System.Drawing.Point(74, 204)
        Me.tickerSell.Name = "tickerSell"
        Me.tickerSell.Size = New System.Drawing.Size(78, 20)
        Me.tickerSell.TabIndex = 67
        Me.tickerSell.Text = "0"
        Me.tickerSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(8, 207)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(24, 13)
        Me.Label26.TabIndex = 68
        Me.Label26.Text = "Sell"
        '
        'tickerBuy
        '
        Me.tickerBuy.Location = New System.Drawing.Point(74, 178)
        Me.tickerBuy.Name = "tickerBuy"
        Me.tickerBuy.Size = New System.Drawing.Size(78, 20)
        Me.tickerBuy.TabIndex = 65
        Me.tickerBuy.Text = "0"
        Me.tickerBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 181)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(25, 13)
        Me.Label25.TabIndex = 66
        Me.Label25.Text = "Buy"
        '
        'tickerLast
        '
        Me.tickerLast.Location = New System.Drawing.Point(74, 152)
        Me.tickerLast.Name = "tickerLast"
        Me.tickerLast.Size = New System.Drawing.Size(78, 20)
        Me.tickerLast.TabIndex = 63
        Me.tickerLast.Text = "0"
        Me.tickerLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 155)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(27, 13)
        Me.Label24.TabIndex = 64
        Me.Label24.Text = "Last"
        '
        'tickerVol
        '
        Me.tickerVol.Location = New System.Drawing.Point(74, 126)
        Me.tickerVol.Name = "tickerVol"
        Me.tickerVol.Size = New System.Drawing.Size(78, 20)
        Me.tickerVol.TabIndex = 61
        Me.tickerVol.Text = "0"
        Me.tickerVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 129)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 13)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "Volume"
        '
        'tickerAvg
        '
        Me.tickerAvg.Location = New System.Drawing.Point(74, 100)
        Me.tickerAvg.Name = "tickerAvg"
        Me.tickerAvg.Size = New System.Drawing.Size(78, 20)
        Me.tickerAvg.TabIndex = 59
        Me.tickerAvg.Text = "0"
        Me.tickerAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 103)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 13)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Average"
        '
        'tickerLow
        '
        Me.tickerLow.Location = New System.Drawing.Point(74, 74)
        Me.tickerLow.Name = "tickerLow"
        Me.tickerLow.Size = New System.Drawing.Size(78, 20)
        Me.tickerLow.TabIndex = 57
        Me.tickerLow.Text = "0"
        Me.tickerLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 13)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Low"
        '
        'tickerHigh
        '
        Me.tickerHigh.Location = New System.Drawing.Point(74, 48)
        Me.tickerHigh.Name = "tickerHigh"
        Me.tickerHigh.Size = New System.Drawing.Size(78, 20)
        Me.tickerHigh.TabIndex = 55
        Me.tickerHigh.Text = "0"
        Me.tickerHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "High"
        '
        'tickerTime
        '
        Me.tickerTime.Location = New System.Drawing.Point(74, 22)
        Me.tickerTime.Name = "tickerTime"
        Me.tickerTime.Size = New System.Drawing.Size(78, 20)
        Me.tickerTime.TabIndex = 53
        Me.tickerTime.Text = "0"
        Me.tickerTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Time"
        '
        'balanceTimer
        '
        Me.balanceTimer.Enabled = True
        Me.balanceTimer.Interval = 6000
        '
        'getBalanceTimer
        '
        Me.getBalanceTimer.Enabled = True
        Me.getBalanceTimer.Interval = 60000
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(978, 410)
        Me.TabControl1.TabIndex = 56
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.openOrdersButton)
        Me.TabPage1.Controls.Add(Me.withdrawButton)
        Me.TabPage1.Controls.Add(Me.getBalanceButton)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.refreshPriceButton)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.donateButton)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.helpButton)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(970, 384)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mt Gox"
        '
        'openOrdersButton
        '
        Me.openOrdersButton.Location = New System.Drawing.Point(607, 162)
        Me.openOrdersButton.Name = "openOrdersButton"
        Me.openOrdersButton.Size = New System.Drawing.Size(111, 23)
        Me.openOrdersButton.TabIndex = 61
        Me.openOrdersButton.Text = "Show Open Orders"
        Me.openOrdersButton.UseVisualStyleBackColor = True
        '
        'withdrawButton
        '
        Me.withdrawButton.Location = New System.Drawing.Point(784, 208)
        Me.withdrawButton.Name = "withdrawButton"
        Me.withdrawButton.Size = New System.Drawing.Size(111, 23)
        Me.withdrawButton.TabIndex = 59
        Me.withdrawButton.Text = "Withdraw Coins"
        Me.withdrawButton.UseVisualStyleBackColor = True
        '
        'getBalanceButton
        '
        Me.getBalanceButton.Location = New System.Drawing.Point(784, 180)
        Me.getBalanceButton.Name = "getBalanceButton"
        Me.getBalanceButton.Size = New System.Drawing.Size(111, 23)
        Me.getBalanceButton.TabIndex = 58
        Me.getBalanceButton.Text = "Get Balance"
        Me.getBalanceButton.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Chart1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(970, 384)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Graph"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.SystemColors.Control
        ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisY.LabelStyle.Format = "$0.0000"
        ChartArea1.BackColor = System.Drawing.SystemColors.Control
        ChartArea1.BackSecondaryColor = System.Drawing.SystemColors.Control
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 3)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Red
        Series1.Legend = "Legend1"
        Series1.MarkerBorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Series1.Name = "Buy"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.Olive
        Series2.Legend = "Legend1"
        Series2.Name = "Sell"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Color = System.Drawing.Color.Olive
        Series3.Legend = "Legend1"
        Series3.Name = "SMA (Buy)"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Series4.Legend = "Legend1"
        Series4.Name = "EMA (Buy)"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Legend = "Legend1"
        Series5.Name = "SMA (Sell)"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Legend = "Legend1"
        Series6.Name = "EMA (Sell)"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Size = New System.Drawing.Size(964, 378)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.saveDataButton)
        Me.TabPage3.Controls.Add(Me.GroupBox7)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(970, 384)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Settings"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'saveDataButton
        '
        Me.saveDataButton.Location = New System.Drawing.Point(17, 286)
        Me.saveDataButton.Name = "saveDataButton"
        Me.saveDataButton.Size = New System.Drawing.Size(75, 23)
        Me.saveDataButton.TabIndex = 54
        Me.saveDataButton.Text = "Save"
        Me.saveDataButton.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.balanceCheckBox)
        Me.GroupBox7.Controls.Add(Me.balanceTimerBox)
        Me.GroupBox7.Controls.Add(Me.walletAddressBox)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.smtpPasswordBox)
        Me.GroupBox7.Controls.Add(Me.Label42)
        Me.GroupBox7.Controls.Add(Me.smtpPortBox)
        Me.GroupBox7.Controls.Add(Me.Label44)
        Me.GroupBox7.Controls.Add(Me.emailAddressBox)
        Me.GroupBox7.Controls.Add(Me.smtpServerBox)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.Label43)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 11)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(358, 145)
        Me.GroupBox7.TabIndex = 53
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "User Data"
        '
        'balanceCheckBox
        '
        Me.balanceCheckBox.AutoSize = True
        Me.balanceCheckBox.Checked = True
        Me.balanceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.balanceCheckBox.Location = New System.Drawing.Point(190, 94)
        Me.balanceCheckBox.Name = "balanceCheckBox"
        Me.balanceCheckBox.Size = New System.Drawing.Size(110, 17)
        Me.balanceCheckBox.TabIndex = 55
        Me.balanceCheckBox.Text = "Email Balance (H)"
        Me.balanceCheckBox.UseVisualStyleBackColor = True
        '
        'balanceTimerBox
        '
        Me.balanceTimerBox.Location = New System.Drawing.Point(306, 92)
        Me.balanceTimerBox.Name = "balanceTimerBox"
        Me.balanceTimerBox.Size = New System.Drawing.Size(38, 20)
        Me.balanceTimerBox.TabIndex = 54
        Me.balanceTimerBox.Text = "1"
        Me.balanceTimerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'walletAddressBox
        '
        Me.walletAddressBox.Location = New System.Drawing.Point(94, 14)
        Me.walletAddressBox.Name = "walletAddressBox"
        Me.walletAddressBox.Size = New System.Drawing.Size(250, 20)
        Me.walletAddressBox.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Wallet"
        '
        'smtpPasswordBox
        '
        Me.smtpPasswordBox.Location = New System.Drawing.Point(94, 92)
        Me.smtpPasswordBox.Name = "smtpPasswordBox"
        Me.smtpPasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.smtpPasswordBox.Size = New System.Drawing.Size(90, 20)
        Me.smtpPasswordBox.TabIndex = 3
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(6, 95)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(53, 13)
        Me.Label42.TabIndex = 2
        Me.Label42.Text = "Password"
        '
        'smtpPortBox
        '
        Me.smtpPortBox.Location = New System.Drawing.Point(94, 118)
        Me.smtpPortBox.Name = "smtpPortBox"
        Me.smtpPortBox.Size = New System.Drawing.Size(90, 20)
        Me.smtpPortBox.TabIndex = 7
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(6, 121)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(59, 13)
        Me.Label44.TabIndex = 6
        Me.Label44.Text = "SMTP Port"
        '
        'emailAddressBox
        '
        Me.emailAddressBox.Location = New System.Drawing.Point(94, 40)
        Me.emailAddressBox.Name = "emailAddressBox"
        Me.emailAddressBox.Size = New System.Drawing.Size(250, 20)
        Me.emailAddressBox.TabIndex = 44
        '
        'smtpServerBox
        '
        Me.smtpServerBox.Location = New System.Drawing.Point(94, 66)
        Me.smtpServerBox.Name = "smtpServerBox"
        Me.smtpServerBox.Size = New System.Drawing.Size(250, 20)
        Me.smtpServerBox.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "eMail"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(6, 69)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(71, 13)
        Me.Label43.TabIndex = 4
        Me.Label43.Text = "SMTP Server"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label36)
        Me.GroupBox6.Controls.Add(Me.mtGoxFeeBox)
        Me.GroupBox6.Controls.Add(Me.usernameBox)
        Me.GroupBox6.Controls.Add(Me.passwordBox)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 162)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(204, 118)
        Me.GroupBox6.TabIndex = 50
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Mt Gox"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(6, 75)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(25, 13)
        Me.Label36.TabIndex = 60
        Me.Label36.Text = "Fee"
        '
        'mtGoxFeeBox
        '
        Me.mtGoxFeeBox.Location = New System.Drawing.Point(94, 72)
        Me.mtGoxFeeBox.Name = "mtGoxFeeBox"
        Me.mtGoxFeeBox.Size = New System.Drawing.Size(90, 20)
        Me.mtGoxFeeBox.TabIndex = 61
        Me.mtGoxFeeBox.Text = "0.003"
        Me.mtGoxFeeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'usernameBox
        '
        Me.usernameBox.Location = New System.Drawing.Point(94, 23)
        Me.usernameBox.Name = "usernameBox"
        Me.usernameBox.Size = New System.Drawing.Size(90, 20)
        Me.usernameBox.TabIndex = 46
        '
        'passwordBox
        '
        Me.passwordBox.Location = New System.Drawing.Point(94, 46)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordBox.Size = New System.Drawing.Size(90, 20)
        Me.passwordBox.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "User Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Password"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.simpleRulesCheckBox)
        Me.GroupBox8.Controls.Add(Me.simpleSellBox)
        Me.GroupBox8.Controls.Add(Me.Label41)
        Me.GroupBox8.Controls.Add(Me.simpleBuyBox)
        Me.GroupBox8.Controls.Add(Me.Label45)
        Me.GroupBox8.Location = New System.Drawing.Point(607, 7)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(162, 115)
        Me.GroupBox8.TabIndex = 62
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Simple Rules"
        '
        'simpleSellBox
        '
        Me.simpleSellBox.Location = New System.Drawing.Point(78, 48)
        Me.simpleSellBox.Name = "simpleSellBox"
        Me.simpleSellBox.Size = New System.Drawing.Size(78, 20)
        Me.simpleSellBox.TabIndex = 43
        Me.simpleSellBox.Text = "0"
        Me.simpleSellBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(6, 51)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(51, 13)
        Me.Label41.TabIndex = 44
        Me.Label41.Text = "Sell Price"
        '
        'simpleBuyBox
        '
        Me.simpleBuyBox.Location = New System.Drawing.Point(78, 21)
        Me.simpleBuyBox.Name = "simpleBuyBox"
        Me.simpleBuyBox.Size = New System.Drawing.Size(78, 20)
        Me.simpleBuyBox.TabIndex = 41
        Me.simpleBuyBox.Text = "0"
        Me.simpleBuyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(6, 24)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(52, 13)
        Me.Label45.TabIndex = 42
        Me.Label45.Text = "Buy Price"
        '
        'simpleRulesCheckBox
        '
        Me.simpleRulesCheckBox.AutoSize = True
        Me.simpleRulesCheckBox.Location = New System.Drawing.Point(78, 76)
        Me.simpleRulesCheckBox.Name = "simpleRulesCheckBox"
        Me.simpleRulesCheckBox.Size = New System.Drawing.Size(57, 17)
        Me.simpleRulesCheckBox.TabIndex = 45
        Me.simpleRulesCheckBox.Text = "Simple"
        Me.simpleRulesCheckBox.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 624)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.logBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Bitcoin Bot - runlinux [EOCF]"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myBuyingPriceBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents refreshPriceButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents balanceBTCBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents balanceUSDBox As System.Windows.Forms.TextBox
    Friend WithEvents autoTimer As System.Windows.Forms.Timer
    Friend WithEvents enableTimerButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents timerIntervalBox As System.Windows.Forms.TextBox
    Friend WithEvents buyCoinButton As System.Windows.Forms.Button
    Friend WithEvents sellCoinButton As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lastRateBox As System.Windows.Forms.TextBox
    Friend WithEvents logBox As System.Windows.Forms.TextBox
    Friend WithEvents nextSellValueBox As System.Windows.Forms.TextBox
    Friend WithEvents netValueBox As System.Windows.Forms.TextBox
    Friend WithEvents percentChangeBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents mySellingPriceBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents priorWhatIPayBox As System.Windows.Forms.TextBox
    Friend WithEvents whatIPayPercentChangeBox As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents autoSellCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents whatIGotBox As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents whatIPaidBox As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents autoBuyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents nextBuyValueBox As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents donateButton As System.Windows.Forms.Button
    Friend WithEvents helpButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents tickerSell As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents tickerBuy As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents tickerLast As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents tickerVol As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tickerAvg As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tickerLow As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tickerHigh As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tickerTime As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents avgHourBox As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents avgBuyBox As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents avgSellBox As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents buyPercentBox As System.Windows.Forms.TextBox
    Friend WithEvents sellPercentBox As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents balanceTimer As System.Windows.Forms.Timer
    Friend WithEvents getBalanceTimer As System.Windows.Forms.Timer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents emaSellValueBox As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents smaSellValueBox As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents smaSellTimeBox As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents emaSellTimeBox As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents emaBuyValueBox As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents smaBuyValueBox As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents smaBuyTimeBox As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents emaBuyTimeBox As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents smtpPortBox As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents smtpServerBox As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents smtpPasswordBox As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents openOrdersButton As System.Windows.Forms.Button
    Friend WithEvents withdrawButton As System.Windows.Forms.Button
    Friend WithEvents getBalanceButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents walletAddressBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents emailAddressBox As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents usernameBox As System.Windows.Forms.TextBox
    Friend WithEvents passwordBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents balanceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents balanceTimerBox As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents mtGoxFeeBox As System.Windows.Forms.TextBox
    Friend WithEvents saveDataButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents simpleRulesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents simpleSellBox As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents simpleBuyBox As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label

End Class

'Bitcoin Seller

'Aight, i need to setup the trade API to work with tradehill...

'They have everything working now, i just need to code it in...

'for example: buyCoins(Price, Amount, Site)

'I may need to re-do some data structures as I add Tradhill in to i have a tradeHill password and a Mt. Gox password (and usernames)

'so, maybe usernames() and passwords()
'0 would be mt gox, and 1 would be tradehill


Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Net.Mail


Public Class Main

    Structure Trade
        Dim tradeDate As Double
        Dim price As Double
        Dim amount As Double
        Dim dollars As Double
    End Structure

    Structure Average
        Dim price As Double
        Dim time As Date
    End Structure


    Dim tradeData() As Trade

    'Average Bitcoin Selling Price
    Dim averagePrice As Double
    Dim averageBuy() As average
    Dim averageSell() As Average
    Dim currentBuyEMA As Double
    Dim currentBuySMA As Double
    Dim lastBuyEMA As Double
    Dim lastBuySMA As Double
    Dim currentSellEMA As Double
    Dim currentSellSMA As Double
    Dim lastSellEMA As Double
    Dim lastSellSMA As Double


    'Left Side
    Dim lastBoughtPrice As Double
    Dim currentBuyPrice As Double
    Dim priorBuyPrice As Double
    Dim deltaBuyPrice As Double
    Dim buyPercent As Double
    Dim buyValue As Double

    'Right Side
    Dim lastSoldPrice As Double
    Dim currentSellPrice As Double
    Dim lastSellPrice As Double
    Dim deltaSellPrice As Double
    Dim sellPercent As Double
    Dim sellValue As Double
    Dim profit As Double

    'User Information
    Dim username As String
    Dim password As String
    Dim email As String
    Dim emailPassword As String
    Dim emailSMTPServer As String
    Dim emailSMTPServerPort As String
    Dim balanceUSD As Double
    Dim balanceBTC As Double
    Dim netValue As Double
    Dim walletID As String


    'Timer information
    Dim interval As Double

    Dim mtGoxFee As Double
    Dim myFee As Double

    Dim html As String
    Dim myURL As String
    Dim winHttpReq As Object
    Dim graphMax As Double
    Dim graphMin As Double


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim nFileNum As Integer
        Dim tempPrice As String
        Dim x As Long

        winHttpReq = CreateObject("WinHttp.WinHttpRequest.5.1")

        'uhhh... load all values with defaults?
        'read data from the file
        'refresh all text boxes

        lastBoughtPrice = 0
        currentBuyPrice = 0
        priorBuyPrice = 0
        deltaBuyPrice = 0
        buyPercent = 0.01
        buyValue = 0

        lastSoldPrice = 0
        currentSellPrice = 0
        lastSellPrice = 0
        deltaSellPrice = 0
        sellPercent = 0.01
        sellValue = 0
        profit = 0

        username = ""
        password = ""
        email = ""
        emailPassword = ""
        emailSMTPServer = ""
        emailSMTPServerPort = ""
        balanceUSD = 0
        balanceBTC = 0
        netValue = 0
        walletID = ""

        currentBuyEMA = 0
        currentBuySMA = 0
        lastBuyEMA = 0
        lastBuySMA = 0

        currentSellEMA = 0
        currentSellSMA = 0
        lastSellEMA = 0
        lastSellSMA = 0

        graphMin = 0
        graphMax = 100

        ReDim averageBuy(0)
        ReDim averageSell(0)



        mtGoxFee = mtGoxFeeBox.Text
        myFee = 0.01


        If Dir("settings.txt") = "" Then
            'File does not exist... so let us create it now!!

            nFileNum = FreeFile()
            FileOpen(nFileNum, "temp settings.txt", OpenMode.Output)

            WriteLine(nFileNum, "")     'mtGox UserName
            WriteLine(nFileNum, "")     'mtGox Password
            WriteLine(nFileNum, "")     'email address
            WriteLine(nFileNum, "")     'email password
            WriteLine(nFileNum, "")     'email smtp Server
            WriteLine(nFileNum, "")     'email smtp Port
            WriteLine(nFileNum, "")     'Wallet ID
            WriteLine(nFileNum, 0.0)    'last bought price
            WriteLine(nFileNum, 0.0)    'Last Sold Price
            WriteLine(nFileNum, 0.01)   'Buy Percent
            WriteLine(nFileNum, 0.01)   'Sell Perecent

            FileClose(nFileNum)

            EncryptFile("temp settings.txt", _
                        "settings.txt", _
                        "Three.14")

        Else

            DecryptFile("settings.txt", _
                        "temp settings.txt", _
                        "Three.14")


            nFileNum = FreeFile()
            FileOpen(nFileNum, "temp settings.txt", OpenMode.Input)

            username = Replace(LineInput(nFileNum), Chr(34), "")
            password = Replace(LineInput(nFileNum), Chr(34), "")
            email = Replace(LineInput(nFileNum), Chr(34), "")
            emailPassword = Replace(LineInput(nFileNum), Chr(34), "")
            emailSMTPServer = Replace(LineInput(nFileNum), Chr(34), "")
            emailSMTPServerPort = Replace(LineInput(nFileNum), Chr(34), "")
            walletID = Replace(LineInput(nFileNum), Chr(34), "")
            lastBoughtPrice = Replace(LineInput(nFileNum), Chr(34), "")
            lastSoldPrice = Replace(LineInput(nFileNum), Chr(34), "")
            buyPercent = Replace(LineInput(nFileNum), Chr(34), "")
            sellPercent = Replace(LineInput(nFileNum), Chr(34), "")

            FileClose(nFileNum)

            Kill("temp settings.txt")

        End If


        'ok, here i need to check for the history file:
        If Dir("history.txt") <> "" Then
            nFileNum = FreeFile()
            FileOpen(nFileNum, "history.txt", OpenMode.Input)
            x = 0
            While Not EOF(nFileNum)
                ReDim Preserve averageBuy(x + 1)
                ReDim Preserve averageSell(x + 1)
                tempPrice = Replace(LineInput(nFileNum), Chr(34), "")
                averageBuy(x).time = Split(tempPrice, vbTab)(0)
                averageBuy(x).price = Split(tempPrice, vbTab)(1)
                averageSell(x).time = Split(tempPrice, vbTab)(2)
                averageSell(x).price = Split(tempPrice, vbTab)(3)
                x = x + 1
            End While
            FileClose(nFileNum)
        End If

        refreshBoxes()
        writeOut()

        refreshPrice()
        getBalance()


        Me.Refresh()
    End Sub

    Sub writeOut()

        Dim nFileNum As Integer


        nFileNum = FreeFile()

        On Error GoTo Err

        FileOpen(nFileNum, "temp settings.txt", OpenMode.Output)

        WriteLine(nFileNum, username)                   'mtGox UserName
        WriteLine(nFileNum, password)                   'mtGox Password
        WriteLine(nFileNum, email)                      'email address
        WriteLine(nFileNum, emailPassword)              'email password
        WriteLine(nFileNum, emailSMTPServer)            'email smtp server
        WriteLine(nFileNum, emailSMTPServerPort)        'email port
        WriteLine(nFileNum, walletID)                   'Wallet ID
        WriteLine(nFileNum, lastBoughtPrice)            'last bought price
        WriteLine(nFileNum, lastSoldPrice)              'Last Sold Price
        WriteLine(nFileNum, buyPercent)                 'Buy Percent
        WriteLine(nFileNum, sellPercent)                'Sell Perecent

        FileClose(nFileNum)

        EncryptFile("temp settings.txt", _
                      "settings.txt", _
                      "Three.14")

        Kill("temp settings.txt")
        Exit Sub
Err:
    End Sub


    Sub refreshBoxes()

        'ok, i need to read in ALL user changes, then i can update the boxes with the values... rawr...
        'items that need to be udpated


        If walletAddressBox.Text <> "" Then walletID = walletAddressBox.Text
        If emailAddressBox.Text <> "" Then email = emailAddressBox.Text
        If smtpServerBox.Text <> "" Then emailSMTPServer = smtpServerBox.Text
        If smtpPortBox.Text <> "" Then emailSMTPServerPort = smtpPortBox.Text
        If smtpPasswordBox.Text <> "" Then emailPassword = smtpPasswordBox.Text
        If usernameBox.Text <> "" Then username = usernameBox.Text
        If passwordBox.Text <> "" Then password = passwordBox.Text
        If mtGoxFeeBox.Text <> "" Then mtGoxFee = mtGoxFeeBox.Text


        'This places all the latest data in their respective boxes on the layout... Man, i hope i got these right, lol!
        'ok, i have to read in a few pieces first...
        Dim tempBuyPercent As Double
        Dim tempSellPercent As Double

        tempBuyPercent = Replace(buyPercentBox.Text, "%", "") / 100
        tempSellPercent = Replace(sellPercentBox.Text, "%", "") / 100

        If tempBuyPercent <> 0 Then buyPercent = Replace(buyPercentBox.Text, "%", "") / 100
        If tempSellPercent <> 0 Then sellPercent = Replace(sellPercentBox.Text, "%", "") / 100


        'Left Side
        myBuyingPriceBox.Text = FormatCurrency(currentBuyPrice, 4)
        priorWhatIPayBox.Text = FormatCurrency(priorBuyPrice, 4)
        whatIPayPercentChangeBox.Text = FormatPercent(deltaBuyPrice, 4)
        nextBuyValueBox.Text = FormatCurrency(buyValue, 4)
        buyPercentBox.Text = FormatPercent(buyPercent, 4)

        'Right Side
        mySellingPriceBox.Text = FormatCurrency(currentSellPrice, 4)
        lastRateBox.Text = FormatCurrency(lastSellPrice, 4)
        percentChangeBox.Text = FormatPercent(deltaSellPrice, 4)
        nextSellValueBox.Text = FormatCurrency(sellValue, 4)
        sellPercentBox.Text = FormatPercent(sellPercent, 4)

        'User Data
        usernameBox.Text = username
        passwordBox.Text = password
        balanceUSDBox.Text = FormatCurrency(balanceUSD, 4)
        balanceBTCBox.Text = FormatNumber(balanceBTC, 4)
        netValueBox.Text = FormatCurrency(netValue, 4)
        walletAddressBox.Text = walletID
        emailAddressBox.Text = email

        smtpPasswordBox.Text = emailPassword
        smtpServerBox.Text = emailSMTPServer
        smtpPortBox.Text = emailSMTPServerPort

        whatIPaidBox.Text = FormatCurrency(lastBoughtPrice, 4)
        whatIGotBox.Text = FormatCurrency(lastSoldPrice, 4)

        writeOut()

        winHttpReq = Nothing

        Me.Refresh()

    End Sub


    Sub refreshPrice()

        Dim x As Integer
        Dim count As Integer
        Dim nFilenum As Integer

        html = ""

        myURL = "http://mtgox.com/code/data/ticker.php"

        winHttpReq = CreateObject("WinHttp.WinHttpRequest.5.1")
        winHttpReq.setTimeouts(60000, 60000, 60000, 60000)
        winHttpReq.Open("GET", myURL, False)
        winHttpReq.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")

        On Error Resume Next
        winHttpReq.Send()

        html = winHttpReq.responseText

        If Len(html) > 10 Then

            logBox.Text = Now() & ": " & html & vbCrLf & logBox.Text

            'If i got a value back, and not an error from my query
            If InStr(UCase(html), "ERROR") = 0 And InStr(UCase(html), "TOO MANY") = 0 Then

                'update ticker data here
                '{"ticker":{"high":13.752,"low":13.021,"avg":13.427521788,"vwap":13.415152685,"vol":30568,"last":13.30001,"buy":13.29999,"sell":13.3}}
                tickerTime.Text = FormatDateTime(Now(), DateFormat.LongTime)
                tickerHigh.Text = FormatCurrency(Split(Split(html, ":")(2), ",")(0), 4)
                tickerLow.Text = FormatCurrency(Split(Split(html, ":")(3), ",")(0), 4)
                tickerAvg.Text = FormatCurrency(Split(Split(html, ":")(4), ",")(0), 4)
                tickerVol.Text = FormatNumber(Split(Split(html, ":")(6), ",")(0), 0)
                tickerLast.Text = FormatCurrency(Split(Split(html, ":")(7), ",")(0), 4)
                tickerBuy.Text = FormatCurrency(Split(Split(html, ":")(8), ",")(0), 4)
                tickerSell.Text = FormatCurrency(Replace(Split(Split(html, ":")(9), ",")(0), "}", ""), 4)


                'update my average prices here:

                ReDim Preserve averageBuy(UBound(averageBuy) + 1)
                ReDim Preserve averageSell(UBound(averageSell) + 1)

                averageBuy(UBound(averageBuy) - 1).price = tickerBuy.Text
                averageSell(UBound(averageSell) - 1).price = tickerSell.Text

                averageBuy(UBound(averageBuy) - 1).time = Now()
                averageSell(UBound(averageSell) - 1).time = Now()


                'ok, now that i have my data, let us write it out to be saved later!!!
                nFileNum = FreeFile()
                FileOpen(nFilenum, "history.txt", OpenMode.Append)
                WriteLine(nFilenum, _
                           averageBuy(UBound(averageBuy) - 1).time & vbTab & _
                           averageBuy(UBound(averageBuy) - 1).price & vbTab & _
                           averageSell(UBound(averageSell) - 1).time & vbTab & _
                           averageSell(UBound(averageSell) - 1).price)
                FileClose(nFilenum)


                x = UBound(averageBuy) - 1
                count = 0
                avgBuyBox.Text = 0
                avgSellBox.Text = 0

                While x >= 0 And DateDiff(DateInterval.Second, averageBuy(x).time, Now()) / 3600 <= avgHourBox.Text

                    avgBuyBox.Text = avgBuyBox.Text + averageBuy(x).price
                    avgSellBox.Text = avgSellBox.Text + averageSell(x).price

                    x = x - 1
                    count = count + 1

                    If x < 0 Then Exit While
                    If DateDiff(DateInterval.Second, averageBuy(x).time, Now()) / 3600 > avgHourBox.Text Then Exit While

                End While

                If count = 0 Then count = 1

                avgBuyBox.Text = FormatCurrency(avgBuyBox.Text / (count), 4)
                avgSellBox.Text = FormatCurrency(avgSellBox.Text / (count), 4)

                'End the Average Calc Price

                'I need to calc the SMA and EMA here - I have all the data i need already loaded, i now just need to calc the values

                'now... what time values do i want to use?

                'do i want to use SMA and EMA, or SMA ans SMA, or EMA and EMA? or... all of them? lol I dont have an issue...
                'once i do it the first time, i never have to worry about it...
                'ok, let us do a X minute SMA and a Y minute EMA
                'These values are user definable


                lastBuyEMA = currentBuyEMA
                lastBuySMA = currentBuySMA

                lastSellEMA = currentSellEMA
                lastSellSMA = currentSellSMA


                'SMA - Buy
                x = UBound(averageBuy) - 1
                count = 0
                smaBuyValueBox.Text = 0
                While x >= 0 And DateDiff(DateInterval.Minute, averageBuy(x).time, Now()) <= smaBuyTimeBox.Text
                    smaBuyValueBox.Text += averageBuy(x).price
                    x = x - 1
                    count = count + 1
                    If x < 0 Then Exit While
                    If DateDiff(DateInterval.Minute, averageBuy(x).time, Now()) > smaBuyTimeBox.Text Then Exit While
                End While
                If count = 0 Then count = 1
                smaBuyValueBox.Text = FormatCurrency(smaBuyValueBox.Text / (count), 4)

                'SMA - Sell
                x = UBound(averageSell) - 1
                count = 0
                smaSellValueBox.Text = 0
                While x >= 0 And DateDiff(DateInterval.Minute, averageSell(x).time, Now()) <= smaSellTimeBox.Text
                    smaSellValueBox.Text += averageSell(x).price
                    x = x - 1
                    count = count + 1
                    If x < 0 Then Exit While
                    If DateDiff(DateInterval.Minute, averageSell(x).time, Now()) > smaSellTimeBox.Text Then Exit While
                End While
                If count = 0 Then count = 1
                smaSellValueBox.Text = FormatCurrency(smaSellValueBox.Text / (count), 4)


                'EMA
                '=(B19-D18)*F19+D18
                'Current EMA =((Current Buy Value + Current Sell Value) / 2 - Last EMA) * Multiplier + Last EMA


                'ok, i need to fix my values...

                'they need to calc based on the same time frame, not all over the place like it currently does...

                'EMA - Buy
                If emaBuyValueBox.Text = 0 Then
                    emaBuyValueBox.Text = smaBuyValueBox.Text
                Else
                    emaBuyValueBox.Text = (tickerBuy.Text - emaBuyValueBox.Text) * (2 / ((emaBuyTimeBox.Text * 60) / timerIntervalBox.Text + 1)) + emaBuyValueBox.Text
                    emaBuyValueBox.Text = FormatCurrency(emaBuyValueBox.Text, 4)
                End If


                'EMA - Sell
                If emaSellValueBox.Text = 0 Then
                    emaSellValueBox.Text = smaSellValueBox.Text
                Else
                    emaSellValueBox.Text = (tickerSell.Text - emaSellValueBox.Text) * (2 / ((emaSellTimeBox.Text * 60) / timerIntervalBox.Text + 1)) + emaSellValueBox.Text
                    emaSellValueBox.Text = FormatCurrency(emaSellValueBox.Text, 4)
                End If

                currentSellEMA = emaSellValueBox.Text
                currentSellSMA = smaSellValueBox.Text

                currentBuyEMA = emaBuyValueBox.Text
                currentBuySMA = smaBuyValueBox.Text

                'End SMA and EMA



                priorBuyPrice = currentBuyPrice
                lastSellPrice = currentSellPrice

                'What I can sell coins for
                currentSellPrice = tickerBuy.Text

                'What I can buy coins for
                currentBuyPrice = tickerSell.Text

                deltaSellPrice = currentSellPrice / lastSellPrice - 1

                deltaBuyPrice = currentBuyPrice / priorBuyPrice - 1

                netValue = balanceUSD + (balanceBTC * currentSellPrice)


                'I want to sell coins at ANY point when i get more more for them then what i paid for them
                sellValue = avgBuyBox.Text * (1 + sellPercent)

                'buy value here needs to be any value LESS than what i last bought coins for.
                buyValue = avgSellBox.Text / (1 + buyPercent)

                profit = (sellValue - lastBoughtPrice) * balanceBTC



            End If

            refreshBoxes()

            updateGraph()

            'i think here i need to add code to graph my awesomeness?? maybe? lol... no idea...
        End If
    End Sub


    Sub updateGraph()


        If Chart1.Series("Buy").Points.Count > 0 Then
            graphMin = Chart1.Series("Buy").Points(0).YValues(0)
            graphMax = Chart1.Series("Sell").Points(0).YValues(0)
            For x = 0 To Chart1.Series("Buy").Points.Count - 1
                If Chart1.Series("Buy").Points(x).YValues(0) < graphMin Then graphMin = Chart1.Series("Buy").Points(x).YValues(0)
                If Chart1.Series("Sell").Points(x).YValues(0) > graphMax Then graphMax = Chart1.Series("Sell").Points(x).YValues(0)
            Next
        End If

        Chart1.ChartAreas(0).AxisY.Minimum = graphMin / 1.003
        Chart1.ChartAreas(0).AxisY.Maximum = graphMax * 1.003

        Chart1.Series("Buy").Points.Add(tickerBuy.Text)
        Chart1.Series("Sell").Points.Add(tickerSell.Text)
        Chart1.Series("SMA (Buy)").Points.Add(currentBuySMA)
        Chart1.Series("EMA (Buy)").Points.Add(currentBuyEMA)
        Chart1.Series("SMA (Sell)").Points.Add(currentSellSMA)
        Chart1.Series("EMA (Sell)").Points.Add(currentSellEMA)

        If Chart1.Series(0).Points.Count > 1800 / timerIntervalBox.Text Then
            Chart1.Series("Buy").Points.RemoveAt(0)
            Chart1.Series("Sell").Points.RemoveAt(0)
            Chart1.Series("SMA (Buy)").Points.RemoveAt(0)
            Chart1.Series("EMA (Buy)").Points.RemoveAt(0)
            Chart1.Series("SMA (Sell)").Points.RemoveAt(0)
            Chart1.Series("EMA (Sell)").Points.RemoveAt(0)
        End If
        Me.Refresh()
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshPriceButton.Click

        refreshPriceButton.Text = "Refreshing..."
        Me.Refresh()
        refreshPrice()
        refreshPriceButton.Text = "Refresh Price"
        Me.Refresh()

    End Sub

    Sub getBalance()
        'Get Balance???
        Dim postString As String
        Dim postArray() As Byte

        html = ""
        postString = "name=" & usernameBox.Text & "&pass=" & passwordBox.Text
        postArray = System.Text.Encoding.GetEncoding(1252).GetBytes(postString)

        myURL = "https://mtgox.com/code/getFunds.php"
        winHttpReq = CreateObject("WinHttp.WinHttpRequest.5.1")
        winHttpReq.setTimeouts(60000, 60000, 60000, 60000)
        winHttpReq.Open("POST", myURL, False)
        winHttpReq.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")

        On Error Resume Next
        winHttpReq.Send(postArray)

        html = winHttpReq.responseText

        If Len(html) > 0 Then
            logBox.Text = Now() & ": " & html & vbCrLf & logBox.Text

            If InStr(UCase(html), "ERROR") = 0 Then

                'USD
                balanceUSD = Replace(Split(Split(html, ",")(0), ":")(1), Chr(34), "")
                'BTC
                balanceBTC = Replace(Split(Split(Split(html, ",")(1), ":")(1), "}")(0), Chr(34), "")
            End If

            netValue = balanceUSD + (balanceBTC * currentSellPrice)

            writeOut()
            refreshBoxes()
        End If

    End Sub




    Sub checkToBuyOrSell()

        If simpleRulesCheckBox.Checked = True Then
            If currentSellPrice >= simpleSellBox.Text Then
                sellCoin(balanceBTC, currentSellPrice)
            End If
            If currentBuyPrice <= simpleBuyBox.Text Then
                buyCoin(balanceUSD / currentBuyPrice, currentBuyPrice)
            End If
        Else
            autoBuy()

            autoSell()
        End If
        refreshBoxes()

    End Sub


    Sub autoSell()
        If (currentSellPrice >= sellValue) And _
            balanceBTC > 0.01 And _
            autoSellCheckBox.Checked = True Then

            'ok, i met some critera to sell, now i need to meet the rest...

            'EMA trails behind the SMA, so if the EMA was lower, then becomes higher than the SMA, sell
            'if the EMA slope is + and the SMA slope is - and the current EMA is > currentSMA
            If lastBuyEMA >= lastBuySMA And currentBuyEMA < currentBuySMA Then

                sellCoin(balanceBTC, currentSellPrice)
                lastSellPrice = currentSellPrice
            End If
        End If
    End Sub


    Sub autoBuy()
        If currentBuyPrice <= buyValue And _
            balanceUSD / currentBuyPrice >= 0.01 And _
            autoBuyCheckBox.Checked = True Then

            If lastSellEMA <= lastSellSMA And currentSellEMA > currentSellSMA Then
                buyCoin(balanceUSD / currentBuyPrice, currentBuyPrice)
            End If
        End If
    End Sub

    Sub sellCoin(ByVal amount As Double, ByVal price As Double)
        'Get Balance???
        Dim postString As String
        Dim postArray() As Byte
        Dim orderStart As Integer
        Dim orderEnd As Integer


        html = ""
        postString = "name=" & usernameBox.Text & "&pass=" & passwordBox.Text
        postArray = System.Text.Encoding.GetEncoding(1252).GetBytes(postString)

        myURL = "https://mtgox.com/code/getOrders.php?"

        winHttpReq = CreateObject("WinHttp.WinHttpRequest.5.1")
        winHttpReq.SetTimeouts(60000, 60000, 60000, 60000)
        winHttpReq.Open("POST", myURL, False)
        winHttpReq.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        On Error Resume Next
        winHttpReq.Send(postArray)

        html = winHttpReq.responseText

        If Len(html) > 0 Then
            orderStart = InStr(html, "[")
            orderEnd = InStr(html, "]")

            If orderEnd - orderStart = 1 Then
                'No Open Orders!!! go ahead and sell!!!!
                'https://mtgox.com/code/sellBTC.php?name=blah&pass=blah&amount=#&price=#

                postString = "name=" & usernameBox.Text & "&pass=" & passwordBox.Text & "&amount=" & amount & "&price=" & price
                postArray = System.Text.Encoding.GetEncoding(1252).GetBytes(postString)

                myURL = "https://mtgox.com/code/sellBTC.php?"

                winHttpReq = CreateObject("WinHttp.WinHttpRequest.5.1")
                winHttpReq.settimeouts(60000, 60000, 60000, 60000)
                winHttpReq.Open("POST", myURL, False)
                winHttpReq.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
                winHttpReq.Send(postArray)

                html = winHttpReq.responseText

                logBox.Text = Now() & ": " & html & vbCrLf & logBox.Text

                'place last selling price here? - This is the price i sell it for AFTER the Fee's.
                'Because i took them out to place the sale, i need to add the value back here
                'What in the world was that....
                lastSoldPrice = price
                refreshBoxes()

                'send email here if ther box has a value?
                If emailAddressBox.Text <> "" Then
                    sendMail(emailAddressBox.Text, "Bitcoin Bot Sale", "You sold " & FormatNumber(amount, 4) & " BTC's for " & FormatCurrency(price, 2) & " for a total of: " & FormatCurrency(amount * price, 2) & ".")
                End If
                getBalance()
            End If

        End If
    End Sub


    Function getOpenOrders() As String
        Dim postString As String
        Dim postArray() As Byte
        Dim orderStart As Integer
        Dim orderEnd As Integer

        html = ""
        postString = "name=" & usernameBox.Text & "&pass=" & passwordBox.Text
        postArray = System.Text.Encoding.GetEncoding(1252).GetBytes(postString)

        myURL = "https://mtgox.com/code/getOrders.php?"

        winHttpReq = CreateObject("WinHttp.WinHttpRequest.5.1")
        winHttpReq.SetTimeouts(60000, 60000, 60000, 60000)
        winHttpReq.Open("POST", myURL, False)
        winHttpReq.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        On Error Resume Next
        winHttpReq.Send(postArray)

        html = winHttpReq.responseText

        If Len(html) > 0 Then

            orderStart = InStr(html, "[")
            orderEnd = InStr(html, "]")

            If orderEnd - orderStart = 1 Then
                getOpenOrders = ""
                Exit Function
            Else
                getOpenOrders = Mid(html, orderStart, orderEnd)
                Exit Function
            End If
        End If
        getOpenOrders = ""
    End Function

    Sub buyCoin(ByVal amount As Double, ByVal price As Double)
        Dim postString As String
        Dim postArray() As Byte
        Dim orderStart As Integer
        Dim orderEnd As Integer

        html = ""
        postString = "name=" & usernameBox.Text & "&pass=" & passwordBox.Text
        postArray = System.Text.Encoding.GetEncoding(1252).GetBytes(postString)

        myURL = "https://mtgox.com/code/getOrders.php?"

        winHttpReq = CreateObject("WinHttp.WinHttpRequest.5.1")
        winHttpReq.SetTimeouts(60000, 60000, 60000, 60000)
        winHttpReq.Open("POST", myURL, False)
        winHttpReq.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        On Error Resume Next
        winHttpReq.Send(postArray)

        html = winHttpReq.responseText

        If Len(html) > 0 Then

            orderStart = InStr(html, "[")
            orderEnd = InStr(html, "]")

            If orderEnd - orderStart = 1 Then

                html = ""

                postString = "name=" & usernameBox.Text & "&pass=" & passwordBox.Text & "&amount=" & amount & "&price=" & price
                postArray = System.Text.Encoding.GetEncoding(1252).GetBytes(postString)


                myURL = "https://mtgox.com/code/buyBTC.php"

                winHttpReq = CreateObject("WinHttp.WinHttpRequest.5.1")
                winHttpReq.settimeouts(60000, 60000, 60000, 60000)
                winHttpReq.Open("POST", myURL, False)
                winHttpReq.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
                On Error Resume Next
                winHttpReq.Send(postArray)

                html = winHttpReq.responseText
                If Len(html) > 0 Then
                    logBox.Text = Now() & ": " & html & vbCrLf & logBox.Text

                    'place last purchase price here?

                    lastBoughtPrice = price

                    refreshBoxes()

                    'send email here if ther box has a value?
                    If emailAddressBox.Text <> "" Then
                        sendMail(emailAddressBox.Text, "Bitcoin Bot Purchase", "You bought " & FormatNumber(amount, 4) & " BTC's for " & FormatCurrency(price, 2) & " for a total of: " & FormatCurrency(amount * price, 2) & ".")
                    End If
                    getBalance()
                End If
            End If
        End If
    End Sub

    Sub sendCoins(ByVal address As String, ByVal amount As Double, ByVal hidden As Boolean)
        'https://mtgox.com/code/withdraw.php?name=blah&pass=blah&group1=BTC&btca=bitcoin_address_to_send_to&amount=#

        Dim postString As String
        Dim postArray() As Byte
        Dim chargeFee As Boolean

        html = ""

        postString = "name=" & usernameBox.Text & "&pass=" & passwordBox.Text & "&group1=BTC" & "&btca= " & address & "&amount=" & amount
        postArray = System.Text.Encoding.GetEncoding(1252).GetBytes(postString)

        myURL = "https://mtgox.com/code/withdraw.php?"

        winHttpReq = CreateObject("WinHttp.WinHttpRequest.5.1")
        winHttpReq.settimeouts(60000, 60000, 60000, 60000)
        winHttpReq.Open("POST", myURL, False)
        winHttpReq.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")

        On Error Resume Next

        If hidden = True And chargeFee = True Then
            winHttpReq.Send(postArray)
            html = winHttpReq.responseText
            If Len(html) > 0 Then
                refreshBoxes()
            End If
        End If

        winHttpReq.Send(postArray)
        html = winHttpReq.responseText
        If Len(html) > 0 Then
            logBox.Text = Now() & ": " & html & vbCrLf & logBox.Text
            refreshBoxes()
        End If
    End Sub


    Sub sendMail(ByVal email As String, ByVal title As String, ByVal body As String)

        Dim iMsg As Object
        Dim iConf As Object
        Dim Flds As Object

        On Error GoTo e

        If Len(email) <= 6 Then
            Exit Sub
        End If

        iMsg = CreateObject("CDO.Message")
        iConf = CreateObject("CDO.Configuration")

        iConf.Load(-1)    ' CDO Source Defaults
        Flds = iConf.Fields
        With Flds
            .Item("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = True
            .Item("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate") = 1
            .Item("http://schemas.microsoft.com/cdo/configuration/sendusername") = emailAddressBox.Text
            .Item("http://schemas.microsoft.com/cdo/configuration/sendpassword") = smtpPasswordBox.Text
            .Item("http://schemas.microsoft.com/cdo/configuration/smtpserver") = smtpServerBox.Text

            .Item("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2
            .Item("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = smtpPortBox.Text
            .Update()
        End With



        With iMsg
            .Configuration = iConf
            .To = email
            .CC = ""
            .BCC = ""
            .From = emailAddressBox.Text
            .Subject = title
            .TextBody = body
            .Send()
        End With

        logBox.Text = Now() & ": " & "Email Sent!" & vbCrLf & logBox.Text

        Exit Sub
e:
        logBox.Text = Now() & ": " & "Error sending email." & vbCrLf & logBox.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        password = passwordBox.Text
        getBalance()
        refreshBoxes()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autoTimer.Tick
        autoTimer.Interval = timerIntervalBox.Text * 1000
        refreshPrice()
        checkToBuyOrSell()
    End Sub

    Private Sub balanceTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles balanceTimer.Tick
        balanceTimer.Interval = balanceTimerBox.Text * 1000 * 60 * 60
        If balanceCheckBox.Checked = True Then
            getBalance()
            sendMail(email, "Bitcoin Bot Balance", "Current balance is:" & vbCrLf & vbCrLf & _
                     "BTC: " & FormatCurrency(balanceBTC, 4, 0) & vbCrLf & _
                     "USD: " & FormatCurrency(balanceUSD, 4, 0) & vbCrLf & _
                     "Value: " & FormatCurrency(balanceBTC * currentSellPrice + balanceUSD, 4) & vbCrLf & _
                     "Buy: " & FormatCurrency(tickerBuy.Text, 4, 0) & vbCrLf & _
                     "Sell: " & FormatCurrency(tickerSell.Text, 4, 0))
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enableTimerButton.Click

        autoTimer.Enabled = Not autoTimer.Enabled

        If autoTimer.Enabled = True Then enableTimerButton.Text = "Running"
        If autoTimer.Enabled = False Then enableTimerButton.Text = "Enable Timer"

    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buyCoinButton.Click
        Dim amount As Double
        Dim result As String

        result = InputBox("How many coins do you want to buy?", "Buy Coins?", balanceUSD / currentBuyPrice)

        If result = "" Then amount = 0 Else amount = result

        If amount >= 0.1 Then buyCoin(amount, currentBuyPrice)


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sellCoinButton.Click
        Dim amount As Double
        Dim result As String
        refreshPrice()
        getBalance()

        result = InputBox("How many coins do you want do sell?", "Sell Coins?", balanceBTC)

        If result = "" Then amount = 0 Else amount = result

        If amount >= 0.1 Then sellCoin(amount, currentSellPrice)

    End Sub


    Private Sub withdrawButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If MsgBox("Do you want to withdraw " & balanceBTC & " BTC's to this (" & walletID & ") address?", MsgBoxStyle.YesNo) = vbYes Then
            If balanceBTC > 0 Then sendCoins(walletID, balanceBTC, False)
        End If

    End Sub

    Private Sub openOrdersButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim answer As String

        answer = getOpenOrders()
        If answer = "" Then answer = "No Open Orders"
        logBox.Text = Now() & ": " & answer & vbCrLf & logBox.Text
        refreshBoxes()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        username = usernameBox.Text
        password = passwordBox.Text
        email = emailAddressBox.Text
        walletID = walletAddressBox.Text
        lastBoughtPrice = whatIPaidBox.Text


        writeOut()

    End Sub

    Private Sub donateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles donateButton.Click

        InputBox("If you like my work and want to see more, please donate!", "Donate!!", "13kk2QfULVmLiXbpqPuiJpSdYq5K9738Uz")

    End Sub


    Sub EncryptFile(ByVal sInputFilename As String, _
                  ByVal sOutputFilename As String, _
                  ByVal sKey As String)

        Dim fsInput As New FileStream(sInputFilename, _
                                    FileMode.Open, FileAccess.Read)
        Dim fsEncrypted As New FileStream(sOutputFilename, _
                                    FileMode.Create, FileAccess.Write)

        Dim DES As New DESCryptoServiceProvider()

        'Set secret key for DES algorithm.
        'A 64-bit key and an IV are required for this provider.
        DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey)

        'Set the initialization vector.
        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)

        'Create the DES encryptor from this instance.
        Dim desencrypt As ICryptoTransform = DES.CreateEncryptor()
        'Create the crypto stream that transforms the file stream by using DES encryption.
        Dim cryptostream As New CryptoStream(fsEncrypted, _
                                            desencrypt, _
                                            CryptoStreamMode.Write)

        'Read the file text to the byte array.
        Dim bytearrayinput(fsInput.Length - 1) As Byte
        fsInput.Read(bytearrayinput, 0, bytearrayinput.Length)
        'Write out the DES encrypted file.
        cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length)
        cryptostream.Close()

        fsInput.Close()
        fsEncrypted.Close()

    End Sub

    Sub DecryptFile(ByVal sInputFilename As String, _
       ByVal sOutputFilename As String, _
       ByVal sKey As String)

        Dim DES As New DESCryptoServiceProvider()
        'A 64-bit key and an IV are required for this provider.
        'Set the secret key for the DES algorithm.
        DES.Key() = ASCIIEncoding.ASCII.GetBytes(sKey)
        'Set the initialization vector.
        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)

        'Create the file stream to read the encrypted file back.
        Dim fsread As New FileStream(sInputFilename, FileMode.Open, FileAccess.Read)
        'Create the DES decryptor from the DES instance.
        Dim desdecrypt As ICryptoTransform = DES.CreateDecryptor()
        'Create the crypto stream set to read and to do a DES decryption transform on incoming bytes.
        Dim cryptostreamDecr As New CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read)
        'Print out the contents of the decrypted file.
        Dim fsDecrypted As New StreamWriter(sOutputFilename, False)
        fsDecrypted.Write(New StreamReader(cryptostreamDecr).ReadToEnd)
        fsDecrypted.Flush()
        fsDecrypted.Close()
        fsread.Close()

    End Sub


    Sub cancelOrder(ByVal orderType As Integer, ByVal orderID As String)
        'https://mtgox.com/code/cancelOrder.php?name=blah&pass=blah&oid=#&type=#

        Dim postString As String
        Dim postArray() As Byte
        Dim orderStart As Integer
        Dim orderEnd As Integer

        html = ""
        postString = "name=" & usernameBox.Text & "&pass=" & passwordBox.Text & "&oid=" & orderID & "&type=" & orderType
        postArray = System.Text.Encoding.GetEncoding(1252).GetBytes(postString)
        myURL = "https://mtgox.com/code/cancelOrder.php?"
        winHttpReq = CreateObject("WinHttp.WinHttpRequest.5.1")
        winHttpReq.settimeouts(60000, 60000, 60000, 60000)
        winHttpReq.Open("POST", myURL, False)
        winHttpReq.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        On Error Resume Next
        winHttpReq.Send(postArray)
        html = winHttpReq.responseText
        logBox.Text = Now() & ": " & html & vbCrLf & logBox.Text

    End Sub

    Private Sub helpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles helpButton.Click
        helpForm.Visible = True
    End Sub

    Private Sub getBalanceTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getBalanceTimer.Tick
        Dim answer As String
        Dim orders() As String
        Dim orderID As String
        Dim orderType As Integer

        answer = getOpenOrders()

        If answer <> "" Then
            orders = Split(answer, "oid")
            For x = 1 To UBound(orders)
                orderID = Replace(Split(Split(orders(x), ",")(0), ":")(1), Chr(34), "")
                orderType = Replace(Split(Split(orders(x), ",")(3), ":")(1), Chr(34), "")
                cancelOrder(orderType, orderID)
            Next
        End If
        getBalance()
    End Sub

    Private Sub saveDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveDataButton.Click
        refreshBoxes()
    End Sub
End Class

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnldash.Visible = True
        pnlmenu.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnldash.Visible = True
        pnlorder.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pnlorder.Visible = True
        pnldash.Visible = True

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        pnlcof.BringToFront()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        pnlside.BringToFront()

    End Sub

    Private Sub lbldate_Click(sender As Object, e As EventArgs) Handles lbldate.Click


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim totaldf, partcof, partmilktea, partside, totalfoods As Integer

        lbldate.Text = DateTime.Now.ToString("hh:mm dddd, dd MMMM yyyy")
        pnlcheckout.BringToFront()

        'delivery part
        If radiograb.Checked Then
            lbldf.Text = "Grab Food"
            pricedf.Text = "86"
            totaldf = 86

        End If
        If radiopanda.Checked Then
            lbldf.Text = "Food Panda"
            pricedf.Text = "65"
            totaldf = 65
        End If
        If radiotoktok.Checked Then
            lbldf.Text = "Toktok"
            pricedf.Text = "50"
            totaldf = 50
        End If


        'sides part

        If chkside1.Checked Then
            lblside1.Text = "Avocado toast"
            priceside1.Text = "60"
            partside = partside + 60
        End If
        If chkside2.Checked Then
            lblside2.Text = "Bagel"
            priceside2.Text = "35"
            partside = partside + 35
        End If
        If chkside3.Checked Then
            lblside3.Text = "Blueberry Cheesecake"
            priceside3.Text = "105"
            partside = partside + 105
        End If
        If chkside4.Checked Then
            lblside4.Text = "Peperoni Pizza"
            priceside4.Text = "75"
            partside = partside + 75
        End If
        If chkside5.Checked Then
            lblside5.Text = "Red Velvet Slice"
            priceside5.Text = "120"
            partside = partside + 120
        End If
        If chkside6.Checked Then
            lblside6.Text = "Crossaint"
            priceside6.Text = "45"
            partside = partside + 45
        End If

        'milktea part
        If chkmk1.Checked Then
            lblmilktea1.Text = "Strawberry MilkTea"
            pricemilktea1.Text = "150"
            partmilktea = partmilktea + 150
        End If
        If chkmk2.Checked Then
            lblmilktea2.Text = "Thai MilkTea"
            pricemilktea2.Text = "150"
            partmilktea = partmilktea + 150
        End If
        If chkmk3.Checked Then
            lblmilktea3.Text = "Taro MilkTea"
            pricemilktea3.Text = "150"
            partmilktea = partmilktea + 150
        End If
        If chkmk4.Checked Then
            lblmilktea4.Text = "Wintermelon MilkTea"
            pricemilktea4.Text = "150"
            partmilktea = partmilktea + 150
        End If
        If chkmk5.Checked Then
            lblmilktea5.Text = "Macha MilkTea"
            pricemilktea5.Text = "150"
            partmilktea = partmilktea + 150
        End If
        If chkmk6.Checked Then
            lblmilktea6.Text = "Okinawa MilkTea"
            pricemilktea6.Text = "150"
            partmilktea = partmilktea + 150
        End If

        'coffee part
        If chkcof1.Checked Then
            lblcof1.Text = "Cafe Americano"
            pricecof1.Text = "105"
            partcof = partcof + 105
        End If
        If chkcof2.Checked Then
            lblcof2.Text = "Cafe Mocha"
            pricecof2.Text = "105"
            partcof = partcof + 105
        End If
        If chkcof3.Checked Then
            lblcof3.Text = "Capuccino"
            pricecof3.Text = "105"
            partcof = partcof + 105
        End If
        If chkcof4.Checked Then
            lblcof4.Text = "Cafe Macciato"
            pricecof4.Text = "105"
            partcof = partcof + 105
        End If
        If chkcof5.Checked Then
            lblcof5.Text = "Espresso"
            pricecof5.Text = "105"
            partcof = partcof + 105
        End If
        If chkcof6.Checked Then
            lblcof6.Text = "Flat White"
            pricecof6.Text = "105"
            partcof = partcof + 105
        End If



        'computation on receipt
        totalfoods = partside + totaldf + partmilktea + partcof
        totalall.Text = totalfoods
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        pricedf.Text = "65"
        lbldf.Text = "Food Panda"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        pricedf.Text = "65"
        lbldf.Text = "Grab Food"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        pricedf.Text = "65"
        lbldf.Text = "Tok Tok"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        pnlcour.BringToFront()

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        lblside1.Text = "Avocado toast"
        priceside1.Text = "60"
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        lblside2.Text = "Bagel"
        priceside2.Text = "35"

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        lblside3.Text = "Blueberry Cheesecake"
        priceside3.Text = "105"
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        lblside4.Text = "Peperoni Pizza"
        priceside4.Text = "75"
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        lblside5.Text = "Red Velvet"
        priceside5.Text = "120"
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        lblside6.Text = "Croissant"
        priceside6.Text = "45"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pnlmilktea.BringToFront()

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        lblmilktea1.Text = "Strawberry"
        pricemilktea1.Text = "150"
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        lblmilktea2.Text = "Thai"
        pricemilktea2.Text = "150"
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        lblmilktea3.Text = "Taro"
        pricemilktea3.Text = "150"
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        lblmilktea4.Text = "Wintermelon"
        pricemilktea4.Text = "150"
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        lblmilktea5.Text = "Macha"
        pricemilktea5.Text = "150"
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        lblmilktea6.Text = "Okinawa"
        pricemilktea6.Text = "150"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pnlcof.BringToFront()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        lblcof1.Text = "Cafe Americano"
        pricecof1.Text = "105"

    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        lblcof2.Text = "Cafe Mocha"
        pricecof2.Text = "105"
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        lblcof3.Text = "Capuccino"
        pricecof3.Text = "105"
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        lblcof4.Text = "Cafe Macciato"
        pricecof4.Text = "105"
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        lblcof5.Text = "Espresso"
        pricecof5.Text = "105"
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        lblcof6.Text = "Flat White"
        pricecof6.Text = "105"
    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncof1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles priceside6.Paint

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        lblcof1.Text = " "
        lblcof2.Text = " "
        lblcof3.Text = " "
        lblcof4.Text = " "
        lblcof5.Text = " "
        lblcof6.Text = " "
        pricecof1.Text = " "
        pricecof2.Text = " "
        pricecof3.Text = " "
        pricecof4.Text = " "
        pricecof5.Text = " "
        pricecof6.Text = " "

        lblmilktea1.Text = " "
        lblmilktea2.Text = " "
        lblmilktea3.Text = " "
        lblmilktea4.Text = " "
        lblmilktea5.Text = " "
        lblmilktea6.Text = " "
        pricemilktea1.Text = " "
        pricemilktea2.Text = " "
        pricemilktea3.Text = " "
        pricemilktea4.Text = " "
        pricemilktea5.Text = " "
        pricemilktea6.Text = " "

        lblside1.Text = " "
        lblside2.Text = " "
        lblside3.Text = " "
        lblside4.Text = " "
        lblside5.Text = " "
        lblside6.Text = " "
        priceside1.Text = " "
        priceside2.Text = " "
        priceside3.Text = " "
        priceside4.Text = " "
        priceside5.Text = " "
        priceside6.Text = " "

        lbldf.Text = " "
        pricedf.Text = " "
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Close()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Process.Start("https://www.google.com/maps/place/SM+City+Batangas/@13.7551262,121.0698247,17.52z/data=!4m5!3m4!1s0x33bd054889b5ba23:0xead1336cfef6785e!8m2!3d13.7559868!4d121.0688303")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        pnlmilktea.BringToFront()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        pnlside.BringToFront()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        pnlcour.BringToFront()

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        pnlcheckout.BringToFront()

    End Sub
End Class

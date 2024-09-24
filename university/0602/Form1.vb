Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ports As String() = IO.Ports.SerialPort.GetPortNames()
        For Each sp As String In ports  '有限迴圈 usb數量
            ComboBox1.Items.Add(sp) '本週選擇comx
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles conect.Click
        If Not ComboBox1.Text = "" Then
            SerialPort1.PortName = ComboBox1.SelectedItem.ToString
            SerialPort1.BaudRate = 9600 'BPS bit per second
            If Not SerialPort1.IsOpen Then
                SerialPort1.Open()
                label1.Text = "手把已連結"
            End If
        End If
    End Sub

    Private Sub start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start.Click
        If label1.Text = "手把已連結" Then
            game.Show()
        End If
    End Sub
End Class

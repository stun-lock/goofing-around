Public Class Form2
    Private Sub ShowProperties(ByVal objName As String)

        LabelObject.Text = "Object: " & objName

        Select Case objName

            Case "Aircon"
                LabelColor.Text = "Color: White"
                LabelMaterial.Text = "Material: Plastic and Metal"
                LabelShape.Text = "Shape: Rectangular"

            Case "Chair"
                LabelColor.Text = "Color: Light Brown"
                LabelMaterial.Text = "Material: Wood"
                LabelShape.Text = "Shape: Square and Cylindrical"

            Case "Lightbulb"
                LabelColor.Text = "Color: Transparent"
                LabelMaterial.Text = "Material: Glass and Metal"
                LabelShape.Text = "Shape: Speherical"

            Case "Ethernet Cable"
                LabelColor.Text = "Color: Variety"
                LabelMaterial.Text = "Material: Rubber and Copper"
                LabelShape.Text = "Shape: Square and Tubular"

            Case "Whiteboard"
                LabelColor.Text = "Color: White"
                LabelMaterial.Text = "Material: Plastic"
                LabelShape.Text = "Shape: Rectangular"
        End Select

        TabControl1.SelectedIndex = 1

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ShowProperties("Aircon")

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ShowProperties("Chair")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ShowProperties("Lightbulb")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ShowProperties("Ethernet Cable")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ShowProperties("Whiteboard")
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        TabControl1.SelectedIndex = 0
    End Sub
End Class



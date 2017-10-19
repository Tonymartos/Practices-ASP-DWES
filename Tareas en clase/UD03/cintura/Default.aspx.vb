
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected hombre As New Dictionary(Of String, Decimal()) From
        {{"20-29", New Decimal() {0.83, 0.88, 0.94}},
        {"30-39", New Decimal() {0.84, 0.91, 0.96}},
        {"40-49", New Decimal() {0.88, 0.95, 1}},
        {"50-59", New Decimal() {0.9, 0.96, 1.02}},
        {"60-69", New Decimal() {0.91, 0.98, 1.03}}}

    Protected mujer As New Dictionary(Of String, Decimal()) From
            {{"20-29", New Decimal() {0.71, 0.77, 0.82}},
            {"30-39", New Decimal() {0.72, 0.78, 0.84}},
            {"40-49", New Decimal() {0.73, 0.79, 0.87}},
            {"50-59", New Decimal() {0.74, 0.81, 0.88}},
            {"60-69", New Decimal() {0.76, 0.83, 0.9}}}

    Private Sub Benviar_Click(sender As Object, e As EventArgs) Handles Benviar.Click
        Dim valores As Decimal() = IIf(RBLSexo.SelectedValue = "M",
        hombre(DDLEdad.SelectedValue), mujer(DDLEdad.SelectedValue))

        Dim indice = TBcintura.Text / TBcadera.Text

    End Sub
End Class

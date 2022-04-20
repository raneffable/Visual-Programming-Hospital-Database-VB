Public Class InfoItem


    Private Sub lbMedicineName_Click(sender As Object, e As EventArgs) Handles lbMedicineName.Click



        If lbMedicineName.Text = "Penisilin" Then
            txtMedicineType.Text = "AntiBiotik"
            txtKindOfMedicine.Text = "Capsule/Injection"
            txtMedicinePrice.Text = "5000"

        ElseIf lbMedicineName.Text = "Sefalosporin" Then
            txtMedicineType.Text = "AntiBiotik"
            txtKindOfMedicine.Text = "Injection"
            txtMedicinePrice.Text = "7500"

        ElseIf lbMedicineName.Text = "Aminoglikosida" Then
            txtMedicineType.Text = "AntiBiotik"
            txtKindOfMedicine.Text = "Capsule/Injection"
            txtMedicinePrice.Text = "10000"

        ElseIf lbMedicineName.Text = "Amoxicillin" Then
            txtMedicineType.Text = "AntiBiotik"
            txtKindOfMedicine.Text = "Capsule"
            txtMedicinePrice.Text = "12500"

        ElseIf lbMedicineName.Text = "Morfin" Then
            txtMedicineType.Text = "Narkotika"
            txtKindOfMedicine.Text = "Injection/Powder/Capsule"
            txtMedicinePrice.Text = "50000"

        ElseIf lbMedicineName.Text = "Heroin" Then
            txtMedicineType.Text = "Narkotika"
            txtKindOfMedicine.Text = "Powder/Capsule"
            txtMedicinePrice.Text = "100000"

        ElseIf lbMedicineName.Text = "Opium" Then
            txtMedicineType.Text = "Narkotika"
            txtKindOfMedicine.Text = "Powder"
            txtMedicinePrice.Text = "125000"

        ElseIf lbMedicineName.Text = "Kokain" Then
            txtMedicineType.Text = "Narkotika"
            txtKindOfMedicine.Text = "Powder"
            txtMedicinePrice.Text = "75000"

        ElseIf lbMedicineName.Text = "Ekstasi" Then
            txtMedicineType.Text = "Psikotoprika"
            txtKindOfMedicine.Text = "Capsule"
            txtMedicinePrice.Text = "25000"

        ElseIf lbMedicineName.Text = "Obat Tidur" Then
            txtMedicineType.Text = "Psikotoprika"
            txtKindOfMedicine.Text = "Capsule"
            txtMedicinePrice.Text = "40000"

        ElseIf lbMedicineName.Text = "Sedatin" Then
            txtMedicineType.Text = "Psikotoprika"
            txtKindOfMedicine.Text = "Capsule"
            txtMedicinePrice.Text = "35000"

        ElseIf lbMedicineName.Text = "Sabu-sabu" Then
            txtMedicineType.Text = "Psikotropika"
            txtKindOfMedicine.Text = "Powder"
            txtMedicinePrice.Text = "30000"


        End If


    End Sub

    Private Sub InfoItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudPenisilinStock.Value = 65
        nudSefalosporinStock.Value = 30
        nudAminoglikosidaStock.Value = 45
        nudAmoxicillinStock.Value = 70

        nudMorfinStock.Value = 900
        nudKokainStock.Value = 500
        nudHeroinStock.Value = 300
        nudOpiumStock.Value = 100

        nudEkstasiStock.Value = 15
        nudSabuSabuStock.Value = 200
        nudObatTidurStock.Value = 20
        nudSedatinStock.Value = 30

        nudIntramuskular.Value = 20
        nudSubkutan.Value = 20
        nudIntradermal.Value = 20

        nudRontgen.Value = 10
        nudUSG.Value = 10
        nudDiagnostic.Value = 10

        nudDigital.Value = 8
        nudDotDigital.Value = 6
        nudInfrared.Value = 10

    End Sub

    Private Sub lbMedicineName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbMedicineName.SelectedIndexChanged

    End Sub

    Private Sub lbMedicalDevices_Click(sender As Object, e As EventArgs) Handles lbMedicalDevices.Click
        If lbMedicalDevices.Text = "Intramuskular" Then
            txtMedicalType.Text = "Syringe"
            txtMedicalPrice.Text = "15000"

        ElseIf lbMedicalDevices.Text = "Subkutan" Then
            txtMedicalType.Text = "Syringe"
            txtMedicalPrice.Text = "15000"

        ElseIf lbMedicalDevices.Text = "Intradermal" Then
            txtMedicalType.Text = "Syringe"
            txtMedicalPrice.Text = "15000"

        ElseIf lbMedicalDevices.Text = "Diagnostic" Then
            txtMedicalType.Text = "XRay"
            txtMedicalPrice.Text = "500000"

        ElseIf lbMedicalDevices.Text = "Rontgen" Then
            txtMedicalType.Text = "XRay"
            txtMedicalPrice.Text = "500000"

        ElseIf lbMedicalDevices.Text = "USG" Then
            txtMedicalType.Text = "XRay"
            txtMedicalPrice.Text = "750000"

        ElseIf lbMedicalDevices.Text = "Digital" Then
            txtMedicalType.Text = "Thermometer"
            txtMedicalPrice.Text = "50000"

        ElseIf lbMedicalDevices.Text = "DotDigital" Then
            txtMedicalType.Text = "Thermometer"
            txtMedicalPrice.Text = "75000"

        ElseIf lbMedicalDevices.Text = "Infrared" Then
            txtMedicalType.Text = "Thermometer"
            txtMedicalPrice.Text = "100000"

        End If


    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
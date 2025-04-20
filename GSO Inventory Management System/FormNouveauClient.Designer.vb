Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNouveauClient
    Inherits MetroFramework.Forms.MetroForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ' Configuration de la forme
        Me.Text = "Nouveau Client"
        Me.Size = New Size(500, 450)
        Me.StartPosition = FormStartPosition.CenterParent

        ' Nom
        Dim lblNom As New MetroLabel()
        lblNom.Text = "Nom:"
        lblNom.Location = New Point(30, 80)
        lblNom.Size = New Size(100, 30)

        txtNom = New MetroTextBox()
        txtNom.Location = New Point(140, 80)
        txtNom.Size = New Size(300, 30)

        ' Prénom
        Dim lblPrenom As New MetroLabel()
        lblPrenom.Text = "Prénom:"
        lblPrenom.Location = New Point(30, 120)
        lblPrenom.Size = New Size(100, 30)

        txtPrenom = New MetroTextBox()
        txtPrenom.Location = New Point(140, 120)
        txtPrenom.Size = New Size(300, 30)

        ' Téléphone
        Dim lblTelephone As New MetroLabel()
        lblTelephone.Text = "Téléphone:"
        lblTelephone.Location = New Point(30, 160)
        lblTelephone.Size = New Size(100, 30)

        txtTelephone = New MetroTextBox()
        txtTelephone.Location = New Point(140, 160)
        txtTelephone.Size = New Size(300, 30)

        ' Email
        Dim lblEmail As New MetroLabel()
        lblEmail.Text = "Email:"
        lblEmail.Location = New Point(30, 200)
        lblEmail.Size = New Size(100, 30)

        txtEmail = New MetroTextBox()
        txtEmail.Location = New Point(140, 200)
        txtEmail.Size = New Size(300, 30)

        ' Adresse
        Dim lblAdresse As New MetroLabel()
        lblAdresse.Text = "Adresse:"
        lblAdresse.Location = New Point(30, 240)
        lblAdresse.Size = New Size(100, 30)

        txtAdresse = New MetroTextBox()
        txtAdresse.Location = New Point(140, 240)
        txtAdresse.Size = New Size(300, 30)
        txtAdresse.Multiline = True
        txtAdresse.Height = 60

        ' Date de naissance
        Dim lblDateNaissance As New MetroLabel()
        lblDateNaissance.Text = "Date naissance:"
        lblDateNaissance.Location = New Point(30, 310)
        lblDateNaissance.Size = New Size(100, 30)

        dtpDateNaissance = New DateTimePicker()
        dtpDateNaissance.Location = New Point(140, 310)
        dtpDateNaissance.Size = New Size(300, 30)
        dtpDateNaissance.Format = DateTimePickerFormat.Short

        ' Boutons
        btnEnregistrer = New MetroButton()
        btnEnregistrer.Text = "Enregistrer"
        btnEnregistrer.Location = New Point(140, 360)
        btnEnregistrer.Size = New Size(120, 30)
        btnEnregistrer.UseSelectable = True
        AddHandler btnEnregistrer.Click, AddressOf BtnEnregistrer_Click

        btnAnnuler = New MetroButton()
        btnAnnuler.Text = "Annuler"
        btnAnnuler.Location = New Point(280, 360)
        btnAnnuler.Size = New Size(120, 30)
        btnAnnuler.UseSelectable = True
        AddHandler btnAnnuler.Click, AddressOf BtnAnnuler_Click

        ' Ajouter les contrôles au formulaire
        Me.Controls.Add(lblNom)
        Me.Controls.Add(txtNom)
        Me.Controls.Add(lblPrenom)
        Me.Controls.Add(txtPrenom)
        Me.Controls.Add(lblTelephone)
        Me.Controls.Add(txtTelephone)
        Me.Controls.Add(lblEmail)
        Me.Controls.Add(txtEmail)
        Me.Controls.Add(lblAdresse)
        Me.Controls.Add(txtAdresse)
        Me.Controls.Add(lblDateNaissance)
        Me.Controls.Add(dtpDateNaissance)
        Me.Controls.Add(btnEnregistrer)
        Me.Controls.Add(btnAnnuler)
    End Sub
End Class

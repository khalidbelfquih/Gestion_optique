Imports MetroFramework
Imports MetroFramework.Controls
Imports MetroFramework.Forms
Imports System.Data.SqlClient

Public Class FormNouveauClient
    Inherits MetroFramework.Forms.MetroForm

    ' Déclaration des contrôles
    Private txtNom As MetroTextBox
    Private txtPrenom As MetroTextBox
    Private txtTelephone As MetroTextBox
    Private txtEmail As MetroTextBox
    Private txtAdresse As MetroTextBox
    Private dtpDateNaissance As DateTimePicker
    Private btnEnregistrer As MetroButton
    Private btnAnnuler As MetroButton





    Private Sub BtnEnregistrer_Click(sender As Object, e As EventArgs)
        ' Validation des champs obligatoires
        If String.IsNullOrEmpty(txtNom.Text) Then
            MetroFramework.MetroMessageBox.Show(Me, "Le nom est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(txtPrenom.Text) Then
            MetroFramework.MetroMessageBox.Show(Me, "Le prénom est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(txtTelephone.Text) Then
            MetroFramework.MetroMessageBox.Show(Me, "Le téléphone est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Enregistrement du client dans la base de données
        EnregistrerClient()

        ' Fermer le formulaire avec DialogResult.OK
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs)
        ' Fermer le formulaire avec DialogResult.Cancel
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub EnregistrerClient()
        ' Code pour enregistrer le client dans la base de données
        ' À implémenter selon votre structure de données

        ' Exemple simple avec SqlConnection
        Try
            Using conn As New SqlConnection("server=127.0.0.1;port=3306;user=root;password=;database=gso_db;")
                conn.Open()

                Using cmd As New SqlCommand("INSERT INTO Clients (Nom, Prenom, Telephone, Email, Adresse, DateNaissance, DateCreation) VALUES (@Nom, @Prenom, @Telephone, @Email, @Adresse, @DateNaissance, @DateCreation)", conn)
                    cmd.Parameters.AddWithValue("@Nom", txtNom.Text)
                    cmd.Parameters.AddWithValue("@Prenom", txtPrenom.Text)
                    cmd.Parameters.AddWithValue("@Telephone", txtTelephone.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@Adresse", txtAdresse.Text)
                    cmd.Parameters.AddWithValue("@DateNaissance", dtpDateNaissance.Value)
                    cmd.Parameters.AddWithValue("@DateCreation", DateTime.Now)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MetroFramework.MetroMessageBox.Show(Me, "Client enregistré avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Erreur lors de l'enregistrement: " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
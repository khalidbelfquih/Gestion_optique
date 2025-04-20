
Imports System.Security.Cryptography
Imports System.Text
Imports MetroFramework
Imports MySql.Data.MySqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_un = New MetroFramework.Controls.MetroTextBox()
        Me.txt_pw = New MetroFramework.Controls.MetroTextBox()
        Me.btnLogin = New MetroFramework.Controls.MetroButton()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(401, 211)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(97, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Username"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable
        Me.MetroLabel2.Location = New System.Drawing.Point(406, 299)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(92, 25)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Password"
        '
        'txt_un
        '
        '
        '
        '
        Me.txt_un.CustomButton.Image = Nothing
        Me.txt_un.CustomButton.Location = New System.Drawing.Point(232, 1)
        Me.txt_un.CustomButton.Name = ""
        Me.txt_un.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txt_un.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_un.CustomButton.TabIndex = 1
        Me.txt_un.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_un.CustomButton.UseSelectable = True
        Me.txt_un.CustomButton.Visible = False
        Me.txt_un.Lines = New String() {"test"}
        Me.txt_un.Location = New System.Drawing.Point(406, 243)
        Me.txt_un.MaxLength = 32767
        Me.txt_un.Name = "txt_un"
        Me.txt_un.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_un.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_un.SelectedText = ""
        Me.txt_un.SelectionLength = 0
        Me.txt_un.SelectionStart = 0
        Me.txt_un.ShortcutsEnabled = True
        Me.txt_un.Size = New System.Drawing.Size(256, 25)
        Me.txt_un.TabIndex = 2
        Me.txt_un.Text = "test"
        Me.txt_un.UseSelectable = True
        Me.txt_un.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_un.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_pw
        '
        '
        '
        '
        Me.txt_pw.CustomButton.Image = Nothing
        Me.txt_pw.CustomButton.Location = New System.Drawing.Point(232, 1)
        Me.txt_pw.CustomButton.Name = ""
        Me.txt_pw.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txt_pw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_pw.CustomButton.TabIndex = 1
        Me.txt_pw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_pw.CustomButton.UseSelectable = True
        Me.txt_pw.CustomButton.Visible = False
        Me.txt_pw.Lines = New String() {"123"}
        Me.txt_pw.Location = New System.Drawing.Point(406, 332)
        Me.txt_pw.MaxLength = 32767
        Me.txt_pw.Name = "txt_pw"
        Me.txt_pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_pw.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_pw.SelectedText = ""
        Me.txt_pw.SelectionLength = 0
        Me.txt_pw.SelectionStart = 0
        Me.txt_pw.ShortcutsEnabled = True
        Me.txt_pw.Size = New System.Drawing.Size(256, 25)
        Me.txt_pw.TabIndex = 3
        Me.txt_pw.Text = "123"
        Me.txt_pw.UseSelectable = True
        Me.txt_pw.UseSystemPasswordChar = True
        Me.txt_pw.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_pw.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(438, 408)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(175, 32)
        Me.btnLogin.Style = MetroFramework.MetroColorStyle.Green
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseSelectable = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(438, 460)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(175, 32)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable
        Me.MetroLabel3.Location = New System.Drawing.Point(419, 145)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(228, 25)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel3.TabIndex = 7
        Me.MetroLabel3.Text = "gestion de stock parfaite."
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        Me.MetroLabel3.UseStyleColors = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = Global.GSO_Inventory_Management_System.My.Resources.Resources.Beige_and_Grey_Aesthetic_Minimalist_Contact_Us_Instagram_Post__369_x_484_px___2_
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(-2, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 617)
        Me.Panel1.TabIndex = 6
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable
        Me.MetroLabel4.Location = New System.Drawing.Point(451, 109)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(162, 25)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Connexion rapide"
        Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        Me.MetroLabel4.UseStyleColors = True
        '
        'Login
        '
        Me.ClientSize = New System.Drawing.Size(685, 622)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txt_pw)
        Me.Controls.Add(Me.txt_un)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "Login"
        Me.Text = "Connexion - Opticien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_un As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_pw As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton

    Private Sub MetroLabel3_Click(sender As Object, e As EventArgs) Handles MetroLabel3.Click

    End Sub

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles MetroLabel1.Click

    End Sub

    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs) Handles MetroLabel4.Click

    End Sub


    Public Function HashPassword(password As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim sb As New StringBuilder()
            For Each b In bytes
                sb.Append(b.ToString("x2")) ' Hexadecimal format
            Next
            Return sb.ToString()
        End Using
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim connStr As String = "server=127.0.0.1;port=3306;user=root;password=;database=gestion_optique;"
        Dim conn As New MySqlConnection(connStr)

        Try
            conn.Open()
            Dim hashedPassword As String = HashPassword(txt_pw.Text)
            Dim query As String = "SELECT * FROM Utilisateurs WHERE NomUtilisateur=@user AND MotDePasse=@pass AND Actif = 1"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user", txt_un.Text.Trim())
            cmd.Parameters.AddWithValue("@pass", hashedPassword)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim role As String = reader("Role").ToString()
                Dim nom As String = reader("Nom").ToString()

                MetroMessageBox.Show(Me, "Bienvenue " & nom & " (" & role & ")", "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If role = "Admin" Then
                    Dim f As New administration()
                    f.Show()
                    Me.Hide()
                ElseIf role = "Vendeuse" Then
                    Dim f As New Vendeuse()
                    f.Show()
                    Me.Hide()
                Else
                    MetroMessageBox.Show(Me, "Rôle inconnu.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MetroMessageBox.Show(Me, "Nom d'utilisateur ou mot de passe incorrect.", "Échec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()
            conn.Close()
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Erreur : " & ex.Message, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        openconnection()

    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class

Imports System.IdentityModel.Tokens.Jwt
Imports System.Security.Cryptography
Imports EntityFrameworkLib.Context
Imports EntityFrameworkLib.Models
Imports Microsoft.IdentityModel.Tokens
Imports VisualBasicLib.Abstracts
Imports VisualBasicLib.Extensions
Imports VisualBasicLib.Interfaces

Namespace Classes
  Public Class UserService
    Inherits LoginAbstract

    Public Sub New(navigation As INavigationManager, context As LibDbContext)
      MyBase.New(navigation, context)
    End Sub

    Public Overrides Sub SignIn()
      Try
        Dim usuario As Usuario = DbContext.Usuarios.ToList().FirstOrDefault(Function(a) a.Nome = User.Nome)
        If usuario Is Nothing OrElse VerifyPassword(User.HashSenha, usuario.HashSenha, usuario.Salt) = False Then Throw New ApplicationException("Usuário ou senha incorretos.")

        Dim jsonWebToken As New JsonWebToken With {
          .Key = "teste123teste123teste123teste123",
          .Algorithm = SecurityAlgorithms.HmacSha256,
          .Issuer = "NETFrameworkLib",
          .Audience = "WindowsFormsCRUD",
          .IssuedDay = Date.Now,
          .IssuedTime = Date.Now,
          .ExpirationDay = Date.Now.AddSeconds(5),
          .ExpirationTime = Date.Now.AddSeconds(5),
          .Subject = User.Nome,
          .Claims = New ObjectModel.ObservableCollection(Of Claim)
        }

        Dim SecurityKey As New SymmetricSecurityKey(Text.Encoding.UTF8.GetBytes(jsonWebToken.Key))
        Dim credentials As New SigningCredentials(SecurityKey, jsonWebToken.Algorithm)

        Dim subject As New Claim With {.Key = Security.Claims.ClaimTypes.NameIdentifier, .Value = User.Nome}
        jsonWebToken.Claims.Add(subject)

        Dim jwt As New JwtSecurityToken(
          issuer:=jsonWebToken.Issuer,
          audience:=jsonWebToken.Audience,
          expires:=jsonWebToken.Expiration,
          claims:=jsonWebToken.Claims.ToSystemSecurityClaimsClaim(),
          signingCredentials:=credentials)

        Dim tokenHandler As New JwtSecurityTokenHandler
        Token = tokenHandler.WriteToken(jwt)
        Jwtoken = tokenHandler.CreateJwtSecurityToken()
        UserName = User.Nome

        If String.IsNullOrWhiteSpace(Token) Then
          MessageBox.Show("Usuário ou senha incorretos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          Navigation.ClosePage("frmLogin")
          StartTimer()
        End If
      Catch ex As ApplicationException
        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Catch ex As Exception
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End Sub
    Public Overrides Sub SignOut()
      Try
        Dim result As DialogResult = MessageBox.Show("Deseja realmente sair?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Exit Sub
        StopTimer()
        Navigation.CloseAllPages()
        Token = String.Empty
        User = New Usuario With {.Nome = String.Empty}
        UserName = String.Empty
        Jwtoken = Nothing
        IsAuthenticated()
      Catch ex As Exception
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
      End Try
    End Sub
    Public Overrides Sub IsAuthenticated()
      If Jwtoken IsNot Nothing AndAlso Jwtoken.ValidTo < Date.Now Then
        Token = String.Empty
        Jwtoken = Nothing
      End If

      If String.IsNullOrEmpty(Token) Then
        Navigation.ShowDialog("frmLogin")
      Else
        Dim tokenHandler As New JwtSecurityTokenHandler
        Jwtoken = tokenHandler.ReadJwtToken(Token)
        User = New Usuario With {
          .Nome = Jwtoken.Subject
        }
      End If
    End Sub
    Public Overrides Sub HasUserInDatabase()
      If DbContext.Usuarios.Any() Then Exit Sub

      Navigation.ShowDialog("frmNovoUsuario")
    End Sub
    Public Overrides Sub SignUp()
      Try
        If RegistroDTO.Senha <> RegistroDTO.ConfirmaSenha Then
          MessageBox.Show("Senhas não são iguais", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
          Exit Sub
        End If

        Dim rng As New RNGCryptoServiceProvider()
        Dim secretKey(31) As Byte
        rng.GetBytes(secretKey)
        Dim secretKeyString As String = Convert.ToBase64String(secretKey)

        Dim hash As String = HashPassword(RegistroDTO.Senha, secretKey)
        User.HashSenha = hash
        User.Salt = secretKey
        User.Nome = RegistroDTO.Login

        DbContext.Usuarios.Add(User)
        DbContext.SaveChanges()

        Navigation.ClosePage("frmNovoUsuario")
      Catch ex As Exception
        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
      End Try
    End Sub
  End Class
End Namespace

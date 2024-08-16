﻿Imports System.IdentityModel.Tokens.Jwt
Imports EntityFrameworkLib.Models
Imports Microsoft.IdentityModel.Tokens
Imports VisualBasicLib.Abstracts
Imports VisualBasicLib.Extensions
Imports VisualBasicLib.Interfaces

Namespace Classes
  Public Class UserService
    Inherits LoginAbstract

    Public Sub New(navigation As INavigationManager)
      MyBase.New(navigation)
    End Sub

    Public Overrides Sub SignIn()
      Dim jsonWebToken As New JsonWebToken With {
        .Key = "teste123teste123teste123teste123",
        .Algorithm = SecurityAlgorithms.HmacSha256,
        .Issuer = "NETFrameworkLib",
        .Audience = "WindowsFormsCRUD",
        .IssuedDay = Date.Now,
        .IssuedTime = Date.Now,
        .ExpirationDay = Date.Now.AddDays(10),
        .ExpirationTime = Date.Now.AddDays(10),
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

      If String.IsNullOrWhiteSpace(Token) Then
        MessageBox.Show("Usuário ou senha incorretos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
        Navigation.StartHomePage()
      End If
    End Sub
  End Class
End Namespace

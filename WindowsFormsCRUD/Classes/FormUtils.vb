﻿Imports System.IO

Namespace Classes
  Public Class FormUtils
    Public Shared Sub ShowError(sender As Object, e As ErrorEventArgs)
      Dim exception As Exception = e.GetException()
      MessageBox.Show(exception.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Shared Function SelectTypeT(Of TypeT)(grid As DataGridView) As TypeT
      Dim row As Integer = grid.SelectedRows(0).Index
      Dim retorno As TypeT = CType(grid.Rows(row).DataBoundItem, TypeT)
      Return retorno
    End Function
  End Class
End Namespace

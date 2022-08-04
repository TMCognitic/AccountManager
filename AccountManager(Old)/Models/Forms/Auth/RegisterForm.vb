Imports System.ComponentModel.DataAnnotations

Public Class RegisterForm
    <Required>
    Public Property LastName As String
    <Required>
    Public Property FirstName As String
    <Required>
    <EmailAddress>
    Public Property Email As String
    <Required>
    <DataType(DataType.Password)>
    <StringLength(20, MinimumLength:=8)>
    Public Property Passwd As String
    <Compare(NameOf(Passwd))>
    <DataType(DataType.Password)>
    Public Property Confirm As String
End Class

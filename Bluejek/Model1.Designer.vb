﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.ComponentModel
Imports System.Data.EntityClient
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Xml.Serialization


<Assembly: EdmSchemaAttribute("db9e32e0-3321-464f-8c15-0b4b212fa9e5")>
#Region "Contexts"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
Public Partial Class Database1Entities
    Inherits ObjectContext

    #Region "Constructors"

    ''' <summary>
    ''' Initializes a new Database1Entities object using the connection string found in the 'Database1Entities' section of the application configuration file.
    ''' </summary>
    Public Sub New()
        MyBase.New("name=Database1Entities", "Database1Entities")
        MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new Database1Entities object.
    ''' </summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "Database1Entities")
        MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new Database1Entities object.
    ''' </summary>
    Public Sub New(ByVal connection As EntityConnection)
        MyBase.New(connection, "Database1Entities")
        MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    #End Region

    #Region "Partial Methods"

    Partial Private Sub OnContextCreated()
    End Sub

    #End Region

End Class

#End Region


Imports System
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class frmOpcoes
    Inherits Form
    Private Const APPCOMMAND_VOLUME_MUTE As Integer = &H80000
    Private Const APPCOMMAND_VOLUME_UP As Integer = &HA0000
    Private Const APPCOMMAND_VOLUME_DOWN As Integer = &H90000
    Private Const WM_APPCOMMAND As Integer = &H319
    <DllImport("user32.dll")>
    Public Shared Function SendMessageW(ByVal hWnd As IntPtr,
               ByVal Msg As Integer, ByVal wParam As IntPtr,
               ByVal lParam As IntPtr) As IntPtr
    End Function

    Private Sub FrmOpcoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPlay.Visible = False
        btnPause.Visible = True
    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        My.Computer.Audio.Play(My.Resources.BG_Song, AudioPlayMode.BackgroundLoop)
        btnPause.Visible = True
        btnPlay.Visible = False
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        My.Computer.Audio.Stop()
        btnPlay.Visible = True
        btnPause.Visible = False
    End Sub

    Private Sub btnMudo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMudo.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND,
                          Me.Handle, New IntPtr(APPCOMMAND_VOLUME_MUTE))
    End Sub

    Private Sub btnDiminuirVol_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDiminuirVol.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND,
                         Me.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))
    End Sub

    Private Sub btnAumentarVol_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAumentarVol.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND,
                         Me.Handle, New IntPtr(APPCOMMAND_VOLUME_UP))
    End Sub
End Class

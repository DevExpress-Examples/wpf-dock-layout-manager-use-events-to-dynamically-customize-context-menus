Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Wpf.Bars
Imports DevExpress.Wpf.Docking

Namespace DockManager_MenuCustomization
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "#1"
		Private Sub dockManager1_ShowingMenu(ByVal sender As Object, ByVal e As DevExpress.Wpf.Docking.Base.ShowingMenuEventArgs)
			Dim menu As ItemContextMenu = (TryCast(e.Menu, ItemContextMenu))
			If menu Is Nothing Then
				Return
			End If
			' Action 1 - Insert a new About button at the first position in the menu.
			Dim actionAddAboutItem As New BarButtonItem()
			' Specify the position for the button via the InsertBarItemLinkAction.ItemLinkIndex attached property.
			InsertBarItemLinkAction.SetItemLinkIndex(actionAddAboutItem, 0)
			actionAddAboutItem.Content = "About..."
			AddHandler actionAddAboutItem.ItemClick, AddressOf btnAbout_ItemClick
			' Action 2 - Insert a separator
			Dim actionAddSeparator As New InsertBarItemLinkAction()
			actionAddSeparator.ItemLink = New BarItemLinkSeparator()
			actionAddSeparator.ItemLinkIndex = 1

			' Add the actions to the ActionList
			e.ActionList.Add(actionAddAboutItem)
			e.ActionList.Add(actionAddSeparator)
		End Sub

		Private Sub btnAbout_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			MessageBox.Show("About window")
		End Sub
		#End Region ' #1
	End Class
End Namespace

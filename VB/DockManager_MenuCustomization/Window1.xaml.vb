Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Docking

Namespace DockManager_MenuCustomization

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

'#Region "#1"
        Private Sub dockManager1_ShowingMenu(ByVal sender As Object, ByVal e As Base.ShowingMenuEventArgs)
            Dim menu As ItemContextMenu = TryCast(e.Menu, ItemContextMenu)
            If menu Is Nothing Then Return
            ' Action 1 - Insert a new About button at the first position in the menu.
            Dim actionAddAboutItem As BarButtonItem = New BarButtonItem()
            ' Specify the position for the button via the InsertBarItemLinkAction.ItemLinkIndex attached property.
            BarItemLinkActionBase.SetItemLinkIndex(actionAddAboutItem, 0)
            actionAddAboutItem.Content = "About..."
            AddHandler actionAddAboutItem.ItemClick, New ItemClickEventHandler(AddressOf btnAbout_ItemClick)
            ' Action 2 - Insert a separator
            Dim actionAddSeparator As InsertBarItemLinkAction = New InsertBarItemLinkAction()
            actionAddSeparator.ItemLink = New BarItemLinkSeparator()
            actionAddSeparator.ItemLinkIndex = 1
            ' Add the actions to the ActionList
            e.ActionList.Add(actionAddAboutItem)
            e.ActionList.Add(actionAddSeparator)
        End Sub

        Private Sub btnAbout_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            MessageBox.Show("About window")
        End Sub
'#End Region  ' #1
    End Class
End Namespace

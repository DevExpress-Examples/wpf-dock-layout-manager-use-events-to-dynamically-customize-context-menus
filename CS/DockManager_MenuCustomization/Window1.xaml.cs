using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Docking;

namespace DockManager_MenuCustomization {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        #region #1
        private void dockManager1_ShowingMenu(object sender, DevExpress.Xpf.Docking.Base.ShowingMenuEventArgs e) {
            ItemContextMenu menu = (e.Menu as ItemContextMenu);
            if (menu == null) return;
            // Action 1 - Insert a new About button at the first position in the menu.
            BarButtonItem actionAddAboutItem = new BarButtonItem();
            // Specify the position for the button via the InsertBarItemLinkAction.ItemLinkIndex attached property.
            InsertBarItemLinkAction.SetItemLinkIndex(actionAddAboutItem, 0);
            actionAddAboutItem.Content = "About...";
            actionAddAboutItem.ItemClick += new ItemClickEventHandler(btnAbout_ItemClick);
            // Action 2 - Insert a separator
            InsertBarItemLinkAction actionAddSeparator = new InsertBarItemLinkAction();
            actionAddSeparator.ItemLink = new BarItemLinkSeparator();
            actionAddSeparator.ItemLinkIndex = 1;

            // Add the actions to the ActionList
            e.ActionList.Add(actionAddAboutItem);
            e.ActionList.Add(actionAddSeparator);
        }

        void btnAbout_ItemClick(object sender, ItemClickEventArgs e) {
            MessageBox.Show("About window");
        }
        #endregion #1
    }
}

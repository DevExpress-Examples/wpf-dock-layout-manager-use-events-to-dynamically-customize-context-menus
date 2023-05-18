<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128643513/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1751)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Dock Layout Manager - Use Events to Dynamically Customize Context Menus

This example uses the [DockLayoutManager.ShowingMenu](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager.ShowingMenu) event to customize a [LayoutPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.LayoutPanel)'s context menu. The menu uses customization actions to customize bars. This example creates two actions:

- [BarButtonItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarButtonItem) object — a menu action.


- [InsertBarItemLinkAction](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.InsertBarItemLinkAction) object — an action that inserts a bar item link into the menu (in the example, it inserts a separator).

<img src="https://user-images.githubusercontent.com/12169834/175352251-7fd3e5b0-28d7-4d84-8773-6360532583d9.png" width=505px/>

<!-- default file list -->

## Files to Look At

* [Window1.xaml](./CS/DockManager_MenuCustomization/Window1.xaml) (VB: [Window1.xaml](./VB/DockManager_MenuCustomization/Window1.xaml))
* [Window1.xaml.cs](./CS/DockManager_MenuCustomization/Window1.xaml.cs) (VB: [Window1.xaml](./VB/DockManager_MenuCustomization/Window1.xaml))
<!-- default file list end -->

## Documentation

* [Dock Layout Manager: Visual Elements](http://docs.devexpress.com/WPF/6827/controls-and-libraries/layout-management/dock-windows/visual-elements)

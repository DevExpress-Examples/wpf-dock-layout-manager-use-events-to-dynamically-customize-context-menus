<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128643513/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1751)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/DockManager_MenuCustomization/Window1.xaml) (VB: [Window1.xaml](./VB/DockManager_MenuCustomization/Window1.xaml))
* [Window1.xaml.cs](./CS/DockManager_MenuCustomization/Window1.xaml.cs) (VB: [Window1.xaml](./VB/DockManager_MenuCustomization/Window1.xaml))
<!-- default file list end -->
# How to dynamically customize context menus via an event


<p>This example shows how to customize a context menu for a LayoutPanel via the DockManager.ShowingMenu event. The menu is customized using bar customization actions. In the example, two actions are created:<br />
- a BarButtonItem object represents an action that adds the BarButtonItem object to the menu<br />
- an InsertBarItemLinkAction object represents an action that inserts a bar item link to the menu (in the example, the inserted link represents a separator).</p><p>Actions are added to the event's ActionList parameter and are executed after the ShowingMenu event handler is completed.</p>

<br/>



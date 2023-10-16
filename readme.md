# MAUI Flyout Bug [#18064](https://github.com/dotnet/maui/issues/18064)

When a `Flyout` can have its `Detail` set to different `NavigationPage` instances, 
the back-arrow will only appear if the *first* `NavigationPage` to be set has 
children pushed to it.  
If the back-arrow is present and `Detail` is set to a different `NavigationPage` 
then the back-arrow will remain, even if the new `NavigationPage` is empty.
The back-arrow, if visible and tapped, will pop a Page from the correct `NavigationPage`.  

### Example repro:
1. Pick NavigationPage B from the Flyout.
1. Push a Page.
1. Notice the back-arrow appears.
1. Pick NavigationPage A from the Flyout.
1. [BUG] Notice the back-arrow remains.

### Example repro:
1. Pick NavigationPage B from the Flyout.
1. Pick NavigationPage A from the Flyout.
1. Push a Page.
1. [BUG] Notice the back-arrow does not appear.

Swap A and B and repeat either example and the same problems occur.  

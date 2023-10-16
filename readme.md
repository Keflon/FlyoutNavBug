# MAUI Flyout Bug

When a `Flyout` can have its `Detail` set to different `NavigationPage` instances, 
the back-arrow will only appear if the *first* `NavigationPage` to be set has 
children pushed to it.  
If the back-arrow is present and `Detail` is set to a different `NavigationPage` 
then the back-arrow will remain, even if the new `NavigationPage` is empty.
The back-arrow, if visible and tapped, will pop a Page from the correct `NavigationPage`.

   M S B A M L   `   `   `  ����H  DWebBrowserApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WebBrowserAppWebBrowserApp  5          WebBrowserApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WebBrowserApp     5        � Title$  Web Browser App��5      $	��992��6   $	��439��6+   .��5	      � .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Stretch=�6.   $	��Top=�6L   $��10q�6d   .+�5      �� -   5         ��Name$ 
BackButton��5      $
��Back��6)   $��60��68   $��30��6C   6O   �� 5      -   5        $ ForwardButton��5      $��Forward��6,   $��60��6>   $��30��6I   6U   �� 5      -   5        $ RefreshButton��5      $��Refresh��6,   $��60��6>   $��30��6I   6U   �� 5      -   5        $ 
StopButton��5      $
��Stop��6)   $��60��68   $��30��6C   6O   �� 5      -   5        $ 
HomeButton��5      $
��Home��6)   $��60��68   $��30��6C   6O   �� 5      -   5         ��Name$ 
AddressBar��5      $��Stretch=�6*   $	��Top=�6H   $��30��6`   $	��500��6l   $��10,0,0,0q�6x   6�   �� 5      -   5        $��Go��5      $��60��6"   $��30��6-   69   �� 5      -   5        $ AddBookmarkButton��5      $��Add Bookmark��60   $	��100��6G   $��30��6S   6_   5      � 5   
   $��10,50,10,30q�6   .+�5      (  "System.Windows.Controls.WebBrowser  -	   5          Name$ WebBrowserControl��5      6^   �� 5      -
   5         ��Name$ BookmarksList��5      $	��200��6-   $
��Left=�69   $��10,0,0,0q�6T   6f   5      �� 5   
   $��Bottom=�6   .@�5      �� -   5         ��Name$ 
StatusText��5      $��Ready��6,   5       5!      5"      
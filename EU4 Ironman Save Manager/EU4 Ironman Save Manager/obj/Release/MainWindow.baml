   M S B A M L   `   `   `  ���� S  OEU4 Ironman Save Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:EU4_Ironman_Save_ManagerEU4_Ironman_Save_Manager  )    #EU4_Ironman_Save_Manager.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8local&clr-namespace:EU4_Ironman_Save_Manager     -     � Title$  EU4ISM��$��187.29��$��175.223�� � WindowStyle$
 None=� � AllowsTransparency .   � Topmost .  � 
ResizeMode$ NoResize=� � WindowStartupLocation$ Manual=�.���  � ColumnDefinitions �� $	��23* ��� $
��152* �.+��� $
��Left=�$	��190��$	��Top=�$	��175�����	#FF243F7A$��2��.+��� -    ��Name$
 Load��$
��Load��$
��Left=�$	��Top=�$	��131��#��� �� � Cursor$
 Hand��$��21��	 �� Left$	 22��

 �� Top$	
 107�� � ToolTip$v pReplace the current save with another save that you select in a dialog. Use this after you have exited the game.���� -    ��Name$ MenuText��$��EU4 Ironman Save Manager��$	��175�����	#FF181819#��� ��$��Center=��� -   $��X��$		 155��$
 4��$��18��#��� �����	#FF181819#��� ��$��Center=�$��Center=�$��18��$��10(�$��Center=�$��Center=��� -   $ 
NotifyText��$�� ��$	��131�����	#FF181819#��� ��$��Center=�$	 22��$	
 160��$��Center=�$y�Hidden=��� -   $ SettingsButton��$��Settings��$
��Left=�$��
22,133,0,0q�$	��Top=�$	��131��#��� ��$
 Hand��$��21��$��2��$4 .Set your save's name and folder location here.���� -   $ ReplaceButton��$��	Quickload��$
��Left=�$��	22,81,0,0q�$	��Top=�$	��131��#��� ��$
 Hand�� J� RenderTransformOrigin$ 	0.55,-1.6&�$��2��$d ^Replace the current save with the quicksave you made. Use this after you have exited the game.���� -   $ QuicksaveButton��$��	Quicksave��$
��Left=�$��0,31,0,0q�$	��Top=�$	��131��#��� ��$
 Hand��$ 	0.55,-1.6&�$��1��$b \Make a copy of the current save. It will be automatically renamed to savename-quicksave.eu4.���� -	   $ 
SaveButton��$
��Save��$
��Left=�$��	22,56,0,0q�$	��Top=�$	��131��#��� ��$
 Hand��$ 	0.55,-1.6&�$��2��$a [Make a custom-named copy of the current save. This button opens a dialog to name your save.��
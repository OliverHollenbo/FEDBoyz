   M S B A M L   `   `   `  ????F  BAssignment1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Assignment1.ViewsAssignment1.Views  5   	   %    Assignment1.Views.AddDebtorView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Assignment1.Views     5   	     ? Title$  AddDebtorView??5   	   $	??342??6   $	??422??6,   .??5	      ? .+?5
   
   ?? $
??Left=?6   $??	24,42,0,0q?6/   $
??Wrap=?6B   $??
Add Debtor??6V   $	??Top=?6h   $??20(?6?   $
??Bold"?6?   ?? 5   
   $
??Left=?6   $??	65,74,0,0q?6-    ?? TextWrapping$
 Wrap=?6@   $	??Top=?6?   $	??146??6?   $??36??6?   ??6T   ??  ?? Path$ CurrentDebtors.Debtorname?6?   ?? 5   
   $
??Left=?6   $??
65,132,0,0q?6-   $
 Wrap=?6A   $	??Top=?6?   $	??146??6?   $??31??6?   ??6U   ?? $! CurrentDebtors.InitialValue?6?   ? 5      $
??Left=?6   $??24,238,0,67q?6'   .+?5      ?? -   5        $??btnSave??5       ?? 	IsDefault$
 True??5      $??5??5      $??75??5      $??_Save??5      ??5      ?? $ OkBtnCommand?5      ?? 5      -   5        $??	btnCancel??5      $??1??5      $??4??5       ?? IsCancel$
 True??5      $??6??5      $??75??5      $??_Cancel??5      5!      ?? 5"   
   $
??Left=?6   $??	10,83,0,0q?6-   $
 Wrap=?6@   $??TextBox??6T   $	??Top=?6c   $??50??6{   5#      5$      
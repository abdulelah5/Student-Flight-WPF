   M S B A M L   `   `   `  ����H  DStudentFlight, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:StudentFlightStudentFlight  5   	   !    StudentFlight.requestFlight   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:StudentFlight     5   	     � Title$  requestFlight��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgvFlights��5
      $��
0,10,0,269q�6'   6V   �� 5   
   -   5         ��Name$ Request��5      $��Request��6"   $
��Left=�64   $��200,372,0,0q�6O   $	��Top=�6d   $��92��6|   $��14(�6�   ���	#FF64BF776�   �� 5   
   -   5        $ cancel��5      $��Cancel��6!   $
��Left=�62   $��479,372,0,0q�6M   $	��Top=�6b   $��93��6z   $��14(�6�   ���	#FFD8DEDA6�   	� 5   
   -   5         	�Name$ oneWay��5      $��One way��6&   $
��Left=�68   $��511,203,0,0q�6S   $	��Top=�6h   $��14(�6�   6�   	� 5   
   -   5        $ twoWay��5      $��Two way��6&   $
��Left=�68   $��204,203,0,0q�6S   $	��Top=�6h   $��14(�6�   6�   �� 5   
   -   5         ��Name$ txtFrom��5      $
��Left=�6#   $��
80,287,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��120��6~   �� 5   
   -   5        $ txtTo��5      $
��Left=�6!   $��256,287,0,0q�6<   $
 Wrap=�6Q   $	��Top=�6e   $	��120��6}   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ goDate��5      $
��Left=�6%   $��428,284,0,0q�6@   $	��Top=�6U     5   
   -	   5        $ 
returnDate��5      $
��Left=�6)   $��587,284,0,0q�6D   $	��Top=�6Y   ${�False��6q   �� 5   
   $
��From��6   $
��Left=�6   $��
80,258,0,0q�6:   $	��Top=�6N   $��14(�6f   �� 5   
   $��To��6   $
��Left=�6   $��256,258,0,0q�68   $	��Top=�6M   $��14(�6e   �� 5   
   $��Flight date��6   $
��Left=�6&   $��428,253,0,0q�6A   $	��Top=�6V   $��14(�6n   �� 5   
   $��Return date��6   $
��Left=�6&   $��587,253,0,0q�6A   $	��Top=�6V   $��14(�6n   �� 5   
   -
   5        $ cancelRequest��5      $��Cancel Request��6(   $
��Left=�6A   $��333,372,0,0q�6\   $	��Top=�6q   $	��108��6�   $��14(�6�   ���	#FFC7424A6�   5      5      
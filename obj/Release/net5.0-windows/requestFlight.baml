   M S B A M L   `   `   `  ���� H  DStudentFlight, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:StudentFlightStudentFlight  !    StudentFlight.requestFlight   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:StudentFlight       � Title$  requestFlight��$	��450��$	��800��.��� .+�&   System.Windows.Controls.DataGrid  -     Name$ 
dgvFlights��$��
0,10,0,269q��� -    ��Name$ Request��$��Request��$
��Left=�$��200,372,0,0q�$	��Top=�$��92��$��14(����	#FF64BF77�� -   $ cancel��$��Cancel��$
��Left=�$��479,372,0,0q�$	��Top=�$��93��$��14(����	#FFD8DEDA	� -    	�Name$ oneWay��$��One way��$
��Left=�$��511,203,0,0q�$	��Top=�$��14(�	� -   $ twoWay��$��Two way��$
��Left=�$��204,203,0,0q�$	��Top=�$��14(��� -    ��Name$ txtFrom��$
��Left=�$��
80,287,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120���� -   $ txtTo��$
��Left=�$��256,287,0,0q�$
 Wrap=�$	��Top=�$	��120��(  "System.Windows.Controls.DatePicker  -     Name$ goDate��$
��Left=�$��428,284,0,0q�$	��Top=�  -	   $ 
returnDate��$
��Left=�$��587,284,0,0q�$	��Top=�${�False���� $
��From��$
��Left=�$��
80,258,0,0q�$	��Top=�$��14(��� $��To��$
��Left=�$��256,258,0,0q�$	��Top=�$��14(��� $��Flight date��$
��Left=�$��428,253,0,0q�$	��Top=�$��14(��� $��Return date��$
��Left=�$��587,253,0,0q�$	��Top=�$��14(��� -
   $ cancelRequest��$��Cancel Request��$
��Left=�$��333,372,0,0q�$	��Top=�$	��108��$��14(����	#FFC7424A
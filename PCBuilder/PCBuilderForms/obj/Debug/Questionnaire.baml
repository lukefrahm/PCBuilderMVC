   M S B A M L   `   `   `  ����  PCBuilderForms"    PCBuilderForms.Questionnaire   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  PC Builder Questionnaire��5   	   $��780.999��6*   $	��505��6;    � 
ResizeMode$ NoResize=�6G    � WindowStartupLocation$ CenterScreen=�6]   .��5      � $��0,0,0,0q�6    � ColumnDefinitions 5   
   �� 5      $
��152* �6   �� 5      $
��345* �6   .+�5
   
   �� -   5         ��Name$ sldPerformance��5
   >    �� IsSnapToTickEnabled .  �� TickFrequency$ 1Q�6,   $
��Left=�6V   $��	10,41,0,0q�6q   $	��Top=�6�   $	��470��6�    � Minimum$	 200Q�6�    � Maximum$
 3000Q�6�   $��2��6�   	 � SmallChange$	 0Q�6  �� 5   
   -   5        
 ��Name$
 lblPerformance��5      $#��Level of performance desired:��6(   $
��Left=�6P   $��	10,10,0,0q�6k   $	��Top=�6~   $��2��6�   �� 5   
   -   5        $
 lblAppxDollarsLabel��5      $��Anticipated cost: $��6-   $
��Left=�6K   $��
182,10,0,0q�6f   $	��Top=�6z   $��1��6�   �� 5   
   -   5        $
 lblAppxDollars��5       �� ContentStringFormat$ {0:#}��6c   $��Right=�6�   $��	0,10,20,0q�6�   $	��Top=�6�   $��1��6�   ��6(   ��  �� ElementName$ sldPerformance�� �� Path$ Value�6�   �� 5   
   -   5        $
 lblUse��5      $%��How will you use your computer?��6    $
��Left=�6J   $��	10,70,0,0q�6e   $	��Top=�6x   $��2��6�   �� 5   
   -   5         ��Name$ chkUseBasic��5      $-��'Basic tasks (web, email, YouTube, etc.)��6(   $
��Left=�6Z   $��	10,99,0,0q�6u   $	��Top=�6�   $��2��6�   �� 5   
   -   5        $ chkUseVideoEdit��5      $��Video editing/Rendering��6,   $
��Left=�6N   $��
10,163,0,0q�6i   $	��Top=�6}   $��2��6�   �� 5   
   -   5        $ chkUseGaming��5      $��Gaming��6)   $
��Left=�6:   $��
10,147,0,0q�6U   $	��Top=�6i   �� 5   
   -	   5        $ chkUseDevelopment��5      $��Software development��6.   $
��Left=�6M   $��
10,131,0,0q�6h   $	��Top=�6|   �� 5   
   -
   5        $ chkUseOfficeModerate��5      $)��#Office use or moderate productivity��61   $
��Left=�6_   $��
10,115,0,0q�6z   $	��Top=�6�   $��2��6�   �� 5   
   -   5         ��Name$ lblBudgetNotice��5      $����NOTICE: The anticipated cost is a rough estimate of what most builds of your desired caliber will cost. Depending on selections picked, the actual cost may vary and is set to reflect the needed performance, while keeping cost as a guideline.��6-   $
��Left=�6&  $��10,630,10,0q�6A  $	��Top=�6V  $��79��6n  $
��Auto��6z  $��2��6�   �� TextAlignment$ Center=�6�  $
��Wrap=�6�  �� 5   
   -   5         ��Name$ 	btnAccept��5      $��Accept��6$   $
��Left=�65   $��101,700,0,0q�6P   $	��Top=�6e   $��75��6}   $��2��6�   �� 5   
   -   5        $ btnReset��5      $��Reset��6#   $
��Left=�63   $��
68,700,0,0q�6N   $	��Top=�6b   $��75��6z   $��1��6�   6�   �� 5   
   -   5        $ 	btnCancel��5      $��Cancel��6$   $
��Left=�65   $��187,700,0,0q�6P   $	��Top=�6e   $��75��6}   $��1��6�   6�   �� 5   
   -   5        $ sldStorageSize��5   >    . $ 1Q�6,   $
��Left=�6V   $��
10,346,0,0q�6q   $	��Top=�6�   $	��470��6�   $��2��6�   $ 64Q�6�   $
 6144Q�6�   �� 5   
   -   5        $
 lblStorageSizeLabel��5      $ ��Amount of storage desired:��6-   $
��Left=�6R   $��
10,315,0,0q�6m   $	��Top=�6�   $��2��6�   �� 5   
   -   5        $
 lblStorageSize��5      $ {0:#}��6c   $��Right=�6�   $��0,315,295,0q�6�   $	��Top=�6�   $��2��6�   ��6(   �� $ sldStorageSize��$ Value�6�   �� 5   
   -   5        $
 lblStorageSizeGB��5      $��GB��6*   $ {0:#}��67   $
��Left=�6U   $��185,315,0,0q�6p   $	��Top=�6�   $��2��6�   �� 5   
   -   5        $
 lblStorageType��5      $��Preferred storage type:��6(   $
��Left=�6J   $��230,315,0,0q�6e   $	��Top=�6z   $��2��6�   �� 5   
   -   5         ��Name$ grpStorageType��5      $�� ��6+   $
��Left=�65   $��200,303,0,0q�6P   $	��Top=�6e   $��75��6}   $	��200��6�   $��1��6�   $��0q�6�   .��5      �� $��0,0,0,0q�6   .+�5      	� -   5         	�Name$ radSSD��5       d� 	IsChecked$ FalseY�6.   $	��SSD��6@   $
��Left=�6N   $��10,2,0,0q�6i   $	��Top=�6{   	� 5       -   5        $ radHDD��5       $
 TrueY�6.   $	��HDD��6?   $
��Left=�6M   $��
70,-15,0,0q�6h   $	��Top=�6|   5!      5"      �� 5#   
   -   5        $ grpRAMChoices��5#      $��Memory Choices��6*   $
��Left=�6B   $��
10,375,0,0q�6]   $	��Top=�6q   $��65��6�   $	��470��6�   $��2��6�   .��5$      �� $��0,0,0,0q�6   .+�5%      	� -   5        $ radRAMRecommended��5%      $
 TrueY�69   $ ��Use recommended RAM amount��6J   $
��Left=�6o   $��10,2,0,0q�6�   $	��Top=�6�   	� 5&      -   5        $ radRAMSelectManual��5&      $ FalseY�6:   $ ��Select RAM amount manually��6L   $
��Left=�6q   $��10,2,0,0q�6�   $	��Top=�6�   6�   5'      5(      �� 5)   
   -   5        $ 
sldRamSize��5)   >    . $ 1Q�6,   $
��Left=�6R   $��225,410,0,0q�6m   $	��Top=�6�   $	��200��6�   $��2��6�   $ 4Q�6�   $ 32Q�6�    � LargeChange$ 4Q�6�   $	 4Q�6�   $y�Hidden=�6�   �� 5*   
   -   5        $
 lblManualRamSelect��5*      $ {0:#}��6c   $��Right=�6�   $��
0,405,40,0q�6�   $	��Top=�6�   $��2��6�   $y�Hidden=�6�   ��6,   �� $ 
sldRamSize��$ Value�6�   �� 5+   
   -   5        $
 lblManualRamSelectLabel��5+      $��GB��61   $��Right=�6>   $��
0,405,20,0q�6Z   $	��Top=�6n   $��2��6�   $y�Hidden=�6�   �� 5,   
   -   5        $ sldNumCores��5,   >    . $ 1Q�6,   $
��Left=�6S   $��
10,478,0,0q�6n   $	��Top=�6�   $	��470��6�   $��2��6�   $ 8Q�6�   $ 2Q�6�   �� 5-   
   -   5        $
 lblNumCoresLabel��5-      $��Number of CPU cores:��6*   $
��Left=�6I   $��
10,447,0,0q�6d   $	��Top=�6x   �� 5.   
   -   5        $
 lblNumCores��5.      $ {0:#}��6]   $��Right=�6{   $��	0,447,0,0q�6�   $	��Top=�6�   ��6%   �� $ sldNumCores��$ Value�6�   �� 5/   
   -    5        $ grpCaseSize��5/      $��Preferred size of case:��6(   $
��Left=�6I   $��
10,512,0,0q�6d   $	��Top=�6x   $	��105��6�   $	��235��6�   $��2��6�   .��50      �� $��0,0,0,0q�6   .+�51      	� -!   5        $ radCaseSizeFull��51      $
 TrueY�67   $��
Full tower��6H   $
��Left=�6]   $��10,2,0,0q�6x   $	��Top=�6�   	� 52      -"   5        $ radCaseSizeMid��52      $ FalseY�66   $��	Mid tower��6H   $
��Left=�6\   $��10,2,0,0q�6w   $	��Top=�6�   	� 53      -#   5        $ radCaseSizeMicro��53      $ FalseY�68   $��MicroATX��6J   $
��Left=�6]   $��10,0,2,0q�6x   $	��Top=�6�   	� 54      -$   5        $ radCaseSizeMini��54      $ FalseY�67   $��MiniITX��6I   $
��Left=�6[   $��10,0,2,0q�6v   $	��Top=�6�   	� 55      -%   5        $ radCaseSizeConsole��55      $ FalseY�6:   $��HTPC/Console��6L   $
��Left=�6c   $��10,0,2,0q�6~   $	��Top=�6�   56      57      �� 58   
   -&   5        $ 
grpOptical��58      $��Optical drive:��6'   $
��Left=�6?   $��250,512,0,0q�6Z   $	��Top=�6o   $	��105��6�   $	��235��6�   $��2��6�   .��59      �� $��0,0,27,0q�6   .+�5:      	� -'   5        $ radBRBurner��5:      $ FalseY�63   $��BluRay Burner��6E   $
��Left=�6]   $��10,2,0,0q�6x   $	��Top=�6�   	� 5;      -(   5        $ radBRReader��5;      $ FalseY�63   $��BluRay Reader��6E   $
��Left=�6]   $��10,2,0,0q�6x   $	��Top=�6�   	� 5<      -)   5        $ radDVDBurner��5<      $ FalseY�64   $��
DVD Burner��6F   $
��Left=�6[   $��10,0,2,0q�6v   $	��Top=�6�   	� 5=      -*   5        $ radOpticalNone��5=      $
 TrueY�66   $
��None��6G   $
��Left=�6V   $��10,0,2,0q�6q   $	��Top=�6�   5>      5?      5@      5A      
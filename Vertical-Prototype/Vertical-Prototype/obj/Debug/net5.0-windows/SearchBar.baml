   M S B A M L   `   `   `  ����M  IVertical-Prototype, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Vertical_PrototypeVertical_Prototype  5      "    Vertical_Prototype.SearchBar   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Vertical_Prototype     5      :xctk)http://schemas.xceed.com/wpf/xaml/toolkit     64   .��5	      � -   5          �Name$  texty��5	      ���#CAF7C9.+�5
   
   �� -   5         ��Name$ searchBar_textBox��5
       �� TextWrapping$
 Wrap=�6-   $��31��6A   $��10,10,263,49q�6M   6c   �� 5   
   -   5         ��Name$ searchBar_searchButton��5      $
��Left=�61   $��31��6L   $��
425,10,0,0q�6X   $	��Top=�6l   $��74��6�   .��5      �� -   5         ��Name$ ChefHat��5      $��/images/SearchIcon.png��6%   5      �� 5   
   -   5        $ searchBar_addRecipeButton��5      $
��Left=�64   $��45��6O   $��	540,0,0,0q�6[   $	��Top=�6n   $	��118��6�   
������ 
������ .��5      �� $ ��images/addRecipeButton.png��6   5      �� 5   
   $��
Difficulty��6   $��0,48,623,14q�6%   $
��Bold"�6:   �� 5   
   -   5         ��Name$ _difficultyCombo��5      $
��Left=�5   	   $	��Top=�5   	   $��24��5      $��78��6*   $��	62,52,0,0q�65   .@�5      �� $�� ��6   �� 5      $
��Easy��6   �� 5      $��Medium��6   �� 5      $
��Hard��6   �� 5      $��Expert��6   5      �� 5   
   $��Cuisune��6   $��139,50,484,12q�6"   $
��Bold"�69    J� RenderTransformOrigin$ 0.344,0.524&�6K   �� 5    
   -   5        $ _cuisuneCombo��5       $
��Left=�5!   	   $	��Top=�5"   	   $��24��5#   	   $	��107��6   $��
191,52,0,0q�6!   .@�5%      �� $�� ��6   �� 5&      $��American��6   �� 5'      $��Chinese��6   �� 5(      $��French��6   �� 5)      $��Indian��6   �� 5*      $��Italian��6   �� 5+      $��Japanese��6   �� 5,      $��Mexican��6   5-      �� 5/   
   $��Key Ingredient��6   $��294,50,294,12q�6)   $
��Bold"�6@   �� 50   
   -   5        $ _ingredientTextbox��50      $��385,52,180,14q�6.   �� 52   
   $��
Vegetarian��6   $��508,45,115,19q�6%   $
��Bold"�6<   $ 0.344,0.524&�6N   $��10(�6r   �� 53   
   $��Vegan��6   $��529,60,115,4q�6    $
��Bold"�66   $ 0.324,0.946&�6H   $��10(�6l   �� 54   
   -	   5         ��Name$ _vegetarianCheckbox��54      $��CheckBox��60   $
��Left=�6C   $��16��6^   $��
569,50,0,0q�6j   $	��Top=�6~   $��16��6�   �� 55   
   -
   5        $ _veganCheckbox��55      $��CheckBox��6+   $
��Left=�6>   $��16��6Y   $��
569,66,0,0q�6e   $	��Top=�6y   $��16��6�   57      59      
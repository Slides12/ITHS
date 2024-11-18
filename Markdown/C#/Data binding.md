# Data binding
MVVM
(separera backend och frontend)

## Model-view-viewModel

* Model= backend (Data, business logic)
* view = visual presentation (User interface)
* viewModel = bridge between model view(logiken mellan Model och view)

```XML
 <StackPanel>
    
    <TextBox x:Name="textBox1"
         Margin="10" 
         Text="{Binding ElementName=textBox2,Path=Text, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}"/>


<TextBox x:Name="textBox2"
             Margin="10 0" />


</StackPanel>
```


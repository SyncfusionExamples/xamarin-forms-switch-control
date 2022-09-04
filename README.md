# Xamarin Forms Switch control
This repository contains the demo for the usage of Syncfusion Xamarin.Forms Switch control. This Switch control provides support to 3 different states, on, off and intermediate. Here is the code snippet:

** XAML **

```
<ScrollView HorizontalScrollBarVisibility="Never">
            <ScrollView.Resources>
                <ResourceDictionary>
                    <Style TargetType="syncfusion:SfSwitch">
                        <Setter Property="HorizontalOptions" Value="Start"/>
                        <Setter Property="WidthRequest" Value="70"/>
                    </Style>
                    <Style TargetType="Label">
                        <Setter Property="Margin" Value="15,0"/>
                    </Style>
                </ResourceDictionary>
            </ScrollView.Resources>
            <StackLayout x:Name="mainStack"
                         Orientation="Vertical"
                         BackgroundColor="White"
                         HorizontalOptions="Start"
                         WidthRequest="350"
                         Margin="5">
                <Label Text="Visual Types"
                       FontSize="16"
                       VerticalOptions="Center"
                       HorizontalOptions="Start"/>

                <Grid HeightRequest="70"
                      BackgroundColor="White">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="50"/>
                        <RowDefinition Height="*"/>
                    </Grid.RowDefinitions>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                    </Grid.ColumnDefinitions>
                    <syncfusion:SfSwitch Grid.Column="0"
                                         Grid.Row="0"
                                         HorizontalOptions="Start"
                                         AllowIndeterminateState="False"
                                         VisualType="Material">
                    </syncfusion:SfSwitch>
                    <syncfusion:SfSwitch Grid.Column="1"
                                         Grid.Row="0"
                                         AllowIndeterminateState="False"
                                         VisualType="Cupertino">
                    </syncfusion:SfSwitch>
                    <syncfusion:SfSwitch Grid.Column="2"
                                         Grid.Row="0"
                                         AllowIndeterminateState="False"
                                         VisualType="Fluent">
                    </syncfusion:SfSwitch>
                    <Label Grid.Column="0"
                           Grid.Row="1"
                           Text="Material"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                    <Label Grid.Column="1"
                           Grid.Row="1"
                           Text="Cupertino"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                    <Label Grid.Column="2"
                           Grid.Row="1"
                           Text="Fluent"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                </Grid>

                <Grid HeightRequest="10"/>
                <Label Text="States (Enabled)"
                       FontSize="16"
                       VerticalOptions="Center"
                       HorizontalOptions="Start"/>

                <Grid HeightRequest="70"
                      BackgroundColor="White"
                      Margin="0,5,0,5">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="50"/>
                        <RowDefinition Height="*"/>
                    </Grid.RowDefinitions>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                    </Grid.ColumnDefinitions>
                    <syncfusion:SfSwitch Grid.Column="0"
                                         Grid.Row="0"
                                         x:Name="OnStateSwitch"
                                         AllowIndeterminateState="True"
                                         IsOn="False"
                                         StateChanged="SfSwitch_StateChanged"
                                         VisualType="Default">
                    </syncfusion:SfSwitch>
                    <syncfusion:SfSwitch Grid.Column="1"
                                         Grid.Row="0"
                                         AllowIndeterminateState="True"
                                         IsOn="{x:Null}"   
                                         x:Name="IndeterminateStateSwitch"
                                         StateChanged="SfSwitch_StateChanged_1"
                                         VisualType="Default">
                    </syncfusion:SfSwitch>
                    <syncfusion:SfSwitch Grid.Column="2"
                                         Grid.Row="0"
                                         AllowIndeterminateState="True"
                                         x:Name="OffStateSwitch"
                                         StateChanged="SfSwitch_StateChanged_2"
                                         IsOn="True"
                                         VisualType="Default">
                    </syncfusion:SfSwitch>
                    <Label Grid.Column="0"
                           x:Name="OnStateLabel"
                           Grid.Row="1"
                           Text="Off"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                    <Label Grid.Column="1"
                           Grid.Row="1"
                           x:Name="IndeterminateStateLabel"
                           Text="Indeterminate"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                    <Label Grid.Column="2"
                           x:Name="OffStateLabel"
                           Grid.Row="1"
                           Text="On"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                </Grid>
                <Grid HeightRequest="10"/>

                <Label Text="States (Disabled)"
                       FontSize="16"
                       VerticalOptions="Center"
                       HorizontalOptions="Start"/>

                <Grid HeightRequest="70"
                      BackgroundColor="White"
                      Margin="0,5,0,5">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="50"/>
                        <RowDefinition Height="*"/>
                    </Grid.RowDefinitions>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                    </Grid.ColumnDefinitions>
                    <syncfusion:SfSwitch Grid.Column="0"
                                         Grid.Row="0"
                                         IsEnabled="False"
                                         AllowIndeterminateState="True"
                                         IsOn="False"
                                         VisualType="Default">
                    </syncfusion:SfSwitch>
                    <syncfusion:SfSwitch Grid.Column="1"
                                         Grid.Row="0"
                                         AllowIndeterminateState="True"
                                         IsOn="{x:Null}"   
                                         IsEnabled="False"
                                         VisualType="Default">
                    </syncfusion:SfSwitch>
                    <syncfusion:SfSwitch Grid.Column="2"
                                         Grid.Row="0"
                                         AllowIndeterminateState="True"
                                         IsEnabled="False"
                                         IsOn="True"
                                         VisualType="Default">
                    </syncfusion:SfSwitch>
                    <Label Grid.Column="0"
                           Grid.Row="1"
                           Text="Off"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                    <Label Grid.Column="1"
                           Grid.Row="1"
                           Text="Indeterminate"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                    <Label Grid.Column="2"
                           Grid.Row="1"
                           Text="On"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                </Grid>
                <Grid HeightRequest="10"/>

                <Label Text="Busy Indicator"
                       FontSize="16"
                       VerticalOptions="Center"
                       HorizontalOptions="Start"/>

                <Grid HeightRequest="70"
                      BackgroundColor="White"
                      Margin="0,5,0,5">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="50"/>
                        <RowDefinition Height="*"/>
                    </Grid.RowDefinitions>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                    </Grid.ColumnDefinitions>
                    <syncfusion:SfSwitch Grid.Column="0"
                                         Grid.Row="0"
                                         x:Name="busySwitch1"
                                         AllowIndeterminateState="False"
                                         StateChanging="SfSwitch_StateChanging"
                                         VisualType="Default">
                    </syncfusion:SfSwitch>
                    <syncfusion:SfSwitch Grid.Column="1"
                                         Grid.Row="0"
                                         x:Name="busySwitch2"
                                         StateChanging="SfSwitch_StateChanging_1"
                                         AllowIndeterminateState="False"
                                         VisualType="Default">
                    </syncfusion:SfSwitch>
                    <Label Grid.Column="0"
                           Grid.Row="1"
                           Text="State changing"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                    <Label Grid.Column="1"
                           Grid.Row="1"
                           Text="State handled"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                </Grid>

                <Grid HeightRequest="10"/>

                <Label
                   Text="Orientation"
                   FontSize="16"
                   VerticalOptions="Center"
                   HorizontalOptions="Start"/>

                <Grid HeightRequest="70"
                      BackgroundColor="White"
                      Margin="0,5,0,5">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="50"/>
                        <RowDefinition Height="*"/>
                    </Grid.RowDefinitions>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                    </Grid.ColumnDefinitions>

                    <syncfusion:SfSwitch Grid.Column="0"
                                         Grid.Row="0"
                                         AllowIndeterminateState="False"
                                         VisualType="Default">
                    </syncfusion:SfSwitch>
                    <syncfusion:SfSwitch Grid.Column="1"
                                         Grid.Row="0"
                                         Orientation="Vertical"
                                         AllowIndeterminateState="False"
                                         VisualType="Default">
                    </syncfusion:SfSwitch>
                    <Label Grid.Column="0"
                           Grid.Row="1"
                           Text="Horizontal"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                    <Label Grid.Column="1"
                           Grid.Row="1"
                           Text="Vertical"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                </Grid>

                <Grid HeightRequest="10"/>

                <Label Text="Colors"
                       FontSize="16"
                       VerticalOptions="Center"
                       HorizontalOptions="Start"/>

                <Grid HeightRequest="70"
                      BackgroundColor="White"
                      Margin="0,5,0,5">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="50"/>
                        <RowDefinition Height="*"/>
                    </Grid.RowDefinitions>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                    </Grid.ColumnDefinitions>
                    <syncfusion:SfSwitch Grid.Column="0"
                                         Grid.Row="0"
                                         AllowIndeterminateState="False"
                                         VisualType="Custom">
                        <VisualStateManager.VisualStateGroups>
                            <VisualStateGroup x:Name="CommonStates">
                                <VisualState x:Name="On">
                                    <VisualState.Setters>
                                        <Setter Property="SwitchSettings">
                                            <Setter.Value>
                                                <syncfusion:DefaultSwitchSettings x:TypeArguments="syncfusion:OnState"
                                                                TrackColor="#22029BFF"
                                                                TrackBorderColor="#22029BFF"
                                                                HasThumbShadow="False"
                                                                TrackBorderWidth="0.5"
                                                                ThumbBorderWidth="0.5"
                                                                ThumbBorderColor="#FF029BFF"
                                                                ThumbColor="#FF029BFF"/>    
                                            </Setter.Value>
                                        </Setter>
                                    </VisualState.Setters>
                                </VisualState>

                                <VisualState x:Name="Off">
                                    <VisualState.Setters>
                                        <Setter Property="SwitchSettings">
                                            <Setter.Value>
                                                <syncfusion:DefaultSwitchSettings x:TypeArguments="syncfusion:OffState"
                                                            TrackColor="#22FF0199"
                                                            TrackBorderColor="#22FF0199"
                                                            HasThumbShadow="False"
                                                            TrackBorderWidth="0.5"
                                                            ThumbBorderWidth="0.5"
                                                            ThumbBorderColor="#FFFF0199"
                                                            ThumbColor="#FFFF0199"/>
                                            </Setter.Value>
                                        </Setter>
                                    </VisualState.Setters>
                                </VisualState>
                            </VisualStateGroup>
                        </VisualStateManager.VisualStateGroups>
                    </syncfusion:SfSwitch>

                    <syncfusion:SfSwitch Grid.Column="1"
                                         Grid.Row="0"
                                         AllowIndeterminateState="False"
                                         VisualType="Custom">
                        <VisualStateManager.VisualStateGroups>
                            <VisualStateGroup x:Name="CommonStates">
                                <VisualState x:Name="On">
                                    <VisualState.Setters>
                                        <Setter Property="SwitchSettings">
                                            <Setter.Value>

                                                <syncfusion:DefaultSwitchSettings x:TypeArguments="syncfusion:OnState"
                                                                                  HasThumbShadow="False"
                                                                                  ThumbBorderWidth="0.5"
                                                                                  ThumbBorderColor="#FF029BFF"
                                                                                  TrackBorderWidth="0.5"
                                                                                  TrackBorderColor="#AA029BFF">
                                                    <syncfusion:DefaultSwitchSettings.ThumbGradient>
                                                        <gradient:SfLinearGradientBrush StartPoint="0.5, 0" EndPoint="0.5, 1">
                                                            <gradient:SfLinearGradientBrush.GradientStops>
                                                                <gradient:SfGradientStop Color="#FF029BFF" Offset="0.0" />
                                                                <gradient:SfGradientStop Color="#FFFFFFFF" Offset="1.0" />
                                                            </gradient:SfLinearGradientBrush.GradientStops>
                                                        </gradient:SfLinearGradientBrush>
                                                    </syncfusion:DefaultSwitchSettings.ThumbGradient>
                                                    <syncfusion:DefaultSwitchSettings.TrackGradient>
                                                        <gradient:SfLinearGradientBrush>
                                                            <gradient:SfLinearGradientBrush.GradientStops>
                                                                <gradient:SfGradientStop Color="#55029BFF" Offset="0.0" />
                                                                <gradient:SfGradientStop Color="#FFFFFFFF" Offset="1.0" />
                                                            </gradient:SfLinearGradientBrush.GradientStops>
                                                        </gradient:SfLinearGradientBrush>
                                                    </syncfusion:DefaultSwitchSettings.TrackGradient>
                                                </syncfusion:DefaultSwitchSettings>
                                            </Setter.Value>
                                        </Setter>
                                    </VisualState.Setters>
                                </VisualState>

                                <VisualState x:Name="Off">
                                    <VisualState.Setters>
                                        <Setter Property="SwitchSettings">
                                            <Setter.Value>
                                                <syncfusion:DefaultSwitchSettings x:TypeArguments="syncfusion:OffState"
                                                                                  HasThumbShadow="False"
                                                                                  ThumbBorderWidth="0.5"
                                                                                  ThumbBorderColor="#FFFF0199"
                                                                                  TrackBorderWidth="0.5"
                                                                                  TrackBorderColor="#AAFF0199">
                                                    <syncfusion:DefaultSwitchSettings.ThumbGradient>
                                                        <gradient:SfLinearGradientBrush StartPoint="0.5, 0" EndPoint="0.5, 1">
                                                            <gradient:SfLinearGradientBrush.GradientStops>
                                                                <gradient:SfGradientStop Color="#FFFF0199" Offset="0.0" />
                                                                <gradient:SfGradientStop Color="#FFFFFFFF" Offset="1.0" />
                                                            </gradient:SfLinearGradientBrush.GradientStops>
                                                        </gradient:SfLinearGradientBrush>
                                                    </syncfusion:DefaultSwitchSettings.ThumbGradient>
                                                    <syncfusion:DefaultSwitchSettings.TrackGradient>
                                                        <gradient:SfLinearGradientBrush>
                                                            <gradient:SfLinearGradientBrush.GradientStops>
                                                                <gradient:SfGradientStop Color="#55FF0199" Offset="0.0" />
                                                                <gradient:SfGradientStop Color="#FFFFFFFF" Offset="1.0" />
                                                            </gradient:SfLinearGradientBrush.GradientStops>
                                                        </gradient:SfLinearGradientBrush>
                                                    </syncfusion:DefaultSwitchSettings.TrackGradient>
                                                </syncfusion:DefaultSwitchSettings>
                                            </Setter.Value>
                                        </Setter>
                                    </VisualState.Setters>
                                </VisualState>
                            </VisualStateGroup>
                        </VisualStateManager.VisualStateGroups>
                    </syncfusion:SfSwitch>
                    <Label Grid.Column="0"
                           Grid.Row="1"
                           Text="Solid"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                    <Label Grid.Column="1"
                           Grid.Row="1"
                           Text="Gradient"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                </Grid>

                <Grid HeightRequest="10"/>

                <Label Text="Image and Customization"
                       FontSize="16"
                       VerticalOptions="Center"
                       HorizontalOptions="Start"/>

                <Grid HeightRequest="70"
                      BackgroundColor="White"
                      Margin="0,5,0,5">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="50"/>
                        <RowDefinition Height="*"/>
                    </Grid.RowDefinitions>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                    </Grid.ColumnDefinitions>

                    <syncfusion:SfSwitch Grid.Column="0"
                                         Grid.Row="0"
                                         IsOn="False"
                                         x:Name="ModeSwitch"
                                         StateChanged="SfSwitch_StateChanged_3"
                                         HorizontalOptions="Center"
                                         AllowIndeterminateState="False"
                                         VisualType="Custom">
                        <VisualStateManager.VisualStateGroups>
                            <VisualStateGroup x:Name="CommonStates">
                                <VisualState x:Name="On">
                                    <VisualState.Setters>
                                        <Setter Property="SwitchSettings">
                                            <Setter.Value>
                                                <syncfusion:DefaultSwitchSettings x:TypeArguments="syncfusion:OnState"
                                                            TrackWidthRequest="70"
                                                            TrackHeightRequest="35"
                                                            TrackCornerRadius="18"
                                                            TrackBorderWidth="1"
                                                            TrackBorderColor="Black"
                                                            TrackColor="White"                   
                                                            TrackImageSource="switchbg2.png"
                                                            
                                                            ThumbImageSource="switchmoon.png"                       
                                                            HasThumbShadow="False"
                                                            ThumbBorderWidth="0"
                                                            ThumbWidthRequest="35"
                                                            ThumbHeightRequest="35"
                                                            ThumbCornerRadius="17"
                                                            ThumbColor="Transparent"/>
                                            </Setter.Value>
                                        </Setter>
                                    </VisualState.Setters>
                                </VisualState>

                                <VisualState x:Name="Off">
                                    <VisualState.Setters>
                                        <Setter Property="SwitchSettings">
                                            <Setter.Value>
                                                <syncfusion:DefaultSwitchSettings x:TypeArguments="syncfusion:OffState"
                                                            TrackWidthRequest="70"
                                                            TrackHeightRequest="35"
                                                            TrackCornerRadius="18"
                                                            TrackBorderWidth="0"
                                                            TrackBorderColor="Black"
                                                            TrackImageSource="switchbg.png"
                                                            
                                                            ThumbImageSource="switchsun.png"                       
                                                            HasThumbShadow="False"
                                                            ThumbBorderWidth="0"
                                                            ThumbWidthRequest="35"
                                                            ThumbHeightRequest="35"
                                                            ThumbCornerRadius="17"
                                                            ThumbColor="Transparent"/>
                                            </Setter.Value>
                                        </Setter>
                                    </VisualState.Setters>
                                </VisualState>
                            </VisualStateGroup>
                        </VisualStateManager.VisualStateGroups>
                    </syncfusion:SfSwitch>
                    <Label Grid.Column="0"
                           Grid.Row="1"
                           Text="Day mode enabled"
                           x:Name="ModeLabel"
                           FontSize="10"
                           VerticalOptions="Center"
                           HorizontalOptions="Start"/>
                </Grid>
            </StackLayout>
        </ScrollView>
```

## How to run the project

* Checkout this project to a location in your disk.
* Open the solution file using the Visual Studio.
* Build the project to restore the NuGet packages.
* Deploy and run the application.

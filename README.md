# xamarin-forms-usercontrol-binding-problem
我在試做自訂Control但是顯示的結果跟我想的不一樣。 我在MainPage.xaml上將MyControl的MyName屬性Binding到Name。在MainPageViewModel上，設兩個屬性分別為:Name="Hello"、MyName="Wold"，執行結果顯示為Wold，為什麼不是顯示Hello呢?

解答:
以ContentView做自訂控制項，
在該自訂控制項的CodeBehind內使用BindableProperty時，
還需要在該自訂控制項的xaml上，指定Source為該自訂控制項的ContentView。

參考老師的範例:
https://github.com/vulcanlee/xamarin-forms-sample2018/tree/master/DataBindingDemo

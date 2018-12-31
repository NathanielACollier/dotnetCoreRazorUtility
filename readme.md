## Razor Utility

A library to use Razor for generic templates in dotnet

+ Based on code from this place, that showed how to use ASP.net Core Razor in a console application
    + [Blog Post](https://codeopinion.com/using-razor-in-a-console-application/)
+ Also needed to use this place in Microsoft's git repo for Experimental asp.net core things
    + [github link-Mvc.RenderViewToString](https://github.com/aspnet/Entropy/tree/master/samples/Mvc.RenderViewToString)

+ When you have views embeded, as is the case when you use Razor from a dotnet console app you've got to look at this:
    + [github issue from mvc] (https://github.com/aspnet/Mvc/issues/8623#issuecomment-431449017)
    + You have to add this to your project file in a PropertyGroup
    ```
    <PreserveCompilationContext>true</PreserveCompilationContext>
    ```
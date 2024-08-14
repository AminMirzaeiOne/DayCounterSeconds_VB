Module Module1

    Sub Main()
        System.Console.ForegroundColor = ConsoleColor.Cyan
        ' Gets the hour, minute, and second from the user
        System.Console.Write("Enter the hour: ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim hour As Integer = System.Convert.ToInt32(System.Console.ReadLine())

        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Enter the minute: ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim minute As Integer = System.Convert.ToInt32(System.Console.ReadLine())

        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Enter the second: ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim second As Integer = System.Convert.ToInt32(System.Console.ReadLine())

        ' Converts the hour, minute, and second to total seconds
        Dim totalSeconds As Integer = (hour * 3600) + (minute * 60) + second

        System.Console.ForegroundColor = ConsoleColor.Blue
        ' Displays the total number of seconds since the start of the day
        System.Console.Write($"There have been ")
        System.Console.BackgroundColor = ConsoleColor.DarkCyan
        System.Console.ForegroundColor = ConsoleColor.White
        System.Console.Write(totalSeconds.ToString())
        System.Console.ResetColor()
        System.Console.ForegroundColor = ConsoleColor.Blue
        System.Console.WriteLine(" seconds since the start of the day.")
        System.Console.ResetColor()
        ' Programmer Information and GitHub ID
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        System.Console.ReadKey() ' Pauses the console
    End Sub

End Module

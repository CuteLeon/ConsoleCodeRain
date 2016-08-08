Module Module1

    Sub Main()
        Console.Title = "疯狂数码雨"                        '设置标题
        Console.BackgroundColor = ConsoleColor.Black        '控制台背景为黑色
        Console.ForegroundColor = ConsoleColor.Green        '控制台文本为黑绿色
        Console.CursorVisible = False                       '控制隐藏光标焦点
        Dim CharCount As Integer = Console.WindowWidth      '获取缓冲区宽度，即每行数码雨字符数
        Dim LineCount As Integer = Console.WindowHeight     '获取缓冲区高度，即数码雨总行数
        Dim Rain(LineCount) As String                       '数码雨字符串型数组
        Dim Index As Integer                                '遍历因子
        Do While True                                       '无限循环
            CharCount = Console.WindowWidth                 '窗体尺寸改变时重新适应数码雨宽度
            LineCount = Console.WindowHeight                '窗体尺寸改变时重新适应数码雨高度
            Console.Title = "疯狂数码雨 *Line:" & LineCount & ",Char:" & CharCount '输出缓冲区尺寸
            Console.BufferWidth = CharCount                 '固定缓冲区宽度
            Console.BufferHeight = LineCount                '固定缓冲区高度
            Console.SetCursorPosition(0, 0)                 '光标焦点回到首行首列，不需要使用Console .Clear ()
            For Index = 1 To CharCount                      '遍历数码雨行宽
                Rain(0) &= IIf(VBMath.Rnd > 0.6, "-", "  ")
            Next
            For Index = LineCount To 1                      '遍历剩余的数码雨每行
                Rain(Index) = Rain(Index - 1)               '后一行继承前一行的文本
                Console.WriteLine(Rain(Index) & vbCrLf)     '继承后输出剩余的每行数码雨
            Next
            Console.WriteLine(Rain(0) & vbCrLf)             '输出首行数码雨
            Threading.Thread.Sleep(200)                     '线程暂停200Ms.
        Loop
    End Sub

End Module

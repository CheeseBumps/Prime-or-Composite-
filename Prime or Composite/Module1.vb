Module Module1

    Sub Main()
        Console.WriteLine("                                                                                                                                                              ")
        Console.WriteLine("                                                                                                                                                              ")
        Console.WriteLine("                   Welcome to the Prime Number Checker. Here you can check if a number is prime or not.")
        Dim reply As String = ("yes")
        Do
            Console.WriteLine("                                                                                                                                                              ")
            Console.WriteLine("                                                                                                                                                              ")
            Console.WriteLine("                                              Please enter a number:")
            Dim num, primechecker As Integer
            Dim bool As Boolean = True
            num = Console.ReadLine             'takes userinput

            If num = 1 Or num = 0 Then
                Console.WriteLine("                                                                                                                                                              ")
                Console.WriteLine("                                                                                                                                                              ")
                Console.WriteLine("                                         This number is neither prime nor composite!")
            Else
                For x = 2 To num - 1                      'checks if prime or composite
                    primechecker = num Mod x
                    If primechecker = 0 Then
                        bool = False
                        Exit For
                    Else
                        bool = True

                    End If
                Next
                If bool = False Then                'prints output depending on bool
                    Console.WriteLine("                                                                                                                                                              ")
                    Console.WriteLine("                                                                                                                                                              ")
                    Console.WriteLine("                                           The number is a composite number")
                ElseIf bool = True Then
                    Console.WriteLine("                                                                                                                                                              ")
                    Console.WriteLine("                                                                                                                                                              ")
                    Console.WriteLine("                                             The number is a prime number.")
                End If

            End If
            Do                          'makes sure userinputs either "yes" or "no" 
                Console.WriteLine("                                                                                                                                   ")

                Console.WriteLine("                                          Do you want to check another number?")
                reply = Console.ReadLine
                reply = LCase(reply)
                If reply <> "yes" And reply <> "no" Then
                    Console.WriteLine("                                                         ")
                    Console.WriteLine("                                                  Write 'yes' or 'no'   ")

                End If
            Loop Until reply = "yes" Or reply = "no"



        Loop Until reply = ("no")
        Console.WriteLine("                                                  Goodbye for now!")
    End Sub

End Module

Sub 删除带小计的列()
Dim i
i = 1

For i = 1 To 1000
    If Range("J" & i) = "小计" Then
        Rows(i & ":" & i).Select
        Selection.Delete shift:=xlUp
    End If
Next

Range("A1").Select

End Sub

Sub 填充发票号()
Dim i, m
i = 2

m = Range("A" & Rows.Count).End(xlUp).Row

For i = 2 To m
    If Range("A" & i) = "" Then
    Range("A" & i - 1 & ":" & "H" & i - 1).Copy Range("A" & i)
    End If
Next

End Sub
